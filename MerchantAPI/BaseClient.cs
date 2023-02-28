/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles sending everything related to
	/// sending requests to the API
	/// </summary>
	public class BaseClient
	{
		// Property Endpoint - System.Uri
		public System.Uri Endpoint { get; set; }

		// Property ApiToken - String
		public Authenticator CurrentAuthenticator { get; set; }

		// Property DefaultStoreCode - String
		public String DefaultStoreCode { get; set; }

		// Property RequireTimestamps - Boolean
		public Boolean RequireTimestamps { get; set; } = true;

		private HttpClient HttpClient;

		public static int DefaultOperationTimeout = 60;

		public int OperationTimeout { get; set; } = DefaultOperationTimeout;

		public Logger Log { get; set; } = null;

		public Dictionary<String, String> GlobalHeaders { get; set; } = new Dictionary<String, String>();

		/// <summary>
		/// Constructor with defaults for request signing.
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// <param name="signingKey"></param>
		/// <param name="signType"></param>
		/// </summary>
		public BaseClient(String endpoint, Authenticator authenticator)
		{
			Endpoint = new System.Uri(endpoint);
			CurrentAuthenticator = authenticator;
			HttpClient = new HttpClient();
			DefaultStoreCode = "";
		}

		/// <summary>
		/// Constructor with defaults for request signing with optional HttpClient when you already have an instance to use.
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// <param name="signingKey"></param>
		/// <param name="signType"></param>
		/// </summary>
		public BaseClient(HttpClient httpClient, String endpoint, Authenticator authenticator)
		{
			Endpoint = new System.Uri(endpoint);
			CurrentAuthenticator = authenticator;
			HttpClient = httpClient;
			DefaultStoreCode = "";
		}

		/// <summary>
		/// Sends a blocking call for a given request
		/// <param name="request">The Request object</param>
		/// <returns>Response</returns>
		/// </summary>
		public Response SendRequest<TRequest, TResponse>(TRequest request)
			where TRequest : Request
			where TResponse : Response
		{
			return SendRequestAsync<TRequest, TResponse>(request).Result;
		}

		/// <summary>
		/// Sends a request async
		/// </summary>
		/// <exception cref="ClientException"></exception>
		public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request)
			where TRequest : Request
			where TResponse : Response
		{
			String requestData;
			TResponse response;
			Dictionary<String, String> headers = new Dictionary<String, String>(GlobalHeaders);

			if (request.Client != this)
			{
				request.Client = this;
			}

			requestData = JsonSerializer.Serialize(request);

			if (Client.DefaultOperationTimeout != OperationTimeout)
			{
				headers["X-Miva-API-Timeout"] = OperationTimeout.ToString();
			}

			if (request.GetBinaryEncoding() == Request.BinaryEncodingType.Base64)
			{
				headers["X-Miva-API-Binary-Encoding"] = "base64";
			}

			request.ProcessRequestHeaders(headers);

			if (Log != null)
			{
				Log.LogRequest(request, headers, requestData);
			}

			HttpResponseMessage httpResponse = await SendRequestLowLevel(requestData, headers);

			try
			{
				httpResponse.EnsureSuccessStatusCode();

				var options = new JsonSerializerOptions();

				if (request is MultiCallRequest mrequest)
				{
					options.Converters.Add(new MultiCallResponseConverter(mrequest));
				}

				response = JsonSerializer.Deserialize<TResponse>(httpResponse.Content.ReadAsStringAsync().Result, options);
				response.Request = request;
				response.HttpResponse = httpResponse;
			}
			catch (HttpRequestException e)
			{
				if (httpResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
				{
					throw new MerchantAPIException("HTTP Authentication Error", e);
				}

				throw new MerchantAPIException("HTTP Response Error", e);
			}
			catch (Exception e)
			{
				throw new MerchantAPIException("Error Parsing JSON Response", e);
			}
			finally
			{
				if (Log != null)
				{
					Log.LogResponse(httpResponse);
				}
			}

			if (request is MultiCallRequest mcreq && response is MultiCallResponse mcresp)
			{
				if (mcresp.HttpResponse.StatusCode == System.Net.HttpStatusCode.PartialContent)
				{
					mcresp.Request = mcreq;
					mcresp.Timeout = true;

					if (mcreq.AutoTimeoutContinue && mcreq._InitialResponse == null)
					{
						mcresp.AutoContinue();
					}
				}
			}

			return response;
		}

		/// <summary>
		/// Signs if required and makes a POST request using HTTPClient with the given content.
		/// </summary>
		/// <exception cref="MerchantAPIException"></exception>
		public async Task<HttpResponseMessage> SendRequestLowLevel(String content, Dictionary<String, String> headers)
		{
			HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, Endpoint);

			foreach (KeyValuePair<String, String> header in headers)
			{
				httpRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
			}

			httpRequest.Headers.TryAddWithoutValidation("X-Miva-API-Authorization", CurrentAuthenticator.GenerateAuthenticationHeader(content));
			httpRequest.Content = new StringContent(content);
			httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

			try
			{
				HttpResponseMessage response = await HttpClient.SendAsync(httpRequest, HttpCompletionOption.ResponseContentRead);

				return response;
			}
			catch (HttpRequestException e)
			{
				throw new MerchantAPIException("HTTP Error", e);
			}
		}

		/// <summary>
		/// Set the Logger instance
		/// </summary>
		/// <param name="logger"></param>
		public void SetLogger(Logger logger)
		{
			Log = logger;
		}

		/// <summary>
		/// Get the logger instance
		/// </summary>
		/// <returns></returns>
		public Logger GetLogger()
		{
			return Log;
		}

		/// <summary>
		/// Set a global header to be included with each request
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public BaseClient SetGlobalHeader(String key, String value)
		{
			GlobalHeaders[key] = value;
			return this;
		}

		/// <summary>
		/// Get a global header or nul if not set
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public String GetGlobalHeader(String key)
		{
			return GlobalHeaders.ContainsKey(key) ? GlobalHeaders[key] : null;
		}

		/// <summary>
		/// Check if a global header is defined
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public bool HasGlobalHeader(String key)
		{
			return GlobalHeaders.ContainsKey(key);
		}

		/// <summary>
		/// Remove a defined global header
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public BaseClient RemoveGlobalHeader(String key)
		{
			GlobalHeaders.Remove(key);
			return this;
		}
	}
}
