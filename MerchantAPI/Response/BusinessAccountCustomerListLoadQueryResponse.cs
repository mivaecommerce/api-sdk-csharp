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
	/// API Response for BusinessAccountCustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/businessaccountcustomerlist_load_query</see>
	/// </summary>
	public class BusinessAccountCustomerListLoadQueryResponse : ListQueryResponse<BusinessAccountCustomer>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BusinessAccountCustomerListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for businessAccountCustomers.
		/// <returns>BusinessAccountCustomer[]</returns>
		/// </summary>
		public List<BusinessAccountCustomer> GetBusinessAccountCustomers()
		{
			return Data.Data;
		}
	}
}