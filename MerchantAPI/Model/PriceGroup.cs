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
	public class PriceGroup : Model
	{
		/// Enumeration Eligibility
		public enum Eligibility
		{
			Coupon,
			All,
			Customer,
			LoggedIn,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String EligibilityToString(Eligibility value)
		{
			switch(value)
			{
				case Eligibility.Coupon: return "C";
				case Eligibility.All: return "A";
				case Eligibility.Customer: return "X";
				case Eligibility.LoggedIn: return "L";
			}
			return "";
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property CustomerScope - String</value>
		[JsonPropertyName("custscope")]
		public String CustomerScope { get; set; }

		/// <value>Property Discount - float</value>
		[JsonPropertyName("discount")]
		public float Discount { get; set; }

		/// <value>Property Markup - float</value>
		[JsonPropertyName("markup")]
		public float Markup { get; set; }

		/// <value>Property DateTimeStart - int</value>
		[JsonPropertyName("dt_start")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStart { get; set; }

		/// <value>Property DateTimeEnd - int</value>
		[JsonPropertyName("dt_end")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeEnd { get; set; }

		/// <value>Property MinimumSubtotal - float</value>
		[JsonPropertyName("qmn_subtot")]
		public float MinimumSubtotal { get; set; }

		/// <value>Property MaximumSubtotal - float</value>
		[JsonPropertyName("qmx_subtot")]
		public float MaximumSubtotal { get; set; }

		/// <value>Property MinimumQuantity - int</value>
		[JsonPropertyName("qmn_quan")]
		public int MinimumQuantity { get; set; }

		/// <value>Property MaximumQuantity - int</value>
		[JsonPropertyName("qmx_quan")]
		public int MaximumQuantity { get; set; }

		/// <value>Property MinimumWeight - float</value>
		[JsonPropertyName("qmn_weight")]
		public float MinimumWeight { get; set; }

		/// <value>Property MaximumWeight - float</value>
		[JsonPropertyName("qmx_weight")]
		public float MaximumWeight { get; set; }

		/// <value>Property BasketMinimumSubtotal - float</value>
		[JsonPropertyName("bmn_subtot")]
		public float BasketMinimumSubtotal { get; set; }

		/// <value>Property BasketMaximumSubtotal - float</value>
		[JsonPropertyName("bmx_subtot")]
		public float BasketMaximumSubtotal { get; set; }

		/// <value>Property BasketMinimumQuantity - int</value>
		[JsonPropertyName("bmn_quan")]
		public int BasketMinimumQuantity { get; set; }

		/// <value>Property BasketMaximumQuantity - int</value>
		[JsonPropertyName("bmx_quan")]
		public int BasketMaximumQuantity { get; set; }

		/// <value>Property BasketMinimumWeight - float</value>
		[JsonPropertyName("bmn_weight")]
		public float BasketMinimumWeight { get; set; }

		/// <value>Property BasketMaximumWeight - float</value>
		[JsonPropertyName("bmx_weight")]
		public float BasketMaximumWeight { get; set; }

		/// <value>Property Priority - int</value>
		[JsonPropertyName("priority")]
		public int Priority { get; set; }

		/// <value>Property Module - Module</value>
		[JsonPropertyName("module")]
		public Module Module { get; set; }

		/// <value>Property Capabilities - DiscountModuleCapabilities</value>
		[JsonPropertyName("capabilities")]
		public DiscountModuleCapabilities Capabilities { get; set; }

		/// <value>Property Exclusion - bool</value>
		[JsonPropertyName("exclusion")]
		public bool Exclusion { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property Display - bool</value>
		[JsonPropertyName("display")]
		public bool Display { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
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
		/// Getter for discount.
		/// <returns>float</returns>
		/// </summary>
		public float GetDiscount()
		{
			return Discount;
		}

		/// <summary>
		/// Getter for markup.
		/// <returns>float</returns>
		/// </summary>
		public float GetMarkup()
		{
			return Markup;
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
		/// Getter for qmn_subtot.
		/// <returns>float</returns>
		/// </summary>
		public float GetMinimumSubtotal()
		{
			return MinimumSubtotal;
		}

		/// <summary>
		/// Getter for qmx_subtot.
		/// <returns>float</returns>
		/// </summary>
		public float GetMaximumSubtotal()
		{
			return MaximumSubtotal;
		}

		/// <summary>
		/// Getter for qmn_quan.
		/// <returns>int</returns>
		/// </summary>
		public int GetMinimumQuantity()
		{
			return MinimumQuantity;
		}

		/// <summary>
		/// Getter for qmx_quan.
		/// <returns>int</returns>
		/// </summary>
		public int GetMaximumQuantity()
		{
			return MaximumQuantity;
		}

		/// <summary>
		/// Getter for qmn_weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetMinimumWeight()
		{
			return MinimumWeight;
		}

		/// <summary>
		/// Getter for qmx_weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetMaximumWeight()
		{
			return MaximumWeight;
		}

		/// <summary>
		/// Getter for bmn_subtot.
		/// <returns>float</returns>
		/// </summary>
		public float GetBasketMinimumSubtotal()
		{
			return BasketMinimumSubtotal;
		}

		/// <summary>
		/// Getter for bmx_subtot.
		/// <returns>float</returns>
		/// </summary>
		public float GetBasketMaximumSubtotal()
		{
			return BasketMaximumSubtotal;
		}

		/// <summary>
		/// Getter for bmn_quan.
		/// <returns>int</returns>
		/// </summary>
		public int GetBasketMinimumQuantity()
		{
			return BasketMinimumQuantity;
		}

		/// <summary>
		/// Getter for bmx_quan.
		/// <returns>int</returns>
		/// </summary>
		public int GetBasketMaximumQuantity()
		{
			return BasketMaximumQuantity;
		}

		/// <summary>
		/// Getter for bmn_weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetBasketMinimumWeight()
		{
			return BasketMinimumWeight;
		}

		/// <summary>
		/// Getter for bmx_weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetBasketMaximumWeight()
		{
			return BasketMaximumWeight;
		}

		/// <summary>
		/// Getter for priority.
		/// <returns>int</returns>
		/// </summary>
		public int GetPriority()
		{
			return Priority;
		}

		/// <summary>
		/// Getter for module.
		/// <returns>Module</returns>
		/// </summary>
		public Module GetModule()
		{
			return Module;
		}

		/// <summary>
		/// Getter for capabilities.
		/// <returns>DiscountModuleCapabilities</returns>
		/// </summary>
		public DiscountModuleCapabilities GetCapabilities()
		{
			return Capabilities;
		}

		/// <summary>
		/// Getter for exclusion.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetExclusion()
		{
			return Exclusion;
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
		/// Getter for display.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetDisplay()
		{
			return Display;
		}
	}
}
