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
			switch(value)
			{
				case PageRuleSettings.All: return "all";
				case PageRuleSettings.None: return "none";
				case PageRuleSettings.Specific: return "specific";
			}
			return "";
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

		/// <value>Property Jsres - bool</value>
		[JsonPropertyName("jsres")]
		public bool Jsres { get; set; }

		/// <value>Property CSSres - bool</value>
		[JsonPropertyName("cssres")]
		public bool CSSres { get; set; }

		/// <value>Property Cacheset - bool</value>
		[JsonPropertyName("cacheset")]
		public bool Cacheset { get; set; }

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
		public bool GetJsres()
		{
			return Jsres;
		}

		/// <summary>
		/// Getter for cssres.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCSSres()
		{
			return CSSres;
		}

		/// <summary>
		/// Getter for cacheset.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCacheset()
		{
			return Cacheset;
		}
	}
}
