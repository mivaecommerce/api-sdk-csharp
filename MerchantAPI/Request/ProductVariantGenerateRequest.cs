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
	/// Handles API Request ProductVariant_Generate.
	/// <see>https://docs.miva.com/json-api/functions/productvariant_generate</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductVariantGenerateRequest : Request
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

		/// Request field Pricing_Method.
		[JsonPropertyName("Pricing_Method")]
		public int PricingMethod { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductVariantGenerateRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductVariant_Generate";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					ProductCode = product.Code;
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
		/// <returns>int</returns>
		/// </summary>
		public int GetPricingMethod()
		{
			return PricingMethod;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductVariantGenerateRequest</returns>
		/// </summary>
		public ProductVariantGenerateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductVariantGenerateRequest</returns>
		/// </summary>
		public ProductVariantGenerateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductVariantGenerateRequest</returns>
		/// </summary>
		public ProductVariantGenerateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Pricing_Method.
		/// <param name="value">int</param>
		/// <returns>ProductVariantGenerateRequest</returns>
		/// </summary>
		public ProductVariantGenerateRequest SetPricingMethod(int value)
		{
			PricingMethod = value;
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

			writer.WriteNumber("Pricing_Method", PricingMethod);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductVariantGenerateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductVariantGenerateResponse</returns>
		/// </summary>
		public new ProductVariantGenerateResponse Send()
		{
			return Client.SendRequestAsync<ProductVariantGenerateRequest, ProductVariantGenerateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductVariantGenerateResponse></returns>
		/// </summary>
		public new async Task<ProductVariantGenerateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductVariantGenerateRequest, ProductVariantGenerateResponse>(this);
		}
	}
}
