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
	/// API Response for PriceGroupExcludedProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupexcludedproductlist_load_query</see>
	/// </summary>
	public class PriceGroupExcludedProductListLoadQueryResponse : ListQueryResponse<PriceGroupProduct>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupExcludedProductListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for priceGroupProducts.
		/// <returns>PriceGroupProduct[]</returns>
		/// </summary>
		public List<PriceGroupProduct> GetPriceGroupProducts()
		{
			return Data.Data;
		}
	}
}