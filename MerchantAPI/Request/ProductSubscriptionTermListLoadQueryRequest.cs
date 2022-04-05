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
	/// Handles API Request ProductSubscriptionTermList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productsubscriptiontermlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductSubscriptionTermListLoadQueryRequest : ListQueryRequest
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
			"frequency",
			"term",
			"descrip",
			"n",
			"fixed_dow",
			"fixed_dom",
			"sub_count"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"frequency",
			"term",
			"descrip",
			"n",
			"frequency",
			"fixed_dow",
			"fixed_dom",
			"sub_count",
			"disp_order"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductSubscriptionTermListLoadQueryRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductSubscriptionTermList_Load_Query";
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
		/// <returns>ProductSubscriptionTermListLoadQueryRequest</returns>
		/// </summary>
		public ProductSubscriptionTermListLoadQueryRequest SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductSubscriptionTermListLoadQueryRequest</returns>
		/// </summary>
		public ProductSubscriptionTermListLoadQueryRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductSubscriptionTermListLoadQueryRequest</returns>
		/// </summary>
		public ProductSubscriptionTermListLoadQueryRequest SetProductCode(String value)
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
			return JsonSerializer.Deserialize<ProductSubscriptionTermListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductSubscriptionTermListLoadQueryResponse</returns>
		/// </summary>
		public new ProductSubscriptionTermListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ProductSubscriptionTermListLoadQueryRequest, ProductSubscriptionTermListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductSubscriptionTermListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ProductSubscriptionTermListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductSubscriptionTermListLoadQueryRequest, ProductSubscriptionTermListLoadQueryResponse>(this);
		}
	}
}
