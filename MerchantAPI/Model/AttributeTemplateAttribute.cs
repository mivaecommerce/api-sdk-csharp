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
	public class AttributeTemplateAttribute : Model
	{
		/// Enumeration TemplateAttributeType
		public enum TemplateAttributeType
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
		public static String TemplateAttributeTypeToString(TemplateAttributeType value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static TemplateAttributeType? TemplateAttributeTypeFromString(String value)
		{
			switch(value)
			{
				case "checkbox": return TemplateAttributeType.Checkbox;
				case "radio": return TemplateAttributeType.Radio;
				case "text": return TemplateAttributeType.Text;
				case "select": return TemplateAttributeType.Select;
				case "memo": return TemplateAttributeType.Memo;
				case "template": return TemplateAttributeType.Template;
				case "swatch-select": return TemplateAttributeType.SwatchSelect;
				default: return null;
			}
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property AttributeTemplateId - int</value>
		[JsonPropertyName("attemp_id")]
		public int AttributeTemplateId { get; set; }

		/// <value>Property DefaultId - int</value>
		[JsonPropertyName("default_id")]
		public int DefaultId { get; set; }

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

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

		/// <value>Property Cost - decimal</value>
		[JsonPropertyName("cost")]
		public decimal Cost { get; set; }

		/// <value>Property Weight - decimal</value>
		[JsonPropertyName("weight")]
		public decimal Weight { get; set; }

		/// <value>Property FormattedPrice - String</value>
		[JsonPropertyName("formatted_price")]
		public String FormattedPrice { get; set; }

		/// <value>Property FormattedCost - String</value>
		[JsonPropertyName("formatted_cost")]
		public String FormattedCost { get; set; }

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

		/// <value>Property Options - List<AttributeTemplateOption></value>
		[JsonPropertyName("options")]
		public List<AttributeTemplateOption> Options { get; set; } = new List<AttributeTemplateOption>();

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// <returns>TemplateAttributeType?</returns>
		/// </summary>
		public TemplateAttributeType? GetAttributeTypeConst()
		{
			return TemplateAttributeTypeFromString(AttributeType);
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
		/// Getter for cost.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal GetCost()
		{
			return Cost;
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
		/// Getter for formatted_price.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedPrice()
		{
			return FormattedPrice;
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
		/// Getter for options.
		/// <returns>List<AttributeTemplateOption></returns>
		/// </summary>
		public List<AttributeTemplateOption> GetOptions()
		{
			return Options;
		}
	}

	/// Enum Extensions
	public static class AttributeTemplateAttributeExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this AttributeTemplateAttribute.TemplateAttributeType e)
	    {
			switch(e)
			{
				case AttributeTemplateAttribute.TemplateAttributeType.Checkbox: return "checkbox";
				case AttributeTemplateAttribute.TemplateAttributeType.Radio: return "radio";
				case AttributeTemplateAttribute.TemplateAttributeType.Text: return "text";
				case AttributeTemplateAttribute.TemplateAttributeType.Select: return "select";
				case AttributeTemplateAttribute.TemplateAttributeType.Memo: return "memo";
				case AttributeTemplateAttribute.TemplateAttributeType.Template: return "template";
				case AttributeTemplateAttribute.TemplateAttributeType.SwatchSelect: return "swatch-select";
			}
			return "";
		}
	}
}
