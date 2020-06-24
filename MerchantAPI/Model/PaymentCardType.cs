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
	public class PaymentCardType : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property CardType - String</value>
		[JsonPropertyName("type")]
		public String CardType { get; set; }

		/// <value>Property Prefixes - String</value>
		[JsonPropertyName("prefixes")]
		public String Prefixes { get; set; }

		/// <value>Property Lengths - String</value>
		[JsonPropertyName("lengths")]
		public String Lengths { get; set; }

		/// <value>Property Cvv - bool</value>
		[JsonPropertyName("cvv")]
		public bool Cvv { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetCardType()
		{
			return CardType;
		}

		/// <summary>
		/// Getter for prefixes.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrefixes()
		{
			return Prefixes;
		}

		/// <summary>
		/// Getter for lengths.
		/// <returns>String</returns>
		/// </summary>
		public String GetLengths()
		{
			return Lengths;
		}

		/// <summary>
		/// Getter for cvv.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCvv()
		{
			return Cvv;
		}
	}
}
