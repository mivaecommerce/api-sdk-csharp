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
	/// Handles API Request Attribute_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attribute_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeInsertRequest : Request
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
		/// <param name="product">Product</param>
		/// </summary>
		public AttributeInsertRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "Attribute_Insert";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
				}

				ProductCode = product.Code;
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Type.
		/// <param name="value">String</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetAttributeType(String value)
		{
			AttributeType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">ProductAttribute.ProductAttributeType</param>
		/// <returns></returns>
		/// </summary>
		public AttributeInsertRequest SetAttributeType(ProductAttribute.ProductAttributeType value)
		{
			AttributeType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetPrice(float? value)
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetPrice(double? value)
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetCost(float? value)
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetCost(double? value)
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetWeight(float? value)
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetWeight(double? value)
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
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetWeight(decimal? value)
		{
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Copy.
		/// <param name="value">bool</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetCopy(bool? value)
		{
			Copy = value;
			return this;
		}

		/// <summary>
		/// Setter for Required.
		/// <param name="value">bool</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetRequired(bool? value)
		{
			Required = value;
			return this;
		}

		/// <summary>
		/// Setter for Inventory.
		/// <param name="value">bool</param>
		/// <returns>AttributeInsertRequest</returns>
		/// </summary>
		public AttributeInsertRequest SetInventory(bool? value)
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
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}

			if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
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
			return JsonSerializer.Deserialize<AttributeInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeInsertResponse</returns>
		/// </summary>
		public new AttributeInsertResponse Send()
		{
			return Client.SendRequestAsync<AttributeInsertRequest, AttributeInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeInsertResponse></returns>
		/// </summary>
		public new async Task<AttributeInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeInsertRequest, AttributeInsertResponse>(this);
		}
	}
}
