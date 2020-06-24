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
	/// API Response for ProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productlist_load_query</see>
	/// </summary>
	public class ProductListLoadQueryResponse : ListQueryResponse<Product>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for products.
		/// <returns>Product[]</returns>
		/// </summary>
		public List<Product> GetProducts()
		{
			return Data.Data;
		}
	}
}