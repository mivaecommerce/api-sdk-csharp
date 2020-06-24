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
	/// API Response for Customer_Insert.
	/// <see>https://docs.miva.com/json-api/functions/customer_insert</see>
	/// </summary>
	public class CustomerInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Customer Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customer.
		/// <returns>Customer</returns>
		/// </summary>
		public Customer GetCustomer()
		{
			return Data;
		}
	}
}