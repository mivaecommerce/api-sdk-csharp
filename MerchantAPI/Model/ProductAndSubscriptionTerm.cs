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
	public class ProductAndSubscriptionTerm : Product
	{
		/// <value>Property TermId - int</value>
		[JsonPropertyName("term_id")]
		public int TermId { get; set; }

		/// <value>Property TermFrequency - String</value>
		[JsonPropertyName("term_frequency")]
		public String TermFrequency { get; set; }

		/// <value>Property TermTerm - int</value>
		[JsonPropertyName("term_term")]
		public int TermTerm { get; set; }

		/// <value>Property TermDescription - String</value>
		[JsonPropertyName("term_descrip")]
		public String TermDescription { get; set; }

		/// <value>Property TermN - int</value>
		[JsonPropertyName("term_n")]
		public int TermN { get; set; }

		/// <value>Property TermFixedDayOfWeek - int</value>
		[JsonPropertyName("term_fixed_dow")]
		public int TermFixedDayOfWeek { get; set; }

		/// <value>Property TermFixedDayOfMonth - int</value>
		[JsonPropertyName("term_fixed_dom")]
		public int TermFixedDayOfMonth { get; set; }

		/// <value>Property TermSubscriptionCount - int</value>
		[JsonPropertyName("term_sub_count")]
		public int TermSubscriptionCount { get; set; }

		/// <summary>
		/// Getter for term_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermId()
		{
			return TermId;
		}

		/// <summary>
		/// Getter for term_frequency.
		/// <returns>String</returns>
		/// </summary>
		public String GetTermFrequency()
		{
			return TermFrequency;
		}

		/// <summary>
		/// Getter for term_term.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermTerm()
		{
			return TermTerm;
		}

		/// <summary>
		/// Getter for term_descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetTermDescription()
		{
			return TermDescription;
		}

		/// <summary>
		/// Getter for term_n.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermN()
		{
			return TermN;
		}

		/// <summary>
		/// Getter for term_fixed_dow.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermFixedDayOfWeek()
		{
			return TermFixedDayOfWeek;
		}

		/// <summary>
		/// Getter for term_fixed_dom.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermFixedDayOfMonth()
		{
			return TermFixedDayOfMonth;
		}

		/// <summary>
		/// Getter for term_sub_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermSubscriptionCount()
		{
			return TermSubscriptionCount;
		}
	}
}
