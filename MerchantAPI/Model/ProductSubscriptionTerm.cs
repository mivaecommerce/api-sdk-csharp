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
	public class ProductSubscriptionTerm : Model
	{
		/// Enumeration TermFrequency
		public enum TermFrequency
		{
			NDays,
			NMonths,
			Daily,
			Weekly,
			Biweekly,
			Quarterly,
			Semiannually,
			Annually,
			FixedWeekly,
			FixedMonthly,
			Dates,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String TermFrequencyToString(TermFrequency value)
		{
			switch(value)
			{
				case TermFrequency.NDays: return "n";
				case TermFrequency.NMonths: return "n_months";
				case TermFrequency.Daily: return "daily";
				case TermFrequency.Weekly: return "weekly";
				case TermFrequency.Biweekly: return "biweekly";
				case TermFrequency.Quarterly: return "quarterly";
				case TermFrequency.Semiannually: return "semiannually";
				case TermFrequency.Annually: return "annually";
				case TermFrequency.FixedWeekly: return "fixedweekly";
				case TermFrequency.FixedMonthly: return "fixedmonthly";
				case TermFrequency.Dates: return "dates";
			}
			return "";
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property Frequency - String</value>
		[JsonPropertyName("frequency")]
		public String Frequency { get; set; }

		/// <value>Property Term - int</value>
		[JsonPropertyName("term")]
		public int Term { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property N - int</value>
		[JsonPropertyName("n")]
		public int N { get; set; }

		/// <value>Property FixedDayOfWeek - int</value>
		[JsonPropertyName("fixed_dow")]
		public int FixedDayOfWeek { get; set; }

		/// <value>Property FixedDayOfMonth - int</value>
		[JsonPropertyName("fixed_dom")]
		public int FixedDayOfMonth { get; set; }

		/// <value>Property SubscriptionCount - int</value>
		[JsonPropertyName("sub_count")]
		public int SubscriptionCount { get; set; }

		/// <value>Property Dates - List<ProductSubscriptionTermDate></value>
		[JsonPropertyName("dates")]
		public List<ProductSubscriptionTermDate> Dates { get; set; } = new List<ProductSubscriptionTermDate>();

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for frequency.
		/// <returns>String</returns>
		/// </summary>
		public String GetFrequency()
		{
			return Frequency;
		}

		/// <summary>
		/// Getter for term.
		/// <returns>int</returns>
		/// </summary>
		public int GetTerm()
		{
			return Term;
		}

		/// <summary>
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for n.
		/// <returns>int</returns>
		/// </summary>
		public int GetN()
		{
			return N;
		}

		/// <summary>
		/// Getter for fixed_dow.
		/// <returns>int</returns>
		/// </summary>
		public int GetFixedDayOfWeek()
		{
			return FixedDayOfWeek;
		}

		/// <summary>
		/// Getter for fixed_dom.
		/// <returns>int</returns>
		/// </summary>
		public int GetFixedDayOfMonth()
		{
			return FixedDayOfMonth;
		}

		/// <summary>
		/// Getter for sub_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionCount()
		{
			return SubscriptionCount;
		}

		/// <summary>
		/// Getter for dates.
		/// <returns>List<ProductSubscriptionTermDate></returns>
		/// </summary>
		public List<ProductSubscriptionTermDate> GetDates()
		{
			return Dates;
		}
	}
}
