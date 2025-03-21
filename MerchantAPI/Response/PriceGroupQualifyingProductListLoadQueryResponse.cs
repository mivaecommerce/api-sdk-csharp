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
	/// API Response for PriceGroupQualifyingProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupqualifyingproductlist_load_query</see>
	/// </summary>
	public class PriceGroupQualifyingProductListLoadQueryResponse : ListQueryResponse<PriceGroupProduct>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupQualifyingProductListLoadQueryResponse() :
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