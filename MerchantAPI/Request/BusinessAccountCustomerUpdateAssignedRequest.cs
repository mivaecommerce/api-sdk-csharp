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
	/// Handles API Request BusinessAccountCustomer_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/businessaccountcustomer_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BusinessAccountCustomerUpdateAssignedRequest : Request
	{
		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field BusinessAccount_ID.
		[JsonPropertyName("BusinessAccount_ID")]
		public int? BusinessAccountId { get; set; }

		/// Request field Edit_BusinessAccount.
		[JsonPropertyName("Edit_BusinessAccount")]
		public String EditBusinessAccount { get; set; }

		/// Request field BusinessAccount_Title.
		[JsonPropertyName("BusinessAccount_Title")]
		public String BusinessAccountTitle { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="businessAccount">BusinessAccount</param>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest(BaseClient client = null, BusinessAccount businessAccount = null) :
			base(client)
		{
			Function = "BusinessAccountCustomer_Update_Assigned";
			if (businessAccount != null) {
				if (businessAccount.Id > 0)
				{
					BusinessAccountId = businessAccount.Id;
				}
			}
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
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_ID.
		/// <param name="value">int</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetBusinessAccountId(int? value)
		{
			BusinessAccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_BusinessAccount.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetEditBusinessAccount(String value)
		{
			EditBusinessAccount = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>BusinessAccountCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public BusinessAccountCustomerUpdateAssignedRequest SetAssigned(bool? value)
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

			writer.WriteString("Customer_Login", CustomerLogin);

			writer.WriteString("BusinessAccount_Title", BusinessAccountTitle);

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
			return JsonSerializer.Deserialize<BusinessAccountCustomerUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BusinessAccountCustomerUpdateAssignedResponse</returns>
		/// </summary>
		public new BusinessAccountCustomerUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<BusinessAccountCustomerUpdateAssignedRequest, BusinessAccountCustomerUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BusinessAccountCustomerUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<BusinessAccountCustomerUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BusinessAccountCustomerUpdateAssignedRequest, BusinessAccountCustomerUpdateAssignedResponse>(this);
		}
	}
}
