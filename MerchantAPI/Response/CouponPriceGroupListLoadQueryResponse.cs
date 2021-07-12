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
	/// API Response for CouponPriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/couponpricegrouplist_load_query</see>
	/// </summary>
	public class CouponPriceGroupListLoadQueryResponse : ListQueryResponse<CouponPriceGroup>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CouponPriceGroupListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for couponPriceGroups.
		/// <returns>CouponPriceGroup[]</returns>
		/// </summary>
		public List<CouponPriceGroup> GetCouponPriceGroups()
		{
			return Data.Data;
		}
	}
}