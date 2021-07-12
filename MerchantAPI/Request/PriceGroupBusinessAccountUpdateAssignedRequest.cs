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
	/// Handles API Request PriceGroupBusinessAccount_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupbusinessaccount_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupBusinessAccountUpdateAssignedRequest : Request
	{
		/// Request field BusinessAccount_ID.
		[JsonPropertyName("BusinessAccount_ID")]
		public int? BusinessAccountId { get; set; }

		/// Request field Edit_BusinessAccount.
		[JsonPropertyName("Edit_BusinessAccount")]
		public String EditBusinessAccount { get; set; }

		/// Request field BusinessAccount_Title.
		[JsonPropertyName("BusinessAccount_Title")]
		public String BusinessAccountTitle { get; set; }

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
		public PriceGroupBusinessAccountUpdateAssignedRequest(BaseClient client = null, PriceGroup priceGroup = null) :
			base(client)
		{
			Function = "PriceGroupBusinessAccount_Update_Assigned";
			if (priceGroup != null) {
				if (priceGroup.Id > 0)
				{
					PriceGroupId = priceGroup.Id;
				}
			}
		}

		/// <summary>
		/// Getter for BusinessAccount_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBusinessAccountId()
		{
			return BusinessAccountId;
		}

		/// <summary>
		/// Getter for Edit_BusinessAccount.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditBusinessAccount()
		{
			return EditBusinessAccount;
		}

		/// <summary>
		/// Getter for BusinessAccount_Title.
		/// <returns>String</returns>
		/// </summary>
		public String GetBusinessAccountTitle()
		{
			return BusinessAccountTitle;
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
		/// Setter for BusinessAccount_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetBusinessAccountId(int? value)
		{
			BusinessAccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_BusinessAccount.
		/// <param name="value">String</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetEditBusinessAccount(String value)
		{
			EditBusinessAccount = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_PriceGroup.
		/// <param name="value">String</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetEditPriceGroup(String value)
		{
			EditPriceGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupBusinessAccountUpdateAssignedRequest SetAssigned(bool? value)
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

			if (BusinessAccountId.HasValue)
			{
				writer.WriteNumber("BusinessAccount_ID", BusinessAccountId.Value);
			}
			else if (EditBusinessAccount != null && EditBusinessAccount.Length > 0)
			{
				writer.WriteString("Edit_BusinessAccount", EditBusinessAccount);
			}
			else if (BusinessAccountTitle != null && BusinessAccountTitle.Length > 0)
			{
				writer.WriteString("BusinessAccount_Title", BusinessAccountTitle);
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
			return JsonSerializer.Deserialize<PriceGroupBusinessAccountUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupBusinessAccountUpdateAssignedResponse</returns>
		/// </summary>
		public new PriceGroupBusinessAccountUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupBusinessAccountUpdateAssignedRequest, PriceGroupBusinessAccountUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupBusinessAccountUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<PriceGroupBusinessAccountUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupBusinessAccountUpdateAssignedRequest, PriceGroupBusinessAccountUpdateAssignedResponse>(this);
		}
	}
}
