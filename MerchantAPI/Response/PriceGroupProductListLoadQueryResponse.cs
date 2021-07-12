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
	/// API Response for PriceGroupProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupproductlist_load_query</see>
	/// </summary>
	public class PriceGroupProductListLoadQueryResponse : ListQueryResponse<PriceGroupProduct>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupProductListLoadQueryResponse() :
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