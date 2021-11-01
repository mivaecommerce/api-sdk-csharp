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
	public class Customer : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property AccountId - int</value>
		[JsonPropertyName("account_id")]
		public int AccountId { get; set; }

		/// <value>Property Login - String</value>
		[JsonPropertyName("login")]
		public String Login { get; set; }

		/// <value>Property PasswordEmail - String</value>
		[JsonPropertyName("pw_email")]
		public String PasswordEmail { get; set; }

		/// <value>Property ShipId - int</value>
		[JsonPropertyName("ship_id")]
		public int ShipId { get; set; }

		/// <value>Property ShippingResidential - bool</value>
		[JsonPropertyName("ship_res")]
		public bool ShippingResidential { get; set; }

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

		/// <value>Property BillId - int</value>
		[JsonPropertyName("bill_id")]
		public int BillId { get; set; }

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

		/// <value>Property TaxExempt - bool</value>
		[JsonPropertyName("tax_exempt")]
		public bool TaxExempt { get; set; }

		/// <value>Property OrderCount - int</value>
		[JsonPropertyName("order_cnt")]
		public int OrderCount { get; set; }

		/// <value>Property OrderAverage - float</value>
		[JsonPropertyName("order_avg")]
		public float OrderAverage { get; set; }

		/// <value>Property FormattedOrderAverage - String</value>
		[JsonPropertyName("formatted_order_avg")]
		public String FormattedOrderAverage { get; set; }

		/// <value>Property OrderTotal - float</value>
		[JsonPropertyName("order_tot")]
		public float OrderTotal { get; set; }

		/// <value>Property FormattedOrderTotal - String</value>
		[JsonPropertyName("formatted_order_tot")]
		public String FormattedOrderTotal { get; set; }

		/// <value>Property NoteCount - int</value>
		[JsonPropertyName("note_count")]
		public int NoteCount { get; set; }

		/// <value>Property CreatedOn - int</value>
		[JsonPropertyName("dt_created")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime CreatedOn { get; set; }

		/// <value>Property LastLogin - int</value>
		[JsonPropertyName("dt_login")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime LastLogin { get; set; }

		/// <value>Property PasswordChangeDateTime - int</value>
		[JsonPropertyName("dt_pwchg")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime PasswordChangeDateTime { get; set; }

		/// <value>Property Credit - float</value>
		[JsonPropertyName("credit")]
		public float Credit { get; set; }

		/// <value>Property FormattedCredit - String</value>
		[JsonPropertyName("formatted_credit")]
		public String FormattedCredit { get; set; }

		/// <value>Property BusinessTitle - String</value>
		[JsonPropertyName("business_title")]
		public String BusinessTitle { get; set; }

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
		/// Getter for account_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAccountId()
		{
			return AccountId;
		}

		/// <summary>
		/// Getter for login.
		/// <returns>String</returns>
		/// </summary>
		public String GetLogin()
		{
			return Login;
		}

		/// <summary>
		/// Getter for pw_email.
		/// <returns>String</returns>
		/// </summary>
		public String GetPasswordEmail()
		{
			return PasswordEmail;
		}

		/// <summary>
		/// Getter for ship_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetShipId()
		{
			return ShipId;
		}

		/// <summary>
		/// Getter for ship_res.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetShippingResidential()
		{
			return ShippingResidential;
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
		/// Getter for bill_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetBillId()
		{
			return BillId;
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
		/// Getter for tax_exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTaxExempt()
		{
			return TaxExempt;
		}

		/// <summary>
		/// Getter for order_cnt.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderCount()
		{
			return OrderCount;
		}

		/// <summary>
		/// Getter for order_avg.
		/// <returns>float</returns>
		/// </summary>
		public float GetOrderAverage()
		{
			return OrderAverage;
		}

		/// <summary>
		/// Getter for formatted_order_avg.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedOrderAverage()
		{
			return FormattedOrderAverage;
		}

		/// <summary>
		/// Getter for order_tot.
		/// <returns>float</returns>
		/// </summary>
		public float GetOrderTotal()
		{
			return OrderTotal;
		}

		/// <summary>
		/// Getter for formatted_order_tot.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedOrderTotal()
		{
			return FormattedOrderTotal;
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
		/// Getter for dt_created.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetCreatedOn()
		{
			return CreatedOn;
		}

		/// <summary>
		/// Getter for dt_login.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetLastLogin()
		{
			return LastLogin;
		}

		/// <summary>
		/// Getter for dt_pwchg.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetPasswordChangeDateTime()
		{
			return PasswordChangeDateTime;
		}

		/// <summary>
		/// Getter for credit.
		/// <returns>float</returns>
		/// </summary>
		public float GetCredit()
		{
			return Credit;
		}

		/// <summary>
		/// Getter for formatted_credit.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedCredit()
		{
			return FormattedCredit;
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
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}
	}
}
