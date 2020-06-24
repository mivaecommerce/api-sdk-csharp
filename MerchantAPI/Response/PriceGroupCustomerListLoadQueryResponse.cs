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
	/// API Response for PriceGroupCustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupcustomerlist_load_query</see>
	/// </summary>
	public class PriceGroupCustomerListLoadQueryResponse : ListQueryResponse<PriceGroupCustomer>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupCustomerListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for priceGroupCustomers.
		/// <returns>PriceGroupCustomer[]</returns>
		/// </summary>
		public List<PriceGroupCustomer> GetPriceGroupCustomers()
		{
			return Data.Data;
		}
	}
}