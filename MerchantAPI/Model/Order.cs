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

namespace MerchantAPI
{
	public class Order : Model
	{
		/// Enumeration OrderStatus
		public enum OrderStatus
		{
			Pending = 0,
			Processing = 100,
			Shipped = 200,
			PartiallyShipped = 201,
			Cancelled = 300,
			Backordered = 400,
			RmaIssued = 500,
			Returned = 600,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderStatusToString(OrderStatus value)
		{
			switch(value)
			{
				case OrderStatus.Pending: return "0";
				case OrderStatus.Processing: return "100";
				case OrderStatus.Shipped: return "200";
				case OrderStatus.PartiallyShipped: return "201";
				case OrderStatus.Cancelled: return "300";
				case OrderStatus.Backordered: return "400";
				case OrderStatus.RmaIssued: return "500";
				case OrderStatus.Returned: return "600";
			}
			return "";
		}

		/// Enumeration OrderPaymentStatus
		public enum OrderPaymentStatus
		{
			Pending = 0,
			Authorized = 100,
			Captured = 200,
			PartiallyCaptured = 201,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderPaymentStatusToString(OrderPaymentStatus value)
		{
			switch(value)
			{
				case OrderPaymentStatus.Pending: return "0";
				case OrderPaymentStatus.Authorized: return "100";
				case OrderPaymentStatus.Captured: return "200";
				case OrderPaymentStatus.PartiallyCaptured: return "201";
			}
			return "";
		}

