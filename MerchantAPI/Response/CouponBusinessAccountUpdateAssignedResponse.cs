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
	/// API Response for CouponBusinessAccount_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/couponbusinessaccount_update_assigned</see>
	/// </summary>
	public class CouponBusinessAccountUpdateAssignedResponse : Response
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CouponBusinessAccountUpdateAssignedResponse() :
			base()
		{
		}
	}
}