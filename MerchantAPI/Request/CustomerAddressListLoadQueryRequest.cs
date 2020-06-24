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
	/// Handles API Request CustomerAddressList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customeraddresslist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerAddressListLoadQueryRequest : ListQueryRequest
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

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"cust_id",
			"id",
			"descrip",
			"fname",
			"lname",
			"email",
			"comp",
			"phone",
			"fax",
			"addr1",
			"addr2",
			"city",
			"state",
			"zip",
			"cntry",
			"resdntl"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"cust_id",
			"id",
			"descrip",
			"fname",
			"lname",
			"email",
			"comp",
			"phone",
			"fax",
			"addr1",
			"addr2",
			"city",
			"state",
			"zip",
			"cntry",
			"resdntl"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerAddressListLoadQueryRequest(Client client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerAddressList_Load_Query";
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
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressListLoadQueryRequest</returns>
		/// </summary>
		public CustomerAddressListLoadQueryRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressListLoadQueryRequest</returns>
		/// </summary>
		public CustomerAddressListLoadQueryRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressListLoadQueryRequest</returns>
		/// </summary>
		public CustomerAddressListLoadQueryRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
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
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerAddressListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerAddressListLoadQueryResponse</returns>
		/// </summary>
		public new CustomerAddressListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CustomerAddressListLoadQueryRequest, CustomerAddressListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerAddressListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CustomerAddressListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerAddressListLoadQueryRequest, CustomerAddressListLoadQueryResponse>(this);
		}
	}
}
