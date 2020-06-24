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
			switch(value)
			{
				case OrderShipmentStatus.Pending: return "0";
				case OrderShipmentStatus.Picking: return "100";
				case OrderShipmentStatus.Shipped: return "200";
			}
			return "";
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
		/// Setter for id.
		/// <param name="value">int</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetId(int value)
		{
			Id = value;
			return this;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for batch_id.
		/// <param name="value">int</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetBatchId(int value)
		{
			BatchId = value;
			return this;
		}

		/// <summary>
		/// Setter for order_id.
		/// <param name="value">int</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for status.
		/// <param name="value">int</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetStatus(int value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for labelcount.
		/// <param name="value">int</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetLabelCount(int value)
		{
			LabelCount = value;
			return this;
		}

		/// <summary>
		/// Setter for ship_date.
		/// <param name="value">int</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetShipDate(int value)
		{
			ShipDate = value;
			return this;
		}

		/// <summary>
		/// Setter for tracknum.
		/// <param name="value">String</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetTrackingNumber(String value)
		{
			TrackingNumber = value;
			return this;
		}

		/// <summary>
		/// Setter for tracktype.
		/// <param name="value">String</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetTrackingType(String value)
		{
			TrackingType = value;
			return this;
		}

		/// <summary>
		/// Setter for tracklink.
		/// <param name="value">String</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment SetTrackingLink(String value)
		{
			TrackingLink = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
	   public OrderShipment SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
	   public OrderShipment SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">float</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
	   public OrderShipment SetCost(float value)
	   {
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">double</param>
		/// <returns>OrderShipment</returns>
		/// </summary>
	   public OrderShipment SetCost(double value)
	   {
			Cost = (float) value;
			return this;
		}
	}
}
