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
	public class Subscription : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property LineId - int</value>
		[JsonPropertyName("line_id")]
		public int LineId { get; set; }

		/// <value>Property CustomerId - int</value>
		[JsonPropertyName("cust_id")]
		public int CustomerId { get; set; }

		/// <value>Property CustomerPaymentCardId - int</value>
		[JsonPropertyName("custpc_id")]
		public int CustomerPaymentCardId { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property SubscriptionTermId - int</value>
		[JsonPropertyName("subterm_id")]
		public int SubscriptionTermId { get; set; }

		/// <value>Property AddressId - int</value>
		[JsonPropertyName("addr_id")]
		public int AddressId { get; set; }

		/// <value>Property ShipId - int</value>
		[JsonPropertyName("ship_id")]
		public int ShipId { get; set; }

		/// <value>Property ShipData - String</value>
		[JsonPropertyName("ship_data")]
		public String ShipData { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <value>Property TermRemaining - int</value>
		[JsonPropertyName("termrem")]
		public int TermRemaining { get; set; }

		/// <value>Property TermProcessed - int</value>
		[JsonPropertyName("termproc")]
		public int TermProcessed { get; set; }

		/// <value>Property FirstDate - int</value>
		[JsonPropertyName("firstdate")]
		public int FirstDate { get; set; }

		/// <value>Property LastDate - int</value>
		[JsonPropertyName("lastdate")]
		public int LastDate { get; set; }

		/// <value>Property NextDate - int</value>
		[JsonPropertyName("nextdate")]
		public int NextDate { get; set; }

		/// <value>Property Status - String</value>
		[JsonPropertyName("status")]
		public String Status { get; set; }

		/// <value>Property Message - String</value>
		[JsonPropertyName("message")]
		public String Message { get; set; }

		/// <value>Property CancelDate - String</value>
		[JsonPropertyName("cncldate")]
		public String CancelDate { get; set; }

		/// <value>Property Tax - float</value>
		[JsonPropertyName("tax")]
		public float Tax { get; set; }

		/// <value>Property FormattedTax - String</value>
		[JsonPropertyName("formatted_tax")]
		public String FormattedTax { get; set; }

		/// <value>Property Shipping - float</value>
		[JsonPropertyName("shipping")]
		public float Shipping { get; set; }

		/// <value>Property FormattedShipping - String</value>
		[JsonPropertyName("formatted_shipping")]
		public String FormattedShipping { get; set; }

		/// <value>Property Subtotal - float</value>
		[JsonPropertyName("subtotal")]
		public float Subtotal { get; set; }

		/// <value>Property FormattedSubtotal - String</value>
		[JsonPropertyName("formatted_subtotal")]
		public String FormattedSubtotal { get; set; }

		/// <value>Property Total - float</value>
		[JsonPropertyName("total")]
		public float Total { get; set; }

		/// <value>Property FormattedTotal - String</value>
		[JsonPropertyName("formatted_total")]
		public String FormattedTotal { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for order_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for line_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetLineId()
		{
			return LineId;
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
		/// Getter for custpc_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCustomerPaymentCardId()
		{
			return CustomerPaymentCardId;
		}

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for subterm_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionTermId()
		{
			return SubscriptionTermId;
		}

		/// <summary>
		/// Getter for addr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAddressId()
		{
			return AddressId;
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
		/// Getter for ship_data.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipData()
		{
			return ShipData;
		}

		/// <summary>
		/// Getter for quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for termrem.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermRemaining()
		{
			return TermRemaining;
		}

		/// <summary>
		/// Getter for termproc.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermProcessed()
		{
			return TermProcessed;
		}

		/// <summary>
		/// Getter for firstdate.
		/// <returns>int</returns>
		/// </summary>
		public int GetFirstDate()
		{
			return FirstDate;
		}

		/// <summary>
		/// Getter for lastdate.
		/// <returns>int</returns>
		/// </summary>
		public int GetLastDate()
		{
			return LastDate;
		}

		/// <summary>
		/// Getter for nextdate.
		/// <returns>int</returns>
		/// </summary>
		public int GetNextDate()
		{
			return NextDate;
		}

		/// <summary>
		/// Getter for status.
		/// <returns>String</returns>
		/// </summary>
		public String GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for message.
		/// <returns>String</returns>
		/// </summary>
		public String GetMessage()
		{
			return Message;
		}

		/// <summary>
		/// Getter for cncldate.
		/// <returns>String</returns>
		/// </summary>
		public String GetCancelDate()
		{
			return CancelDate;
		}

		/// <summary>
		/// Getter for tax.
		/// <returns>float</returns>
		/// </summary>
		public float GetTax()
		{
			return Tax;
		}

		/// <summary>
		/// Getter for formatted_tax.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTax()
		{
			return FormattedTax;
		}

		/// <summary>
		/// Getter for shipping.
		/// <returns>float</returns>
		/// </summary>
		public float GetShipping()
		{
			return Shipping;
		}

		/// <summary>
		/// Getter for formatted_shipping.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedShipping()
		{
			return FormattedShipping;
		}

		/// <summary>
		/// Getter for subtotal.
		/// <returns>float</returns>
		/// </summary>
		public float GetSubtotal()
		{
			return Subtotal;
		}

		/// <summary>
		/// Getter for formatted_subtotal.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedSubtotal()
		{
			return FormattedSubtotal;
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
	}
}
