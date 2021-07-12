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
	/// Handles API Request AvailabilityGroupCategory_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupcategory_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupCategoryUpdateAssignedRequest : Request
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

		/// Request field AvailabilityGroup_ID.
		[JsonPropertyName("AvailabilityGroup_ID")]
		public int? AvailabilityGroupId { get; set; }

		/// Request field Edit_AvailabilityGroup.
		[JsonPropertyName("Edit_AvailabilityGroup")]
		public String EditAvailabilityGroup { get; set; }

		/// Request field AvailabilityGroup_Name.
		[JsonPropertyName("AvailabilityGroup_Name")]
		public String AvailabilityGroupName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="category">Category</param>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "AvailabilityGroupCategory_Update_Assigned";
			if (category != null) {
				if (category.Id > 0)
				{
					CategoryId = category.Id;
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
		/// Getter for AvailabilityGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAvailabilityGroupId()
		{
			return AvailabilityGroupId;
		}

		/// <summary>
		/// Getter for Edit_AvailabilityGroup.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAvailabilityGroup()
		{
			return EditAvailabilityGroup;
		}

		/// <summary>
		/// Getter for AvailabilityGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetAvailabilityGroupName()
		{
			return AvailabilityGroupName;
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
		/// Setter for Category_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetCategoryId(int? value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetEditCategory(String value)
		{
			EditCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetAvailabilityGroupId(int? value)
		{
			AvailabilityGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AvailabilityGroup.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetEditAvailabilityGroup(String value)
		{
			EditAvailabilityGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCategoryUpdateAssignedRequest SetAssigned(bool? value)
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

			if (AvailabilityGroupId.HasValue)
			{
				writer.WriteNumber("AvailabilityGroup_ID", AvailabilityGroupId.Value);
			}
			else if (EditAvailabilityGroup != null && EditAvailabilityGroup.Length > 0)
			{
				writer.WriteString("Edit_AvailabilityGroup", EditAvailabilityGroup);
			}
			else if (AvailabilityGroupName != null && AvailabilityGroupName.Length > 0)
			{
				writer.WriteString("AvailabilityGroup_Name", AvailabilityGroupName);
			}

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

			writer.WriteString("AvailabilityGroup_Name", AvailabilityGroupName);

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
			return JsonSerializer.Deserialize<AvailabilityGroupCategoryUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupCategoryUpdateAssignedResponse</returns>
		/// </summary>
		public new AvailabilityGroupCategoryUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupCategoryUpdateAssignedRequest, AvailabilityGroupCategoryUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupCategoryUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupCategoryUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupCategoryUpdateAssignedRequest, AvailabilityGroupCategoryUpdateAssignedResponse>(this);
		}
	}
}
