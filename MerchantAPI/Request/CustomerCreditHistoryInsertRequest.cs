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
	/// Handles API Request CustomerCreditHistory_Insert.
	/// <see>https://docs.miva.com/json-api/functions/customercredithistory_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerCreditHistoryInsertRequest : Request
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

		/// Request field Amount.
		[JsonPropertyName("Amount")]
		public float Amount { get; set; }

		/// Request field Description.
		[JsonPropertyName("Description")]
		public String Description { get; set; }

		/// Request field TransactionReference.
		[JsonPropertyName("TransactionReference")]
		public String TransactionReference { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerCreditHistoryInsertRequest(BaseClient client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerCreditHistory_Insert";
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
		/// Getter for Amount.
		/// <returns>float</returns>
		/// </summary>
		public float GetAmount()
		{
			return Amount;
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
		/// Getter for TransactionReference.
		/// <returns>String</returns>
		/// </summary>
		public String GetTransactionReference()
		{
			return TransactionReference;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">float</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetAmount(float value)
		{
			Amount = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">double</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetAmount(double value)
		{
			Amount = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for Description.
		/// <param name="value">String</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetDescription(String value)
		{
			Description = value;
			return this;
		}

		/// <summary>
		/// Setter for TransactionReference.
		/// <param name="value">String</param>
		/// <returns>CustomerCreditHistoryInsertRequest</returns>
		/// </summary>
		public CustomerCreditHistoryInsertRequest SetTransactionReference(String value)
		{
			TransactionReference = value;
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

			writer.WriteNumber("Amount", Amount);

			writer.WriteString("Description", Description);

			if (TransactionReference != null && TransactionReference.Length > 0)
			{
				writer.WriteString("TransactionReference", TransactionReference);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerCreditHistoryInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerCreditHistoryInsertResponse</returns>
		/// </summary>
		public new CustomerCreditHistoryInsertResponse Send()
		{
			return Client.SendRequestAsync<CustomerCreditHistoryInsertRequest, CustomerCreditHistoryInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerCreditHistoryInsertResponse></returns>
		/// </summary>
		public new async Task<CustomerCreditHistoryInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerCreditHistoryInsertRequest, CustomerCreditHistoryInsertResponse>(this);
		}
	}
}
