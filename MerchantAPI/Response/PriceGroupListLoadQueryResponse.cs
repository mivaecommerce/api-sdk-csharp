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
	/// API Response for PriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegrouplist_load_query</see>
	/// </summary>
	public class PriceGroupListLoadQueryResponse : ListQueryResponse<PriceGroup>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for priceGroups.
		/// <returns>PriceGroup[]</returns>
		/// </summary>
		public List<PriceGroup> GetPriceGroups()
		{
			return Data.Data;
		}
	}
}