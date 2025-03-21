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
	/// Handles API Request Option_Insert.
	/// <see>https://docs.miva.com/json-api/functions/option_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OptionInsertRequest : Request
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
		/// <param name="productAttribute">ProductAttribute</param>
		/// </summary>
		public OptionInsertRequest(BaseClient client = null, ProductAttribute productAttribute = null) :
			base(client)
		{
			Function = "Option_Insert";
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
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetAttributeId(int? value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Attribute.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetEditAttribute(String value)
		{
			EditAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_Code.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetPrice(float? value)
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
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetPrice(double? value)
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
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetCost(float? value)
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
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetCost(double? value)
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
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetWeight(float? value)
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
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetWeight(double? value)
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
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetWeight(decimal? value)
		{
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Default.
		/// <param name="value">bool</param>
		/// <returns>OptionInsertRequest</returns>
		/// </summary>
		public OptionInsertRequest SetDefault(bool? value)
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

			if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
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
			return JsonSerializer.Deserialize<OptionInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OptionInsertResponse</returns>
		/// </summary>
		public new OptionInsertResponse Send()
		{
			return Client.SendRequestAsync<OptionInsertRequest, OptionInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OptionInsertResponse></returns>
		/// </summary>
		public new async Task<OptionInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OptionInsertRequest, OptionInsertResponse>(this);
		}
	}
}
