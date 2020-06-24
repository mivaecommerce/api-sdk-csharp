/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MerchantAPI
{
	abstract public class Request
	{
		public enum RequestScope
		{
			Store,
			Domain
		};

		[JsonIgnore]
		public Client Client { get; set; }

		[JsonIgnore]
		public RequestScope Scope { get; set; }

		[JsonPropertyName("Function")]
		public String Function { get; set; }

		[JsonPropertyName("Store_Code")]
		public String StoreCode { get; set; }

		public Request(Client client = null)
		{
			Client = client;
			Scope = RequestScope.Store;
		}

		/// <summary>
		/// Gets the API function name of the Request.
		/// <returns>String</returns>
		/// </summary>
		public String GetFunction()
		{
			return Function;
		}

		/// <summary>
		/// Sets the API function name of the Request.
		/// <param name="function">String</returns>
		/// <returns>Request</returns>
		/// </summary>
		public Request SetFunction(String function)
		{
			Function = function;
			return this;
		}

		/// <summary>
		/// Get the request store code.
		/// <param name="function">String</param>
		/// <returns>Request</returns>
		/// </summary>
		public String GetStoreCode()
		{
			return Function;
		}

		/// <summary>
		/// Set the request store code.
		/// <param name="function">String</param>
		/// <returns>Request</returns>
		/// </summary>
		public Request SetStoreCode(String storeCode)
		{
			StoreCode = storeCode;
			return this;
		}

		/// <summary>
		/// Gets the scope of the request.
		/// <returns>RequestScope</returns>
		/// </summary>
		public RequestScope GetScope()
		{
			return Scope;
		}

		/// <summary>
		/// Set the request store code.
		/// <param name="scope">RequestScope</param>
		/// <returns>Request</returns>
		/// </summary>
		public Request SetScope(RequestScope scope)
		{
			Scope = scope;
			return this;
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>Response</returns>
		/// </summary>
		virtual public Response Send()
		{
			return SendAsync().Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<Response></returns>
		/// </summary>
		virtual public async Task<Response> SendAsync()
		{
			throw new NotImplementedException("Must be implemented in inherited class");
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		virtual public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<Response>(ref reader, options);
		}

		/// <summary>
		/// Serializes the Request to JSON for sending to the API, called from RequestConverter
		/// <param name="writer">Utf8JsonWriter</param>
		/// <returns>void</returns>
		/// </summary>
		virtual public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (Scope == Request.RequestScope.Domain)
			{
				StoreCode = null;
			}
			else if ((StoreCode == null || StoreCode.Length == 0) && (Client != null && Client.DefaultStoreCode != null))
			{
				StoreCode = Client.DefaultStoreCode;
			}

			if (StoreCode != null && StoreCode.Length > 0)
			{
				writer.WriteString("Store_Code", StoreCode);
			}

			if (Client != null && Client.RequireTimestamps)
			{
				writer.WriteNumber("Miva_Request_Timestamp", DateTimeOffset.UtcNow.ToUnixTimeSeconds());
			}

			writer.WriteString("Function", GetFunction());
		}
	}

	public class RequestConverter : BaseJsonConverter<Request>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override Request Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException("Request objects do not support deserialization");
		}

		public override void Write(Utf8JsonWriter writer, Request request, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			request.Write(writer, options);

			writer.WriteEndObject();
		}
	}
}