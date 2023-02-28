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
	public class ProductVariantAttribute : Model
	{
		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int AttributeId { get; set; }

		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property AttributeTemplateAttributeId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int AttributeTemplateAttributeId { get; set; }

		/// <value>Property OptionId - int</value>
		[JsonPropertyName("option_id")]
		public int OptionId { get; set; }

		/// <value>Property OptionCode - String</value>
		[JsonPropertyName("option_code")]
		public String OptionCode { get; set; }

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeId()
		{
			return AttributeId;
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
		/// Getter for attmpat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeTemplateAttributeId()
		{
			return AttributeTemplateAttributeId;
		}

		/// <summary>
		/// Getter for option_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOptionId()
		{
			return OptionId;
		}

		/// <summary>
		/// Getter for option_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCode()
		{
			return OptionCode;
		}
	}
}
