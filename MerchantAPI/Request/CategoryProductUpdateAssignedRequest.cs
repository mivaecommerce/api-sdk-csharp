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
	/// Handles API Request CategoryProduct_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/categoryproduct_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryProductUpdateAssignedRequest : Request
	{
		/// Request field Category_ID.
		[JsonPropertyName("Category_ID")]
		public int? CategoryId { get; set; }

		/// Request field Edit_Category.
		[JsonPropertyName("Edit_Category")]
		public String EditCategory { get; set; }

		/// Request field Category_Code.
		[JsonPropertyName("Category_Code")]
		public String CategoryCode { get; set; }

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

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="category">Category</param>
		/// </summary>
		public CategoryProductUpdateAssignedRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "CategoryProduct_Update_Assigned";
			if (category != null) {
				if (category.Id > 0)
				{
					CategoryId = category.Id;
				}
				else if (category.Code.Length > 0)
				{
					EditCategory = category.Code;
				}
			}
		}

		/// <summary>
		/// Getter for Category_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCategoryId()
		{
			return CategoryId;
		}

		/// <summary>
		/// Getter for Edit_Category.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCategory()
		{
			return EditCategory;
		}

		/// <summary>
		/// Getter for Category_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryCode()
		{
			return CategoryCode;
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
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for Category_ID.
		/// <param name="value">int</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetCategoryId(int? value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetEditCategory(String value)
		{
			EditCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CategoryProductUpdateAssignedRequest</returns>
		/// </summary>
		public CategoryProductUpdateAssignedRequest SetAssigned(bool value)
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

			if (CategoryId.HasValue)
			{
				writer.WriteNumber("Category_ID", CategoryId.Value);
			}
			else if (EditCategory != null && EditCategory.Length > 0)
			{
				writer.WriteString("Edit_Category", EditCategory);
			}
			else if (CategoryCode != null && CategoryCode.Length > 0)
			{
				writer.WriteString("Category_Code", CategoryCode);
			}

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

			writer.WriteBoolean("Assigned", Assigned);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryProductUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryProductUpdateAssignedResponse</returns>
		/// </summary>
		public new CategoryProductUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<CategoryProductUpdateAssignedRequest, CategoryProductUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryProductUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<CategoryProductUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryProductUpdateAssignedRequest, CategoryProductUpdateAssignedResponse>(this);
		}
	}
}
