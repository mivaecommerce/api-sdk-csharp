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
	public class OrderItemAttribute : Model
	{
		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property OptionCodeOrData - String</value>
		[JsonPropertyName("opt_code_or_data")]
		public String OptionCodeOrData { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float Price { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float Weight { get; set; }

		/// <summary>
		/// Getter for attr_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeCode()
		{
			return AttributeCode;
		}

		/// <summary>
		/// Getter for opt_code_or_data.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCodeOrData()
		{
			return OptionCodeOrData;
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
		/// Getter for weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Setter for attr_code.
		/// <param name="value">String</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
		public OrderItemAttribute SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for opt_code_or_data.
		/// <param name="value">String</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
		public OrderItemAttribute SetOptionCodeOrData(String value)
		{
			OptionCodeOrData = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">float</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetPrice(float value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">double</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetPrice(double value)
	   {
			Price = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}
	}
}
