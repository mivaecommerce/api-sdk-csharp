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
	public class ProductVariantExclusion : Model
	{
		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int AttributeId { get; set; }

		/// <value>Property AttributeTemplateId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int AttributeTemplateId { get; set; }

		/// <value>Property OptionId - int</value>
		[JsonPropertyName("option_id")]
		public int OptionId { get; set; }

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for attmpat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeTemplateId()
		{
			return AttributeTemplateId;
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
		/// Setter for attr_id.
		/// <param name="value">int</param>
		/// <returns>ProductVariantExclusion</returns>
		/// </summary>
		public ProductVariantExclusion SetAttributeId(int value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for attmpat_id.
		/// <param name="value">int</param>
		/// <returns>ProductVariantExclusion</returns>
		/// </summary>
		public ProductVariantExclusion SetAttributeTemplateId(int value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for option_id.
		/// <param name="value">int</param>
		/// <returns>ProductVariantExclusion</returns>
		/// </summary>
		public ProductVariantExclusion SetOptionId(int value)
		{
			OptionId = value;
			return this;
		}
	}
}
