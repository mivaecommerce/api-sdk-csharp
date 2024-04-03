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
	/// API Response for CouponBusinessAccountList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/couponbusinessaccountlist_load_query</see>
	/// </summary>
	public class CouponBusinessAccountListLoadQueryResponse : ListQueryResponse<CouponBusinessAccount>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CouponBusinessAccountListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for couponBusinessAccounts.
		/// <returns>CouponBusinessAccount[]</returns>
		/// </summary>
		public List<CouponBusinessAccount> GetCouponBusinessAccounts()
		{
			return Data.Data;
		}
	}
}