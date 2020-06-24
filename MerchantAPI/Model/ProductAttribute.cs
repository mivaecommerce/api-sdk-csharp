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
	public class ProductAttribute : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property DefaultId - int</value>
		[JsonPropertyName("default_id")]
		public int DefaultId { get; set; }

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

		/// <value>Property AttributeTemplateId - int</value>
		[JsonPropertyName("attemp_id")]
		public int AttributeTemplateId { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property AttributeType - String</value>
		[JsonPropertyName("type")]
		public String AttributeType { get; set; }

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

		/// <value>Property Required - bool</value>
		[JsonPropertyName("required")]
		public bool Required { get; set; }

		/// <value>Property Inventory - bool</value>
		[JsonPropertyName("inventory")]
		public bool Inventory { get; set; }

		/// <value>Property Image - String</value>
		[JsonPropertyName("image")]
		public String Image { get; set; }

		/// <value>Property Options - List<ProductOption></value>
		[JsonPropertyName("options")]
		public List<ProductOption> Options { get; set; } = new List<ProductOption>();

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
		/// Getter for default_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetDefaultId()
		{
			return DefaultId;
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
		/// Getter for attemp_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeTemplateId()
		{
			return AttributeTemplateId;
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
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeType()
		{
			return AttributeType;
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
		/// Getter for required.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetRequired()
		{
			return Required;
		}

		/// <summary>
		/// Getter for inventory.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetInventory()
		{
			return Inventory;
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
		/// Getter for options.
		/// <returns>List<ProductOption></returns>
		/// </summary>
		public List<ProductOption> GetOptions()
		{
			return Options;
		}
	}
}
