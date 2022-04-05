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
	public class ChangesetTemplateVersion : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplateId { get; set; }

		/// <value>Property ParentId - int</value>
		[JsonPropertyName("parent_id")]
		public int ParentId { get; set; }

		/// <value>Property ItemId - int</value>
		[JsonPropertyName("item_id")]
		public int ItemId { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property UserName - String</value>
		[JsonPropertyName("user_name")]
		public String UserName { get; set; }

		/// <value>Property UserIcon - String</value>
		[JsonPropertyName("user_icon")]
		public String UserIcon { get; set; }

		/// <value>Property PropertyId - int</value>
		[JsonPropertyName("prop_id")]
		public int PropertyId { get; set; }

		/// <value>Property Sync - bool</value>
		[JsonPropertyName("sync")]
		public bool Sync { get; set; }

		/// <value>Property Filename - String</value>
		[JsonPropertyName("filename")]
		public String Filename { get; set; }

		/// <value>Property DateTimeStamp - int</value>
		[JsonPropertyName("dtstamp")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStamp { get; set; }

		/// <value>Property Notes - String</value>
		[JsonPropertyName("notes")]
		public String Notes { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("source")]
		public String Source { get; set; }

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
		/// Getter for templ_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTemplateId()
		{
			return TemplateId;
		}

		/// <summary>
		/// Getter for parent_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetParentId()
		{
			return ParentId;
		}

		/// <summary>
		/// Getter for item_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetItemId()
		{
			return ItemId;
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
		/// Getter for prop_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPropertyId()
		{
			return PropertyId;
		}

		/// <summary>
		/// Getter for sync.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetSync()
		{
			return Sync;
		}

		/// <summary>
		/// Getter for filename.
		/// <returns>String</returns>
		/// </summary>
		public String GetFilename()
		{
			return Filename;
		}

		/// <summary>
		/// Getter for dtstamp.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeStamp()
		{
			return DateTimeStamp;
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
	}
}
