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
	public class BusinessAccount : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Title - String</value>
		[JsonPropertyName("title")]
		public String Title { get; set; }

		/// <value>Property TaxExempt - bool</value>
		[JsonPropertyName("tax_exempt")]
		public bool TaxExempt { get; set; }

		/// <value>Property OrderCount - int</value>
		[JsonPropertyName("order_cnt")]
		public int OrderCount { get; set; }

		/// <value>Property OrderAverage - float</value>
		[JsonPropertyName("order_avg")]
		public float OrderAverage { get; set; }

		/// <value>Property FormattedOrderAverage - String</value>
		[JsonPropertyName("formatted_order_avg")]
		public String FormattedOrderAverage { get; set; }

		/// <value>Property OrderTotal - float</value>
		[JsonPropertyName("order_tot")]
		public float OrderTotal { get; set; }

		/// <value>Property FormattedOrderTotal - String</value>
		[JsonPropertyName("formatted_order_tot")]
		public String FormattedOrderTotal { get; set; }

		/// <value>Property NoteCount - int</value>
		[JsonPropertyName("note_count")]
		public int NoteCount { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for tax_exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTaxExempt()
		{
			return TaxExempt;
		}

		/// <summary>
		/// Getter for order_cnt.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderCount()
		{
			return OrderCount;
		}

		/// <summary>
		/// Getter for order_avg.
		/// <returns>float</returns>
		/// </summary>
		public float GetOrderAverage()
		{
			return OrderAverage;
		}

		/// <summary>
		/// Getter for formatted_order_avg.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedOrderAverage()
		{
			return FormattedOrderAverage;
		}

		/// <summary>
		/// Getter for order_tot.
		/// <returns>float</returns>
		/// </summary>
		public float GetOrderTotal()
		{
			return OrderTotal;
		}

		/// <summary>
		/// Getter for formatted_order_tot.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedOrderTotal()
		{
			return FormattedOrderTotal;
		}

		/// <summary>
		/// Getter for note_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetNoteCount()
		{
			return NoteCount;
		}
	}
}
