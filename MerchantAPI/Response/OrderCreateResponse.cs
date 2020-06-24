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
	/// API Response for Order_Create.
	/// <see>https://docs.miva.com/json-api/functions/order_create</see>
	/// </summary>
	public class OrderCreateResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Order Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderCreateResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for order.
		/// <returns>Order</returns>
		/// </summary>
		public Order GetOrder()
		{
			return Data;
		}
	}
}