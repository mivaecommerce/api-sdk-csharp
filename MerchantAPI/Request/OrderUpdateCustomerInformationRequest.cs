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
	/// Handles API Request Order_Update_Customer_Information.
	/// <see>https://docs.miva.com/json-api/functions/order_update_customer_information</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderUpdateCustomerInformationRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Ship_Residential.
		[JsonPropertyName("Ship_Residential")]
		public bool? ShipResidential { get; set; }

		/// Request field Ship_FirstName.
		[JsonPropertyName("Ship_FirstName")]
		public String ShipFirstName { get; set; }

		/// Request field Ship_LastName.
		[JsonPropertyName("Ship_LastName")]
		public String ShipLastName { get; set; }

		/// Request field Ship_Email.
		[JsonPropertyName("Ship_Email")]
		public String ShipEmail { get; set; }

		/// Request field Ship_Phone.
		[JsonPropertyName("Ship_Phone")]
		public String ShipPhone { get; set; }

		/// Request field Ship_Fax.
		[JsonPropertyName("Ship_Fax")]
		public String ShipFax { get; set; }

		/// Request field Ship_Company.
		[JsonPropertyName("Ship_Company")]
		public String ShipCompany { get; set; }

		/// Request field Ship_Address1.
		[JsonPropertyName("Ship_Address1")]
		public String ShipAddress1 { get; set; }

		/// Request field Ship_Address2.
		[JsonPropertyName("Ship_Address2")]
		public String ShipAddress2 { get; set; }

		/// Request field Ship_City.
		[JsonPropertyName("Ship_City")]
		public String ShipCity { get; set; }

		/// Request field Ship_State.
		[JsonPropertyName("Ship_State")]
		public String ShipState { get; set; }

		/// Request field Ship_Zip.
		[JsonPropertyName("Ship_Zip")]
		public String ShipZip { get; set; }

		/// Request field Ship_Country.
		[JsonPropertyName("Ship_Country")]
		public String ShipCountry { get; set; }

		/// Request field Bill_FirstName.
		[JsonPropertyName("Bill_FirstName")]
		public String BillFirstName { get; set; }

		/// Request field Bill_LastName.
		[JsonPropertyName("Bill_LastName")]
		public String BillLastName { get; set; }

		/// Request field Bill_Email.
		[JsonPropertyName("Bill_Email")]
		public String BillEmail { get; set; }

		/// Request field Bill_Phone.
		[JsonPropertyName("Bill_Phone")]
		public String BillPhone { get; set; }

		/// Request field Bill_Fax.
		[JsonPropertyName("Bill_Fax")]
		public String BillFax { get; set; }

		/// Request field Bill_Company.
		[JsonPropertyName("Bill_Company")]
		public String BillCompany { get; set; }

		/// Request field Bill_Address1.
		[JsonPropertyName("Bill_Address1")]
		public String BillAddress1 { get; set; }

		/// Request field Bill_Address2.
		[JsonPropertyName("Bill_Address2")]
		public String BillAddress2 { get; set; }

		/// Request field Bill_City.
		[JsonPropertyName("Bill_City")]
		public String BillCity { get; set; }

		/// Request field Bill_State.
		[JsonPropertyName("Bill_State")]
		public String BillState { get; set; }

		/// Request field Bill_Zip.
		[JsonPropertyName("Bill_Zip")]
		public String BillZip { get; set; }

		/// Request field Bill_Country.
		[JsonPropertyName("Bill_Country")]
		public String BillCountry { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderUpdateCustomerInformationRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "Order_Update_Customer_Information";
			if (order != null) {
				OrderId = order.Id;
			}
		}

		/// <summary>
		/// Getter for Order_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
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
		/// Getter for Ship_Residential.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetShipResidential()
		{
			return ShipResidential;
		}

		/// <summary>
		/// Getter for Ship_FirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipFirstName()
		{
			return ShipFirstName;
		}

		/// <summary>
		/// Getter for Ship_LastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipLastName()
		{
			return ShipLastName;
		}

		/// <summary>
		/// Getter for Ship_Email.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipEmail()
		{
			return ShipEmail;
		}

		/// <summary>
		/// Getter for Ship_Phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipPhone()
		{
			return ShipPhone;
		}

		/// <summary>
		/// Getter for Ship_Fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipFax()
		{
			return ShipFax;
		}

		/// <summary>
		/// Getter for Ship_Company.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCompany()
		{
			return ShipCompany;
		}

		/// <summary>
		/// Getter for Ship_Address1.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipAddress1()
		{
			return ShipAddress1;
		}

		/// <summary>
		/// Getter for Ship_Address2.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipAddress2()
		{
			return ShipAddress2;
		}

		/// <summary>
		/// Getter for Ship_City.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCity()
		{
			return ShipCity;
		}

		/// <summary>
		/// Getter for Ship_State.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipState()
		{
			return ShipState;
		}

		/// <summary>
		/// Getter for Ship_Zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipZip()
		{
			return ShipZip;
		}

		/// <summary>
		/// Getter for Ship_Country.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCountry()
		{
			return ShipCountry;
		}

		/// <summary>
		/// Getter for Bill_FirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillFirstName()
		{
			return BillFirstName;
		}

		/// <summary>
		/// Getter for Bill_LastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillLastName()
		{
			return BillLastName;
		}

		/// <summary>
		/// Getter for Bill_Email.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillEmail()
		{
			return BillEmail;
		}

		/// <summary>
		/// Getter for Bill_Phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillPhone()
		{
			return BillPhone;
		}

		/// <summary>
		/// Getter for Bill_Fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillFax()
		{
			return BillFax;
		}

		/// <summary>
		/// Getter for Bill_Company.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCompany()
		{
			return BillCompany;
		}

		/// <summary>
		/// Getter for Bill_Address1.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillAddress1()
		{
			return BillAddress1;
		}

		/// <summary>
		/// Getter for Bill_Address2.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillAddress2()
		{
			return BillAddress2;
		}

		/// <summary>
		/// Getter for Bill_City.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCity()
		{
			return BillCity;
		}

		/// <summary>
		/// Getter for Bill_State.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillState()
		{
			return BillState;
		}

		/// <summary>
		/// Getter for Bill_Zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillZip()
		{
			return BillZip;
		}

		/// <summary>
		/// Getter for Bill_Country.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCountry()
		{
			return BillCountry;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Residential.
		/// <param name="value">bool</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipResidential(bool? value)
		{
			ShipResidential = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_FirstName.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipFirstName(String value)
		{
			ShipFirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_LastName.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipLastName(String value)
		{
			ShipLastName = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Email.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipEmail(String value)
		{
			ShipEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Phone.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipPhone(String value)
		{
			ShipPhone = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Fax.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipFax(String value)
		{
			ShipFax = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Company.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipCompany(String value)
		{
			ShipCompany = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Address1.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipAddress1(String value)
		{
			ShipAddress1 = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Address2.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipAddress2(String value)
		{
			ShipAddress2 = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_City.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipCity(String value)
		{
			ShipCity = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_State.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipState(String value)
		{
			ShipState = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Zip.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipZip(String value)
		{
			ShipZip = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Country.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetShipCountry(String value)
		{
			ShipCountry = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_FirstName.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillFirstName(String value)
		{
			BillFirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_LastName.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillLastName(String value)
		{
			BillLastName = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Email.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillEmail(String value)
		{
			BillEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Phone.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillPhone(String value)
		{
			BillPhone = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Fax.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillFax(String value)
		{
			BillFax = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Company.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillCompany(String value)
		{
			BillCompany = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Address1.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillAddress1(String value)
		{
			BillAddress1 = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Address2.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillAddress2(String value)
		{
			BillAddress2 = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_City.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillCity(String value)
		{
			BillCity = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_State.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillState(String value)
		{
			BillState = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Zip.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillZip(String value)
		{
			BillZip = value;
			return this;
		}

		/// <summary>
		/// Setter for Bill_Country.
		/// <param name="value">String</param>
		/// <returns>OrderUpdateCustomerInformationRequest</returns>
		/// </summary>
		public OrderUpdateCustomerInformationRequest SetBillCountry(String value)
		{
			BillCountry = value;
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

			writer.WriteNumber("Order_ID", OrderId);

			if (CustomerId.HasValue)
			{
				writer.WriteNumber("Customer_ID", CustomerId.Value);
			}

			if (ShipResidential.HasValue)
			{
				writer.WriteBoolean("Ship_Residential", ShipResidential.Value);
			}

			if (ShipFirstName != null && ShipFirstName.Length > 0)
			{
				writer.WriteString("Ship_FirstName", ShipFirstName);
			}

			if (ShipLastName != null && ShipLastName.Length > 0)
			{
				writer.WriteString("Ship_LastName", ShipLastName);
			}

			if (ShipEmail != null && ShipEmail.Length > 0)
			{
				writer.WriteString("Ship_Email", ShipEmail);
			}

			if (ShipPhone != null && ShipPhone.Length > 0)
			{
				writer.WriteString("Ship_Phone", ShipPhone);
			}

			if (ShipFax != null && ShipFax.Length > 0)
			{
				writer.WriteString("Ship_Fax", ShipFax);
			}

			if (ShipCompany != null && ShipCompany.Length > 0)
			{
				writer.WriteString("Ship_Company", ShipCompany);
			}

			if (ShipAddress1 != null && ShipAddress1.Length > 0)
			{
				writer.WriteString("Ship_Address1", ShipAddress1);
			}

			if (ShipAddress2 != null && ShipAddress2.Length > 0)
			{
				writer.WriteString("Ship_Address2", ShipAddress2);
			}

			if (ShipCity != null && ShipCity.Length > 0)
			{
				writer.WriteString("Ship_City", ShipCity);
			}

			if (ShipState != null && ShipState.Length > 0)
			{
				writer.WriteString("Ship_State", ShipState);
			}

			if (ShipZip != null && ShipZip.Length > 0)
			{
				writer.WriteString("Ship_Zip", ShipZip);
			}

			if (ShipCountry != null && ShipCountry.Length > 0)
			{
				writer.WriteString("Ship_Country", ShipCountry);
			}

			if (BillFirstName != null && BillFirstName.Length > 0)
			{
				writer.WriteString("Bill_FirstName", BillFirstName);
			}

			if (BillLastName != null && BillLastName.Length > 0)
			{
				writer.WriteString("Bill_LastName", BillLastName);
			}

			if (BillEmail != null && BillEmail.Length > 0)
			{
				writer.WriteString("Bill_Email", BillEmail);
			}

			if (BillPhone != null && BillPhone.Length > 0)
			{
				writer.WriteString("Bill_Phone", BillPhone);
			}

			if (BillFax != null && BillFax.Length > 0)
			{
				writer.WriteString("Bill_Fax", BillFax);
			}

			if (BillCompany != null && BillCompany.Length > 0)
			{
				writer.WriteString("Bill_Company", BillCompany);
			}

			if (BillAddress1 != null && BillAddress1.Length > 0)
			{
				writer.WriteString("Bill_Address1", BillAddress1);
			}

			if (BillAddress2 != null && BillAddress2.Length > 0)
			{
				writer.WriteString("Bill_Address2", BillAddress2);
			}

			if (BillCity != null && BillCity.Length > 0)
			{
				writer.WriteString("Bill_City", BillCity);
			}

			if (BillState != null && BillState.Length > 0)
			{
				writer.WriteString("Bill_State", BillState);
			}

			if (BillZip != null && BillZip.Length > 0)
			{
				writer.WriteString("Bill_Zip", BillZip);
			}

			if (BillCountry != null && BillCountry.Length > 0)
			{
				writer.WriteString("Bill_Country", BillCountry);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderUpdateCustomerInformationResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderUpdateCustomerInformationResponse</returns>
		/// </summary>
		public new OrderUpdateCustomerInformationResponse Send()
		{
			return Client.SendRequestAsync<OrderUpdateCustomerInformationRequest, OrderUpdateCustomerInformationResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderUpdateCustomerInformationResponse></returns>
		/// </summary>
		public new async Task<OrderUpdateCustomerInformationResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderUpdateCustomerInformationRequest, OrderUpdateCustomerInformationResponse>(this);
		}
	}
}
