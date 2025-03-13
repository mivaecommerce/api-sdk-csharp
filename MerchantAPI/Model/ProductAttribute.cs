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
		/// Enumeration ProductAttributeType
		public enum ProductAttributeType
		{
			Checkbox,
			Radio,
			Text,
			Select,
			Memo,
			Template,
			SwatchSelect,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String ProductAttributeTypeToString(ProductAttributeType value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static ProductAttributeType? ProductAttributeTypeFromString(String value)
		{
			switch(value)
			{
				case "checkbox": return ProductAttributeType.Checkbox;
				case "radio": return ProductAttributeType.Radio;
				case "text": return ProductAttributeType.Text;
				case "select": return ProductAttributeType.Select;
				case "memo": return ProductAttributeType.Memo;
				case "template": return ProductAttributeType.Template;
				case "swatch-select": return ProductAttributeType.SwatchSelect;
				default: return null;
			}
		}

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

		/// <value>Property Price - decimal</value>
		[JsonPropertyName("price")]
		public decimal Price { get; set; }

		/// <value>Property FormattedPrice - String</value>
		[JsonPropertyName("formatted_price")]
		public String FormattedPrice { get; set; }

		/// <value>Property Cost - decimal</value>
		[JsonPropertyName("cost")]
		public decimal Cost { get; set; }

		/// <value>Property FormattedCost - String</value>
		[JsonPropertyName("formatted_cost")]
		public String FormattedCost { get; set; }

		/// <value>Property Weight - decimal</value>
		[JsonPropertyName("weight")]
		public decimal Weight { get; set; }

		/// <value>Property FormattedWeight - String</value>
		[JsonPropertyName("formatted_weight")]
		public String FormattedWeight { get; set; }

		/// <value>Property Required - bool</value>
		[JsonPropertyName("required")]
		public bool Required { get; set; }

		/// <value>Property Inventory - bool</value>
		[JsonPropertyName("inventory")]
		public bool Inventory { get; set; }

		/// <value>Property Image - String</value>
		[JsonPropertyName("image")]
		public String Image { get; set; }

		/// <value>Property TemplateAttributes - List<ProductAttribute></value>
		[JsonPropertyName("attributes")]
		public List<ProductAttribute> TemplateAttributes { get; set; } = new List<ProductAttribute>();

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
		/// Enum Getter for type.
		/// <returns>ProductAttributeType?</returns>
		/// </summary>
		public ProductAttributeType? GetAttributeTypeConst()
		{
			return ProductAttributeTypeFromString(AttributeType);
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
		/// <returns>decimal</returns>
		/// </summary>
		public decimal GetPrice()
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

		/// <summary>
		/// Getter for cost.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Getter for formatted_cost.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedCost()
		{
			return FormattedCost;
		}

		/// <summary>
		/// Getter for weight.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Getter for formatted_weight.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedWeight()
		{
			return FormattedWeight;
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
		/// Getter for attributes.
		/// <returns>List<ProductAttribute></returns>
		/// </summary>
		public List<ProductAttribute> GetTemplateAttributes()
		{
			return TemplateAttributes;
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

	/// Enum Extensions
	public static class ProductAttributeExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this ProductAttribute.ProductAttributeType e)
	    {
			switch(e)
			{
				case ProductAttribute.ProductAttributeType.Checkbox: return "checkbox";
				case ProductAttribute.ProductAttributeType.Radio: return "radio";
				case ProductAttribute.ProductAttributeType.Text: return "text";
				case ProductAttribute.ProductAttributeType.Select: return "select";
				case ProductAttribute.ProductAttributeType.Memo: return "memo";
				case ProductAttribute.ProductAttributeType.Template: return "template";
				case ProductAttribute.ProductAttributeType.SwatchSelect: return "swatch-select";
			}
			return "";
		}
	}
}
