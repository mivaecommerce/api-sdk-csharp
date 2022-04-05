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
	public class ProductSubscriptionTermDate : Model
	{
		/// <value>Property SubscriptionTermId - int</value>
		[JsonPropertyName("subterm_id")]
		public int SubscriptionTermId { get; set; }

		/// <value>Property TermDayOfMonth - int</value>
		[JsonPropertyName("term_dom")]
		public int TermDayOfMonth { get; set; }

		/// <value>Property TermMonth - int</value>
		[JsonPropertyName("term_mon")]
		public int TermMonth { get; set; }

		/// <summary>
		/// Getter for subterm_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionTermId()
		{
			return SubscriptionTermId;
		}

		/// <summary>
		/// Getter for term_dom.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermDayOfMonth()
		{
			return TermDayOfMonth;
		}

		/// <summary>
		/// Getter for term_mon.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermMonth()
		{
			return TermMonth;
		}
	}
}
