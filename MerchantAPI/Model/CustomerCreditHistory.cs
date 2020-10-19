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
	public class CustomerCreditHistory : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property CustomerId - int</value>
		[JsonPropertyName("cust_id")]
		public int CustomerId { get; set; }

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property TransactionReference - String</value>
		[JsonPropertyName("txref")]
		public String TransactionReference { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property Amount - float</value>
		[JsonPropertyName("amount")]
		public float Amount { get; set; }

		/// <value>Property DateTimeStamp - int</value>
		[JsonPropertyName("dtstamp")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStamp { get; set; }

		/// <value>Property UserName - String</value>
		[JsonPropertyName("user_name")]
		public String UserName { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUserId()
		{
			return UserId;
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
		/// Getter for order_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for txref.
		/// <returns>String</returns>
		/// </summary>
		public String GetTransactionReference()
		{
			return TransactionReference;
		}

		/// <summary>
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
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
		/// Getter for dtstamp.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeStamp()
		{
			return DateTimeStamp;
		}

		/// <summary>
		/// Getter for user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetUserName()
		{
			return UserName;
		}
	}
}
