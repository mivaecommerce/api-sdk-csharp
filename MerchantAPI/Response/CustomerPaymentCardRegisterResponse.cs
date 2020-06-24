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
	/// API Response for CustomerPaymentCard_Register.
	/// <see>https://docs.miva.com/json-api/functions/customerpaymentcard_register</see>
	/// </summary>
	public class CustomerPaymentCardRegisterResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public CustomerPaymentCard Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerPaymentCardRegisterResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customerPaymentCard.
		/// <returns>CustomerPaymentCard</returns>
		/// </summary>
		public CustomerPaymentCard GetCustomerPaymentCard()
		{
			return Data;
		}
	}
}