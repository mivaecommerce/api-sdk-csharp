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
	/// API Response for CouponCustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/couponcustomerlist_load_query</see>
	/// </summary>
	public class CouponCustomerListLoadQueryResponse : ListQueryResponse<CouponCustomer>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CouponCustomerListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for couponCustomers.
		/// <returns>CouponCustomer[]</returns>
		/// </summary>
		public List<CouponCustomer> GetCouponCustomers()
		{
			return Data.Data;
		}
	}
}