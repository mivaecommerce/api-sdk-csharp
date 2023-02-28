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
	public class OrderReturn : Model
	{
		/// Enumeration OrderReturnStatus
		public enum OrderReturnStatus
		{
			Issued = 500,
			Received = 600,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderReturnStatusToString(OrderReturnStatus value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static OrderReturnStatus? OrderReturnStatusFromString(String value)
		{
			OrderReturnStatus v;
			if (Enum.TryParse<OrderReturnStatus>(value, out v))
			{
				return v;
			}
			return null;
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property DateTimeIssued - int</value>
		[JsonPropertyName("dt_issued")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeIssued { get; set; }

		/// <value>Property DateTimeReceived - int</value>
		[JsonPropertyName("dt_recvd")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeReceived { get; set; }

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
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
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
		/// <returns>OrderReturnStatus?</returns>
		/// </summary>
		public OrderReturnStatus? GetStatusConst()
		{
			OrderReturnStatus v;
			if (Enum.TryParse<OrderReturnStatus>(Status.ToString(), out v))
			{
				return v;
			}
			return null;
		}

		/// <summary>
		/// Getter for dt_issued.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeIssued()
		{
			return DateTimeIssued;
		}

		/// <summary>
		/// Getter for dt_recvd.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeReceived()
		{
			return DateTimeReceived;
		}
	}

	/// Enum Extensions
	public static class OrderReturnExtensions
	{
		
		/// <summary>
		/// Extends enum to provide a ToConstInt() method on a value
		/// <returns>int</returns>
		/// </summary>
	    public static int ToConstInt(this OrderReturn.OrderReturnStatus e)
	    {
	    	return (int) e;
	    }

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this OrderReturn.OrderReturnStatus e)
	    {
			return ((int) e).ToString();
		}
	}
}
