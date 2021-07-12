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
	/// API Response for OrderList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/orderlist_load_query</see>
	/// </summary>
	public class OrderListLoadQueryResponse : ListQueryResponse<Order>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public OrderListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for orders.
		/// <returns>Order[]</returns>
		/// </summary>
		public List<Order> GetOrders()
		{
			return Data.Data;
		}
	}
}