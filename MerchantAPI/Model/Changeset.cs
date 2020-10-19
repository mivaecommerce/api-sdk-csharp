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
	public class Changeset : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property BranchId - int</value>
		[JsonPropertyName("branch_id")]
		public int BranchId { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property DateTimeStamp - int</value>
		[JsonPropertyName("dtstamp")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeStamp { get; set; }

		/// <value>Property Notes - String</value>
		[JsonPropertyName("notes")]
		public String Notes { get; set; }

		/// <value>Property UserName - String</value>
		[JsonPropertyName("user_name")]
		public String UserName { get; set; }

		/// <value>Property UserIcon - String</value>
		[JsonPropertyName("user_icon")]
		public String UserIcon { get; set; }

		/// <value>Property Tags - List<String></value>
		[JsonPropertyName("tags")]
		public List<String> Tags { get; set; } = new List<String>();

		/// <value>Property FormattedTags - String</value>
		[JsonPropertyName("formatted_tags")]
		public String FormattedTags { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for branch_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetBranchId()
		{
			return BranchId;
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
		/// Getter for tags.
		/// <returns>List<String></returns>
		/// </summary>
		public List<String> GetTags()
		{
			return Tags;
		}

		/// <summary>
		/// Getter for formatted_tags.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTags()
		{
			return FormattedTags;
		}
	}
}
