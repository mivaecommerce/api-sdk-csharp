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
	public class OrderShipmentUpdate : Model
	{
		/// <value>Property ShipmentId - int</value>
		[JsonPropertyName("shpmnt_id")]
		public int ShipmentId { get; set; }

		/// <value>Property MarkShipped - bool</value>
		[JsonPropertyName("mark_shipped")]
		public bool MarkShipped { get; set; }

		/// <value>Property TrackingNumber - String</value>
		[JsonPropertyName("tracknum")]
		public String TrackingNumber { get; set; }

		/// <value>Property TrackingType - String</value>
		[JsonPropertyName("tracktype")]
		public String TrackingType { get; set; }

		/// <value>Property Cost - float</value>
		[JsonPropertyName("cost")]
		public float Cost { get; set; }

		/// <summary>
		/// Getter for shpmnt_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetShipmentId()
		{
			return ShipmentId;
		}

		/// <summary>
		/// Getter for mark_shipped.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetMarkShipped()
		{
			return MarkShipped;
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
		/// Getter for cost.
		/// <returns>float</returns>
		/// </summary>
		public float GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Setter for shpmnt_id.
		/// <param name="value">int</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetShipmentId(int value)
		{
			ShipmentId = value;
			return this;
		}

		/// <summary>
		/// Setter for mark_shipped.
		/// <param name="value">bool</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetMarkShipped(bool value)
		{
			MarkShipped = value;
			return this;
		}

		/// <summary>
		/// Setter for tracknum.
		/// <param name="value">String</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetTrackingNumber(String value)
		{
			TrackingNumber = value;
			return this;
		}

		/// <summary>
		/// Setter for tracktype.
		/// <param name="value">String</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetTrackingType(String value)
		{
			TrackingType = value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">float</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
	   public OrderShipmentUpdate SetCost(float value)
	   {
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">double</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
	   public OrderShipmentUpdate SetCost(double value)
	   {
			Cost = (float) value;
			return this;
		}
	}
}
