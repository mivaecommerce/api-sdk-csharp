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
	public class OrderTotalAndItem : OrderTotal
	{
		/// <value>Property OrderItem - OrderItem</value>
		[JsonPropertyName("orderitem")]
		public OrderItem OrderItem { get; set; }

		/// <summary>
		/// Getter for orderitem.
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem GetOrderItem()
		{
			return OrderItem;
		}
	}
}
