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
	/// Handles API Request ProductKit_Generate_Variants.
	/// <see>https://docs.miva.com/json-api/functions/productkit_generate_variants</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductKitGenerateVariantsRequest : Request
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

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Pricing_Method.
		[JsonPropertyName("Pricing_Method")]
		public String PricingMethod { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductKitGenerateVariantsRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductKit_Generate_Variants";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
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
		/// Getter for Pricing_Method.
		/// <returns>String</returns>
		/// </summary>
		public String GetPricingMethod()
		{
			return PricingMethod;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>VariantPricingMethod?</returns>
		/// </summary>
		public VariantPricingMethod? GetPricingMethodConst()
		{
			return VariantPricingMethodFromString(PricingMethod);
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductKitGenerateVariantsRequest</returns>
		/// </summary>
		public ProductKitGenerateVariantsRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductKitGenerateVariantsRequest</returns>
		/// </summary>
		public ProductKitGenerateVariantsRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductKitGenerateVariantsRequest</returns>
		/// </summary>
		public ProductKitGenerateVariantsRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Pricing_Method.
		/// <param name="value">String</param>
		/// <returns>ProductKitGenerateVariantsRequest</returns>
		/// </summary>
		public ProductKitGenerateVariantsRequest SetPricingMethod(String value)
		{
			PricingMethod = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">VariantPricingMethod</param>
		/// <returns></returns>
		/// </summary>
		public ProductKitGenerateVariantsRequest SetPricingMethod(VariantPricingMethod value)
		{
			PricingMethod = value.ToConstString();
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

			writer.WriteString("Pricing_Method", PricingMethod);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductKitGenerateVariantsResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductKitGenerateVariantsResponse</returns>
		/// </summary>
		public new ProductKitGenerateVariantsResponse Send()
		{
			return Client.SendRequestAsync<ProductKitGenerateVariantsRequest, ProductKitGenerateVariantsResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductKitGenerateVariantsResponse></returns>
		/// </summary>
		public new async Task<ProductKitGenerateVariantsResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductKitGenerateVariantsRequest, ProductKitGenerateVariantsResponse>(this);
		}

		/// <summary>
		/// Setter for Pricing_Method. Backwards compatibility with less than 2.2.0
		/// <param name="value">int</param>
		/// <returns>ProductKitGenerateVariantsRequest</returns>
		/// </summary>
		public ProductKitGenerateVariantsRequest SetPricingMethod(int value)
		{
			PricingMethod = value.ToString();
			return this;
		}
	}

	/// Enum Extensions
	public static class ProductKitGenerateVariantsRequestExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this ProductKitGenerateVariantsRequest.VariantPricingMethod e)
	    {
			switch(e)
			{
				case ProductKitGenerateVariantsRequest.VariantPricingMethod.Master: return "master";
				case ProductKitGenerateVariantsRequest.VariantPricingMethod.Specific: return "specific";
				case ProductKitGenerateVariantsRequest.VariantPricingMethod.Sum: return "sum";
			}
			return "";
	    
		}
	}
}
