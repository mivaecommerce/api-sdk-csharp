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
	/// Handles API Request Category_Update.
	/// <see>https://docs.miva.com/json-api/functions/category_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryUpdateRequest : Request
	{
		/// Request field Category_ID.
		[JsonPropertyName("Category_ID")]
		public int? CategoryId { get; set; }

		/// Request field Category_Code.
		[JsonPropertyName("Category_Code")]
		public String CategoryCode { get; set; }

		/// Request field Edit_Category.
		[JsonPropertyName("Edit_Category")]
		public String EditCategory { get; set; }

		/// Request field Category_Name.
		[JsonPropertyName("Category_Name")]
		public String CategoryName { get; set; }

		/// Request field Category_Page_Title.
		[JsonPropertyName("Category_Page_Title")]
		public String CategoryPageTitle { get; set; }

		/// Request field Category_Active.
		[JsonPropertyName("Category_Active")]
		public bool? CategoryActive { get; set; }

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
		public CategoryUpdateRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "Category_Update";
			CustomFieldValues = new CustomFieldValues();
			if (category != null) {
				if (category.Id > 0)
				{
					CategoryId = category.Id;
				}
				else if (category.Code.Length > 0)
				{
					EditCategory = category.Code;
				}

				CategoryCode = category.Code;
				CategoryName = category.Name;
				CategoryPageTitle = category.PageTitle;
				CategoryActive = category.Active;
				CategoryParentCategory = category.ParentCategory;
				CategoryAlternateDisplayPage = category.PageCode;
				CustomFieldValues = category.CustomFieldValues;
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
		/// Getter for Category_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryName()
		{
			return CategoryName;
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
		/// Getter for Category_Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCategoryActive()
		{
			return CategoryActive;
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
		/// Setter for Category_ID.
		/// <param name="value">int</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryId(int? value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetEditCategory(String value)
		{
			EditCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Name.
		/// <param name="value">String</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryName(String value)
		{
			CategoryName = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Page_Title.
		/// <param name="value">String</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryPageTitle(String value)
		{
			CategoryPageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Active.
		/// <param name="value">bool</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryActive(bool? value)
		{
			CategoryActive = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Parent_Category.
		/// <param name="value">String</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryParentCategory(String value)
		{
			CategoryParentCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Alternate_Display_Page.
		/// <param name="value">String</param>
		/// <returns>CategoryUpdateRequest</returns>
		/// </summary>
		public CategoryUpdateRequest SetCategoryAlternateDisplayPage(String value)
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

			if (CategoryId.HasValue)
			{
				writer.WriteNumber("Category_ID", CategoryId.Value);
			}
			else if (EditCategory != null && EditCategory.Length > 0)
			{
				writer.WriteString("Edit_Category", EditCategory);
			}

			if (CategoryCode != null && CategoryCode.Length > 0)
			{
				writer.WriteString("Category_Code", CategoryCode);
			}

			if (CategoryName != null && CategoryName.Length > 0)
			{
				writer.WriteString("Category_Name", CategoryName);
			}

			if (CategoryPageTitle != null && CategoryPageTitle.Length > 0)
			{
				writer.WriteString("Category_Page_Title", CategoryPageTitle);
			}

			if (CategoryActive.HasValue)
			{
				writer.WriteBoolean("Category_Active", CategoryActive.Value);
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
			return JsonSerializer.Deserialize<CategoryUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryUpdateResponse</returns>
		/// </summary>
		public new CategoryUpdateResponse Send()
		{
			return Client.SendRequestAsync<CategoryUpdateRequest, CategoryUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryUpdateResponse></returns>
		/// </summary>
		public new async Task<CategoryUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryUpdateRequest, CategoryUpdateResponse>(this);
		}
	}
}
