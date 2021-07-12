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
	/// API Response for OrderCouponList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/ordercouponlist_load_query</see>
	/// </summary>
	public class OrderCouponListLoadQueryResponse : ListQueryResponse<OrderCoupon>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public OrderCouponListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for orderCoupons.
		/// <returns>OrderCoupon[]</returns>
		/// </summary>
		public List<OrderCoupon> GetOrderCoupons()
		{
			return Data.Data;
		}
	}
}