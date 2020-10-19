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
	public class Branch : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Immutable - bool</value>
		[JsonPropertyName("immutable")]
		public bool Immutable { get; set; }

		/// <value>Property BranchKey - String</value>
		[JsonPropertyName("branchkey")]
		public String BranchKey { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Color - String</value>
		[JsonPropertyName("color")]
		public String Color { get; set; }

		/// <value>Property Framework - String</value>
		[JsonPropertyName("framework")]
		public String Framework { get; set; }

		/// <value>Property IsPrimary - bool</value>
		[JsonPropertyName("is_primary")]
		public bool IsPrimary { get; set; }

		/// <value>Property IsWorking - bool</value>
		[JsonPropertyName("is_working")]
		public bool IsWorking { get; set; }

		/// <value>Property PreviewUrl - String</value>
		[JsonPropertyName("preview_url")]
		public String PreviewUrl { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for immutable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetImmutable()
		{
			return Immutable;
		}

		/// <summary>
		/// Getter for branchkey.
		/// <returns>String</returns>
		/// </summary>
		public String GetBranchKey()
		{
			return BranchKey;
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
		/// Getter for color.
		/// <returns>String</returns>
		/// </summary>
		public String GetColor()
		{
			return Color;
		}

		/// <summary>
		/// Getter for framework.
		/// <returns>String</returns>
		/// </summary>
		public String GetFramework()
		{
			return Framework;
		}

		/// <summary>
		/// Getter for is_primary.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetIsPrimary()
		{
			return IsPrimary;
		}

		/// <summary>
		/// Getter for is_working.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetIsWorking()
		{
			return IsWorking;
		}

		/// <summary>
		/// Getter for preview_url.
		/// <returns>String</returns>
		/// </summary>
		public String GetPreviewUrl()
		{
			return PreviewUrl;
		}
	}
}
