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
	/// API Response for PriceGroupBusinessAccountList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupbusinessaccountlist_load_query</see>
	/// </summary>
	public class PriceGroupBusinessAccountListLoadQueryResponse : ListQueryResponse<PriceGroupBusinessAccount>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupBusinessAccountListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for priceGroupBusinessAccounts.
		/// <returns>PriceGroupBusinessAccount[]</returns>
		/// </summary>
		public List<PriceGroupBusinessAccount> GetPriceGroupBusinessAccounts()
		{
			return Data.Data;
		}
	}
}