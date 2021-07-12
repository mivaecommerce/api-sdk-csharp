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
	/// Handles API Request CategoryURI_Insert.
	/// <see>https://docs.miva.com/json-api/functions/categoryuri_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryURIInsertRequest : Request
	{
		/// Request field URI.
		[JsonPropertyName("URI")]
		public String Uri { get; set; }

		/// Request field Status.
		[JsonPropertyName("Status")]
		public int? Status { get; set; }

		/// Request field Canonical.
		[JsonPropertyName("Canonical")]
		public bool? Canonical { get; set; }

		/// Request field Category_ID.
		[JsonPropertyName("Category_ID")]
		public int? CategoryId { get; set; }

		/// Request field Category_Code.
		[JsonPropertyName("Category_Code")]
		public String CategoryCode { get; set; }

		/// Request field Edit_Category.
		[JsonPropertyName("Edit_Category")]
		public String EditCategory { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="category">Category</param>
		/// </summary>
		public CategoryURIInsertRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "CategoryURI_Insert";
			if (category != null) {
				if (category.Id > 0)
				{
					CategoryId = category.Id;
				}
				else if (category.Code.Length > 0)
				{
					CategoryCode = category.Code;
				}
			}
		}

		/// <summary>
		/// Getter for URI.
		/// <returns>String</returns>
		/// </summary>
		public String GetUri()
		{
			return Uri;
		}

		/// <summary>
		/// Getter for Status.
		/// <returns>int</returns>
		/// </summary>
		public int? GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for Canonical.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCanonical()
		{
			return Canonical;
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
		/// Getter for Category_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryCode()
		{
			return CategoryCode;
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
		/// Setter for URI.
		/// <param name="value">String</param>
		/// <returns>CategoryURIInsertRequest</returns>
		/// </summary>
		public CategoryURIInsertRequest SetUri(String value)
		{
			Uri = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>CategoryURIInsertRequest</returns>
		/// </summary>
		public CategoryURIInsertRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for Canonical.
		/// <param name="value">bool</param>
		/// <returns>CategoryURIInsertRequest</returns>
		/// </summary>
		public CategoryURIInsertRequest SetCanonical(bool? value)
		{
			Canonical = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_ID.
		/// <param name="value">int</param>
		/// <returns>CategoryURIInsertRequest</returns>
		/// </summary>
		public CategoryURIInsertRequest SetCategoryId(int? value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryURIInsertRequest</returns>
		/// </summary>
		public CategoryURIInsertRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>CategoryURIInsertRequest</returns>
		/// </summary>
		public CategoryURIInsertRequest SetEditCategory(String value)
		{
			EditCategory = value;
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
			else if (CategoryCode != null && CategoryCode.Length > 0)
			{
				writer.WriteString("Category_Code", CategoryCode);
			}
			else if (EditCategory != null && EditCategory.Length > 0)
			{
				writer.WriteString("Edit_Category", EditCategory);
			}

			if (Uri != null && Uri.Length > 0)
			{
				writer.WriteString("URI", Uri);
			}

			if (Status.HasValue)
			{
				writer.WriteNumber("Status", Status.Value);
			}

			if (Canonical.HasValue)
			{
				writer.WriteBoolean("Canonical", Canonical.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryURIInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryURIInsertResponse</returns>
		/// </summary>
		public new CategoryURIInsertResponse Send()
		{
			return Client.SendRequestAsync<CategoryURIInsertRequest, CategoryURIInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryURIInsertResponse></returns>
		/// </summary>
		public new async Task<CategoryURIInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryURIInsertRequest, CategoryURIInsertResponse>(this);
		}
	}
}
