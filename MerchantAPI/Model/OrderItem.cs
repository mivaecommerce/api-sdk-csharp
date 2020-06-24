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
	public class OrderItem : Model
	{
		/// Enumeration OrderItemStatus
		public enum OrderItemStatus
		{
			Pending = 0,
			Processing = 100,
			Shipped = 200,
			PartiallyShipped = 201,
			GiftCertNotRedeemed = 210,
			GiftCertRedeemed = 211,
			DigitalNotDownloaded = 220,
			DigitalDownloaded = 221,
			Cancelled = 300,
			Backordered = 400,
			RmaIssued = 500,
			Returned = 600,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderItemStatusToString(OrderItemStatus value)
		{
			switch(value)
			{
				case OrderItemStatus.Pending: return "0";
				case OrderItemStatus.Processing: return "100";
				case OrderItemStatus.Shipped: return "200";
				case OrderItemStatus.PartiallyShipped: return "201";
				case OrderItemStatus.GiftCertNotRedeemed: return "210";
				case OrderItemStatus.GiftCertRedeemed: return "211";
				case OrderItemStatus.DigitalNotDownloaded: return "220";
				case OrderItemStatus.DigitalDownloaded: return "221";
				case OrderItemStatus.Cancelled: return "300";
				case OrderItemStatus.Backordered: return "400";
				case OrderItemStatus.RmaIssued: return "500";
				case OrderItemStatus.Returned: return "600";
			}
			return "";
		}

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property LineId - int</value>
		[JsonPropertyName("line_id")]
		public int LineId { get; set; }

		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property SubscriptionId - int</value>
		[JsonPropertyName("subscrp_id")]
		public int SubscriptionId { get; set; }

		/// <value>Property SubscriptionTermId - int</value>
		[JsonPropertyName("subterm_id")]
		public int SubscriptionTermId { get; set; }

		/// <value>Property RmaId - int</value>
		[JsonPropertyName("rma_id")]
		public int RmaId { get; set; }

		/// <value>Property RmaCode - String</value>
		[JsonPropertyName("rma_code")]
		public String RmaCode { get; set; }

		/// <value>Property RmaDataTimeIssued - int</value>
		[JsonPropertyName("rma_dt_issued")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime RmaDataTimeIssued { get; set; }

		/// <value>Property RmaDateTimeReceived - int</value>
		[JsonPropertyName("rma_dt_recvd")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime RmaDateTimeReceived { get; set; }

		/// <value>Property DateInStock - int</value>
		[JsonPropertyName("dt_instock")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateInStock { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Sku - String</value>
		[JsonPropertyName("sku")]
		public String Sku { get; set; }

		/// <value>Property Retail - float</value>
		[JsonPropertyName("retail")]
		public float Retail { get; set; }

		/// <value>Property BasePrice - float</value>
		[JsonPropertyName("base_price")]
		public float BasePrice { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float Price { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float Weight { get; set; }

		/// <value>Property Taxable - bool</value>
		[JsonPropertyName("taxable")]
		public bool Taxable { get; set; }

		/// <value>Property Upsold - bool</value>
		[JsonPropertyName("upsold")]
		public bool Upsold { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <value>Property Shipment - OrderShipment</value>
		[JsonPropertyName("shipment")]
		public OrderShipment Shipment { get; set; }

		/// <value>Property Discounts - List<OrderItemDiscount></value>
		[JsonPropertyName("discounts")]
		public List<OrderItemDiscount> Discounts { get; set; } = new List<OrderItemDiscount>();

		/// <value>Property Options - List<OrderItemOption></value>
		[JsonPropertyName("options")]
		public List<OrderItemOption> Options { get; set; } = new List<OrderItemOption>();

		/// <value>Property Subscription - OrderItemSubscription</value>
		[JsonPropertyName("subscription")]
		public OrderItemSubscription Subscription { get; set; }

		/// <value>Property Total - float</value>
		[JsonPropertyName("total")]
		public float Total { get; set; }

		/// <value>Property TrackingType - String</value>
		[JsonPropertyName("tracktype")]
		public String TrackingType { get; set; }

		/// <value>Property TrackingNumber - String</value>
		[JsonPropertyName("tracknum")]
		public String TrackingNumber { get; set; }

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
		/// Getter for status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for subscrp_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionId()
		{
			return SubscriptionId;
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
		/// Getter for rma_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetRmaId()
		{
			return RmaId;
		}

		/// <summary>
		/// Getter for rma_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetRmaCode()
		{
			return RmaCode;
		}

		/// <summary>
		/// Getter for rma_dt_issued.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetRmaDataTimeIssued()
		{
			return RmaDataTimeIssued;
		}

		/// <summary>
		/// Getter for rma_dt_recvd.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetRmaDateTimeReceived()
		{
			return RmaDateTimeReceived;
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
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
		}

		/// <summary>
		/// Getter for retail.
		/// <returns>float</returns>
		/// </summary>
		public float GetRetail()
		{
			return Retail;
		}

		/// <summary>
		/// Getter for base_price.
		/// <returns>float</returns>
		/// </summary>
		public float GetBasePrice()
		{
			return BasePrice;
		}

		/// <summary>
		/// Getter for price.
		/// <returns>float</returns>
		/// </summary>
		public float GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Getter for taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTaxable()
		{
			return Taxable;
		}

		/// <summary>
		/// Getter for upsold.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetUpsold()
		{
			return Upsold;
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
		/// Getter for shipment.
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment GetShipment()
		{
			return Shipment;
		}

		/// <summary>
		/// Getter for discounts.
		/// <returns>List<OrderItemDiscount></returns>
		/// </summary>
		public List<OrderItemDiscount> GetDiscounts()
		{
			return Discounts;
		}

		/// <summary>
		/// Getter for options.
		/// <returns>List<OrderItemOption></returns>
		/// </summary>
		public List<OrderItemOption> GetOptions()
		{
			return Options;
		}

		/// <summary>
		/// Getter for subscription.
		/// <returns>OrderItemSubscription</returns>
		/// </summary>
		public OrderItemSubscription GetSubscription()
		{
			return Subscription;
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
		/// Getter for tracktype.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingType()
		{
			return TrackingType;
		}

		/// <summary>
		/// Getter for tracknum.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingNumber()
		{
			return TrackingNumber;
		}

		/// <summary>
		/// Setter for status.
		/// <param name="value">int</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetStatus(int value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for name.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for sku.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetSku(String value)
		{
			Sku = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">float</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetPrice(float value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">double</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetPrice(double value)
	   {
			Price = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for taxable.
		/// <param name="value">bool</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetTaxable(bool value)
		{
			Taxable = value;
			return this;
		}

		/// <summary>
		/// Setter for upsold.
		/// <param name="value">bool</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetUpsold(bool value)
		{
			Upsold = value;
			return this;
		}

		/// <summary>
		/// Setter for quantity.
		/// <param name="value">int</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}

		/// <summary>
		/// Setter for tracktype.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetTrackingType(String value)
		{
			TrackingType = value;
			return this;
		}

		/// <summary>
		/// Setter for tracknum.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetTrackingNumber(String value)
		{
			TrackingNumber = value;
			return this;
		}

		/// <summary>
		/// Add a OrderItemOption.
		/// <param name="OrderItemOption"></param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem AddOption(OrderItemOption model)
		{
			Options.Add(model);
			return this;
		}
	}
}
