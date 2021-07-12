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
	/// Handles API Request CustomerAddressList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/customeraddresslist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerAddressListDeleteRequest : Request
	{
		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field CustomerAddress_IDs.
		public List<int> CustomerAddressIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerAddressListDeleteRequest(BaseClient client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerAddressList_Delete";
			if (customer != null) {
				if (customer.Id > 0)
				{
					CustomerId = customer.Id;
				}
				else if (customer.Login.Length > 0)
				{
					CustomerLogin = customer.Login;
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
		/// Getter for Customer_Login.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerLogin()
		{
			return CustomerLogin;
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
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressListDeleteRequest</returns>
		/// </summary>
		public CustomerAddressListDeleteRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressListDeleteRequest</returns>
		/// </summary>
		public CustomerAddressListDeleteRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressListDeleteRequest</returns>
		/// </summary>
		public CustomerAddressListDeleteRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Add CustomerAddress_IDs.
		///	- customerAddressId: Int
		/// - Returns: Self
		/// </summary>
		public CustomerAddressListDeleteRequest AddCustomerAddress_ID(int customerAddressId)
		{
			CustomerAddressIds.Add(customerAddressId);
			return this;
		}

		/// <summary>
		/// Add CustomerAddress model.
		/// <param name="customerAddress">CustomerAddress></param>
		/// <returns>CustomerAddressListDeleteRequest</returns>
		/// </summary>
		public CustomerAddressListDeleteRequest AddCustomerAddress(CustomerAddress customerAddress)
		{
			if (customerAddress.Id > 0)
			{
				CustomerAddressIds.Add(customerAddress.Id);
			}

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
			else if (CustomerLogin != null && CustomerLogin.Length > 0)
			{
				writer.WriteString("Customer_Login", CustomerLogin);
			}
			else if (EditCustomer != null && EditCustomer.Length > 0)
			{
				writer.WriteString("Edit_Customer", EditCustomer);
			}

			writer.WritePropertyName("CustomerAddress_IDs");
			JsonSerializer.Serialize(writer, this.CustomerAddressIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerAddressListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerAddressListDeleteResponse</returns>
		/// </summary>
		public new CustomerAddressListDeleteResponse Send()
		{
			return Client.SendRequestAsync<CustomerAddressListDeleteRequest, CustomerAddressListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerAddressListDeleteResponse></returns>
		/// </summary>
		public new async Task<CustomerAddressListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerAddressListDeleteRequest, CustomerAddressListDeleteResponse>(this);
		}
	}
}
