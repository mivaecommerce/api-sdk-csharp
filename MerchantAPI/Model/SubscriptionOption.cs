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
	public class SubscriptionOption : Model
	{
		/// <value>Property SubscriptionId - int</value>
		[JsonPropertyName("subscrp_id")]
		public int SubscriptionId { get; set; }

		/// <value>Property TemplateCode - String</value>
		[JsonPropertyName("templ_code")]
		public String TemplateCode { get; set; }

		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property Value - String</value>
		[JsonPropertyName("value")]
		public String Value { get; set; }

		/// <summary>
		/// Getter for subscrp_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionId()
		{
			return SubscriptionId;
		}

		/// <summary>
		/// Getter for templ_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetTemplateCode()
		{
			return TemplateCode;
		}

		/// <summary>
		/// Getter for attr_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeCode()
		{
			return AttributeCode;
		}

		/// <summary>
		/// Getter for value.
		/// <returns>String</returns>
		/// </summary>
		public String GetValue()
		{
			return Value;
		}
	}
}
