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
		[JsonPropertyName("data")]
		public DataFields Data { get; set; }

		/// Non model data container containing the response fields in the data propery
		public struct DataFields
		{
			/// Response field id.
			[JsonPropertyName("id")]
			public int Id { get; set; }
		}

		/// <summary>
		///  Constructor
		/// </summary>
		public CouponInsertResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Data.Id;
		}
	}
}