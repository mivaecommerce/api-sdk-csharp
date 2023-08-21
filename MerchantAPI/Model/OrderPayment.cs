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
	public class OrderPayment : Model
	{
		/// Enumeration OrderPaymentType
		public enum OrderPaymentType
		{
			Declined = 0,
			LegacyAuth = 1,
			LegacyCapture = 2,
			Auth = 3,
			Capture = 4,
			AuthCapture = 5,
			Refund = 6,
			Void = 7,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderPaymentTypeToString(OrderPaymentType value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static OrderPaymentType? OrderPaymentTypeFromString(String value)
		{
			OrderPaymentType v;
			if (Enum.TryParse<OrderPaymentType>(value, out v))
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

		/// <value>Property PaymentType - int</value>
		[JsonPropertyName("type")]
		public int PaymentType { get; set; }

		/// <value>Property ReferenceNumber - String</value>
		[JsonPropertyName("refnum")]
		public String ReferenceNumber { get; set; }

		/// <value>Property Amount - float</value>
		[JsonPropertyName("amount")]
		public float Amount { get; set; }

		/// <value>Property FormattedAmount - String</value>
		[JsonPropertyName("formatted_amount")]
		public String FormattedAmount { get; set; }

		/// <value>Property Available - float</value>
		[JsonPropertyName("available")]
		public float Available { get; set; }

		/// <value>Property FormattedAvailable - String</value>
		[JsonPropertyName("formatted_available")]
		public String FormattedAvailable { get; set; }

		/// <value>Property DateTimeStamp - int</value>
		[JsonPropertyName("dtstamp")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStamp { get; set; }

		/// <value>Property Expires - int</value>
		[JsonPropertyName("expires")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime Expires { get; set; }

		/// <value>Property PaymentId - int</value>
		[JsonPropertyName("pay_id")]
		public int PaymentId { get; set; }

		/// <value>Property PaymentSecId - int</value>
		[JsonPropertyName("pay_secid")]
		public int PaymentSecId { get; set; }

		/// <value>Property DecryptStatus - String</value>
		[JsonPropertyName("decrypt_status")]
		public String DecryptStatus { get; set; }

		/// <value>Property DecryptError - String</value>
		[JsonPropertyName("decrypt_error")]
		public String DecryptError { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("description")]
		public String Description { get; set; }

		/// <value>Property PaymentData - List<String></value>
		[JsonPropertyName("data")]
		public Dictionary<String, String> PaymentData { get; set; } = new Dictionary<String, String>();

		/// <value>Property Ip - String</value>
		[JsonPropertyName("ip")]
		public String Ip { get; set; }

		/// <value>Property Module - Module</value>
		[JsonPropertyName("module")]
		public Module Module { get; set; }

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
		/// Getter for type.
		/// <returns>int</returns>
		/// </summary>
		public int GetPaymentType()
		{
			return PaymentType;
		}

		/// <summary>
		/// Enum Getter for type.
		/// <returns>OrderPaymentType?</returns>
		/// </summary>
		public OrderPaymentType? GetPaymentTypeConst()
		{
			OrderPaymentType v;
			if (Enum.TryParse<OrderPaymentType>(PaymentType.ToString(), out v))
			{
				return v;
			}
			return null;
		}

		/// <summary>
		/// Getter for refnum.
		/// <returns>String</returns>
		/// </summary>
		public String GetReferenceNumber()
		{
			return ReferenceNumber;
		}

		/// <summary>
		/// Getter for amount.
		/// <returns>float</returns>
		/// </summary>
		public float GetAmount()
		{
			return Amount;
		}

		/// <summary>
		/// Getter for formatted_amount.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedAmount()
		{
			return FormattedAmount;
		}

		/// <summary>
		/// Getter for available.
		/// <returns>float</returns>
		/// </summary>
		public float GetAvailable()
		{
			return Available;
		}

		/// <summary>
		/// Getter for formatted_available.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedAvailable()
		{
			return FormattedAvailable;
		}

		/// <summary>
		/// Getter for dtstamp.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeStamp()
		{
			return DateTimeStamp;
		}

		/// <summary>
		/// Getter for expires.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetExpires()
		{
			return Expires;
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
		/// Getter for pay_secid.
		/// <returns>int</returns>
		/// </summary>
		public int GetPaymentSecId()
		{
			return PaymentSecId;
		}

		/// <summary>
		/// Getter for decrypt_status.
		/// <returns>String</returns>
		/// </summary>
		public String GetDecryptStatus()
		{
			return DecryptStatus;
		}

		/// <summary>
		/// Getter for decrypt_error.
		/// <returns>String</returns>
		/// </summary>
		public String GetDecryptError()
		{
			return DecryptError;
		}

		/// <summary>
		/// Getter for description.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for data.
		/// <returns>Dictionary<String,String></returns>
		/// </summary>
		public Dictionary<String,String> GetPaymentData()
		{
			return PaymentData;
		}

		/// <summary>
		/// Getter for ip.
		/// <returns>String</returns>
		/// </summary>
		public String GetIp()
		{
			return Ip;
		}

		/// <summary>
		/// Getter for module.
		/// <returns>Module</returns>
		/// </summary>
		public Module GetModule()
		{
			return Module;
		}
	}

	/// Enum Extensions
	public static class OrderPaymentExtensions
	{
		
		/// <summary>
		/// Extends enum to provide a ToConstInt() method on a value
		/// <returns>int</returns>
		/// </summary>
	    public static int ToConstInt(this OrderPayment.OrderPaymentType e)
	    {
	    	return (int) e;
	    }

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this OrderPayment.OrderPaymentType e)
	    {
			return ((int) e).ToString();
		}
	}
}
