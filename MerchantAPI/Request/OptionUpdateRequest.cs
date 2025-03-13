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
	/// Handles API Request Option_Update.
	/// <see>https://docs.miva.com/json-api/functions/option_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OptionUpdateRequest : Request
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

		/// Request field Option_ID.
		[JsonPropertyName("Option_ID")]
		public int? OptionId { get; set; }

		/// Request field Option_Code.
		[JsonPropertyName("Option_Code")]
		public String OptionCode { get; set; }

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
		/// <param name="productOption">ProductOption</param>
		/// </summary>
		public OptionUpdateRequest(BaseClient client = null, ProductOption productOption = null) :
			base(client)
		{
			Function = "Option_Update";
			if (productOption != null) {
				if (productOption.ProductId > 0)
				{
					ProductId = productOption.ProductId;
				}

				if (productOption.AttributeId > 0)
				{
					AttributeId = productOption.AttributeId;
				}

				if (productOption.Id > 0)
				{
					OptionId = productOption.Id;
				}
				else if (productOption.Code.Length > 0)
				{
					OptionCode = productOption.Code;
				}

				Code = productOption.Code;
				Prompt = productOption.Prompt;
				Image = productOption.Image;
				Price = productOption.Price;
				Cost = productOption.Cost;
				Weight = productOption.Weight;
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Option_ID.
		/// <param name="value">int</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetOptionId(int? value)
		{
			OptionId = value;
			return this;
		}

		/// <summary>
		/// Setter for Option_Code.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetOptionCode(String value)
		{
			OptionCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetAttributeId(int? value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Attribute.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetEditAttribute(String value)
		{
			EditAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_Code.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Prompt.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetPrompt(String value)
		{
			Prompt = value;
			return this;
		}

		/// <summary>
		/// Setter for Image.
		/// <param name="value">String</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetPrice(float? value)
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetPrice(double? value)
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetCost(float? value)
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetCost(double? value)
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetWeight(float? value)
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetWeight(double? value)
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
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetWeight(decimal? value)
		{
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Default.
		/// <param name="value">bool</param>
		/// <returns>OptionUpdateRequest</returns>
		/// </summary>
		public OptionUpdateRequest SetDefault(bool? value)
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

			if (OptionId.HasValue)
			{
				writer.WriteNumber("Option_ID", OptionId.Value);
			}
			else if (OptionCode != null && OptionCode.Length > 0)
			{
				writer.WriteString("Option_Code", OptionCode);
			}

			if (Code != null && Code.Length > 0)
			{
				writer.WriteString("Code", Code);
			}

			if (Prompt != null && Prompt.Length > 0)
			{
				writer.WriteString("Prompt", Prompt);
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
			return JsonSerializer.Deserialize<OptionUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OptionUpdateResponse</returns>
		/// </summary>
		public new OptionUpdateResponse Send()
		{
			return Client.SendRequestAsync<OptionUpdateRequest, OptionUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OptionUpdateResponse></returns>
		/// </summary>
		public new async Task<OptionUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OptionUpdateRequest, OptionUpdateResponse>(this);
		}
	}
}
