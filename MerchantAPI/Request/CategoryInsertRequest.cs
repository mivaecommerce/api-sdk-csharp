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
	/// Handles API Request Category_Insert.
	/// <see>https://docs.miva.com/json-api/functions/category_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryInsertRequest : Request
	{
		/// Request field Category_Code.
		[JsonPropertyName("Category_Code")]
		public String CategoryCode { get; set; }

		/// Request field Category_Name.
		[JsonPropertyName("Category_Name")]
		public String CategoryName { get; set; }

		/// Request field Category_Active.
		[JsonPropertyName("Category_Active")]
		public bool? CategoryActive { get; set; }

		/// Request field Category_Page_Title.
		[JsonPropertyName("Category_Page_Title")]
		public String CategoryPageTitle { get; set; }

		/// Request field Category_Parent_Category.
		[JsonPropertyName("Category_Parent_Category")]
		public String CategoryParentCategory { get; set; }

		/// Request field Category_Alternate_Display_Page.
		[JsonPropertyName("Category_Alternate_Display_Page")]
		public String CategoryAlternateDisplayPage { get; set; }

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="category">Category</param>
		/// </summary>
		public CategoryInsertRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "Category_Insert";
			CustomFieldValues = new CustomFieldValues();
			if (category != null) {
				CategoryCode = category.Code;
				CategoryName = category.Name;
				CategoryActive = category.Active;
				CategoryPageTitle = category.PageTitle;
				CategoryParentCategory = category.ParentCategory;
				CategoryAlternateDisplayPage = category.PageCode;
				CustomFieldValues = category.CustomFieldValues;
			}
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
		/// Getter for Category_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryName()
		{
			return CategoryName;
		}

		/// <summary>
		/// Getter for Category_Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCategoryActive()
		{
			return CategoryActive;
		}

		/// <summary>
		/// Getter for Category_Page_Title.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryPageTitle()
		{
			return CategoryPageTitle;
		}

		/// <summary>
		/// Getter for Category_Parent_Category.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryParentCategory()
		{
			return CategoryParentCategory;
		}

		/// <summary>
		/// Getter for Category_Alternate_Display_Page.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryAlternateDisplayPage()
		{
			return CategoryAlternateDisplayPage;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryInsertRequest</returns>
		/// </summary>
		public CategoryInsertRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Name.
		/// <param name="value">String</param>
		/// <returns>CategoryInsertRequest</returns>
		/// </summary>
		public CategoryInsertRequest SetCategoryName(String value)
		{
			CategoryName = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Active.
		/// <param name="value">bool</param>
		/// <returns>CategoryInsertRequest</returns>
		/// </summary>
		public CategoryInsertRequest SetCategoryActive(bool? value)
		{
			CategoryActive = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Page_Title.
		/// <param name="value">String</param>
		/// <returns>CategoryInsertRequest</returns>
		/// </summary>
		public CategoryInsertRequest SetCategoryPageTitle(String value)
		{
			CategoryPageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Parent_Category.
		/// <param name="value">String</param>
		/// <returns>CategoryInsertRequest</returns>
		/// </summary>
		public CategoryInsertRequest SetCategoryParentCategory(String value)
		{
			CategoryParentCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Alternate_Display_Page.
		/// <param name="value">String</param>
		/// <returns>CategoryInsertRequest</returns>
		/// </summary>
		public CategoryInsertRequest SetCategoryAlternateDisplayPage(String value)
		{
			CategoryAlternateDisplayPage = value;
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

			writer.WriteString("Category_Code", CategoryCode);

			writer.WriteString("Category_Name", CategoryName);

			if (CategoryActive.HasValue)
			{
				writer.WriteBoolean("Category_Active", CategoryActive.Value);
			}

			if (CategoryPageTitle != null && CategoryPageTitle.Length > 0)
			{
				writer.WriteString("Category_Page_Title", CategoryPageTitle);
			}

			if (CategoryParentCategory != null && CategoryParentCategory.Length > 0)
			{
				writer.WriteString("Category_Parent_Category", CategoryParentCategory);
			}

			if (CategoryAlternateDisplayPage != null && CategoryAlternateDisplayPage.Length > 0)
			{
				writer.WriteString("Category_Alternate_Display_Page", CategoryAlternateDisplayPage);
			}

			if (CustomFieldValues != null)
			{
				writer.WritePropertyName("CustomField_Values");
				JsonSerializer.Serialize(writer, this.CustomFieldValues, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryInsertResponse</returns>
		/// </summary>
		public new CategoryInsertResponse Send()
		{
			return Client.SendRequestAsync<CategoryInsertRequest, CategoryInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryInsertResponse></returns>
		/// </summary>
		public new async Task<CategoryInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryInsertRequest, CategoryInsertResponse>(this);
		}
	}
}
