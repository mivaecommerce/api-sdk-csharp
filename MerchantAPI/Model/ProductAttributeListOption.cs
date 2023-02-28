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
	public class ProductAttributeListOption : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int AttributeId { get; set; }

		/// <value>Property AttributeTemplateId - int</value>
		[JsonPropertyName("attemp_id")]
		public int AttributeTemplateId { get; set; }

		/// <value>Property AttributeTemplateAttributeId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int AttributeTemplateAttributeId { get; set; }

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Prompt - String</value>
		[JsonPropertyName("prompt")]
		public String Prompt { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float Price { get; set; }

		/// <value>Property Cost - float</value>
		[JsonPropertyName("cost")]
		public float Cost { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float Weight { get; set; }

		/// <value>Property Image - String</value>
		[JsonPropertyName("image")]
		public String Image { get; set; }

		/// <value>Property DefaultOption - bool</value>
		[JsonPropertyName("default_opt")]
		public bool DefaultOption { get; set; }

		/// <value>Property HasVariantParts - bool</value>
		[JsonPropertyName("has_variant_parts")]
		public bool HasVariantParts { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for attemp_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeTemplateId()
		{
			return AttributeTemplateId;
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
		/// Getter for disp_order.
		/// <returns>int</returns>
		/// </summary>
		public int GetDisplayOrder()
		{
			return DisplayOrder;
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
		/// Getter for prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrompt()
		{
			return Prompt;
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
		/// Getter for cost.
		/// <returns>float</returns>
		/// </summary>
		public float GetCost()
		{
			return Cost;
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
		/// Getter for image.
		/// <returns>String</returns>
		/// </summary>
		public String GetImage()
		{
			return Image;
		}

		/// <summary>
		/// Getter for default_opt.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetDefaultOption()
		{
			return DefaultOption;
		}

		/// <summary>
		/// Getter for has_variant_parts.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetHasVariantParts()
		{
			return HasVariantParts;
		}
	}
}
