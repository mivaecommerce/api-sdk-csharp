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
	/// Handles API Request AttributeTemplateOption_Delete.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateoption_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeTemplateOptionDeleteRequest : Request
	{
		/// Request field AttributeTemplate_ID.
		[JsonPropertyName("AttributeTemplate_ID")]
		public int? AttributeTemplateId { get; set; }

		/// Request field AttributeTemplate_Code.
		[JsonPropertyName("AttributeTemplate_Code")]
		public String AttributeTemplateCode { get; set; }

		/// Request field Edit_AttributeTemplate.
		[JsonPropertyName("Edit_AttributeTemplate")]
		public String EditAttributeTemplate { get; set; }

		/// Request field AttributeTemplateAttribute_ID.
		[JsonPropertyName("AttributeTemplateAttribute_ID")]
		public int? AttributeTemplateAttributeId { get; set; }

		/// Request field AttributeTemplateAttribute_Code.
		[JsonPropertyName("AttributeTemplateAttribute_Code")]
		public String AttributeTemplateAttributeCode { get; set; }

		/// Request field Edit_AttributeTemplateAttribute.
		[JsonPropertyName("Edit_AttributeTemplateAttribute")]
		public String EditAttributeTemplateAttribute { get; set; }

		/// Request field AttributeTemplateOption_ID.
		[JsonPropertyName("AttributeTemplateOption_ID")]
		public int? AttributeTemplateOptionId { get; set; }

		/// Request field AttributeTemplateOption_Code.
		[JsonPropertyName("AttributeTemplateOption_Code")]
		public String AttributeTemplateOptionCode { get; set; }

		/// Request field Edit_AttributeTemplateOption.
		[JsonPropertyName("Edit_AttributeTemplateOption")]
		public String EditAttributeTemplateOption { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="attributeTemplateOption">AttributeTemplateOption</param>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest(BaseClient client = null, AttributeTemplateOption attributeTemplateOption = null) :
			base(client)
		{
			Function = "AttributeTemplateOption_Delete";
			if (attributeTemplateOption != null) {
				if (attributeTemplateOption.Id > 0)
				{
					AttributeTemplateOptionId = attributeTemplateOption.Id;
				}
			}
		}

		/// <summary>
		/// Getter for AttributeTemplate_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeTemplateId()
		{
			return AttributeTemplateId;
		}

		/// <summary>
		/// Getter for AttributeTemplate_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeTemplateCode()
		{
			return AttributeTemplateCode;
		}

		/// <summary>
		/// Getter for Edit_AttributeTemplate.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAttributeTemplate()
		{
			return EditAttributeTemplate;
		}

		/// <summary>
		/// Getter for AttributeTemplateAttribute_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeTemplateAttributeId()
		{
			return AttributeTemplateAttributeId;
		}

		/// <summary>
		/// Getter for AttributeTemplateAttribute_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeTemplateAttributeCode()
		{
			return AttributeTemplateAttributeCode;
		}

		/// <summary>
		/// Getter for Edit_AttributeTemplateAttribute.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAttributeTemplateAttribute()
		{
			return EditAttributeTemplateAttribute;
		}

		/// <summary>
		/// Getter for AttributeTemplateOption_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeTemplateOptionId()
		{
			return AttributeTemplateOptionId;
		}

		/// <summary>
		/// Getter for AttributeTemplateOption_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeTemplateOptionCode()
		{
			return AttributeTemplateOptionCode;
		}

		/// <summary>
		/// Getter for Edit_AttributeTemplateOption.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAttributeTemplateOption()
		{
			return EditAttributeTemplateOption;
		}

		/// <summary>
		/// Setter for AttributeTemplate_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetAttributeTemplateId(int? value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplate_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetAttributeTemplateCode(String value)
		{
			AttributeTemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplate.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetEditAttributeTemplate(String value)
		{
			EditAttributeTemplate = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetAttributeTemplateAttributeId(int? value)
		{
			AttributeTemplateAttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetAttributeTemplateAttributeCode(String value)
		{
			AttributeTemplateAttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplateAttribute.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetEditAttributeTemplateAttribute(String value)
		{
			EditAttributeTemplateAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateOption_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetAttributeTemplateOptionId(int? value)
		{
			AttributeTemplateOptionId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateOption_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetAttributeTemplateOptionCode(String value)
		{
			AttributeTemplateOptionCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplateOption.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionDeleteRequest</returns>
		/// </summary>
		public AttributeTemplateOptionDeleteRequest SetEditAttributeTemplateOption(String value)
		{
			EditAttributeTemplateOption = value;
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

			if (AttributeTemplateId.HasValue)
			{
				writer.WriteNumber("AttributeTemplate_ID", AttributeTemplateId.Value);
			}
			else if (AttributeTemplateCode != null && AttributeTemplateCode.Length > 0)
			{
				writer.WriteString("AttributeTemplate_Code", AttributeTemplateCode);
			}
			else if (EditAttributeTemplate != null && EditAttributeTemplate.Length > 0)
			{
				writer.WriteString("Edit_AttributeTemplate", EditAttributeTemplate);
			}

			if (AttributeTemplateAttributeId.HasValue)
			{
				writer.WriteNumber("AttributeTemplateAttribute_ID", AttributeTemplateAttributeId.Value);
			}
			else if (AttributeTemplateAttributeCode != null && AttributeTemplateAttributeCode.Length > 0)
			{
				writer.WriteString("AttributeTemplateAttribute_Code", AttributeTemplateAttributeCode);
			}
			else if (EditAttributeTemplateAttribute != null && EditAttributeTemplateAttribute.Length > 0)
			{
				writer.WriteString("Edit_AttributeTemplateAttribute", EditAttributeTemplateAttribute);
			}

			if (AttributeTemplateOptionId.HasValue)
			{
				writer.WriteNumber("AttributeTemplateOption_ID", AttributeTemplateOptionId.Value);
			}
			else if (AttributeTemplateOptionCode != null && AttributeTemplateOptionCode.Length > 0)
			{
				writer.WriteString("AttributeTemplateOption_Code", AttributeTemplateOptionCode);
			}
			else if (EditAttributeTemplateOption != null && EditAttributeTemplateOption.Length > 0)
			{
				writer.WriteString("Edit_AttributeTemplateOption", EditAttributeTemplateOption);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AttributeTemplateOptionDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeTemplateOptionDeleteResponse</returns>
		/// </summary>
		public new AttributeTemplateOptionDeleteResponse Send()
		{
			return Client.SendRequestAsync<AttributeTemplateOptionDeleteRequest, AttributeTemplateOptionDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeTemplateOptionDeleteResponse></returns>
		/// </summary>
		public new async Task<AttributeTemplateOptionDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeTemplateOptionDeleteRequest, AttributeTemplateOptionDeleteResponse>(this);
		}
	}
}
