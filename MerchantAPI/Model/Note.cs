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
	public class Note : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property CustomerId - int</value>
		[JsonPropertyName("cust_id")]
		public int CustomerId { get; set; }

		/// <value>Property AccountId - int</value>
		[JsonPropertyName("account_id")]
		public int AccountId { get; set; }

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property NoteText - String</value>
		[JsonPropertyName("notetext")]
		public String NoteText { get; set; }

		/// <value>Property DateTimeStamp - int</value>
		[JsonPropertyName("dtstamp")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStamp { get; set; }

		/// <value>Property CustomerLogin - String</value>
		[JsonPropertyName("cust_login")]
		public String CustomerLogin { get; set; }

		/// <value>Property BusinessTitle - String</value>
		[JsonPropertyName("business_title")]
		public String BusinessTitle { get; set; }

		/// <value>Property AdminUser - String</value>
		[JsonPropertyName("admin_user")]
		public String AdminUser { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for account_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAccountId()
		{
			return AccountId;
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
		/// Getter for user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUserId()
		{
			return UserId;
		}

		/// <summary>
		/// Getter for notetext.
		/// <returns>String</returns>
		/// </summary>
		public String GetNoteText()
		{
			return NoteText;
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
		/// Getter for cust_login.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerLogin()
		{
			return CustomerLogin;
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
		/// Getter for admin_user.
		/// <returns>String</returns>
		/// </summary>
		public String GetAdminUser()
		{
			return AdminUser;
		}
	}
}
