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
	public class OrderProductAttribute : Model
	{
		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property TemplateCode - String</value>
		[JsonPropertyName("template_code")]
		public String TemplateCode { get; set; }

		/// <value>Property Value - String</value>
		[JsonPropertyName("value")]
		public String Value { get; set; }

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for template_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetTemplateCode()
		{
			return TemplateCode;
		}

		/// <summary>
		/// Getter for value.
		/// <returns>String</returns>
		/// </summary>
		public String GetValue()
		{
			return Value;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>OrderProductAttribute</returns>
		/// </summary>
		public OrderProductAttribute SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for template_code.
		/// <param name="value">String</param>
		/// <returns>OrderProductAttribute</returns>
		/// </summary>
		public OrderProductAttribute SetTemplateCode(String value)
		{
			TemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for value.
		/// <param name="value">String</param>
		/// <returns>OrderProductAttribute</returns>
		/// </summary>
		public OrderProductAttribute SetValue(String value)
		{
			Value = value;
			return this;
		}
	}
}
