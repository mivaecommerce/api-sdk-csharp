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
	public class CopyPageRule : Model
	{
		/// Enumeration PageRuleSettings
		public enum PageRuleSettings
		{
			All,
			None,
			Specific,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String PageRuleSettingsToString(PageRuleSettings value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static PageRuleSettings? PageRuleSettingsFromString(String value)
		{
			switch(value)
			{
				case "all": return PageRuleSettings.All;
				case "none": return PageRuleSettings.None;
				case "specific": return PageRuleSettings.Specific;
				default: return null;
			}
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Secure - bool</value>
		[JsonPropertyName("secure")]
		public bool Secure { get; set; }

		/// <value>Property Title - bool</value>
		[JsonPropertyName("title")]
		public bool Title { get; set; }

		/// <value>Property Template - bool</value>
		[JsonPropertyName("template")]
		public bool Template { get; set; }

		/// <value>Property Items - bool</value>
		[JsonPropertyName("items")]
		public bool Items { get; set; }

		/// <value>Property Settings - String</value>
		[JsonPropertyName("settings")]
		public String Settings { get; set; }

		/// <value>Property JavascriptResourceAssignments - bool</value>
		[JsonPropertyName("jsres")]
		public bool JavascriptResourceAssignments { get; set; }

		/// <value>Property CSSResourceAssignments - bool</value>
		[JsonPropertyName("cssres")]
		public bool CSSResourceAssignments { get; set; }

		/// <value>Property CacheSettings - bool</value>
		[JsonPropertyName("cacheset")]
		public bool CacheSettings { get; set; }

		/// <value>Property Public - bool</value>
		[JsonPropertyName("public")]
		public bool Public { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for secure.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetSecure()
		{
			return Secure;
		}

		/// <summary>
		/// Getter for title.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTitle()
		{
			return Title;
		}

		/// <summary>
		/// Getter for template.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTemplate()
		{
			return Template;
		}

		/// <summary>
		/// Getter for items.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetItems()
		{
			return Items;
		}

		/// <summary>
		/// Getter for settings.
		/// <returns>String</returns>
		/// </summary>
		public String GetSettings()
		{
			return Settings;
		}

		/// <summary>
		/// Getter for jsres.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetJavascriptResourceAssignments()
		{
			return JavascriptResourceAssignments;
		}

		/// <summary>
		/// Getter for cssres.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCSSResourceAssignments()
		{
			return CSSResourceAssignments;
		}

		/// <summary>
		/// Getter for cacheset.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCacheSettings()
		{
			return CacheSettings;
		}

		/// <summary>
		/// Getter for public.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetPublic()
		{
			return Public;
		}
	}

	/// Enum Extensions
	public static class CopyPageRuleExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this CopyPageRule.PageRuleSettings e)
	    {
			switch(e)
			{
				case CopyPageRule.PageRuleSettings.All: return "all";
				case CopyPageRule.PageRuleSettings.None: return "none";
				case CopyPageRule.PageRuleSettings.Specific: return "specific";
			}
			return "";
		}
	}
}
