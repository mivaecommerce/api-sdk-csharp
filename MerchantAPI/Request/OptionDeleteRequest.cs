/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request Option_Delete.
	/// <see>https://docs.miva.com/json-api/functions/option_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OptionDeleteRequest : Request
	{
		/// Request field Option_ID.
		[JsonPropertyName("Option_ID")]
		public int? OptionId { get; set; }

		/// Request field Option_Code.
		[JsonPropertyName("Option_Code")]
		public String OptionCode { get; set; }

		/// Request field Attribute_ID.
		[JsonPropertyName("Attribute_ID")]
		public int? AttributeId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="productOption">ProductOption</param>
		/// </summary>
		public OptionDeleteRequest(BaseClient client = null, ProductOption productOption = null) :
			base(client)
		{
			Function = "Option_Delete";
			if (productOption != null) {
				if (productOption.Id > 0)
				{
					OptionId = productOption.Id;
				}
				else if (productOption.Code.Length > 0)
				{
					OptionCode = productOption.Code;
				}

				if (productOption.AttributeId > 0)
				{
					AttributeId = productOption.AttributeId;
				}

				OptionId = productOption.Id;
			}
		}

		/// <summary>
		/// Getter for Option_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetOptionId()
		{
			return OptionId;
		}

		/// <summary>
		/// Getter for Option_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCode()
		{
			return OptionCode;
		}

		/// <summary>
		/// Getter for Attribute_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Setter for Option_ID.
		/// <param name="value">int</param>
		/// <returns>OptionDeleteRequest</returns>
		/// </summary>
		public OptionDeleteRequest SetOptionId(int? value)
		{
			OptionId = value;
			return this;
		}

		/// <summary>
		/// Setter for Option_Code.
		/// <param name="value">String</param>
		/// <returns>OptionDeleteRequest</returns>
		/// </summary>
		public OptionDeleteRequest SetOptionCode(String value)
		{
			OptionCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>OptionDeleteRequest</returns>
		/// </summary>
		public OptionDeleteRequest SetAttributeId(int? value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			if (OptionId.HasValue)
			{
				writer.WriteNumber("Option_ID", OptionId.Value);
			}
			else if (OptionCode != null && OptionCode.Length > 0)
			{
				writer.WriteString("Option_Code", OptionCode);
			}

			if (AttributeId.HasValue)
			{
				writer.WriteNumber("Attribute_ID", AttributeId.Value);
			}

			if (OptionId.HasValue)
			{
				writer.WriteNumber("Option_ID", OptionId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OptionDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OptionDeleteResponse</returns>
		/// </summary>
		public new OptionDeleteResponse Send()
		{
			return Client.SendRequestAsync<OptionDeleteRequest, OptionDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OptionDeleteResponse></returns>
		/// </summary>
		public new async Task<OptionDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OptionDeleteRequest, OptionDeleteResponse>(this);
		}
	}
}
