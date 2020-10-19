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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	///  Handles MultiCall Requests
	/// <see>https://docs.miva.com/json-api/multicall</see>
	/// </summary>
	[JsonConverter(typeof(MultiCallRequestConverter))]
	public class MultiCallRequest : Request
	{
		/// Holds all requests associated with the instance.
		public List<dynamic> Requests { get; set; } = new List<dynamic>();

		public bool AutoTimeoutContinue { get; set; } = false;

		public MultiCallResponse _InitialResponse { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="client"></param>
		public MultiCallRequest(BaseClient client) :
			base(client)
		{
			Function = "";
		}

		/// <summary>
		/// Get all the currently assigned requests
		/// </summary>
		/// <returns>List<dynamic></returns>
		public List<dynamic> GetRequests()
		{
			return Requests;
		}

		/// <summary>
		/// Add a request to be processed
		/// </summary>
		/// <param name="request"></param>
		/// <returns>MultiCallRequest</returns>
		public MultiCallRequest AddRequest(Request request)
		{
			if (request != null)
			{
				Requests.Add(request);
			}

			return this;
		}

		/// <summary>
		/// Add an operation to be processed
		/// </summary>
		/// <param name="operation"></param>
		/// <returns>MultiCallRequest</returns>
		public MultiCallRequest AddOperation(MultiCallOperation operation)
		{
			if (operation != null)
			{
				Requests.Add(operation);
			}

			return this;
		}

		/// <summary>
		/// Convinence method to create a MultiCallOperation.
		/// </summary>
		/// <param name="sharedData">Optionally provide shared data</param>
		/// <returns></returns>
		public MultiCallOperation Operation(Dictionary<String, IConvertible> sharedData = null)
		{
			return new MultiCallOperation(this, sharedData);
		}

		/// <summary>
		/// Sends the request
		/// </summary>
		/// <returns></returns>
		public new MultiCallResponse Send()
		{
			return Client.SendRequestAsync<MultiCallRequest, MultiCallResponse>(this).Result;
		}

		/// <summary>
		/// Sends the request, asynchronous
		/// </summary>
		public new async Task<MultiCallResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<MultiCallRequest, MultiCallResponse>(this);
		}


		/// <summary>
		/// Allows the request to manipulate the HTTP request headers
		/// </summary>
		/// <param name="headers"></param>
		override public void ProcessRequestHeaders(Dictionary<String, String> headers)
		{
			if (_InitialResponse != null)
			{
				if (_InitialResponse.Timeout)
				{
					headers["RANGE"] = String.Format("Operations={0}-{1}",
						_InitialResponse.Completed + 1, _InitialResponse.Total);
				}
			}
		}
	}

	/// <summary>
	/// Handles serializing a MultiCallRequest to JSON
	/// </summary>
	public class MultiCallRequestConverter : BaseJsonConverter<MultiCallRequest>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(MultiCallRequest);
		}

		public override MultiCallRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}

		public override void Write(Utf8JsonWriter writer, MultiCallRequest multicallRequest, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (multicallRequest.Client != null && multicallRequest.Client.RequireTimestamps)
			{
				writer.WriteNumber("Miva_Request_Timestamp", DateTimeOffset.UtcNow.ToUnixTimeSeconds());
			}

			writer.WriteStartArray("Operations");

			foreach(dynamic entry in multicallRequest.Requests)
			{
				if (entry is MultiCallOperation operation)
				{
					foreach(Request request in operation.GetRequests())
					{
						if (request.Scope == Request.RequestScope.Store)
						{
							if (request.StoreCode == null && multicallRequest.Client != null && multicallRequest.Client.DefaultStoreCode != null)
							{
								request.StoreCode = multicallRequest.Client.DefaultStoreCode;
							}
						}
					}

					JsonSerializer.Serialize<MultiCallOperation>(writer, operation, options);
				}
				else if (entry is Request request)
				{
					if(request.Scope == Request.RequestScope.Store)
					{
						if (request.StoreCode == null && multicallRequest.Client != null && multicallRequest.Client.DefaultStoreCode != null)
						{
							request.StoreCode = multicallRequest.Client.DefaultStoreCode;
						}
					}

					writer.WriteStartObject();
					request.Write(writer, options);
					writer.WriteEndObject();
				}
			}

			writer.WriteEndArray();
			writer.WriteEndObject();
		}
	}
}