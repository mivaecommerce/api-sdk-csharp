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
	/// API Response for SubscriptionAndOrderItem_Add.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionandorderitem_add</see>
	/// </summary>
	public class SubscriptionAndOrderItemAddResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public OrderTotalAndItem Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public SubscriptionAndOrderItemAddResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderTotalAndItem.
		/// <returns>OrderTotalAndItem</returns>
		/// </summary>
		public OrderTotalAndItem GetOrderTotalAndItem()
		{
			return Data;
		}
	}
}