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
	/// Handles API Request ChildCategoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/childcategorylist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ChildCategoryListLoadQueryRequest : CategoryListLoadQueryRequest
	{
		/// Request field ParentCategory_ID.
		[JsonPropertyName("ParentCategory_ID")]
		public int? ParentCategoryId { get; set; }

		/// Request field ParentCategory_Code.
		[JsonPropertyName("ParentCategory_Code")]
		public String ParentCategoryCode { get; set; }

		/// Request field Edit_ParentCategory.
		[JsonPropertyName("Edit_ParentCategory")]
		public String EditParentCategory { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="category">Category</param>
		/// </summary>
		public ChildCategoryListLoadQueryRequest(BaseClient client = null, Category category = null) :
			base(client)
		{
			Function = "ChildCategoryList_Load_Query";
			if (category != null) {
				if (category.Id > 0)
				{
					ParentCategoryId = category.Id;
				}
				else if (category.Code.Length > 0)
				{
					EditParentCategory = category.Code;
				}
				else if (category.Code.Length > 0)
				{
					ParentCategoryCode = category.Code;
				}
			}
		}

		/// <summary>
		/// Getter for ParentCategory_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetParentCategoryId()
		{
			return ParentCategoryId;
		}

		/// <summary>
		/// Getter for ParentCategory_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetParentCategoryCode()
		{
			return ParentCategoryCode;
		}

		/// <summary>
		/// Getter for Edit_ParentCategory.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditParentCategory()
		{
			return EditParentCategory;
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
		/// Getter for Unassigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUnassigned()
		{
			return Unassigned;
		}

		/// <summary>
		/// Setter for ParentCategory_ID.
		/// <param name="value">int</param>
		/// <returns>ChildCategoryListLoadQueryRequest</returns>
		/// </summary>
		public ChildCategoryListLoadQueryRequest SetParentCategoryId(int? value)
		{
			ParentCategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for ParentCategory_Code.
		/// <param name="value">String</param>
		/// <returns>ChildCategoryListLoadQueryRequest</returns>
		/// </summary>
		public ChildCategoryListLoadQueryRequest SetParentCategoryCode(String value)
		{
			ParentCategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_ParentCategory.
		/// <param name="value">String</param>
		/// <returns>ChildCategoryListLoadQueryRequest</returns>
		/// </summary>
		public ChildCategoryListLoadQueryRequest SetEditParentCategory(String value)
		{
			EditParentCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>ChildCategoryListLoadQueryRequest</returns>
		/// </summary>
		public ChildCategoryListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>ChildCategoryListLoadQueryRequest</returns>
		/// </summary>
		public ChildCategoryListLoadQueryRequest SetUnassigned(bool? value)
		{
			Unassigned = value;
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

			if (ParentCategoryId.HasValue)
			{
				writer.WriteNumber("ParentCategory_ID", ParentCategoryId.Value);
			}
			else if (ParentCategoryCode != null && ParentCategoryCode.Length > 0)
			{
				writer.WriteString("ParentCategory_Code", ParentCategoryCode);
			}
			else if (EditParentCategory != null && EditParentCategory.Length > 0)
			{
				writer.WriteString("Edit_ParentCategory", EditParentCategory);
			}

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}

			if (Unassigned.HasValue)
			{
				writer.WriteBoolean("Unassigned", Unassigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ChildCategoryListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ChildCategoryListLoadQueryResponse</returns>
		/// </summary>
		public new ChildCategoryListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ChildCategoryListLoadQueryRequest, ChildCategoryListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ChildCategoryListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ChildCategoryListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ChildCategoryListLoadQueryRequest, ChildCategoryListLoadQueryResponse>(this);
		}
	}
}
