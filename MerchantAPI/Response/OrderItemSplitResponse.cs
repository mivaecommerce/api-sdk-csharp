/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// API Response for OrderItem_Split.
	/// <see>https://docs.miva.com/json-api/functions/orderitem_split</see>
	/// </summary>
	public class OrderItemSplitResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public SplitOrderItem Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderItemSplitResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for splitOrderItem.
		/// <returns>SplitOrderItem</returns>
		/// </summary>
		public SplitOrderItem GetSplitOrderItem()
		{
			return Data;
		}
	}
}