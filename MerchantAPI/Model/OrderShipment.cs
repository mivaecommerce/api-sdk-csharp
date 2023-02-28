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
	public class OrderShipment : Model
	{
		/// Enumeration OrderShipmentStatus
		public enum OrderShipmentStatus
		{
			Pending = 0,
			Picking = 100,
			Shipped = 200,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderShipmentStatusToString(OrderShipmentStatus value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static OrderShipmentStatus? OrderShipmentStatusFromString(String value)
		{
			OrderShipmentStatus v;
			if (Enum.TryParse<OrderShipmentStatus>(value, out v))
			{
				return v;
			}
			return null;
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property BatchId - int</value>
		[JsonPropertyName("batch_id")]
		public int BatchId { get; set; }

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property LabelCount - int</value>
		[JsonPropertyName("labelcount")]
		public int LabelCount { get; set; }

		/// <value>Property ShipDate - int</value>
		[JsonPropertyName("ship_date")]
		public int ShipDate { get; set; }

		/// <value>Property TrackingNumber - String</value>
		[JsonPropertyName("tracknum")]
		public String TrackingNumber { get; set; }

		/// <value>Property TrackingType - String</value>
		[JsonPropertyName("tracktype")]
		public String TrackingType { get; set; }

		/// <value>Property TrackingLink - String</value>
		[JsonPropertyName("tracklink")]
		public String TrackingLink { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float Weight { get; set; }

		/// <value>Property Cost - float</value>
		[JsonPropertyName("cost")]
		public float Cost { get; set; }

		/// <value>Property FormattedCost - String</value>
		[JsonPropertyName("formatted_cost")]
		public String FormattedCost { get; set; }

		/// <value>Property Order - Order</value>
		[JsonPropertyName("order")]
		public Order Order { get; set; }

		/// <value>Property Items - List<OrderItem></value>
		[JsonPropertyName("items")]
		public List<OrderItem> Items { get; set; } = new List<OrderItem>();

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for batch_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetBatchId()
		{
			return BatchId;
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
		/// Getter for status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Enum Getter for status.
		/// <returns>OrderShipmentStatus?</returns>
		/// </summary>
		public OrderShipmentStatus? GetStatusConst()
		{
			OrderShipmentStatus v;
			if (Enum.TryParse<OrderShipmentStatus>(Status.ToString(), out v))
			{
				return v;
			}
			return null;
		}

		/// <summary>
		/// Getter for labelcount.
		/// <returns>int</returns>
		/// </summary>
		public int GetLabelCount()
		{
			return LabelCount;
		}

		/// <summary>
		/// Getter for ship_date.
		/// <returns>int</returns>
		/// </summary>
		public int GetShipDate()
		{
			return ShipDate;
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
		/// Getter for tracktype.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingType()
		{
			return TrackingType;
		}

		/// <summary>
		/// Getter for tracklink.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingLink()
		{
			return TrackingLink;
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
		/// Getter for cost.
		/// <returns>float</returns>
		/// </summary>
		public float GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Getter for formatted_cost.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedCost()
		{
			return FormattedCost;
		}

		/// <summary>
		/// Getter for order.
		/// <returns>Order</returns>
		/// </summary>
		public Order GetOrder()
		{
			return Order;
		}

		/// <summary>
		/// Getter for items.
		/// <returns>List<OrderItem></returns>
		/// </summary>
		public List<OrderItem> GetItems()
		{
			return Items;
		}
	}

	/// Enum Extensions
	public static class OrderShipmentExtensions
	{
		
		/// <summary>
		/// Extends enum to provide a ToConstInt() method on a value
		/// <returns>int</returns>
		/// </summary>
	    public static int ToConstInt(this OrderShipment.OrderShipmentStatus e)
	    {
	    	return (int) e;
	    }

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this OrderShipment.OrderShipmentStatus e)
	    {
			return ((int) e).ToString();
		}
	}
}
