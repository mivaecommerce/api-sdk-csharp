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
	public class Coupon : Model
	{
		/// Enumeration CouponCustomerScope
		public enum CouponCustomerScope
		{
			AllShoppers,
			SpecificCustomers,
			AllLoggedIn,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String CouponCustomerScopeToString(CouponCustomerScope value)
		{
			switch(value)
			{
				case CouponCustomerScope.AllShoppers: return "A";
				case CouponCustomerScope.SpecificCustomers: return "X";
				case CouponCustomerScope.AllLoggedIn: return "L";
			}
			return "";
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property CustomerScope - String</value>
		[JsonPropertyName("custscope")]
		public String CustomerScope { get; set; }

		/// <value>Property DateTimeStart - int</value>
		[JsonPropertyName("dt_start")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStart { get; set; }

		/// <value>Property DateTimeEnd - int</value>
		[JsonPropertyName("dt_end")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeEnd { get; set; }

		/// <value>Property MaxUse - int</value>
		[JsonPropertyName("max_use")]
		public int MaxUse { get; set; }

		/// <value>Property MaxPer - int</value>
		[JsonPropertyName("max_per")]
		public int MaxPer { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property UseCount - int</value>
		[JsonPropertyName("use_count")]
		public int UseCount { get; set; }

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
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for custscope.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerScope()
		{
			return CustomerScope;
		}

		/// <summary>
		/// Getter for dt_start.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeStart()
		{
			return DateTimeStart;
		}

		/// <summary>
		/// Getter for dt_end.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeEnd()
		{
			return DateTimeEnd;
		}

		/// <summary>
		/// Getter for max_use.
		/// <returns>int</returns>
		/// </summary>
		public int GetMaxUse()
		{
			return MaxUse;
		}

		/// <summary>
		/// Getter for max_per.
		/// <returns>int</returns>
		/// </summary>
		public int GetMaxPer()
		{
			return MaxPer;
		}

		/// <summary>
		/// Getter for active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetActive()
		{
			return Active;
		}

		/// <summary>
		/// Getter for use_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetUseCount()
		{
			return UseCount;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for descrip.
		/// <param name="value">String</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetDescription(String value)
		{
			Description = value;
			return this;
		}

		/// <summary>
		/// Setter for custscope.
		/// <param name="value">String</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetCustomerScope(String value)
		{
			CustomerScope = value;
			return this;
		}

		/// <summary>
		/// Setter for dt_start.
		/// <param name="value">DateTime</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetDateTimeStart(DateTime value)
		{
			DateTimeStart = value;
			return this;
		}

		/// <summary>
		/// Setter for dt_start.
		/// <param name="value">long</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetDateTimeStart(long value)
		{
			DateTimeStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value));
			return this;
		}

		/// <summary>
		/// Setter for dt_end.
		/// <param name="value">DateTime</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetDateTimeEnd(DateTime value)
		{
			DateTimeEnd = value;
			return this;
		}

		/// <summary>
		/// Setter for dt_end.
		/// <param name="value">long</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetDateTimeEnd(long value)
		{
			DateTimeEnd = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value));
			return this;
		}

		/// <summary>
		/// Setter for max_use.
		/// <param name="value">int</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetMaxUse(int value)
		{
			MaxUse = value;
			return this;
		}

		/// <summary>
		/// Setter for max_per.
		/// <param name="value">int</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetMaxPer(int value)
		{
			MaxPer = value;
			return this;
		}

		/// <summary>
		/// Setter for active.
		/// <param name="value">bool</param>
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon SetActive(bool value)
		{
			Active = value;
			return this;
		}
	}
}
