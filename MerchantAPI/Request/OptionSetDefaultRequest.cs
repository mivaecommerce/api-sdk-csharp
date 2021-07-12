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
	/// Handles API Request Option_Set_Default.
	/// <see>https://docs.miva.com/json-api/functions/option_set_default</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OptionSetDefaultRequest : Request
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

		/// Request field Option_Default.
		[JsonPropertyName("Option_Default")]
		public bool? OptionDefault { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="productOption">ProductOption</param>
		/// </summary>
		public OptionSetDefaultRequest(BaseClient client = null, ProductOption productOption = null) :
			base(client)
		{
			Function = "Option_Set_Default";
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

				OptionCode = productOption.Code;
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
		/// Getter for Option_Default.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetOptionDefault()
		{
			return OptionDefault;
		}

		/// <summary>
		/// Setter for Option_ID.
		/// <param name="value">int</param>
		/// <returns>OptionSetDefaultRequest</returns>
		/// </summary>
		public OptionSetDefaultRequest SetOptionId(int? value)
		{
			OptionId = value;
			return this;
		}

		/// <summary>
		/// Setter for Option_Code.
		/// <param name="value">String</param>
		/// <returns>OptionSetDefaultRequest</returns>
		/// </summary>
		public OptionSetDefaultRequest SetOptionCode(String value)
		{
			OptionCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>OptionSetDefaultRequest</returns>
		/// </summary>
		public OptionSetDefaultRequest SetAttributeId(int? value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Option_Default.
		/// <param name="value">bool</param>
		/// <returns>OptionSetDefaultRequest</returns>
		/// </summary>
		public OptionSetDefaultRequest SetOptionDefault(bool? value)
		{
			OptionDefault = value;
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

			if (OptionCode != null && OptionCode.Length > 0)
			{
				writer.WriteString("Option_Code", OptionCode);
			}

			if (OptionDefault.HasValue)
			{
				writer.WriteBoolean("Option_Default", OptionDefault.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OptionSetDefaultResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OptionSetDefaultResponse</returns>
		/// </summary>
		public new OptionSetDefaultResponse Send()
		{
			return Client.SendRequestAsync<OptionSetDefaultRequest, OptionSetDefaultResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OptionSetDefaultResponse></returns>
		/// </summary>
		public new async Task<OptionSetDefaultResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OptionSetDefaultRequest, OptionSetDefaultResponse>(this);
		}
	}
}
