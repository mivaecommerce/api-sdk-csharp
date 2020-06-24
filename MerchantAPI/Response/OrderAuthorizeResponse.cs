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
	/// API Response for Order_Authorize.
	/// <see>https://docs.miva.com/json-api/functions/order_authorize</see>
	/// </summary>
	public class OrderAuthorizeResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public OrderPaymentAuthorize Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderAuthorizeResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderPaymentAuthorize.
		/// <returns>OrderPaymentAuthorize</returns>
		/// </summary>
		public OrderPaymentAuthorize GetOrderPaymentAuthorize()
		{
			return Data;
		}
	}
}