		/// Enumeration OrderStockStatus
		public enum OrderStockStatus
		{
			Available = 100,
			Unavailable = 200,
			Partial = 201,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderStockStatusToString(OrderStockStatus value)
		{
			switch(value)
			{
				case OrderStockStatus.Available: return "100";
				case OrderStockStatus.Unavailable: return "200";
				case OrderStockStatus.Partial: return "201";
			}
			return "";
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property PaymentId - int</value>
		[JsonPropertyName("pay_id")]
		public int PaymentId { get; set; }

		/// <value>Property BatchId - int</value>
		[JsonPropertyName("batch_id")]
		public int BatchId { get; set; }

		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property PaymentStatus - int</value>
		[JsonPropertyName("pay_status")]
		public int PaymentStatus { get; set; }

		/// <value>Property StockStatus - int</value>
		[JsonPropertyName("stk_status")]
		public int StockStatus { get; set; }

		/// <value>Property DateInStock - int</value>
		[JsonPropertyName("dt_instock")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateInStock { get; set; }

		/// <value>Property OrderDate - int</value>
		[JsonPropertyName("orderdate")]
		public int OrderDate { get; set; }

		/// <value>Property CustomerId - int</value>
		[JsonPropertyName("cust_id")]
		public int CustomerId { get; set; }

		/// <value>Property ShipResidential - bool</value>
		[JsonPropertyName("ship_res")]
		public bool ShipResidential { get; set; }

		/// <value>Property ShipFirstName - String</value>
		[JsonPropertyName("ship_fname")]
		public String ShipFirstName { get; set; }

		/// <value>Property ShipLastName - String</value>
		[JsonPropertyName("ship_lname")]
		public String ShipLastName { get; set; }

		/// <value>Property ShipEmail - String</value>
		[JsonPropertyName("ship_email")]
		public String ShipEmail { get; set; }

		/// <value>Property ShipCompany - String</value>
		[JsonPropertyName("ship_comp")]
		public String ShipCompany { get; set; }

		/// <value>Property ShipPhone - String</value>
		[JsonPropertyName("ship_phone")]
		public String ShipPhone { get; set; }

		/// <value>Property ShipFax - String</value>
		[JsonPropertyName("ship_fax")]
		public String ShipFax { get; set; }

		/// <value>Property ShipAddress1 - String</value>
		[JsonPropertyName("ship_addr1")]
		public String ShipAddress1 { get; set; }

		/// <value>Property ShipAddress2 - String</value>
		[JsonPropertyName("ship_addr2")]
		public String ShipAddress2 { get; set; }

		/// <value>Property ShipCity - String</value>
		[JsonPropertyName("ship_city")]
		public String ShipCity { get; set; }

		/// <value>Property ShipState - String</value>
		[JsonPropertyName("ship_state")]
		public String ShipState { get; set; }

		/// <value>Property ShipZip - String</value>
		[JsonPropertyName("ship_zip")]
		public String ShipZip { get; set; }

		/// <value>Property ShipCountry - String</value>
		[JsonPropertyName("ship_cntry")]
		public String ShipCountry { get; set; }

		/// <value>Property BillFirstName - String</value>
		[JsonPropertyName("bill_fname")]
		public String BillFirstName { get; set; }

		/// <value>Property BillLastName - String</value>
		[JsonPropertyName("bill_lname")]
		public String BillLastName { get; set; }

		/// <value>Property BillEmail - String</value>
		[JsonPropertyName("bill_email")]
		public String BillEmail { get; set; }

		/// <value>Property BillCompany - String</value>
		[JsonPropertyName("bill_comp")]
		public String BillCompany { get; set; }

		/// <value>Property BillPhone - String</value>
		[JsonPropertyName("bill_phone")]
		public String BillPhone { get; set; }

		/// <value>Property BillFax - String</value>
		[JsonPropertyName("bill_fax")]
		public String BillFax { get; set; }

		/// <value>Property BillAddress1 - String</value>
		[JsonPropertyName("bill_addr1")]
		public String BillAddress1 { get; set; }

		/// <value>Property BillAddress2 - String</value>
		[JsonPropertyName("bill_addr2")]
		public String BillAddress2 { get; set; }

		/// <value>Property BillCity - String</value>
		[JsonPropertyName("bill_city")]
		public String BillCity { get; set; }

		/// <value>Property BillState - String</value>
		[JsonPropertyName("bill_state")]
		public String BillState { get; set; }

		/// <value>Property BillZip - String</value>
		[JsonPropertyName("bill_zip")]
		public String BillZip { get; set; }

		/// <value>Property BillCountry - String</value>
		[JsonPropertyName("bill_cntry")]
		public String BillCountry { get; set; }

		/// <value>Property ShipmentId - int</value>
		[JsonPropertyName("ship_id")]
		public int ShipmentId { get; set; }

		/// <value>Property ShipData - String</value>
		[JsonPropertyName("ship_data")]
		public String ShipData { get; set; }

		/// <value>Property ShipMethod - String</value>
		[JsonPropertyName("ship_method")]
		public String ShipMethod { get; set; }

		/// <value>Property CustomerLogin - String</value>
		[JsonPropertyName("cust_login")]
		public String CustomerLogin { get; set; }

		/// <value>Property CustomerPasswordEmail - String</value>
		[JsonPropertyName("cust_pw_email")]
		public String CustomerPasswordEmail { get; set; }

		/// <value>Property BusinessTitle - String</value>
		[JsonPropertyName("business_title")]
		public String BusinessTitle { get; set; }

		/// <value>Property PaymentModule - String</value>
		[JsonPropertyName("payment_module")]
		public String PaymentModule { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("source")]
		public String Source { get; set; }

		/// <value>Property SourceId - int</value>
		[JsonPropertyName("source_id")]
		public int SourceId { get; set; }

		/// <value>Property Total - float</value>
		[JsonPropertyName("total")]
		public float Total { get; set; }

		/// <value>Property FormattedTotal - String</value>
		[JsonPropertyName("formatted_total")]
		public String FormattedTotal { get; set; }

		/// <value>Property TotalShip - float</value>
		[JsonPropertyName("total_ship")]
		public float TotalShip { get; set; }

		/// <value>Property FormattedTotalShip - String</value>
		[JsonPropertyName("formatted_total_ship")]
		public String FormattedTotalShip { get; set; }

		/// <value>Property TotalTax - float</value>
		[JsonPropertyName("total_tax")]
		public float TotalTax { get; set; }

		/// <value>Property FormattedTotalTax - String</value>
		[JsonPropertyName("formatted_total_tax")]
		public String FormattedTotalTax { get; set; }

		/// <value>Property TotalAuthorized - float</value>
		[JsonPropertyName("total_auth")]
		public float TotalAuthorized { get; set; }

		/// <value>Property FormattedTotalAuthorized - String</value>
		[JsonPropertyName("formatted_total_auth")]
		public String FormattedTotalAuthorized { get; set; }

		/// <value>Property TotalCaptured - float</value>
		[JsonPropertyName("total_capt")]
		public float TotalCaptured { get; set; }

		/// <value>Property FormattedTotalCaptured - String</value>
		[JsonPropertyName("formatted_total_capt")]
		public String FormattedTotalCaptured { get; set; }

		/// <value>Property TotalRefunded - float</value>
		[JsonPropertyName("total_rfnd")]
		public float TotalRefunded { get; set; }

		/// <value>Property FormattedTotalRefunded - String</value>
		[JsonPropertyName("formatted_total_rfnd")]
		public String FormattedTotalRefunded { get; set; }

		/// <value>Property NetCaptured - float</value>
		[JsonPropertyName("net_capt")]
		public float NetCaptured { get; set; }

		/// <value>Property FormattedNetCaptured - String</value>
		[JsonPropertyName("formatted_net_capt")]
		public String FormattedNetCaptured { get; set; }

		/// <value>Property PendingCount - int</value>
		[JsonPropertyName("pend_count")]
		public int PendingCount { get; set; }

		/// <value>Property BackorderCount - int</value>
		[JsonPropertyName("bord_count")]
		public int BackorderCount { get; set; }

		/// <value>Property NoteCount - int</value>
		[JsonPropertyName("note_count")]
		public int NoteCount { get; set; }

		/// <value>Property Customer - Customer</value>
		[JsonPropertyName("customer")]
		public Customer Customer { get; set; }

		/// <value>Property Items - List<OrderItem></value>
		[JsonPropertyName("items")]
		public List<OrderItem> Items { get; set; } = new List<OrderItem>();

		/// <value>Property Charges - List<OrderCharge></value>
		[JsonPropertyName("charges")]
		public List<OrderCharge> Charges { get; set; } = new List<OrderCharge>();

		/// <value>Property Coupons - List<OrderCoupon></value>
		[JsonPropertyName("coupons")]
		public List<OrderCoupon> Coupons { get; set; } = new List<OrderCoupon>();

		/// <value>Property Discounts - List<OrderDiscountTotal></value>
		[JsonPropertyName("discounts")]
		public List<OrderDiscountTotal> Discounts { get; set; } = new List<OrderDiscountTotal>();

		/// <value>Property Payments - List<OrderPayment></value>
		[JsonPropertyName("payments")]
		public List<OrderPayment> Payments { get; set; } = new List<OrderPayment>();

		/// <value>Property Notes - List<OrderNote></value>
		[JsonPropertyName("notes")]
		public List<OrderNote> Notes { get; set; } = new List<OrderNote>();

		/// <value>Property Parts - List<OrderPart></value>
		[JsonPropertyName("parts")]
		public List<OrderPart> Parts { get; set; } = new List<OrderPart>();

		/// <value>Property CustomFieldValues - CustomFieldValues</value>
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for pay_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPaymentId()
		{
			return PaymentId;
		}

		/// <summary>
		/// Getter for batch_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetBatchId()
		{
			return BatchId;
		}

		/// <summary>
		/// Getter for status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for pay_status.
		/// <returns>int</returns>
		/// </summary>
		public int GetPaymentStatus()
		{
			return PaymentStatus;
		}

		/// <summary>
		/// Getter for stk_status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStockStatus()
		{
			return StockStatus;
		}

		/// <summary>
		/// Getter for dt_instock.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateInStock()
		{
			return DateInStock;
		}

		/// <summary>
		/// Getter for orderdate.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderDate()
		{
			return OrderDate;
		}

		/// <summary>
		/// Getter for cust_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Getter for ship_res.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetShipResidential()
		{
			return ShipResidential;
		}

		/// <summary>
		/// Getter for ship_fname.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipFirstName()
		{
			return ShipFirstName;
		}

		/// <summary>
		/// Getter for ship_lname.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipLastName()
		{
			return ShipLastName;
		}

		/// <summary>
		/// Getter for ship_email.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipEmail()
		{
			return ShipEmail;
		}

		/// <summary>
		/// Getter for ship_comp.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCompany()
		{
			return ShipCompany;
		}

		/// <summary>
		/// Getter for ship_phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipPhone()
		{
			return ShipPhone;
		}

		/// <summary>
		/// Getter for ship_fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipFax()
		{
			return ShipFax;
		}

		/// <summary>
		/// Getter for ship_addr1.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipAddress1()
		{
			return ShipAddress1;
		}

		/// <summary>
		/// Getter for ship_addr2.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipAddress2()
		{
			return ShipAddress2;
		}

		/// <summary>
		/// Getter for ship_city.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCity()
		{
			return ShipCity;
		}

		/// <summary>
		/// Getter for ship_state.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipState()
		{
			return ShipState;
		}

		/// <summary>
		/// Getter for ship_zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipZip()
		{
			return ShipZip;
		}

		/// <summary>
		/// Getter for ship_cntry.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCountry()
		{
			return ShipCountry;
		}

		/// <summary>
		/// Getter for bill_fname.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillFirstName()
		{
			return BillFirstName;
		}

		/// <summary>
		/// Getter for bill_lname.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillLastName()
		{
			return BillLastName;
		}

		/// <summary>
		/// Getter for bill_email.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillEmail()
		{
			return BillEmail;
		}

		/// <summary>
		/// Getter for bill_comp.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCompany()
		{
			return BillCompany;
		}

		/// <summary>
		/// Getter for bill_phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillPhone()
		{
			return BillPhone;
		}

		/// <summary>
		/// Getter for bill_fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillFax()
		{
			return BillFax;
		}

		/// <summary>
		/// Getter for bill_addr1.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillAddress1()
		{
			return BillAddress1;
		}

		/// <summary>
		/// Getter for bill_addr2.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillAddress2()
		{
			return BillAddress2;
		}

		/// <summary>
		/// Getter for bill_city.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCity()
		{
			return BillCity;
		}

		/// <summary>
		/// Getter for bill_state.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillState()
		{
			return BillState;
		}

		/// <summary>
		/// Getter for bill_zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillZip()
		{
			return BillZip;
		}

		/// <summary>
		/// Getter for bill_cntry.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCountry()
		{
			return BillCountry;
		}

		/// <summary>
		/// Getter for ship_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetShipmentId()
		{
			return ShipmentId;
		}

		/// <summary>
		/// Getter for ship_data.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipData()
		{
			return ShipData;
		}

		/// <summary>
		/// Getter for ship_method.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipMethod()
		{
			return ShipMethod;
		}

		/// <summary>
		/// Getter for cust_login.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerLogin()
		{
			return CustomerLogin;
		}

		/// <summary>
		/// Getter for cust_pw_email.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerPasswordEmail()
		{
			return CustomerPasswordEmail;
		}

		/// <summary>
		/// Getter for business_title.
		/// <returns>String</returns>
		/// </summary>
		public String GetBusinessTitle()
		{
			return BusinessTitle;
		}

		/// <summary>
		/// Getter for payment_module.
		/// <returns>String</returns>
		/// </summary>
		public String GetPaymentModule()
		{
			return PaymentModule;
		}

		/// <summary>
		/// Getter for source.
		/// <returns>String</returns>
		/// </summary>
		public String GetSource()
		{
			return Source;
		}

		/// <summary>
		/// Getter for source_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSourceId()
		{
			return SourceId;
		}

		/// <summary>
		/// Getter for total.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotal()
		{
			return Total;
		}

		/// <summary>
		/// Getter for formatted_total.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotal()
		{
			return FormattedTotal;
		}

		/// <summary>
		/// Getter for total_ship.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalShip()
		{
			return TotalShip;
		}

		/// <summary>
		/// Getter for formatted_total_ship.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalShip()
		{
			return FormattedTotalShip;
		}

		/// <summary>
		/// Getter for total_tax.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalTax()
		{
			return TotalTax;
		}

		/// <summary>
		/// Getter for formatted_total_tax.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalTax()
		{
			return FormattedTotalTax;
		}

		/// <summary>
		/// Getter for total_auth.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalAuthorized()
		{
			return TotalAuthorized;
		}

		/// <summary>
		/// Getter for formatted_total_auth.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalAuthorized()
		{
			return FormattedTotalAuthorized;
		}

		/// <summary>
		/// Getter for total_capt.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalCaptured()
		{
			return TotalCaptured;
		}

		/// <summary>
		/// Getter for formatted_total_capt.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalCaptured()
		{
			return FormattedTotalCaptured;
		}

		/// <summary>
		/// Getter for total_rfnd.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalRefunded()
		{
			return TotalRefunded;
		}

		/// <summary>
		/// Getter for formatted_total_rfnd.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalRefunded()
		{
			return FormattedTotalRefunded;
		}

		/// <summary>
		/// Getter for net_capt.
		/// <returns>float</returns>
		/// </summary>
		public float GetNetCaptured()
		{
			return NetCaptured;
		}

		/// <summary>
		/// Getter for formatted_net_capt.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedNetCaptured()
		{
			return FormattedNetCaptured;
		}

		/// <summary>
		/// Getter for pend_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetPendingCount()
		{
			return PendingCount;
		}

		/// <summary>
		/// Getter for bord_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetBackorderCount()
		{
			return BackorderCount;
		}

		/// <summary>
		/// Getter for note_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetNoteCount()
		{
			return NoteCount;
		}

		/// <summary>
		/// Getter for customer.
		/// <returns>Customer</returns>
		/// </summary>
		public Customer GetCustomer()
		{
			return Customer;
		}

		/// <summary>
		/// Getter for items.
		/// <returns>List<OrderItem></returns>
		/// </summary>
		public List<OrderItem> GetItems()
		{
			return Items;
		}

		/// <summary>
		/// Getter for charges.
		/// <returns>List<OrderCharge></returns>
		/// </summary>
		public List<OrderCharge> GetCharges()
		{
			return Charges;
		}

		/// <summary>
		/// Getter for coupons.
		/// <returns>List<OrderCoupon></returns>
		/// </summary>
		public List<OrderCoupon> GetCoupons()
		{
			return Coupons;
		}

		/// <summary>
		/// Getter for discounts.
		/// <returns>List<OrderDiscountTotal></returns>
		/// </summary>
		public List<OrderDiscountTotal> GetDiscounts()
		{
			return Discounts;
		}

		/// <summary>
		/// Getter for payments.
		/// <returns>List<OrderPayment></returns>
		/// </summary>
		public List<OrderPayment> GetPayments()
		{
			return Payments;
		}

		/// <summary>
		/// Getter for notes.
		/// <returns>List<OrderNote></returns>
		/// </summary>
		public List<OrderNote> GetNotes()
		{
			return Notes;
		}

		/// <summary>
		/// Getter for parts.
		/// <returns>List<OrderPart></returns>
		/// </summary>
		public List<OrderPart> GetParts()
		{
			return Parts;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}
	}
}
