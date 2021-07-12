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
	/// API Response for CouponList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/couponlist_load_query</see>
	/// </summary>
	public class CouponListLoadQueryResponse : ListQueryResponse<Coupon>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CouponListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for coupons.
		/// <returns>Coupon[]</returns>
		/// </summary>
		public List<Coupon> GetCoupons()
		{
			return Data.Data;
		}
	}
}