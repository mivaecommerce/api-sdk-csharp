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
	}
}
