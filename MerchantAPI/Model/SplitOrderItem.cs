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
	public class SplitOrderItem : Model
	{
		/// <value>Property OriginalItem - OrderItem</value>
		[JsonPropertyName("original_orderitem")]
		public OrderItem OriginalItem { get; set; }

		/// <value>Property SplitItem - OrderItem</value>
		[JsonPropertyName("split_orderitem")]
		public OrderItem SplitItem { get; set; }

		/// <summary>
		/// Getter for original_orderitem.
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem GetOriginalItem()
		{
			return OriginalItem;
		}

		/// <summary>
		/// Getter for split_orderitem.
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem GetSplitItem()
		{
			return SplitItem;
		}
	}
}
