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
	/// Handles API Request ProductVariantList_Load_Product.
	/// <see>https://docs.miva.com/json-api/functions/productvariantlist_load_product</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductVariantListLoadProductRequest : Request
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field Include_Default_Variant.
		[JsonPropertyName("Include_Default_Variant")]
		public bool? IncludeDefaultVariant { get; set; }

		/// Request field Limits.
		[JsonPropertyName("Limits")]
		public List<ProductVariantLimit> Limits { get; set; } = new List<ProductVariantLimit>();

		/// Request field Exclusions.
		[JsonPropertyName("Exclusions")]
		public List<ProductVariantExclusion> Exclusions { get; set; } = new List<ProductVariantExclusion>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductVariantListLoadProductRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductVariantList_Load_Product";
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
		public int GetProductId()
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
		/// Getter for Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for Include_Default_Variant.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetIncludeDefaultVariant()
		{
			return IncludeDefaultVariant;
		}

		/// <summary>
		/// Getter for Limits.
		/// <returns>List<ProductVariantLimit></returns>
		/// </summary>
		public List<ProductVariantLimit> GetLimits()
		{
			return Limits;
		}

		/// <summary>
		/// Getter for Exclusions.
		/// <returns>List<ProductVariantExclusion></returns>
		/// </summary>
		public List<ProductVariantExclusion> GetExclusions()
		{
			return Exclusions;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Include_Default_Variant.
		/// <param name="value">bool</param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest SetIncludeDefaultVariant(bool? value)
		{
			IncludeDefaultVariant = value;
			return this;
		}

		/// <summary>
		/// Add a ProductVariantLimit.
		/// - limit: ProductVariantLimit
		/// - Returns: Self
		/// </summary>
		public ProductVariantListLoadProductRequest AddLimit(ProductVariantLimit limit)
		{
			Limits.Add(limit);
			return this;
		}

		/// <summary>
		/// Add an array of ProductVariantLimit.
		/// <param name="limits">List<ProductVariantLimit></param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest AddLimits(List<ProductVariantLimit> limits)
		{
			foreach(ProductVariantLimit e in limits)
			{
				Limits.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a ProductVariantExclusion.
		/// - exclusion: ProductVariantExclusion
		/// - Returns: Self
		/// </summary>
		public ProductVariantListLoadProductRequest AddExclusion(ProductVariantExclusion exclusion)
		{
			Exclusions.Add(exclusion);
			return this;
		}

		/// <summary>
		/// Add an array of ProductVariantExclusion.
		/// <param name="exclusions">List<ProductVariantExclusion></param>
		/// <returns>ProductVariantListLoadProductRequest</returns>
		/// </summary>
		public ProductVariantListLoadProductRequest AddExclusions(List<ProductVariantExclusion> exclusions)
		{
			foreach(ProductVariantExclusion e in exclusions)
			{
				Exclusions.Add(e);
			}

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

			if (ProductId > 0)
			{
				writer.WriteNumber("Product_ID", ProductId);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}
			else if (ProductSku != null && ProductSku.Length > 0)
			{
				writer.WriteString("Product_SKU", ProductSku);
			}

			if (IncludeDefaultVariant.HasValue)
			{
				writer.WriteBoolean("Include_Default_Variant", IncludeDefaultVariant.Value);
			}

			if (Limits.Count > 0)
			{
				writer.WritePropertyName("Limits");
				JsonSerializer.Serialize(writer, this.Limits, options);
			}

			if (Exclusions.Count > 0)
			{
				writer.WritePropertyName("Exclusions");
				JsonSerializer.Serialize(writer, this.Exclusions, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductVariantListLoadProductResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductVariantListLoadProductResponse</returns>
		/// </summary>
		public new ProductVariantListLoadProductResponse Send()
		{
			return Client.SendRequestAsync<ProductVariantListLoadProductRequest, ProductVariantListLoadProductResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductVariantListLoadProductResponse></returns>
		/// </summary>
		public new async Task<ProductVariantListLoadProductResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductVariantListLoadProductRequest, ProductVariantListLoadProductResponse>(this);
		}
	}
}
