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
	/// API Response for CustomerCreditHistory_Insert.
	/// <see>https://docs.miva.com/json-api/functions/customercredithistory_insert</see>
	/// </summary>
	public class CustomerCreditHistoryInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public CustomerCreditHistory Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerCreditHistoryInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customerCreditHistory.
		/// <returns>CustomerCreditHistory</returns>
		/// </summary>
		public CustomerCreditHistory GetCustomerCreditHistory()
		{
			return Data;
		}
	}
}