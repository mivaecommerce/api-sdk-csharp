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
	/// API Response for CustomerCreditHistoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customercredithistorylist_load_query</see>
	/// </summary>
	public class CustomerCreditHistoryListLoadQueryResponse : ListQueryResponse<CustomerCreditHistory>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerCreditHistoryListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customerCreditHistory.
		/// <returns>CustomerCreditHistory[]</returns>
		/// </summary>
		public List<CustomerCreditHistory> GetCustomerCreditHistory()
		{
			return Data.Data;
		}
	}
}