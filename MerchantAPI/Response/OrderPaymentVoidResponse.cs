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
	/// API Response for OrderPayment_VOID.
	/// <see>https://docs.miva.com/json-api/functions/orderpayment_void</see>
	/// </summary>
	public class OrderPaymentVoidResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public OrderPaymentTotal Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderPaymentVoidResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderPaymentTotal.
		/// <returns>OrderPaymentTotal</returns>
		/// </summary>
		public OrderPaymentTotal GetOrderPaymentTotal()
		{
			return Data;
		}
	}
}