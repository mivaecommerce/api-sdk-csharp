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
	/// API Response for SubscriptionAndOrderItem_Update.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionandorderitem_update</see>
	/// </summary>
	public class SubscriptionAndOrderItemUpdateResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public OrderTotal Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public SubscriptionAndOrderItemUpdateResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderTotal.
		/// <returns>OrderTotal</returns>
		/// </summary>
		public OrderTotal GetOrderTotal()
		{
			return Data;
		}
	}
}