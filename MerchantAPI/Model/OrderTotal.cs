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
	public class OrderTotal : Model
	{
		/// <value>Property Total - float</value>
		[JsonPropertyName("total")]
		public float Total { get; set; }

		/// <value>Property FormattedTotal - String</value>
		[JsonPropertyName("formatted_total")]
		public String FormattedTotal { get; set; }

		/// <summary>
		/// Getter for total.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotal()
		{
			return Total;
		}

		/// <summary>
		/// Getter for formatted_total.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotal()
		{
			return FormattedTotal;
		}
	}
}
