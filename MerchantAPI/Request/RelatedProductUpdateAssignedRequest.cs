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
	/// Handles API Request RelatedProduct_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/relatedproduct_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class RelatedProductUpdateAssignedRequest : Request
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

		/// Request field RelatedProduct_ID.
		[JsonPropertyName("RelatedProduct_ID")]
		public int RelatedProductId { get; set; }

		/// Request field RelatedProduct_Code.
		[JsonPropertyName("RelatedProduct_Code")]
		public String RelatedProductCode { get; set; }

		/// Request field Edit_RelatedProduct.
		[JsonPropertyName("Edit_RelatedProduct")]
		public String EditRelatedProduct { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public RelatedProductUpdateAssignedRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "RelatedProduct_Update_Assigned";
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
		/// Getter for RelatedProduct_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetRelatedProductId()
		{
			return RelatedProductId;
		}

		/// <summary>
		/// Getter for RelatedProduct_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetRelatedProductCode()
		{
			return RelatedProductCode;
		}

		/// <summary>
		/// Getter for Edit_RelatedProduct.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditRelatedProduct()
		{
			return EditRelatedProduct;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for RelatedProduct_ID.
		/// <param name="value">int</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetRelatedProductId(int value)
		{
			RelatedProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for RelatedProduct_Code.
		/// <param name="value">String</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetRelatedProductCode(String value)
		{
			RelatedProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_RelatedProduct.
		/// <param name="value">String</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetEditRelatedProduct(String value)
		{
			EditRelatedProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>RelatedProductUpdateAssignedRequest</returns>
		/// </summary>
		public RelatedProductUpdateAssignedRequest SetAssigned(bool? value)
		{
			Assigned = value;
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

			if (RelatedProductId > 0)
			{
				writer.WriteNumber("RelatedProduct_ID", RelatedProductId);
			}
			else if (RelatedProductCode != null && RelatedProductCode.Length > 0)
			{
				writer.WriteString("RelatedProduct_Code", RelatedProductCode);
			}
			else if (EditRelatedProduct != null && EditRelatedProduct.Length > 0)
			{
				writer.WriteString("Edit_RelatedProduct", EditRelatedProduct);
			}

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<RelatedProductUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>RelatedProductUpdateAssignedResponse</returns>
		/// </summary>
		public new RelatedProductUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<RelatedProductUpdateAssignedRequest, RelatedProductUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<RelatedProductUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<RelatedProductUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<RelatedProductUpdateAssignedRequest, RelatedProductUpdateAssignedResponse>(this);
		}
	}
}
