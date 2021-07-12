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
	/// API Response for StoreList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/storelist_load_query</see>
	/// </summary>
	public class StoreListLoadQueryResponse : ListQueryResponse<Store>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public StoreListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for stores.
		/// <returns>Store[]</returns>
		/// </summary>
		public List<Store> GetStores()
		{
			return Data.Data;
		}
	}
}