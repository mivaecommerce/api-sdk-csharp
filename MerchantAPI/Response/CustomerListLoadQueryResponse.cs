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
	/// API Response for CustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customerlist_load_query</see>
	/// </summary>
	public class CustomerListLoadQueryResponse : ListQueryResponse<Customer>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for customers.
		/// <returns>Customer[]</returns>
		/// </summary>
		public List<Customer> GetCustomers()
		{
			return Data.Data;
		}
	}
}