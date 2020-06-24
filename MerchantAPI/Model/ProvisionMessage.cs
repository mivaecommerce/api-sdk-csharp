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
	public class ProvisionMessage : Model
	{
		/// <value>Property DateTimeStamp - String</value>
		[JsonPropertyName("dtstamp")]
		public String DateTimeStamp { get; set; }

		/// <value>Property LineNumber - int</value>
		[JsonPropertyName("lineno")]
		public int LineNumber { get; set; }

		/// <value>Property Tag - String</value>
		[JsonPropertyName("tag")]
		public String Tag { get; set; }

		/// <value>Property Message - String</value>
		[JsonPropertyName("message")]
		public String Message { get; set; }

		/// <summary>
		/// Getter for dtstamp.
		/// <returns>String</returns>
		/// </summary>
		public String GetDateTimeStamp()
		{
			return DateTimeStamp;
		}

		/// <summary>
		/// Getter for lineno.
		/// <returns>int</returns>
		/// </summary>
		public int GetLineNumber()
		{
			return LineNumber;
		}

		/// <summary>
		/// Getter for tag.
		/// <returns>String</returns>
		/// </summary>
		public String GetTag()
		{
			return Tag;
		}

		/// <summary>
		/// Getter for message.
		/// <returns>String</returns>
		/// </summary>
		public String GetMessage()
		{
			return Message;
		}
	}
}
