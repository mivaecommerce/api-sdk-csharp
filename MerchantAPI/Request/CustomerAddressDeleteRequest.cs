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
	/// Handles API Request CustomerAddress_Delete.
	/// <see>https://docs.miva.com/json-api/functions/customeraddress_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerAddressDeleteRequest : Request
	{
		/// Request field Address_ID.
		[JsonPropertyName("Address_ID")]
		public int? AddressId { get; set; }

		/// Request field CustomerAddress_ID.
		[JsonPropertyName("CustomerAddress_ID")]
		public int? CustomerAddressId { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customerAddress">CustomerAddress</param>
		/// </summary>
		public CustomerAddressDeleteRequest(BaseClient client = null, CustomerAddress customerAddress = null) :
			base(client)
		{
			Function = "CustomerAddress_Delete";
			if (customerAddress != null) {
				if (customerAddress.CustomerId > 0)
				{
					CustomerId = customerAddress.CustomerId;
				}

				if (customerAddress.Id > 0)
				{
					AddressId = customerAddress.Id;
				}
			}
		}

		/// <summary>
		/// Getter for Address_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAddressId()
		{
			return AddressId;
		}

		/// <summary>
		/// Getter for CustomerAddress_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerAddressId()
		{
			return CustomerAddressId;
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
		/// Setter for Address_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressDeleteRequest</returns>
		/// </summary>
		public CustomerAddressDeleteRequest SetAddressId(int? value)
		{
			AddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerAddress_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressDeleteRequest</returns>
		/// </summary>
		public CustomerAddressDeleteRequest SetCustomerAddressId(int? value)
		{
			CustomerAddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressDeleteRequest</returns>
		/// </summary>
		public CustomerAddressDeleteRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressDeleteRequest</returns>
		/// </summary>
		public CustomerAddressDeleteRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressDeleteRequest</returns>
		/// </summary>
		public CustomerAddressDeleteRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
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

			if (AddressId.HasValue)
			{
				writer.WriteNumber("Address_ID", AddressId.Value);
			}
			else if (CustomerAddressId.HasValue)
			{
				writer.WriteNumber("CustomerAddress_ID", CustomerAddressId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerAddressDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerAddressDeleteResponse</returns>
		/// </summary>
		public new CustomerAddressDeleteResponse Send()
		{
			return Client.SendRequestAsync<CustomerAddressDeleteRequest, CustomerAddressDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerAddressDeleteResponse></returns>
		/// </summary>
		public new async Task<CustomerAddressDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerAddressDeleteRequest, CustomerAddressDeleteResponse>(this);
		}
	}
}
