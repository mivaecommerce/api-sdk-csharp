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
	/// API Response for BusinessAccountList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/businessaccountlist_load_query</see>
	/// </summary>
	public class BusinessAccountListLoadQueryResponse : ListQueryResponse<BusinessAccount>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BusinessAccountListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for businessAccounts.
		/// <returns>BusinessAccount[]</returns>
		/// </summary>
		public List<BusinessAccount> GetBusinessAccounts()
		{
			return Data.Data;
		}
	}
}