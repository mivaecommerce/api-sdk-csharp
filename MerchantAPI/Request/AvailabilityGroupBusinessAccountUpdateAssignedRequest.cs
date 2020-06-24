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
	/// Handles API Request AvailabilityGroupBusinessAccount_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupbusinessaccount_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupBusinessAccountUpdateAssignedRequest : Request
	{
		/// Request field AvailabilityGroup_ID.
		[JsonPropertyName("AvailabilityGroup_ID")]
		public int? AvailabilityGroupId { get; set; }

		/// Request field Edit_AvailabilityGroup.
		[JsonPropertyName("Edit_AvailabilityGroup")]
		public String EditAvailabilityGroup { get; set; }

		/// Request field AvailabilityGroup_Name.
		[JsonPropertyName("AvailabilityGroup_Name")]
		public String AvailabilityGroupName { get; set; }

		/// Request field BusinessAccount_ID.
		[JsonPropertyName("BusinessAccount_ID")]
		public int? BusinessAccountId { get; set; }

		/// Request field BusinessAccount_Title.
		[JsonPropertyName("BusinessAccount_Title")]
		public String BusinessAccountTitle { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="availabilityGroup">AvailabilityGroup</param>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest(Client client = null, AvailabilityGroup availabilityGroup = null) :
			base(client)
		{
			Function = "AvailabilityGroupBusinessAccount_Update_Assigned";
			if (availabilityGroup != null) {
				if (availabilityGroup.Id > 0)
				{
					AvailabilityGroupId = availabilityGroup.Id;
				}
				else if (availabilityGroup.Name.Length > 0)
				{
					EditAvailabilityGroup = availabilityGroup.Name;
				}
			}
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
		/// Getter for BusinessAccount_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBusinessAccountId()
		{
			return BusinessAccountId;
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
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest SetAvailabilityGroupId(int? value)
		{
			AvailabilityGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AvailabilityGroup.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest SetEditAvailabilityGroup(String value)
		{
			EditAvailabilityGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest SetBusinessAccountId(int? value)
		{
			BusinessAccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupBusinessAccountUpdateAssignedRequest SetAssigned(bool? value)
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

			if (BusinessAccountId.HasValue)
			{
				writer.WriteNumber("BusinessAccount_ID", BusinessAccountId.Value);
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
			return JsonSerializer.Deserialize<AvailabilityGroupBusinessAccountUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupBusinessAccountUpdateAssignedResponse</returns>
		/// </summary>
		public new AvailabilityGroupBusinessAccountUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupBusinessAccountUpdateAssignedRequest, AvailabilityGroupBusinessAccountUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupBusinessAccountUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupBusinessAccountUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupBusinessAccountUpdateAssignedRequest, AvailabilityGroupBusinessAccountUpdateAssignedResponse>(this);
		}
	}
}
