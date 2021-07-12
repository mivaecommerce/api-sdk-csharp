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
	/// Handles API Request CategoryURIList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/categoryurilist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryURIListLoadQueryRequest : ListQueryRequest
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

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"canonical",
			"status",
			"uri"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"uri"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="category">Category</param>
		/// </summary>
		public CategoryURIListLoadQueryRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "CategoryURIList_Load_Query";
			if (category != null) {
				if (category.Id > 0)
				{
					CategoryId = category.Id;
				}
				else if (category.Code.Length > 0)
				{
					EditCategory = category.Code;
				}
				else if (category.Code.Length > 0)
				{
					CategoryCode = category.Code;
				}

				CategoryCode = category.Code;
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
		/// Setter for Category_ID.
		/// <param name="value">int</param>
		/// <returns>CategoryURIListLoadQueryRequest</returns>
		/// </summary>
		public CategoryURIListLoadQueryRequest SetCategoryId(int? value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>CategoryURIListLoadQueryRequest</returns>
		/// </summary>
		public CategoryURIListLoadQueryRequest SetEditCategory(String value)
		{
			EditCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryURIListLoadQueryRequest</returns>
		/// </summary>
		public CategoryURIListLoadQueryRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
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

			writer.WriteString("Category_Code", CategoryCode);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryURIListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryURIListLoadQueryResponse</returns>
		/// </summary>
		public new CategoryURIListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CategoryURIListLoadQueryRequest, CategoryURIListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryURIListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CategoryURIListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryURIListLoadQueryRequest, CategoryURIListLoadQueryResponse>(this);
		}
	}
}
