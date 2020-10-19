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
	public class MerchantVersion : Model
	{
		/// <value>Property Version - String</value>
		[JsonPropertyName("version")]
		public String Version { get; set; }

		/// <value>Property Major - int</value>
		[JsonPropertyName("major")]
		public int Major { get; set; }

		/// <value>Property Minor - int</value>
		[JsonPropertyName("minor")]
		public int Minor { get; set; }

		/// <value>Property Bugfix - int</value>
		[JsonPropertyName("bugfix")]
		public int Bugfix { get; set; }

		/// <summary>
		/// Getter for version.
		/// <returns>String</returns>
		/// </summary>
		public String GetVersion()
		{
			return Version;
		}

		/// <summary>
		/// Getter for major.
		/// <returns>int</returns>
		/// </summary>
		public int GetMajor()
		{
			return Major;
		}

		/// <summary>
		/// Getter for minor.
		/// <returns>int</returns>
		/// </summary>
		public int GetMinor()
		{
			return Minor;
		}

		/// <summary>
		/// Getter for bugfix.
		/// <returns>int</returns>
		/// </summary>
		public int GetBugfix()
		{
			return Bugfix;
		}
	}
}
