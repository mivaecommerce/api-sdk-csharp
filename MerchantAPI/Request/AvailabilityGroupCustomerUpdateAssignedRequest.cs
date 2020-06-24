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
	/// Handles API Request AvailabilityGroupCustomer_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupcustomer_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupCustomerUpdateAssignedRequest : Request
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

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="availabilityGroup">AvailabilityGroup</param>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest(Client client = null, AvailabilityGroup availabilityGroup = null) :
			base(client)
		{
			Function = "AvailabilityGroupCustomer_Update_Assigned";
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
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Getter for Edit_Customer.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCustomer()
		{
			return EditCustomer;
		}

		/// <summary>
		/// Getter for Customer_Login.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerLogin()
		{
			return CustomerLogin;
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
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetAvailabilityGroupId(int? value)
		{
			AvailabilityGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AvailabilityGroup.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetEditAvailabilityGroup(String value)
		{
			EditAvailabilityGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupCustomerUpdateAssignedRequest SetAssigned(bool? value)
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

			if (CustomerId.HasValue)
			{
				writer.WriteNumber("Customer_ID", CustomerId.Value);
			}
			else if (EditCustomer != null && EditCustomer.Length > 0)
			{
				writer.WriteString("Edit_Customer", EditCustomer);
			}
			else if (CustomerLogin != null && CustomerLogin.Length > 0)
			{
				writer.WriteString("Customer_Login", CustomerLogin);
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
			return JsonSerializer.Deserialize<AvailabilityGroupCustomerUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupCustomerUpdateAssignedResponse</returns>
		/// </summary>
		public new AvailabilityGroupCustomerUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupCustomerUpdateAssignedRequest, AvailabilityGroupCustomerUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupCustomerUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupCustomerUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupCustomerUpdateAssignedRequest, AvailabilityGroupCustomerUpdateAssignedResponse>(this);
		}
	}
}
