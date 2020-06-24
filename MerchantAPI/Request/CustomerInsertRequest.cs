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
	/// Handles API Request Customer_Insert.
	/// <see>https://docs.miva.com/json-api/functions/customer_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerInsertRequest : Request
	{
		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Customer_PasswordEmail.
		[JsonPropertyName("Customer_PasswordEmail")]
		public String CustomerPasswordEmail { get; set; }

		/// Request field Customer_Password.
		[JsonPropertyName("Customer_Password")]
		public String CustomerPassword { get; set; }

		/// Request field Customer_ShipResidential.
		[JsonPropertyName("Customer_ShipResidential")]
		public bool? CustomerShipResidential { get; set; }

		/// Request field Customer_ShipFirstName.
		[JsonPropertyName("Customer_ShipFirstName")]
		public String CustomerShipFirstName { get; set; }

		/// Request field Customer_ShipLastName.
		[JsonPropertyName("Customer_ShipLastName")]
		public String CustomerShipLastName { get; set; }

		/// Request field Customer_ShipEmail.
		[JsonPropertyName("Customer_ShipEmail")]
		public String CustomerShipEmail { get; set; }

		/// Request field Customer_ShipCompany.
		[JsonPropertyName("Customer_ShipCompany")]
		public String CustomerShipCompany { get; set; }

		/// Request field Customer_ShipPhone.
		[JsonPropertyName("Customer_ShipPhone")]
		public String CustomerShipPhone { get; set; }

		/// Request field Customer_ShipFax.
		[JsonPropertyName("Customer_ShipFax")]
		public String CustomerShipFax { get; set; }

		/// Request field Customer_ShipAddress1.
		[JsonPropertyName("Customer_ShipAddress1")]
		public String CustomerShipAddress1 { get; set; }

		/// Request field Customer_ShipAddress2.
		[JsonPropertyName("Customer_ShipAddress2")]
		public String CustomerShipAddress2 { get; set; }

		/// Request field Customer_ShipCity.
		[JsonPropertyName("Customer_ShipCity")]
		public String CustomerShipCity { get; set; }

		/// Request field Customer_ShipState.
		[JsonPropertyName("Customer_ShipState")]
		public String CustomerShipState { get; set; }

		/// Request field Customer_ShipZip.
		[JsonPropertyName("Customer_ShipZip")]
		public String CustomerShipZip { get; set; }

		/// Request field Customer_ShipCountry.
		[JsonPropertyName("Customer_ShipCountry")]
		public String CustomerShipCountry { get; set; }

		/// Request field Customer_BillFirstName.
		[JsonPropertyName("Customer_BillFirstName")]
		public String CustomerBillFirstName { get; set; }

		/// Request field Customer_BillLastName.
		[JsonPropertyName("Customer_BillLastName")]
		public String CustomerBillLastName { get; set; }

		/// Request field Customer_BillEmail.
		[JsonPropertyName("Customer_BillEmail")]
		public String CustomerBillEmail { get; set; }

		/// Request field Customer_BillCompany.
		[JsonPropertyName("Customer_BillCompany")]
		public String CustomerBillCompany { get; set; }

		/// Request field Customer_BillPhone.
		[JsonPropertyName("Customer_BillPhone")]
		public String CustomerBillPhone { get; set; }

		/// Request field Customer_BillFax.
		[JsonPropertyName("Customer_BillFax")]
		public String CustomerBillFax { get; set; }

		/// Request field Customer_BillAddress1.
		[JsonPropertyName("Customer_BillAddress1")]
		public String CustomerBillAddress1 { get; set; }

		/// Request field Customer_BillAddress2.
		[JsonPropertyName("Customer_BillAddress2")]
		public String CustomerBillAddress2 { get; set; }

		/// Request field Customer_BillCity.
		[JsonPropertyName("Customer_BillCity")]
		public String CustomerBillCity { get; set; }

		/// Request field Customer_BillState.
		[JsonPropertyName("Customer_BillState")]
		public String CustomerBillState { get; set; }

		/// Request field Customer_BillZip.
		[JsonPropertyName("Customer_BillZip")]
		public String CustomerBillZip { get; set; }

		/// Request field Customer_BillCountry.
		[JsonPropertyName("Customer_BillCountry")]
		public String CustomerBillCountry { get; set; }

		/// Request field Customer_Tax_Exempt.
		[JsonPropertyName("Customer_Tax_Exempt")]
		public bool? CustomerTaxExempt { get; set; }

		/// Request field Customer_BusinessAccount.
		[JsonPropertyName("Customer_BusinessAccount")]
		public String CustomerBusinessAccount { get; set; }

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerInsertRequest(Client client = null, Customer customer = null) :
			base(client)
		{
			Function = "Customer_Insert";
			CustomFieldValues = new CustomFieldValues();
			if (customer != null) {
				CustomerLogin = customer.Login;
				CustomerPasswordEmail = customer.PasswordEmail;
				CustomerShipResidential = customer.ShippingResidential;
				CustomerShipFirstName = customer.ShipFirstName;
				CustomerShipLastName = customer.ShipLastName;
				CustomerShipEmail = customer.ShipEmail;
				CustomerShipCompany = customer.ShipCompany;
				CustomerShipPhone = customer.ShipPhone;
				CustomerShipFax = customer.ShipFax;
				CustomerShipAddress1 = customer.ShipAddress1;
				CustomerShipAddress2 = customer.ShipAddress2;
				CustomerShipCity = customer.ShipCity;
				CustomerShipState = customer.ShipState;
				CustomerShipZip = customer.ShipZip;
				CustomerShipCountry = customer.ShipCountry;
				CustomerBillFirstName = customer.BillFirstName;
				CustomerBillLastName = customer.BillLastName;
				CustomerBillEmail = customer.BillEmail;
				CustomerBillCompany = customer.BillCompany;
				CustomerBillPhone = customer.BillPhone;
				CustomerBillFax = customer.BillFax;
				CustomerBillAddress1 = customer.BillAddress1;
				CustomerBillAddress2 = customer.BillAddress2;
				CustomerBillCity = customer.BillCity;
				CustomerBillState = customer.BillState;
				CustomerBillZip = customer.BillZip;
				CustomerBillCountry = customer.BillCountry;
				CustomerBusinessAccount = customer.BusinessTitle;
				CustomFieldValues = customer.CustomFieldValues;
			}
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
		/// Getter for Customer_PasswordEmail.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerPasswordEmail()
		{
			return CustomerPasswordEmail;
		}

		/// <summary>
		/// Getter for Customer_Password.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerPassword()
		{
			return CustomerPassword;
		}

		/// <summary>
		/// Getter for Customer_ShipResidential.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCustomerShipResidential()
		{
			return CustomerShipResidential;
		}

		/// <summary>
		/// Getter for Customer_ShipFirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipFirstName()
		{
			return CustomerShipFirstName;
		}

		/// <summary>
		/// Getter for Customer_ShipLastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipLastName()
		{
			return CustomerShipLastName;
		}

		/// <summary>
		/// Getter for Customer_ShipEmail.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipEmail()
		{
			return CustomerShipEmail;
		}

		/// <summary>
		/// Getter for Customer_ShipCompany.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipCompany()
		{
			return CustomerShipCompany;
		}

		/// <summary>
		/// Getter for Customer_ShipPhone.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipPhone()
		{
			return CustomerShipPhone;
		}

		/// <summary>
		/// Getter for Customer_ShipFax.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipFax()
		{
			return CustomerShipFax;
		}

		/// <summary>
		/// Getter for Customer_ShipAddress1.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipAddress1()
		{
			return CustomerShipAddress1;
		}

		/// <summary>
		/// Getter for Customer_ShipAddress2.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipAddress2()
		{
			return CustomerShipAddress2;
		}

		/// <summary>
		/// Getter for Customer_ShipCity.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipCity()
		{
			return CustomerShipCity;
		}

		/// <summary>
		/// Getter for Customer_ShipState.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipState()
		{
			return CustomerShipState;
		}

		/// <summary>
		/// Getter for Customer_ShipZip.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipZip()
		{
			return CustomerShipZip;
		}

		/// <summary>
		/// Getter for Customer_ShipCountry.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerShipCountry()
		{
			return CustomerShipCountry;
		}

		/// <summary>
		/// Getter for Customer_BillFirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillFirstName()
		{
			return CustomerBillFirstName;
		}

		/// <summary>
		/// Getter for Customer_BillLastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillLastName()
		{
			return CustomerBillLastName;
		}

		/// <summary>
		/// Getter for Customer_BillEmail.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillEmail()
		{
			return CustomerBillEmail;
		}

		/// <summary>
		/// Getter for Customer_BillCompany.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillCompany()
		{
			return CustomerBillCompany;
		}

		/// <summary>
		/// Getter for Customer_BillPhone.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillPhone()
		{
			return CustomerBillPhone;
		}

		/// <summary>
		/// Getter for Customer_BillFax.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillFax()
		{
			return CustomerBillFax;
		}

		/// <summary>
		/// Getter for Customer_BillAddress1.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillAddress1()
		{
			return CustomerBillAddress1;
		}

		/// <summary>
		/// Getter for Customer_BillAddress2.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillAddress2()
		{
			return CustomerBillAddress2;
		}

		/// <summary>
		/// Getter for Customer_BillCity.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillCity()
		{
			return CustomerBillCity;
		}

		/// <summary>
		/// Getter for Customer_BillState.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillState()
		{
			return CustomerBillState;
		}

		/// <summary>
		/// Getter for Customer_BillZip.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillZip()
		{
			return CustomerBillZip;
		}

		/// <summary>
		/// Getter for Customer_BillCountry.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBillCountry()
		{
			return CustomerBillCountry;
		}

		/// <summary>
		/// Getter for Customer_Tax_Exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCustomerTaxExempt()
		{
			return CustomerTaxExempt;
		}

		/// <summary>
		/// Getter for Customer_BusinessAccount.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBusinessAccount()
		{
			return CustomerBusinessAccount;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_PasswordEmail.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerPasswordEmail(String value)
		{
			CustomerPasswordEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Password.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerPassword(String value)
		{
			CustomerPassword = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipResidential.
		/// <param name="value">bool</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipResidential(bool? value)
		{
			CustomerShipResidential = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipFirstName.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipFirstName(String value)
		{
			CustomerShipFirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipLastName.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipLastName(String value)
		{
			CustomerShipLastName = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipEmail.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipEmail(String value)
		{
			CustomerShipEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipCompany.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipCompany(String value)
		{
			CustomerShipCompany = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipPhone.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipPhone(String value)
		{
			CustomerShipPhone = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipFax.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipFax(String value)
		{
			CustomerShipFax = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipAddress1.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipAddress1(String value)
		{
			CustomerShipAddress1 = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipAddress2.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipAddress2(String value)
		{
			CustomerShipAddress2 = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipCity.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipCity(String value)
		{
			CustomerShipCity = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipState.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipState(String value)
		{
			CustomerShipState = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipZip.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipZip(String value)
		{
			CustomerShipZip = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ShipCountry.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerShipCountry(String value)
		{
			CustomerShipCountry = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillFirstName.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillFirstName(String value)
		{
			CustomerBillFirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillLastName.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillLastName(String value)
		{
			CustomerBillLastName = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillEmail.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillEmail(String value)
		{
			CustomerBillEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillCompany.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillCompany(String value)
		{
			CustomerBillCompany = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillPhone.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillPhone(String value)
		{
			CustomerBillPhone = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillFax.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillFax(String value)
		{
			CustomerBillFax = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillAddress1.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillAddress1(String value)
		{
			CustomerBillAddress1 = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillAddress2.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillAddress2(String value)
		{
			CustomerBillAddress2 = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillCity.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillCity(String value)
		{
			CustomerBillCity = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillState.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillState(String value)
		{
			CustomerBillState = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillZip.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillZip(String value)
		{
			CustomerBillZip = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BillCountry.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBillCountry(String value)
		{
			CustomerBillCountry = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Tax_Exempt.
		/// <param name="value">bool</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerTaxExempt(bool? value)
		{
			CustomerTaxExempt = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_BusinessAccount.
		/// <param name="value">String</param>
		/// <returns>CustomerInsertRequest</returns>
		/// </summary>
		public CustomerInsertRequest SetCustomerBusinessAccount(String value)
		{
			CustomerBusinessAccount = value;
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

			writer.WriteString("Customer_Login", CustomerLogin);

			writer.WriteString("Customer_PasswordEmail", CustomerPasswordEmail);

			writer.WriteString("Customer_Password", CustomerPassword);

			if (CustomerShipResidential.HasValue)
			{
				writer.WriteBoolean("Customer_ShipResidential", CustomerShipResidential.Value);
			}

			if (CustomerShipFirstName != null && CustomerShipFirstName.Length > 0)
			{
				writer.WriteString("Customer_ShipFirstName", CustomerShipFirstName);
			}

			if (CustomerShipLastName != null && CustomerShipLastName.Length > 0)
			{
				writer.WriteString("Customer_ShipLastName", CustomerShipLastName);
			}

			if (CustomerShipEmail != null && CustomerShipEmail.Length > 0)
			{
				writer.WriteString("Customer_ShipEmail", CustomerShipEmail);
			}

			if (CustomerShipCompany != null && CustomerShipCompany.Length > 0)
			{
				writer.WriteString("Customer_ShipCompany", CustomerShipCompany);
			}

			if (CustomerShipPhone != null && CustomerShipPhone.Length > 0)
			{
				writer.WriteString("Customer_ShipPhone", CustomerShipPhone);
			}

			if (CustomerShipFax != null && CustomerShipFax.Length > 0)
			{
				writer.WriteString("Customer_ShipFax", CustomerShipFax);
			}

			if (CustomerShipAddress1 != null && CustomerShipAddress1.Length > 0)
			{
				writer.WriteString("Customer_ShipAddress1", CustomerShipAddress1);
			}

			if (CustomerShipAddress2 != null && CustomerShipAddress2.Length > 0)
			{
				writer.WriteString("Customer_ShipAddress2", CustomerShipAddress2);
			}

			if (CustomerShipCity != null && CustomerShipCity.Length > 0)
			{
				writer.WriteString("Customer_ShipCity", CustomerShipCity);
			}

			if (CustomerShipState != null && CustomerShipState.Length > 0)
			{
				writer.WriteString("Customer_ShipState", CustomerShipState);
			}

			if (CustomerShipZip != null && CustomerShipZip.Length > 0)
			{
				writer.WriteString("Customer_ShipZip", CustomerShipZip);
			}

			if (CustomerShipCountry != null && CustomerShipCountry.Length > 0)
			{
				writer.WriteString("Customer_ShipCountry", CustomerShipCountry);
			}

			if (CustomerBillFirstName != null && CustomerBillFirstName.Length > 0)
			{
				writer.WriteString("Customer_BillFirstName", CustomerBillFirstName);
			}

			if (CustomerBillLastName != null && CustomerBillLastName.Length > 0)
			{
				writer.WriteString("Customer_BillLastName", CustomerBillLastName);
			}

			if (CustomerBillEmail != null && CustomerBillEmail.Length > 0)
			{
				writer.WriteString("Customer_BillEmail", CustomerBillEmail);
			}

			if (CustomerBillCompany != null && CustomerBillCompany.Length > 0)
			{
				writer.WriteString("Customer_BillCompany", CustomerBillCompany);
			}

			if (CustomerBillPhone != null && CustomerBillPhone.Length > 0)
			{
				writer.WriteString("Customer_BillPhone", CustomerBillPhone);
			}

			if (CustomerBillFax != null && CustomerBillFax.Length > 0)
			{
				writer.WriteString("Customer_BillFax", CustomerBillFax);
			}

			if (CustomerBillAddress1 != null && CustomerBillAddress1.Length > 0)
			{
				writer.WriteString("Customer_BillAddress1", CustomerBillAddress1);
			}

			if (CustomerBillAddress2 != null && CustomerBillAddress2.Length > 0)
			{
				writer.WriteString("Customer_BillAddress2", CustomerBillAddress2);
			}

			if (CustomerBillCity != null && CustomerBillCity.Length > 0)
			{
				writer.WriteString("Customer_BillCity", CustomerBillCity);
			}

			if (CustomerBillState != null && CustomerBillState.Length > 0)
			{
				writer.WriteString("Customer_BillState", CustomerBillState);
			}

			if (CustomerBillZip != null && CustomerBillZip.Length > 0)
			{
				writer.WriteString("Customer_BillZip", CustomerBillZip);
			}

			if (CustomerBillCountry != null && CustomerBillCountry.Length > 0)
			{
				writer.WriteString("Customer_BillCountry", CustomerBillCountry);
			}

			if (CustomerTaxExempt.HasValue)
			{
				writer.WriteBoolean("Customer_Tax_Exempt", CustomerTaxExempt.Value);
			}

			if (CustomerBusinessAccount != null && CustomerBusinessAccount.Length > 0)
			{
				writer.WriteString("Customer_BusinessAccount", CustomerBusinessAccount);
			}

			if (CustomFieldValues != null)
			{
				writer.WritePropertyName("CustomField_Values");
				JsonSerializer.Serialize(writer, this.CustomFieldValues, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerInsertResponse</returns>
		/// </summary>
		public new CustomerInsertResponse Send()
		{
			return Client.SendRequestAsync<CustomerInsertRequest, CustomerInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerInsertResponse></returns>
		/// </summary>
		public new async Task<CustomerInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerInsertRequest, CustomerInsertResponse>(this);
		}
	}
}
