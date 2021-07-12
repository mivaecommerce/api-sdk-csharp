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
	/// API Response for PriceGroupExcludedCategoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupexcludedcategorylist_load_query</see>
	/// </summary>
	public class PriceGroupExcludedCategoryListLoadQueryResponse : ListQueryResponse<PriceGroupCategory>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupExcludedCategoryListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for priceGroupCategories.
		/// <returns>PriceGroupCategory[]</returns>
		/// </summary>
		public List<PriceGroupCategory> GetPriceGroupCategories()
		{
			return Data.Data;
		}
	}
}