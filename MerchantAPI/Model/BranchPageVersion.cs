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
	public class BranchPageVersion : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property PageId - int</value>
		[JsonPropertyName("page_id")]
		public int PageId { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property UserName - String</value>
		[JsonPropertyName("user_name")]
		public String UserName { get; set; }

		/// <value>Property UserIcon - String</value>
		[JsonPropertyName("user_icon")]
		public String UserIcon { get; set; }

		/// <value>Property Admin - bool</value>
		[JsonPropertyName("admin")]
		public bool Admin { get; set; }

		/// <value>Property Layout - bool</value>
		[JsonPropertyName("layout")]
		public bool Layout { get; set; }

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

		/// <value>Property TemplId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplId { get; set; }

		/// <value>Property Cache - String</value>
		[JsonPropertyName("cache")]
		public String Cache { get; set; }

		/// <value>Property Notes - String</value>
		[JsonPropertyName("notes")]
		public String Notes { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("source")]
		public String Source { get; set; }

		/// <value>Property SourceUserId - int</value>
		[JsonPropertyName("source_user_id")]
		public int SourceUserId { get; set; }

		/// <value>Property SourceUserName - String</value>
		[JsonPropertyName("source_user_name")]
		public String SourceUserName { get; set; }

		/// <value>Property SourceUserIcon - String</value>
		[JsonPropertyName("source_user_icon")]
		public String SourceUserIcon { get; set; }

		/// <value>Property Settings - VersionSettings</value>
		[JsonPropertyName("settings")]
		public VersionSettings Settings { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for page_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPageId()
		{
			return PageId;
		}

		/// <summary>
		/// Getter for user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUserId()
		{
			return UserId;
		}

		/// <summary>
		/// Getter for user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetUserName()
		{
			return UserName;
		}

		/// <summary>
		/// Getter for user_icon.
		/// <returns>String</returns>
		/// </summary>
		public String GetUserIcon()
		{
			return UserIcon;
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
		public int GetTemplId()
		{
			return TemplId;
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
		/// Getter for source_user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSourceUserId()
		{
			return SourceUserId;
		}

		/// <summary>
		/// Getter for source_user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceUserName()
		{
			return SourceUserName;
		}

		/// <summary>
		/// Getter for source_user_icon.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceUserIcon()
		{
			return SourceUserIcon;
		}

		/// <summary>
		/// Getter for settings.
		/// <returns>VersionSettings</returns>
		/// </summary>
		public VersionSettings GetSettings()
		{
			return Settings;
		}
	}
}
