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
	/// Handles API Request PriceGroupCategoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupcategorylist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupCategoryListLoadQueryRequest : CategoryListLoadQueryRequest
	{
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

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="priceGroup">PriceGroup</param>
		/// </summary>
		public PriceGroupCategoryListLoadQueryRequest(BaseClient client = null, PriceGroup priceGroup = null) :
			base(client)
		{
			Function = "PriceGroupCategoryList_Load_Query";
			if (priceGroup != null) {
				if (priceGroup.Id > 0)
				{
					PriceGroupId = priceGroup.Id;
				}
			}
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
		/// Getter for Unassigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUnassigned()
		{
			return Unassigned;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupCategoryListLoadQueryRequest</returns>
		/// </summary>
		public PriceGroupCategoryListLoadQueryRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_PriceGroup.
		/// <param name="value">String</param>
		/// <returns>PriceGroupCategoryListLoadQueryRequest</returns>
		/// </summary>
		public PriceGroupCategoryListLoadQueryRequest SetEditPriceGroup(String value)
		{
			EditPriceGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>PriceGroupCategoryListLoadQueryRequest</returns>
		/// </summary>
		public PriceGroupCategoryListLoadQueryRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupCategoryListLoadQueryRequest</returns>
		/// </summary>
		public PriceGroupCategoryListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupCategoryListLoadQueryRequest</returns>
		/// </summary>
		public PriceGroupCategoryListLoadQueryRequest SetUnassigned(bool? value)
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
			return JsonSerializer.Deserialize<PriceGroupCategoryListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupCategoryListLoadQueryResponse</returns>
		/// </summary>
		public new PriceGroupCategoryListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupCategoryListLoadQueryRequest, PriceGroupCategoryListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupCategoryListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<PriceGroupCategoryListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupCategoryListLoadQueryRequest, PriceGroupCategoryListLoadQueryResponse>(this);
		}
	}
}
