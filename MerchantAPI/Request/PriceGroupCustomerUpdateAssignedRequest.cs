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
	/// Handles API Request PriceGroupCustomer_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupcustomer_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupCustomerUpdateAssignedRequest : Request
	{
		/// Request field PriceGroup_ID.
		[JsonPropertyName("PriceGroup_ID")]
		public int? PriceGroupId { get; set; }

		/// Request field PriceGroup_Name.
		[JsonPropertyName("PriceGroup_Name")]
		public String PriceGroupName { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="priceGroup">PriceGroup</param>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest(Client client = null, PriceGroup priceGroup = null) :
			base(client)
		{
			Function = "PriceGroupCustomer_Update_Assigned";
			if (priceGroup != null) {
				if (priceGroup.Id > 0)
				{
					PriceGroupId = priceGroup.Id;
				}
				else if (priceGroup.Name.Length > 0)
				{
					PriceGroupName = priceGroup.Name;
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
		/// Getter for PriceGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetPriceGroupName()
		{
			return PriceGroupName;
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
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerId()
		{
			return CustomerId;
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
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>PriceGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>PriceGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>PriceGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupCustomerUpdateAssignedRequest SetAssigned(bool? value)
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
			else if (PriceGroupName != null && PriceGroupName.Length > 0)
			{
				writer.WriteString("PriceGroup_Name", PriceGroupName);
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
			return JsonSerializer.Deserialize<PriceGroupCustomerUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupCustomerUpdateAssignedResponse</returns>
		/// </summary>
		public new PriceGroupCustomerUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupCustomerUpdateAssignedRequest, PriceGroupCustomerUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupCustomerUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<PriceGroupCustomerUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupCustomerUpdateAssignedRequest, PriceGroupCustomerUpdateAssignedResponse>(this);
		}
	}
}
