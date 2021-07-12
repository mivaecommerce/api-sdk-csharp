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
	/// Handles API Request PriceGroupExcludedCategory_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupexcludedcategory_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupExcludedCategoryUpdateAssignedRequest : Request
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

		/// Request field PriceGroup_ID.
		[JsonPropertyName("PriceGroup_ID")]
		public int? PriceGroupId { get; set; }

		/// Request field Edit_PriceGroup.
		[JsonPropertyName("Edit_PriceGroup")]
		public String EditPriceGroup { get; set; }

		/// Request field PriceGroup_Name.
		[JsonPropertyName("PriceGroup_Name")]
		public String PriceGroupName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="priceGroup">PriceGroup</param>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest(BaseClient client = null, PriceGroup priceGroup = null) :
			base(client)
		{
			Function = "PriceGroupExcludedCategory_Update_Assigned";
			if (priceGroup != null) {
				if (priceGroup.Id > 0)
				{
					CategoryId = priceGroup.Id;
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
		/// Getter for PriceGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPriceGroupId()
		{
			return PriceGroupId;
		}

		/// <summary>
		/// Getter for Edit_PriceGroup.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditPriceGroup()
		{
			return EditPriceGroup;
		}

		/// <summary>
		/// Getter for PriceGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetPriceGroupName()
		{
			return PriceGroupName;
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
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetCategoryId(int? value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetEditCategory(String value)
		{
			EditCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_PriceGroup.
		/// <param name="value">String</param>
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetEditPriceGroup(String value)
		{
			EditPriceGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupExcludedCategoryUpdateAssignedRequest SetAssigned(bool? value)
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

			if (PriceGroupId.HasValue)
			{
				writer.WriteNumber("PriceGroup_ID", PriceGroupId.Value);
			}
			else if (EditPriceGroup != null && EditPriceGroup.Length > 0)
			{
				writer.WriteString("Edit_PriceGroup", EditPriceGroup);
			}
			else if (PriceGroupName != null && PriceGroupName.Length > 0)
			{
				writer.WriteString("PriceGroup_Name", PriceGroupName);
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

			writer.WriteString("PriceGroup_Name", PriceGroupName);

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
			return JsonSerializer.Deserialize<PriceGroupExcludedCategoryUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupExcludedCategoryUpdateAssignedResponse</returns>
		/// </summary>
		public new PriceGroupExcludedCategoryUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupExcludedCategoryUpdateAssignedRequest, PriceGroupExcludedCategoryUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupExcludedCategoryUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<PriceGroupExcludedCategoryUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupExcludedCategoryUpdateAssignedRequest, PriceGroupExcludedCategoryUpdateAssignedResponse>(this);
		}
	}
}
