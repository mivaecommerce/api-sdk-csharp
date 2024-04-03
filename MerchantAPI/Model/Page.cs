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
	public class Page : Model
	{
		/// Enumeration PageCacheType
		public enum PageCacheType
		{
			Never,
			Provisional,
			Anonempty,
			Allempty,
			Always,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String PageCacheTypeToString(PageCacheType value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static PageCacheType? PageCacheTypeFromString(String value)
		{
			switch(value)
			{
				case "never": return PageCacheType.Never;
				case "provisional": return PageCacheType.Provisional;
				case "anonempty": return PageCacheType.Anonempty;
				case "allempty": return PageCacheType.Allempty;
				case "always": return PageCacheType.Always;
				default: return null;
			}
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Secure - bool</value>
		[JsonPropertyName("secure")]
		public bool Secure { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Title - String</value>
		[JsonPropertyName("title")]
		public String Title { get; set; }

		/// <value>Property UiId - int</value>
		[JsonPropertyName("ui_id")]
		public int UiId { get; set; }

		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplateId { get; set; }

		/// <value>Property Admin - bool</value>
		[JsonPropertyName("admin")]
		public bool Admin { get; set; }

		/// <value>Property Layout - bool</value>
		[JsonPropertyName("layout")]
		public bool Layout { get; set; }

		/// <value>Property Notes - String</value>
		[JsonPropertyName("notes")]
		public String Notes { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("source")]
		public String Source { get; set; }

		/// <value>Property Settings - VersionSettings</value>
		[JsonPropertyName("settings")]
		public VersionSettings Settings { get; set; }

		/// <value>Property Cache - String</value>
		[JsonPropertyName("cache")]
		public String Cache { get; set; }

		/// <value>Property Url - String</value>
		[JsonPropertyName("url")]
		public String Url { get; set; }

		/// <value>Property Uris - List<Uri></value>
		[JsonPropertyName("uris")]
		public List<Uri> Uris { get; set; } = new List<Uri>();

		/// <value>Property CustomFieldValues - CustomFieldValues</value>
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <value>Property VersionId - int</value>
		[JsonPropertyName("version_id")]
		public int VersionId { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
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
		/// Getter for title.
		/// <returns>String</returns>
		/// </summary>
		public String GetTitle()
		{
			return Title;
		}

		/// <summary>
		/// Getter for ui_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUiId()
		{
			return UiId;
		}

		/// <summary>
		/// Getter for templ_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTemplateId()
		{
			return TemplateId;
		}

		/// <summary>
		/// Getter for admin.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAdmin()
		{
			return Admin;
		}

		/// <summary>
		/// Getter for layout.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetLayout()
		{
			return Layout;
		}

		/// <summary>
		/// Getter for notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetNotes()
		{
			return Notes;
		}

		/// <summary>
		/// Getter for source.
		/// <returns>String</returns>
		/// </summary>
		public String GetSource()
		{
			return Source;
		}

		/// <summary>
		/// Getter for settings.
		/// <returns>VersionSettings</returns>
		/// </summary>
		public VersionSettings GetSettings()
		{
			return Settings;
		}

		/// <summary>
		/// Getter for cache.
		/// <returns>String</returns>
		/// </summary>
		public String GetCache()
		{
			return Cache;
		}

		/// <summary>
		/// Enum Getter for cache.
		/// <returns>PageCacheType?</returns>
		/// </summary>
		public PageCacheType? GetCacheConst()
		{
			return PageCacheTypeFromString(Cache);
		}

		/// <summary>
		/// Getter for url.
		/// <returns>String</returns>
		/// </summary>
		public String GetUrl()
		{
			return Url;
		}

		/// <summary>
		/// Getter for uris.
		/// <returns>List<Uri></returns>
		/// </summary>
		public List<Uri> GetUris()
		{
			return Uris;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Getter for version_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetVersionId()
		{
			return VersionId;
		}
	}

	/// Enum Extensions
	public static class PageExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this Page.PageCacheType e)
	    {
			switch(e)
			{
				case Page.PageCacheType.Never: return "never";
				case Page.PageCacheType.Provisional: return "provisional";
				case Page.PageCacheType.Anonempty: return "anonempty";
				case Page.PageCacheType.Allempty: return "allempty";
				case Page.PageCacheType.Always: return "always";
			}
			return "";
		}
	}
}
