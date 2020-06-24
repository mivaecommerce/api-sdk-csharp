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
	/// Handles API Request CustomerPaymentCard_Register.
	/// <see>https://docs.miva.com/json-api/functions/customerpaymentcard_register</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerPaymentCardRegisterRequest : Request
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

		/// Request field FirstName.
		[JsonPropertyName("FirstName")]
		public String FirstName { get; set; }

		/// Request field LastName.
		[JsonPropertyName("LastName")]
		public String LastName { get; set; }

		/// Request field CardType.
		[JsonPropertyName("CardType")]
		public String CardType { get; set; }

		/// Request field CardNumber.
		[JsonPropertyName("CardNumber")]
		public String CardNumber { get; set; }

		/// Request field ExpirationMonth.
		[JsonPropertyName("ExpirationMonth")]
		public int? ExpirationMonth { get; set; }

		/// Request field ExpirationYear.
		[JsonPropertyName("ExpirationYear")]
		public int? ExpirationYear { get; set; }

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

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerPaymentCardRegisterRequest(Client client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerPaymentCard_Register";
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
		/// Getter for CardType.
		/// <returns>String</returns>
		/// </summary>
		public String GetCardType()
		{
			return CardType;
		}

		/// <summary>
		/// Getter for CardNumber.
		/// <returns>String</returns>
		/// </summary>
		public String GetCardNumber()
		{
			return CardNumber;
		}

		/// <summary>
		/// Getter for ExpirationMonth.
		/// <returns>int</returns>
		/// </summary>
		public int? GetExpirationMonth()
		{
			return ExpirationMonth;
		}

		/// <summary>
		/// Getter for ExpirationYear.
		/// <returns>int</returns>
		/// </summary>
		public int? GetExpirationYear()
		{
			return ExpirationYear;
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
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for FirstName.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetFirstName(String value)
		{
			FirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for LastName.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetLastName(String value)
		{
			LastName = value;
			return this;
		}

		/// <summary>
		/// Setter for CardType.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetCardType(String value)
		{
			CardType = value;
			return this;
		}

		/// <summary>
		/// Setter for CardNumber.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetCardNumber(String value)
		{
			CardNumber = value;
			return this;
		}

		/// <summary>
		/// Setter for ExpirationMonth.
		/// <param name="value">int</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetExpirationMonth(int? value)
		{
			ExpirationMonth = value;
			return this;
		}

		/// <summary>
		/// Setter for ExpirationYear.
		/// <param name="value">int</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetExpirationYear(int? value)
		{
			ExpirationYear = value;
			return this;
		}

		/// <summary>
		/// Setter for Address1.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetAddress1(String value)
		{
			Address1 = value;
			return this;
		}

		/// <summary>
		/// Setter for Address2.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetAddress2(String value)
		{
			Address2 = value;
			return this;
		}

		/// <summary>
		/// Setter for City.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetCity(String value)
		{
			City = value;
			return this;
		}

		/// <summary>
		/// Setter for State.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetState(String value)
		{
			State = value;
			return this;
		}

		/// <summary>
		/// Setter for Zip.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetZip(String value)
		{
			Zip = value;
			return this;
		}

		/// <summary>
		/// Setter for Country.
		/// <param name="value">String</param>
		/// <returns>CustomerPaymentCardRegisterRequest</returns>
		/// </summary>
		public CustomerPaymentCardRegisterRequest SetCountry(String value)
		{
			Country = value;
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

			if (FirstName != null && FirstName.Length > 0)
			{
				writer.WriteString("FirstName", FirstName);
			}

			if (LastName != null && LastName.Length > 0)
			{
				writer.WriteString("LastName", LastName);
			}

			if (CardType != null && CardType.Length > 0)
			{
				writer.WriteString("CardType", CardType);
			}

			if (CardNumber != null && CardNumber.Length > 0)
			{
				writer.WriteString("CardNumber", CardNumber);
			}

			if (ExpirationMonth.HasValue)
			{
				writer.WriteNumber("ExpirationMonth", ExpirationMonth.Value);
			}

			if (ExpirationYear.HasValue)
			{
				writer.WriteNumber("ExpirationYear", ExpirationYear.Value);
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
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerPaymentCardRegisterResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerPaymentCardRegisterResponse</returns>
		/// </summary>
		public new CustomerPaymentCardRegisterResponse Send()
		{
			return Client.SendRequestAsync<CustomerPaymentCardRegisterRequest, CustomerPaymentCardRegisterResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerPaymentCardRegisterResponse></returns>
		/// </summary>
		public new async Task<CustomerPaymentCardRegisterResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerPaymentCardRegisterRequest, CustomerPaymentCardRegisterResponse>(this);
		}
	}
}
