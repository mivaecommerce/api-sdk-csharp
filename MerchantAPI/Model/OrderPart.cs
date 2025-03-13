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
	public class OrderPart : Model
	{
		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Sku - String</value>
		[JsonPropertyName("sku")]
		public String Sku { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <value>Property TotalQuantity - int</value>
		[JsonPropertyName("total_quantity")]
		public int TotalQuantity { get; set; }

		/// <value>Property Price - decimal</value>
		[JsonPropertyName("price")]
		public decimal Price { get; set; }

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
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
		/// Getter for quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for total_quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetTotalQuantity()
		{
			return TotalQuantity;
		}

		/// <summary>
		/// Getter for price.
		/// <returns>decimal</returns>
		/// </summary>
		public decimal GetPrice()
		{
			return Price;
		}
	}
}
