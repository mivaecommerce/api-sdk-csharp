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
	/// Handles API Request AttributeTemplateOption_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateoption_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeTemplateOptionInsertRequest : Request
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

		/// Request field Default.
		[JsonPropertyName("Default")]
		public bool? Default { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="attributeTemplateAttribute">AttributeTemplateAttribute</param>
		/// </summary>
		public AttributeTemplateOptionInsertRequest(BaseClient client = null, AttributeTemplateAttribute attributeTemplateAttribute = null) :
			base(client)
		{
			Function = "AttributeTemplateOption_Insert";
			if (attributeTemplateAttribute != null) {
				if (attributeTemplateAttribute.Id > 0)
				{
					AttributeTemplateAttributeId = attributeTemplateAttribute.Id;
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
		/// Getter for Default.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDefault()
		{
			return Default;
		}

		/// <summary>
		/// Setter for AttributeTemplate_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetAttributeTemplateId(int? value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplate_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetAttributeTemplateCode(String value)
		{
			AttributeTemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplate.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetEditAttributeTemplate(String value)
		{
			EditAttributeTemplate = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetAttributeTemplateAttributeId(int? value)
		{
			AttributeTemplateAttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetAttributeTemplateAttributeCode(String value)
		{
			AttributeTemplateAttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplateAttribute.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetEditAttributeTemplateAttribute(String value)
		{
			EditAttributeTemplateAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetPrice(float? value)
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
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetPrice(double? value)
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
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetCost(float? value)
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
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetCost(double? value)
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
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetWeight(float? value)
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
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetWeight(double? value)
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
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetWeight(decimal? value)
		{
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Default.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateOptionInsertRequest</returns>
		/// </summary>
		public AttributeTemplateOptionInsertRequest SetDefault(bool? value)
		{
			Default = value;
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

			writer.WriteString("Code", Code);

			writer.WriteString("Prompt", Prompt);

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

			if (Default.HasValue)
			{
				writer.WriteBoolean("Default", Default.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AttributeTemplateOptionInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeTemplateOptionInsertResponse</returns>
		/// </summary>
		public new AttributeTemplateOptionInsertResponse Send()
		{
			return Client.SendRequestAsync<AttributeTemplateOptionInsertRequest, AttributeTemplateOptionInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeTemplateOptionInsertResponse></returns>
		/// </summary>
		public new async Task<AttributeTemplateOptionInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeTemplateOptionInsertRequest, AttributeTemplateOptionInsertResponse>(this);
		}
	}
}
