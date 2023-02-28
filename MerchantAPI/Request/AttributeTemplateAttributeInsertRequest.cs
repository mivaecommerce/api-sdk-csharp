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
	/// Handles API Request AttributeTemplateAttribute_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateattribute_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeTemplateAttributeInsertRequest : Request
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
		public float? Price { get; set; }

		/// Request field Cost.
		[JsonPropertyName("Cost")]
		public float? Cost { get; set; }

		/// Request field Weight.
		[JsonPropertyName("Weight")]
		public float? Weight { get; set; }

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
		/// <param name="attributeTemplate">AttributeTemplate</param>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest(BaseClient client = null, AttributeTemplate attributeTemplate = null) :
			base(client)
		{
			Function = "AttributeTemplateAttribute_Insert";
			if (attributeTemplate != null) {
				if (attributeTemplate.Id > 0)
				{
					AttributeTemplateId = attributeTemplate.Id;
				}
				else if (attributeTemplate.Code.Length > 0)
				{
					AttributeTemplateCode = attributeTemplate.Code;
				}
				else if (attributeTemplate.Code.Length > 0)
				{
					EditAttributeTemplate = attributeTemplate.Code;
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
		/// <returns>float</returns>
		/// </summary>
		public float? GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for Cost.
		/// <returns>float</returns>
		/// </summary>
		public float? GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Getter for Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetWeight()
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
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetAttributeTemplateId(int? value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplate_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetAttributeTemplateCode(String value)
		{
			AttributeTemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplate.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetEditAttributeTemplate(String value)
		{
			EditAttributeTemplate = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Type.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetAttributeType(String value)
		{
			AttributeType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">AttributeTemplateAttribute.TemplateAttributeType</param>
		/// <returns></returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetAttributeType(AttributeTemplateAttribute.TemplateAttributeType value)
		{
			AttributeType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
	   public AttributeTemplateAttributeInsertRequest SetPrice(float? value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">double</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
	   public AttributeTemplateAttributeInsertRequest SetPrice(double? value)
	   {
			Price = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
	   public AttributeTemplateAttributeInsertRequest SetCost(float? value)
	   {
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">double</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
	   public AttributeTemplateAttributeInsertRequest SetCost(double? value)
	   {
			Cost = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
	   public AttributeTemplateAttributeInsertRequest SetWeight(float? value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">double</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
	   public AttributeTemplateAttributeInsertRequest SetWeight(double? value)
	   {
			Weight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Copy.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetCopy(bool? value)
		{
			Copy = value;
			return this;
		}

		/// <summary>
		/// Setter for Required.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetRequired(bool? value)
		{
			Required = value;
			return this;
		}

		/// <summary>
		/// Setter for Inventory.
		/// <param name="value">bool</param>
		/// <returns>AttributeTemplateAttributeInsertRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeInsertRequest SetInventory(bool? value)
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

			writer.WriteString("Code", Code);

			if (Prompt != null && Prompt.Length > 0)
			{
				writer.WriteString("Prompt", Prompt);
			}

			writer.WriteString("Type", AttributeType);

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
			return JsonSerializer.Deserialize<AttributeTemplateAttributeInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeTemplateAttributeInsertResponse</returns>
		/// </summary>
		public new AttributeTemplateAttributeInsertResponse Send()
		{
			return Client.SendRequestAsync<AttributeTemplateAttributeInsertRequest, AttributeTemplateAttributeInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeTemplateAttributeInsertResponse></returns>
		/// </summary>
		public new async Task<AttributeTemplateAttributeInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeTemplateAttributeInsertRequest, AttributeTemplateAttributeInsertResponse>(this);
		}
	}
}
