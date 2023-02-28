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
	public class ProductKit : Model
	{
		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int AttributeId { get; set; }

		/// <value>Property AttributeType - String</value>
		[JsonPropertyName("attr_type")]
		public String AttributeType { get; set; }

		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property AttributePrompt - String</value>
		[JsonPropertyName("attr_prompt")]
		public String AttributePrompt { get; set; }

		/// <value>Property AttributeTemplateAttributeId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int AttributeTemplateAttributeId { get; set; }

		/// <value>Property OptionId - int</value>
		[JsonPropertyName("option_id")]
		public int OptionId { get; set; }

		/// <value>Property OptionCode - String</value>
		[JsonPropertyName("option_code")]
		public String OptionCode { get; set; }

		/// <value>Property OptionPrompt - String</value>
		[JsonPropertyName("option_prompt")]
		public String OptionPrompt { get; set; }

		/// <value>Property OptionDisplayOrder - int</value>
		[JsonPropertyName("option_disp_order")]
		public int OptionDisplayOrder { get; set; }

		/// <value>Property Parts - List<ProductKitPart></value>
		[JsonPropertyName("parts")]
		public List<ProductKitPart> Parts { get; set; } = new List<ProductKitPart>();

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for attr_type.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeType()
		{
			return AttributeType;
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
		/// Getter for attr_prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributePrompt()
		{
			return AttributePrompt;
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

		/// <summary>
		/// Getter for option_prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionPrompt()
		{
			return OptionPrompt;
		}

		/// <summary>
		/// Getter for option_disp_order.
		/// <returns>int</returns>
		/// </summary>
		public int GetOptionDisplayOrder()
		{
			return OptionDisplayOrder;
		}

		/// <summary>
		/// Getter for parts.
		/// <returns>List<ProductKitPart></returns>
		/// </summary>
		public List<ProductKitPart> GetParts()
		{
			return Parts;
		}
	}
}
