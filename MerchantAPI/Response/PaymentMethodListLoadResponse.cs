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
	/// API Response for PaymentMethodList_Load.
	/// <see>https://docs.miva.com/json-api/functions/paymentmethodlist_load</see>
	/// </summary>
	public class PaymentMethodListLoadResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<PaymentMethod> Data { get; set; } = new List<PaymentMethod>();

		/// <summary>
		///  Constructor
		/// </summary>
		public PaymentMethodListLoadResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for paymentMethods.
		/// <returns>PaymentMethod[]</returns>
		/// </summary>
		public List<PaymentMethod> GetPaymentMethods()
		{
			return Data;
		}
	}
}