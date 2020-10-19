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
	}
}
