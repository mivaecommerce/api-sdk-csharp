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
	public class DiscountModuleCapabilities : Model
	{
		/// <value>Property Preitems - bool</value>
		[JsonPropertyName("preitems")]
		public bool Preitems { get; set; }

		/// <value>Property Items - bool</value>
		[JsonPropertyName("items")]
		public bool Items { get; set; }

		/// <value>Property Eligibility - String</value>
		[JsonPropertyName("eligibility")]
		public String Eligibility { get; set; }

		/// <value>Property Basket - bool</value>
		[JsonPropertyName("basket")]
		public bool Basket { get; set; }

		/// <value>Property Shipping - bool</value>
		[JsonPropertyName("shipping")]
		public bool Shipping { get; set; }

		/// <value>Property Qualifying - bool</value>
		[JsonPropertyName("qualifying")]
		public bool Qualifying { get; set; }

		/// <summary>
		/// Getter for preitems.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetPreitems()
		{
			return Preitems;
		}

		/// <summary>
		/// Getter for items.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetItems()
		{
			return Items;
		}

		/// <summary>
		/// Getter for eligibility.
		/// <returns>String</returns>
		/// </summary>
		public String GetEligibility()
		{
			return Eligibility;
		}

		/// <summary>
		/// Getter for basket.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetBasket()
		{
			return Basket;
		}

		/// <summary>
		/// Getter for shipping.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetShipping()
		{
			return Shipping;
		}

		/// <summary>
		/// Getter for qualifying.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetQualifying()
		{
			return Qualifying;
		}
	}
}
