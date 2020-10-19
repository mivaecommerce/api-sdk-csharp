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
	/// Handles API Request ProductImage_Add.
	/// <see>https://docs.miva.com/json-api/functions/productimage_add</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductImageAddRequest : Request
	{
		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field Filepath.
		[JsonPropertyName("Filepath")]
		public String Filepath { get; set; }

		/// Request field ImageType_ID.
		[JsonPropertyName("ImageType_ID")]
		public int ImageTypeId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductImageAddRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductImage_Add";
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
		/// Getter for Product_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
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
		/// Getter for Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for Filepath.
		/// <returns>String</returns>
		/// </summary>
		public String GetFilepath()
		{
			return Filepath;
		}

		/// <summary>
		/// Getter for ImageType_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetImageTypeId()
		{
			return ImageTypeId;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductImageAddRequest</returns>
		/// </summary>
		public ProductImageAddRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductImageAddRequest</returns>
		/// </summary>
		public ProductImageAddRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductImageAddRequest</returns>
		/// </summary>
		public ProductImageAddRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>ProductImageAddRequest</returns>
		/// </summary>
		public ProductImageAddRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Filepath.
		/// <param name="value">String</param>
		/// <returns>ProductImageAddRequest</returns>
		/// </summary>
		public ProductImageAddRequest SetFilepath(String value)
		{
			Filepath = value;
			return this;
		}

		/// <summary>
		/// Setter for ImageType_ID.
		/// <param name="value">int</param>
		/// <returns>ProductImageAddRequest</returns>
		/// </summary>
		public ProductImageAddRequest SetImageTypeId(int value)
		{
			ImageTypeId = value;
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

			writer.WriteString("Filepath", Filepath);

			writer.WriteNumber("ImageType_ID", ImageTypeId);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductImageAddResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductImageAddResponse</returns>
		/// </summary>
		public new ProductImageAddResponse Send()
		{
			return Client.SendRequestAsync<ProductImageAddRequest, ProductImageAddResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductImageAddResponse></returns>
		/// </summary>
		public new async Task<ProductImageAddResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductImageAddRequest, ProductImageAddResponse>(this);
		}
	}
}
