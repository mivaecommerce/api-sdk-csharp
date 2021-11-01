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
	/// Handles API Request ProductAttributeAndOptionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productattributeandoptionlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductAttributeAndOptionListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int ProductId { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"code",
			"prompt",
			"price",
			"cost",
			"weight",
			"image",
			"type",
			"template",
			"required",
			"inventory",
			"attr_code",
			"attr_prompt",
			"attr_price",
			"attr_cost",
			"attr_weight",
			"attr_image",
			"opt_code",
			"opt_prompt",
			"opt_price",
			"opt_cost",
			"opt_weight",
			"opt_image"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"code",
			"prompt",
			"price",
			"cost",
			"weight",
			"image",
			"type",
			"required",
			"inventory",
			"attr_code",
			"attr_prompt",
			"attr_price",
			"attr_cost",
			"attr_weight",
			"attr_image",
			"opt_code",
			"opt_prompt",
			"opt_price",
			"opt_cost",
			"opt_weight",
			"opt_image",
			"disporder"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductAttributeAndOptionListLoadQueryRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductAttributeAndOptionList_Load_Query";
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
		public int GetProductId()
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
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductAttributeAndOptionListLoadQueryRequest</returns>
		/// </summary>
		public ProductAttributeAndOptionListLoadQueryRequest SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductAttributeAndOptionListLoadQueryRequest</returns>
		/// </summary>
		public ProductAttributeAndOptionListLoadQueryRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductAttributeAndOptionListLoadQueryRequest</returns>
		/// </summary>
		public ProductAttributeAndOptionListLoadQueryRequest SetProductCode(String value)
		{
			ProductCode = value;
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
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductAttributeAndOptionListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductAttributeAndOptionListLoadQueryResponse</returns>
		/// </summary>
		public new ProductAttributeAndOptionListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ProductAttributeAndOptionListLoadQueryRequest, ProductAttributeAndOptionListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductAttributeAndOptionListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ProductAttributeAndOptionListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductAttributeAndOptionListLoadQueryRequest, ProductAttributeAndOptionListLoadQueryResponse>(this);
		}
	}
}
