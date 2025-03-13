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
	/// Handles API Request Attribute_Update.
	/// <see>https://docs.miva.com/json-api/functions/attribute_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeUpdateRequest : Request
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Attribute_ID.
		[JsonPropertyName("Attribute_ID")]
		public int? AttributeId { get; set; }

		/// Request field Edit_Attribute.
		[JsonPropertyName("Edit_Attribute")]
		public String EditAttribute { get; set; }

		/// Request field Attribute_Code.
		[JsonPropertyName("Attribute_Code")]
		public String AttributeCode { get; set; }

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
		/// <param name="productAttribute">ProductAttribute</param>
		/// </summary>
		public AttributeUpdateRequest(BaseClient client = null, ProductAttribute productAttribute = null) :
			base(client)
		{
			Function = "Attribute_Update";
			if (productAttribute != null) {
				if (productAttribute.ProductId > 0)
				{
					ProductId = productAttribute.ProductId;
				}

				if (productAttribute.Id > 0)
				{
					AttributeId = productAttribute.Id;
				}
				else if (productAttribute.Code.Length > 0)
				{
					EditAttribute = productAttribute.Code;
				}
				else if (productAttribute.Code.Length > 0)
				{
					AttributeCode = productAttribute.Code;
				}

				EditAttribute = productAttribute.Code;
				Code = productAttribute.Code;
				Prompt = productAttribute.Prompt;
				AttributeType = productAttribute.AttributeType;
				Image = productAttribute.Image;
				Price = productAttribute.Price;
				Cost = productAttribute.Cost;
				Weight = productAttribute.Weight;
				Required = productAttribute.Required;
				Inventory = productAttribute.Inventory;
			}
		}

		/// <summary>
		/// Getter for Product_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for Product_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
		}

		/// <summary>
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
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
		/// Getter for Edit_Attribute.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAttribute()
		{
			return EditAttribute;
		}

		/// <summary>
		/// Getter for Attribute_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeCode()
		{
			return AttributeCode;
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
		/// <returns>ProductAttribute.ProductAttributeType?</returns>
		/// </summary>
		public ProductAttribute.ProductAttributeType? GetAttributeTypeConst()
		{
			return ProductAttribute.ProductAttributeTypeFromString(AttributeType);
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
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetAttributeId(int? value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Attribute.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetEditAttribute(String value)
		{
			EditAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Type.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetAttributeType(String value)
		{
			AttributeType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">ProductAttribute.ProductAttributeType</param>
		/// <returns></returns>
		/// </summary>
		public AttributeUpdateRequest SetAttributeType(ProductAttribute.ProductAttributeType value)
		{
			AttributeType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetPrice(float? value)
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
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetPrice(double? value)
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
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetCost(float? value)
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
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetCost(double? value)
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
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetWeight(float? value)
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
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetWeight(double? value)
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
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetWeight(decimal? value)
		{
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Copy.
		/// <param name="value">bool</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetCopy(bool? value)
		{
			Copy = value;
			return this;
		}

		/// <summary>
		/// Setter for Required.
		/// <param name="value">bool</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetRequired(bool? value)
		{
			Required = value;
			return this;
		}

		/// <summary>
		/// Setter for Inventory.
		/// <param name="value">bool</param>
		/// <returns>AttributeUpdateRequest</returns>
		/// </summary>
		public AttributeUpdateRequest SetInventory(bool? value)
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

			if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}

			if (AttributeId.HasValue)
			{
				writer.WriteNumber("Attribute_ID", AttributeId.Value);
			}
			else if (EditAttribute != null && EditAttribute.Length > 0)
			{
				writer.WriteString("Edit_Attribute", EditAttribute);
			}
			else if (AttributeCode != null && AttributeCode.Length > 0)
			{
				writer.WriteString("Attribute_Code", AttributeCode);
			}

			if (EditAttribute != null && EditAttribute.Length > 0)
			{
				writer.WriteString("Edit_Attribute", EditAttribute);
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
			return JsonSerializer.Deserialize<AttributeUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeUpdateResponse</returns>
		/// </summary>
		public new AttributeUpdateResponse Send()
		{
			return Client.SendRequestAsync<AttributeUpdateRequest, AttributeUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeUpdateResponse></returns>
		/// </summary>
		public new async Task<AttributeUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeUpdateRequest, AttributeUpdateResponse>(this);
		}
	}
}
