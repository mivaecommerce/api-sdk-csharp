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
			Monthly,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String TermFrequencyToString(TermFrequency value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static TermFrequency? TermFrequencyFromString(String value)
		{
			switch(value)
			{
				case "n": return TermFrequency.NDays;
				case "n_months": return TermFrequency.NMonths;
				case "daily": return TermFrequency.Daily;
				case "weekly": return TermFrequency.Weekly;
				case "biweekly": return TermFrequency.Biweekly;
				case "quarterly": return TermFrequency.Quarterly;
				case "semiannually": return TermFrequency.Semiannually;
				case "annually": return TermFrequency.Annually;
				case "fixedweekly": return TermFrequency.FixedWeekly;
				case "fixedmonthly": return TermFrequency.FixedMonthly;
				case "dates": return TermFrequency.Dates;
				case "monthly": return TermFrequency.Monthly;
				default: return null;
			}
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

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

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
		/// Enum Getter for frequency.
		/// <returns>TermFrequency?</returns>
		/// </summary>
		public TermFrequency? GetFrequencyConst()
		{
			return TermFrequencyFromString(Frequency);
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

		/// <summary>
		/// Getter for disp_order.
		/// <returns>int</returns>
		/// </summary>
		public int GetDisplayOrder()
		{
			return DisplayOrder;
		}
	}

	/// Enum Extensions
	public static class ProductSubscriptionTermExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this ProductSubscriptionTerm.TermFrequency e)
	    {
			switch(e)
			{
				case ProductSubscriptionTerm.TermFrequency.NDays: return "n";
				case ProductSubscriptionTerm.TermFrequency.NMonths: return "n_months";
				case ProductSubscriptionTerm.TermFrequency.Daily: return "daily";
				case ProductSubscriptionTerm.TermFrequency.Weekly: return "weekly";
				case ProductSubscriptionTerm.TermFrequency.Biweekly: return "biweekly";
				case ProductSubscriptionTerm.TermFrequency.Quarterly: return "quarterly";
				case ProductSubscriptionTerm.TermFrequency.Semiannually: return "semiannually";
				case ProductSubscriptionTerm.TermFrequency.Annually: return "annually";
				case ProductSubscriptionTerm.TermFrequency.FixedWeekly: return "fixedweekly";
				case ProductSubscriptionTerm.TermFrequency.FixedMonthly: return "fixedmonthly";
				case ProductSubscriptionTerm.TermFrequency.Dates: return "dates";
				case ProductSubscriptionTerm.TermFrequency.Monthly: return "monthly";
			}
			return "";
		}
	}
}
