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
	[JsonConverter(typeof(ListQueryRequestBuilderConverter))]
	public class ListQueryRequestBuilder : ListQueryRequest
	{
		public Dictionary<String, dynamic> Data { get; set; } = new Dictionary<String, dynamic>();

		public ListQueryRequestBuilder(BaseClient client = null)
		{
			Client = client;
			Scope = RequestScope.Store;
		}

		/// <summary>
		/// Set a fields value in the root data container
		/// <param name="field">String</returns>
		/// <param name="value">dynamic</returns>
		/// <returns>ListQueryRequestBuilder</returns>
		/// </summary>
		public ListQueryRequestBuilder SetField(String field, dynamic value)
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
			return JsonSerializer.Deserialize<ListQueryRequestBuilderResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ListQueryRequestBuilderResponse</returns>
		/// </summary>
		public new ListQueryRequestBuilderResponse Send()
		{
			return Client.SendRequestAsync<ListQueryRequestBuilder, ListQueryRequestBuilderResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<RequestBuilderResponse></returns>
		/// </summary>
		public new async Task<ListQueryRequestBuilderResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ListQueryRequestBuilder, ListQueryRequestBuilderResponse>(this);
		}

		/// <summary>
		/// Serializes the Request to JSON for sending to the API, called from RequestConverter
		/// <param name="writer">Utf8JsonWriter</param>
		/// <returns>void</returns>
		/// </summary>
		virtual new public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			JSONEncoderHelper.Write(Data, writer, options);
		}
	}

	/// <summary>
	/// Response for a ResponseBuilder
	/// </summary>
	public class ListQueryRequestBuilderResponse : Response
	{
		[JsonPropertyName("data")]
		public VariableValue Data { get; set; } = new VariableValue();

		/// <summary>
		/// Get the underlying data result
		/// </summary>
		/// <returns></returns>
		public VariableValue GetData()
		{
			return Data;
		}
	}

	/// <summary>
	/// Handles serialization of a ListQueryRequestBuilder
	/// </summary>
	public class ListQueryRequestBuilderConverter : BaseJsonConverter<ListQueryRequestBuilder>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ListQueryRequestBuilder) || typeToConvert.IsSubclassOf(typeof(ListQueryRequestBuilder));
		}

		public override ListQueryRequestBuilder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException("ListQueryRequestBuilder do not support deserialization");
		}

		public override void Write(Utf8JsonWriter writer, ListQueryRequestBuilder builder, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			builder.Write(writer, options);

			writer.WriteEndObject();
		}
	}
}