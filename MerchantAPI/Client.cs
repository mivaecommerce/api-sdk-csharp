/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles sending everything related to
	/// sending requests to the API
	/// </summary>
	public class Client
	{
		// Available signing types
		public enum ClientSignType
		{
			None,
			SHA1,
			SHA256
		};

		// Property Endpoint - System.Uri
		public System.Uri Endpoint { get; set; }

		// Property ApiToken - String
		public String ApiToken { get; set; }

		// Property SigningKey - byte[]
		public byte[] SigningKey { get; set; }

		// Property DefaultStoreCode - String
		public String DefaultStoreCode { get; set; }

		// Property RequireTimestamps - Boolean
		public Boolean RequireTimestamps { get; set; } = true;

		// Property SignType - ClientSignType
		public ClientSignType SignType { get; set; } = ClientSignType.None;

		private HttpClient HttpClient;

		/// <summary>
		/// Constructor with defaults for request signing.
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// <param name="signingKey"></param>
		/// <param name="signType"></param>
		/// </summary>
		public Client(String endpoint, String apiToken, String signingKey, ClientSignType signType = ClientSignType.SHA256 )
		{
			Endpoint = new System.Uri(endpoint);
			ApiToken = apiToken;
			SignType = signType;
			HttpClient = new HttpClient();
			DefaultStoreCode = "";

			SetSigningKey(signingKey);
		}

		/// <summary>
		/// Constructor with defaults for request signing with optional HttpClient when you already have an instance to use.
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// <param name="signingKey"></param>
		/// <param name="signType"></param>
		/// </summary>
		public Client(HttpClient httpClient, String endpoint, String apiToken, String signingKey, ClientSignType signType = ClientSignType.SHA256)
		{
			Endpoint = new System.Uri(endpoint);
			ApiToken = apiToken;
			SignType = signType;
			HttpClient = httpClient;
			DefaultStoreCode = "";

			SetSigningKey(signingKey);
		}

		/// <summary>
		/// Constructor with defaults for no request signing.
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// </summary>
		public Client(String endpoint, String apiToken)
		{
			Endpoint = new System.Uri(endpoint);
			ApiToken = apiToken;
			SignType = ClientSignType.None;
			HttpClient = new HttpClient();
			DefaultStoreCode = "";
		}

		/// <summary>
		/// Constructor with defaults for no request signing with optional HttpClient when you already have an instance to use.
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// </summary>
		public Client(HttpClient httpClient, String endpoint, String apiToken)
		{
			Endpoint = new System.Uri(endpoint);
			ApiToken = apiToken;
			SignType = ClientSignType.None;
			HttpClient = httpClient;
			DefaultStoreCode = "";
		}

		/// <summary>
		/// Decodes the Base64 signing key and stores the resulting data as a
		/// byte array
		/// <param name="base64Key">The base64 encoded key as a string</param>
		/// <returns>Client</returns>
		/// </summary>
		/// <exception cref="MerchantAPIException"></exception>
		public Client SetSigningKey(String base64Key)
		{
			if ( base64Key.Length % 4 != 0 )
			{
				base64Key = base64Key.PadRight(base64Key.Length + (4 - (base64Key.Length % 4)), '=');
			}

			try
			{
				SigningKey = System.Convert.FromBase64String(base64Key);
			}
			catch( Exception e )
			{
				throw new MerchantAPIException("Unable to decode signing key", e);
			}

			return this;
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

			if (request.Client != this) {
				request.Client = this;
			}

			requestData = JsonSerializer.Serialize(request);

			HttpResponseMessage httpResponse = await SendRequestLowLevel(requestData);

			try {
				var opions = new JsonSerializerOptions();

				if (request is MultiCallRequest mrequest)
				{
					opions.Converters.Add(new MultiCallResponseConverter(mrequest));
				}

				response = JsonSerializer.Deserialize<TResponse>(httpResponse.Content.ReadAsStringAsync().Result, opions);
				response.Request = request;
				response.HttpResponse = httpResponse;
			}
			catch(Exception e )
			{
				throw new MerchantAPIException("Error Parsing JSON Response", e);
			}

			return response;
		}

		/// <summary>
		/// Signs if required and makes a POST request using HTTPClient with the given content.
		/// </summary>
		/// <exception cref="MerchantAPIException"></exception>
		public async Task<HttpResponseMessage> SendRequestLowLevel(String content)
		{
			HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, Endpoint);

			httpRequest.Headers.TryAddWithoutValidation("X-Miva-API-Authorization", SignString(content));
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
		/// Signs a string, used to sign the request body
		/// </summary>
		/// <param name="body"></param>
		/// <returns></returns>
		public String SignString(String content)
		{
			byte[] signature;

			if( SignType == ClientSignType.None )
			{
				return String.Format("MIVA {0}", ApiToken);
			}

			if ( SignType == ClientSignType.SHA256 )
			{
				HMACSHA256 hmac = new HMACSHA256(SigningKey);

				signature = hmac.ComputeHash(Encoding.ASCII.GetBytes(content));

				return String.Format("MIVA-HMAC-SHA256 {0}:{1}", ApiToken, System.Convert.ToBase64String(signature));
			}
			else if (SignType == ClientSignType.SHA1)
			{
				HMACSHA1 hmac = new HMACSHA1(SigningKey);

				signature = hmac.ComputeHash(Encoding.ASCII.GetBytes(content));
				return String.Format("MIVA-HMAC-SHA1 {0}:{1}", ApiToken, System.Convert.ToBase64String(signature));
			}

			throw new MerchantAPIException("Invalid Sign Type");
		}
	}
}
