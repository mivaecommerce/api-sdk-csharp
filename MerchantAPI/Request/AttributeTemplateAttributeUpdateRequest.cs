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
	/// Handles API Request AttributeTemplateAttribute_Update.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateattribute_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeTemplateAttributeUpdateRequest : Request
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

		/// Request field Code.
		[JsonPropertyName("Code")]
		public String Code { get; set; }

		/// Request field Prompt.
		[JsonPropertyName("Prompt")]
		public String Prompt { get; set; }

		/// Request field Type.
		[JsonPropertyName("Type")]
		public String AttributeType { get; set; }

		/// Request field Image.
		[JsonPropertyName("Image")]
		public String Image { get; set; }

		/// Request field Price.
		[JsonPropertyName("Price")]
		public decimal? Price { get; set; }

		/// Request field Cost.
		[JsonPropertyName("Cost")]
		public decimal? Cost { get; set; }

		/// Request field Weight.
		[JsonPropertyName("Weight")]
		public decimal? Weight { get; set; }

		/// Request field Copy.
		[JsonPropertyName("Copy")]
		public bool? Copy { get; set; }

		/// Request field Required.
		[JsonPropertyName("Required")]
		public bool? Required { get; set; }

		/// Request field Inventory.
		[JsonPropertyName("Inventory")]
		public bool? Inventory { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="attributeTemplateAttribute">AttributeTemplateAttribute</param>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest(BaseClient client = null, AttributeTemplateAttribute attributeTemplateAttribute = null) :
			base(client)
		{
			Function = "AttributeTemplateAttribute_Update";
			if (attributeTemplateAttribute != null) {
				if (attributeTemplateAttribute.Id > 0)
				{
					AttributeTemplateAttributeId = attributeTemplateAttribute.Id;
				}
				else if (attributeTemplateAttribute.Code.Length > 0)
				{
					AttributeTemplateAttributeCode = attributeTemplateAttribute.Code;
				}
				else if (attributeTemplateAttribute.Code.Length > 0)
				{
					EditAttributeTemplateAttribute = attributeTemplateAttribute.Code;
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
		/// Getter for Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for Prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrompt()
		{
			return Prompt;
		}

		/// <summary>
		/// Getter for Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeType()
		{
			return AttributeType;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>AttributeTemplateAttribute.TemplateAttributeType?</returns>
		/// </summary>
		public AttributeTemplateAttribute.TemplateAttributeType? GetAttributeTypeConst()
		{
			return AttributeTemplateAttribute.TemplateAttributeTypeFromString(AttributeType);
		}

		/// <summary>
		/// Getter for Image.
		/// <returns>String</returns>
		/// </summary>
		public String GetImage()
		{
			return Image;
		}

		/// <summary>
		/// Getter for Price.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal? GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for Cost.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal? GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Getter for Weight.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal? GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Getter for Copy.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCopy()
		{
			return Copy;
		}

		/// <summary>
		/// Getter for Required.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetRequired()
		{
			return Required;
		}

		/// <summary>
		/// Getter for Inventory.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetInventory()
		{
			return Inventory;
		}

		/// <summary>
		/// Setter for AttributeTemplate_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetAttributeTemplateId(int? value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplate_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetAttributeTemplateCode(String value)
		{
			AttributeTemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplate.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetEditAttributeTemplate(String value)
		{
			EditAttributeTemplate = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetAttributeTemplateAttributeId(int? value)
		{
			AttributeTemplateAttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetAttributeTemplateAttributeCode(String value)
		{
			AttributeTemplateAttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplateAttribute.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetEditAttributeTemplateAttribute(String value)
		{
			EditAttributeTemplateAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Type.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetAttributeType(String value)
		{
			AttributeType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">AttributeTemplateAttribute.TemplateAttributeType</param>
		/// <returns></returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetAttributeType(AttributeTemplateAttribute.TemplateAttributeType value)
		{
			AttributeType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetPrice(float? value)
		{
			if (value is float v) {
				Price = new Decimal(v);
				return this;
			}

			Price = null;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">double</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetPrice(double? value)
		{
			if (value is double v) {
				Price = new Decimal(v);
				return this;
			}

			Price = null;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">decimal</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetCost(float? value)
		{
			if (value is float v) {
				Cost = new Decimal(v);
				return this;
			}

			Cost = null;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">double</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetCost(double? value)
		{
			if (value is double v) {
				Cost = new Decimal(v);
				return this;
			}

			Cost = null;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">decimal</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetWeight(float? value)
		{
			if (value is float v) {
				Weight = new Decimal(v);
				return this;
			}

			Weight = null;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">double</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetWeight(double? value)
		{
			if (value is double v) {
				Weight = new Decimal(v);
				return this;
			}

			Weight = null;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">decimal</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetWeight(decimal? value)
		{
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Copy.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetCopy(bool? value)
		{
			Copy = value;
			return this;
		}

		/// <summary>
		/// Setter for Required.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetRequired(bool? value)
		{
			Required = value;
			return this;
		}

		/// <summary>
		/// Setter for Inventory.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateAttributeUpdateRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeUpdateRequest SetInventory(bool? value)
		{
			Inventory = value;
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

			if (Code != null && Code.Length > 0)
			{
				writer.WriteString("Code", Code);
			}

			if (Prompt != null && Prompt.Length > 0)
			{
				writer.WriteString("Prompt", Prompt);
			}

			if (AttributeType != null && AttributeType.Length > 0)
			{
				writer.WriteString("Type", AttributeType);
			}

			if (Image != null && Image.Length > 0)
			{
				writer.WriteString("Image", Image);
			}

			if (Price.HasValue)
			{
				writer.WriteNumber("Price", Price.Value);
			}

			if (Cost.HasValue)
			{
				writer.WriteNumber("Cost", Cost.Value);
			}

			if (Weight.HasValue)
			{
				writer.WriteNumber("Weight", Weight.Value);
			}

			if (Copy.HasValue)
			{
				writer.WriteBoolean("Copy", Copy.Value);
			}

			if (Required.HasValue)
			{
				writer.WriteBoolean("Required", Required.Value);
			}

			if (Inventory.HasValue)
			{
				writer.WriteBoolean("Inventory", Inventory.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AttributeTemplateAttributeUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeTemplateAttributeUpdateResponse</returns>
		/// </summary>
		public new AttributeTemplateAttributeUpdateResponse Send()
		{
			return Client.SendRequestAsync<AttributeTemplateAttributeUpdateRequest, AttributeTemplateAttributeUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeTemplateAttributeUpdateResponse></returns>
		/// </summary>
		public new async Task<AttributeTemplateAttributeUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeTemplateAttributeUpdateRequest, AttributeTemplateAttributeUpdateResponse>(this);
		}
	}
}
