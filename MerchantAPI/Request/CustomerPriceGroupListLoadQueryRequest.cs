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
	/// Handles API Request CustomerPriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customerpricegrouplist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerPriceGroupListLoadQueryRequest : PriceGroupListLoadQueryRequest
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

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerPriceGroupListLoadQueryRequest(Client client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerPriceGroupList_Load_Query";
			if (customer != null) {
				if (customer.Id > 0)
				{
					CustomerId = customer.Id;
				}
				else if (customer.Login.Length > 0)
				{
					EditCustomer = customer.Login;
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
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CustomerPriceGroupListLoadQueryRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CustomerPriceGroupListLoadQueryRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CustomerPriceGroupListLoadQueryRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CustomerPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CustomerPriceGroupListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>CustomerPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CustomerPriceGroupListLoadQueryRequest SetUnassigned(bool? value)
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
			return JsonSerializer.Deserialize<CustomerPriceGroupListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerPriceGroupListLoadQueryResponse</returns>
		/// </summary>
		public new CustomerPriceGroupListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CustomerPriceGroupListLoadQueryRequest, CustomerPriceGroupListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerPriceGroupListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CustomerPriceGroupListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerPriceGroupListLoadQueryRequest, CustomerPriceGroupListLoadQueryResponse>(this);
		}
	}
}
