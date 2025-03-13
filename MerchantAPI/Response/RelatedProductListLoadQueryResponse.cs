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
	/// API Response for RelatedProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/relatedproductlist_load_query</see>
	/// </summary>
	public class RelatedProductListLoadQueryResponse : ListQueryResponse<RelatedProduct>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public RelatedProductListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for relatedProducts.
		/// <returns>RelatedProduct[]</returns>
		/// </summary>
		public List<RelatedProduct> GetRelatedProducts()
		{
			return Data.Data;
		}
	}
}