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
	/// Allows you to dynamically construct a custom request to the API.
	/// Useful for modules or unimplemented functionality within this version
	/// </summary>
	[JsonConverter(typeof(RequestBuilderConverter))]
	public class RequestBuilder : Request
	{
		public Dictionary<String, dynamic> Data { get; set; } = new Dictionary<String, dynamic>();

		public RequestBuilder(Client client = null)
		{
			Client = client;
			Scope = RequestScope.Store;
		}

		/// <summary>
		/// Set a fields value in the root data container
		/// <param name="field">String</returns>
		/// <param name="value">dynamic</returns>
		/// <returns>RequestBuilder</returns>
		/// </summary>
		public RequestBuilder SetField(String field, dynamic value)
		{
			Data[field] = value;
			return this;
		}

		/// <summary>
		/// Check if a fields exists in the root data container
		/// <param name="field">String</returns>
		/// <returns>bool</returns>
		/// </summary>
		public bool HasField(String field)
		{
			return Data.ContainsKey(field);
		}

		/// <summary>
		/// Get a fields value in the root data container, or null if it doesnt exist
		/// <param name="field">String</returns>
		/// <returns>dynamic|null</returns>
		/// </summary>
		public dynamic GetField(String field)
		{
			if (HasField(field))
			{
				return Data[field];
			}

			return null;
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<RequestBuilderResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>RequestBuilderResponse</returns>
		/// </summary>
		public new RequestBuilderResponse Send()
		{
			return Client.SendRequestAsync<RequestBuilder, RequestBuilderResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<RequestBuilderResponse></returns>
		/// </summary>
		public new async Task<RequestBuilderResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<RequestBuilder, RequestBuilderResponse>(this);
		}

		/// <summary>
		/// Serializes the Request to JSON for sending to the API, called from RequestConverter
		/// <param name="writer">Utf8JsonWriter</param>
		/// <returns>void</returns>
		/// </summary>
		virtual new public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			foreach(KeyValuePair<String, dynamic> entry in Data)
			{
				WriteEntry(entry, writer, options);
			}
		}

		protected void WriteEntry(KeyValuePair<String, dynamic> entry, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (entry.Value is IConvertible)
			{
				WriteConvertibleKeyValue(entry.Key, entry.Value, writer, options);
			}
			else if (entry.Value is Dictionary<String, dynamic>)
			{
				WriteDictionary(entry.Key, entry.Value, writer, options);
			}
			else if (entry.Value is List<dynamic>)
			{
				WriteList(entry.Key, entry.Value, writer, options);
			}
			else if (entry.Value is Model)
			{
				writer.WritePropertyName(entry.Key);
				JsonSerializer.Serialize(writer, entry.Value, options);
			}
			else
			{
				throw new MerchantAPIException(String.Format("Unsupported data type for entry"));
			}
		}

		protected void WriteDictionary(String key, Dictionary<String, dynamic> dict, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (key.Length > 0)
			{
				writer.WritePropertyName(key);
			}
			
			writer.WriteStartObject();

			foreach (KeyValuePair<String, dynamic> entry in dict)
			{
				WriteEntry(entry, writer, options);
			}

			writer.WriteEndObject();
		}

		protected void WriteList(String key, List<dynamic> list, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if ( key.Length > 0 )
			{
				writer.WritePropertyName(key);
			}

			writer.WriteStartArray();

			foreach (dynamic entry in list)
			{
				if ( entry is IConvertible)
				{
					WriteConvertibleValue(entry, writer, options);
				}
				else if (entry is Model)
				{
					JsonSerializer.Serialize(writer, entry, options);
				}
				else if(entry is Dictionary<String, dynamic>)
				{
					WriteDictionary("", entry, writer, options);
				}
				else if (entry is List<dynamic>)
				{
					WriteList("", entry, writer, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unsupported data type for list entry"));
				}
			}

			writer.WriteEndArray();
		}

		protected void WriteConvertibleKeyValue(String key, IConvertible value, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (Util.IsDecimal(value))
			{
				if (Util.IsFloat(value))
				{
					writer.WriteNumber(key, (float)value);
				}
				else
				{
					writer.WriteNumber(key, (double)value);
				}
			}
			else if (Util.IsBoolean(value))
			{
				writer.WriteBoolean(key, (bool)value);
			}
			else if (Util.IsNumeric(value))
			{
				writer.WriteNumber(key, (int)value);
			}
			else
			{
				writer.WriteString(key, value.ToString());
			}
		}

		protected void WriteConvertibleValue(IConvertible value, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (Util.IsDecimal(value))
			{
				if (Util.IsFloat(value))
				{
					writer.WriteNumberValue((float)value);
				}
				else
				{
					writer.WriteNumberValue((double)value);
				}
			}
			else if (Util.IsBoolean(value))
			{
				writer.WriteBooleanValue((bool)value);
			}
			else if (Util.IsNumeric(value))
			{
				writer.WriteNumberValue((int)value);
			}
			else
			{
				writer.WriteStringValue(value.ToString());
			}
		}
	}

	/// <summary>
	/// Response for a ResponseBuilder
	/// </summary>
	public class RequestBuilderResponse : Response
	{
	}

	/// <summary>
	/// Handles serialization of a RequestBuilder
	/// </summary>
	public class RequestBuilderConverter : JsonConverter<RequestBuilder>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override RequestBuilder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException("RequestBuilder do not support deserialization");
		}

		public override void Write(Utf8JsonWriter writer, RequestBuilder builder, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			builder.Write(writer, options);

			writer.WriteEndObject();
		}
	}
}