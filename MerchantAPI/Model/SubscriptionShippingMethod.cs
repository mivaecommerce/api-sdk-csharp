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
	public class SubscriptionShippingMethod : Model
	{
		/// <value>Property Module - Module</value>
		[JsonPropertyName("module")]
		public Module Module { get; set; }

		/// <value>Property MethodCode - String</value>
		[JsonPropertyName("method_code")]
		public String MethodCode { get; set; }

		/// <value>Property MethodName - String</value>
		[JsonPropertyName("method_name")]
		public String MethodName { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float Price { get; set; }

		/// <value>Property FormattedPrice - String</value>
		[JsonPropertyName("formatted_price")]
		public String FormattedPrice { get; set; }

		/// <summary>
		/// Getter for module.
		/// <returns>Module</returns>
		/// </summary>
		public Module GetModule()
		{
			return Module;
		}

		/// <summary>
		/// Getter for method_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodCode()
		{
			return MethodCode;
		}

		/// <summary>
		/// Getter for method_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodName()
		{
			return MethodName;
		}

		/// <summary>
		/// Getter for price.
		/// <returns>float</returns>
		/// </summary>
		public float GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for formatted_price.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedPrice()
		{
			return FormattedPrice;
		}
	}
}
