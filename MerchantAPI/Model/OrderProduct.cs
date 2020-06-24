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
	public class OrderProduct : Model
	{
		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Sku - String</value>
		[JsonPropertyName("sku")]
		public String Sku { get; set; }

		/// <value>Property TrackingNumber - String</value>
		[JsonPropertyName("tracknum")]
		public String TrackingNumber { get; set; }

		/// <value>Property TrackingType - String</value>
		[JsonPropertyName("tracktype")]
		public String TrackingType { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <value>Property Attributes - List<OrderProductAttribute></value>
		[JsonPropertyName("attributes")]
		public List<OrderProductAttribute> Attributes { get; set; } = new List<OrderProductAttribute>();

		/// <summary>
		/// Getter for status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStatus()
		{
			return Status;
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
		/// Getter for sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
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
		/// Getter for quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for attributes.
		/// <returns>List<OrderProductAttribute></returns>
		/// </summary>
		public List<OrderProductAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Setter for status.
		/// <param name="value">int</param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct SetStatus(int value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for sku.
		/// <param name="value">String</param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct SetSku(String value)
		{
			Sku = value;
			return this;
		}

		/// <summary>
		/// Setter for tracknum.
		/// <param name="value">String</param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct SetTrackingNumber(String value)
		{
			TrackingNumber = value;
			return this;
		}

		/// <summary>
		/// Setter for tracktype.
		/// <param name="value">String</param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct SetTrackingType(String value)
		{
			TrackingType = value;
			return this;
		}

		/// <summary>
		/// Setter for quantity.
		/// <param name="value">int</param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}

		/// <summary>
		/// Add a OrderProductAttribute.
		/// <param name="OrderProductAttribute"></param>
		/// <returns>OrderProduct</returns>
		/// </summary>
		public OrderProduct AddAttribute(OrderProductAttribute model)
		{
			Attributes.Add(model);
			return this;
		}
	}
}
