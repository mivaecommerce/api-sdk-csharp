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
	/// API Response for Coupon_Insert.
	/// <see>https://docs.miva.com/json-api/functions/coupon_insert</see>
	/// </summary>
	public class CouponInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Coupon Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CouponInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for coupon.
		/// <returns>Coupon</returns>
		/// </summary>
		public Coupon GetCoupon()
		{
			return Data;
		}
	}
}