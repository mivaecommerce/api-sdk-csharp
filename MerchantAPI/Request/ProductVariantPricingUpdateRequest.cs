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
	/// Handles API Request ProductVariantPricing_Update.
	/// <see>https://docs.miva.com/json-api/functions/productvariantpricing_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductVariantPricingUpdateRequest : Request
	{
		/// Enumeration VariantPricingMethod
		public enum VariantPricingMethod
		{
			Master,
			Specific,
			Sum,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String VariantPricingMethodToString(VariantPricingMethod value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static VariantPricingMethod? VariantPricingMethodFromString(String value)
		{
			switch(value)
			{
				case "master": return VariantPricingMethod.Master;
				case "specific": return VariantPricingMethod.Specific;
				case "sum": return VariantPricingMethod.Sum;
				default: return null;
			}
		}

		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field Variant_ID.
		[JsonPropertyName("Variant_ID")]
		public int VariantId { get; set; }

		/// Request field Method.
		[JsonPropertyName("Method")]
		public String Method { get; set; }

		/// Request field Price.
		[JsonPropertyName("Price")]
		public decimal? Price { get; set; }

		/// Request field Cost.
		[JsonPropertyName("Cost")]
		public decimal? Cost { get; set; }

		/// Request field Weight.
		[JsonPropertyName("Weight")]
		public decimal? Weight { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductVariantPricingUpdateRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductVariantPricing_Update";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
				}
				else if (product.Sku.Length > 0)
				{
					ProductSku = product.Sku;
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
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
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
		/// Getter for Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for Variant_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetVariantId()
		{
			return VariantId;
		}

		/// <summary>
		/// Getter for Method.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethod()
		{
			return Method;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>VariantPricingMethod?</returns>
		/// </summary>
		public VariantPricingMethod? GetMethodConst()
		{
			return VariantPricingMethodFromString(Method);
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
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Variant_ID.
		/// <param name="value">int</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetVariantId(int value)
		{
			VariantId = value;
			return this;
		}

		/// <summary>
		/// Setter for Method.
		/// <param name="value">String</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetMethod(String value)
		{
			Method = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">VariantPricingMethod</param>
		/// <returns></returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetMethod(VariantPricingMethod value)
		{
			Method = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetPrice(float? value)
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
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetPrice(double? value)
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
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetPrice(decimal? value)
		{
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Cost.
		/// <param name="value">float</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetCost(float? value)
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
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetCost(double? value)
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
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetCost(decimal? value)
		{
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetWeight(float? value)
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
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetWeight(double? value)
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
		/// <returns>ProductVariantPricingUpdateRequest</returns>
		/// </summary>
		public ProductVariantPricingUpdateRequest SetWeight(decimal? value)
		{
			Weight = value;
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
			else if (ProductSku != null && ProductSku.Length > 0)
			{
				writer.WriteString("Product_SKU", ProductSku);
			}

			writer.WriteNumber("Variant_ID", VariantId);

			writer.WriteString("Method", Method);

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
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductVariantPricingUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductVariantPricingUpdateResponse</returns>
		/// </summary>
		public new ProductVariantPricingUpdateResponse Send()
		{
			return Client.SendRequestAsync<ProductVariantPricingUpdateRequest, ProductVariantPricingUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductVariantPricingUpdateResponse></returns>
		/// </summary>
		public new async Task<ProductVariantPricingUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductVariantPricingUpdateRequest, ProductVariantPricingUpdateResponse>(this);
		}
	}

	/// Enum Extensions
	public static class ProductVariantPricingUpdateRequestExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this ProductVariantPricingUpdateRequest.VariantPricingMethod e)
	    {
			switch(e)
			{
				case ProductVariantPricingUpdateRequest.VariantPricingMethod.Master: return "master";
				case ProductVariantPricingUpdateRequest.VariantPricingMethod.Specific: return "specific";
				case ProductVariantPricingUpdateRequest.VariantPricingMethod.Sum: return "sum";
			}
			return "";
	    
		}
	}
}
