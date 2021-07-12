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
	/// Handles API Request CustomerAddress_Insert.
	/// <see>https://docs.miva.com/json-api/functions/customeraddress_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerAddressInsertRequest : Request
	{
		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Description.
		[JsonPropertyName("Description")]
		public String Description { get; set; }

		/// Request field FirstName.
		[JsonPropertyName("FirstName")]
		public String FirstName { get; set; }

		/// Request field LastName.
		[JsonPropertyName("LastName")]
		public String LastName { get; set; }

		/// Request field Email.
		[JsonPropertyName("Email")]
		public String Email { get; set; }

		/// Request field Phone.
		[JsonPropertyName("Phone")]
		public String Phone { get; set; }

		/// Request field Fax.
		[JsonPropertyName("Fax")]
		public String Fax { get; set; }

		/// Request field Company.
		[JsonPropertyName("Company")]
		public String Company { get; set; }

		/// Request field Address1.
		[JsonPropertyName("Address1")]
		public String Address1 { get; set; }

		/// Request field Address2.
		[JsonPropertyName("Address2")]
		public String Address2 { get; set; }

		/// Request field City.
		[JsonPropertyName("City")]
		public String City { get; set; }

		/// Request field State.
		[JsonPropertyName("State")]
		public String State { get; set; }

		/// Request field Zip.
		[JsonPropertyName("Zip")]
		public String Zip { get; set; }

		/// Request field Country.
		[JsonPropertyName("Country")]
		public String Country { get; set; }

		/// Request field Residential.
		[JsonPropertyName("Residential")]
		public bool? Residential { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerAddressInsertRequest(BaseClient client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerAddress_Insert";
			if (customer != null) {
				if (customer.Id > 0)
				{
					CustomerId = customer.Id;
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
		/// Getter for Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for FirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetFirstName()
		{
			return FirstName;
		}

		/// <summary>
		/// Getter for LastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetLastName()
		{
			return LastName;
		}

		/// <summary>
		/// Getter for Email.
		/// <returns>String</returns>
		/// </summary>
		public String GetEmail()
		{
			return Email;
		}

		/// <summary>
		/// Getter for Phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetPhone()
		{
			return Phone;
		}

		/// <summary>
		/// Getter for Fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetFax()
		{
			return Fax;
		}

		/// <summary>
		/// Getter for Company.
		/// <returns>String</returns>
		/// </summary>
		public String GetCompany()
		{
			return Company;
		}

		/// <summary>
		/// Getter for Address1.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddress1()
		{
			return Address1;
		}

		/// <summary>
		/// Getter for Address2.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddress2()
		{
			return Address2;
		}

		/// <summary>
		/// Getter for City.
		/// <returns>String</returns>
		/// </summary>
		public String GetCity()
		{
			return City;
		}

		/// <summary>
		/// Getter for State.
		/// <returns>String</returns>
		/// </summary>
		public String GetState()
		{
			return State;
		}

		/// <summary>
		/// Getter for Zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetZip()
		{
			return Zip;
		}

		/// <summary>
		/// Getter for Country.
		/// <returns>String</returns>
		/// </summary>
		public String GetCountry()
		{
			return Country;
		}

		/// <summary>
		/// Getter for Residential.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetResidential()
		{
			return Residential;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Description.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetDescription(String value)
		{
			Description = value;
			return this;
		}

		/// <summary>
		/// Setter for FirstName.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetFirstName(String value)
		{
			FirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for LastName.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetLastName(String value)
		{
			LastName = value;
			return this;
		}

		/// <summary>
		/// Setter for Email.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetEmail(String value)
		{
			Email = value;
			return this;
		}

		/// <summary>
		/// Setter for Phone.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetPhone(String value)
		{
			Phone = value;
			return this;
		}

		/// <summary>
		/// Setter for Fax.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetFax(String value)
		{
			Fax = value;
			return this;
		}

		/// <summary>
		/// Setter for Company.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetCompany(String value)
		{
			Company = value;
			return this;
		}

		/// <summary>
		/// Setter for Address1.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetAddress1(String value)
		{
			Address1 = value;
			return this;
		}

		/// <summary>
		/// Setter for Address2.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetAddress2(String value)
		{
			Address2 = value;
			return this;
		}

		/// <summary>
		/// Setter for City.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetCity(String value)
		{
			City = value;
			return this;
		}

		/// <summary>
		/// Setter for State.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetState(String value)
		{
			State = value;
			return this;
		}

		/// <summary>
		/// Setter for Zip.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetZip(String value)
		{
			Zip = value;
			return this;
		}

		/// <summary>
		/// Setter for Country.
		/// <param name="value">String</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetCountry(String value)
		{
			Country = value;
			return this;
		}

		/// <summary>
		/// Setter for Residential.
		/// <param name="value">bool</param>
		/// <returns>CustomerAddressInsertRequest</returns>
		/// </summary>
		public CustomerAddressInsertRequest SetResidential(bool? value)
		{
			Residential = value;
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

			if (Description != null && Description.Length > 0)
			{
				writer.WriteString("Description", Description);
			}

			if (FirstName != null && FirstName.Length > 0)
			{
				writer.WriteString("FirstName", FirstName);
			}

			if (LastName != null && LastName.Length > 0)
			{
				writer.WriteString("LastName", LastName);
			}

			if (Email != null && Email.Length > 0)
			{
				writer.WriteString("Email", Email);
			}

			if (Phone != null && Phone.Length > 0)
			{
				writer.WriteString("Phone", Phone);
			}

			if (Fax != null && Fax.Length > 0)
			{
				writer.WriteString("Fax", Fax);
			}

			if (Company != null && Company.Length > 0)
			{
				writer.WriteString("Company", Company);
			}

			if (Address1 != null && Address1.Length > 0)
			{
				writer.WriteString("Address1", Address1);
			}

			if (Address2 != null && Address2.Length > 0)
			{
				writer.WriteString("Address2", Address2);
			}

			if (City != null && City.Length > 0)
			{
				writer.WriteString("City", City);
			}

			if (State != null && State.Length > 0)
			{
				writer.WriteString("State", State);
			}

			if (Zip != null && Zip.Length > 0)
			{
				writer.WriteString("Zip", Zip);
			}

			if (Country != null && Country.Length > 0)
			{
				writer.WriteString("Country", Country);
			}

			if (Residential.HasValue)
			{
				writer.WriteBoolean("Residential", Residential.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerAddressInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerAddressInsertResponse</returns>
		/// </summary>
		public new CustomerAddressInsertResponse Send()
		{
			return Client.SendRequestAsync<CustomerAddressInsertRequest, CustomerAddressInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerAddressInsertResponse></returns>
		/// </summary>
		public new async Task<CustomerAddressInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerAddressInsertRequest, CustomerAddressInsertResponse>(this);
		}
	}
}
