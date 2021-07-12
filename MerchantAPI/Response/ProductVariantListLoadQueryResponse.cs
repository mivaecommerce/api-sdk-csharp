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
	/// API Response for ProductVariantList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productvariantlist_load_query</see>
	/// </summary>
	public class ProductVariantListLoadQueryResponse : ListQueryResponse<ProductVariant>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductVariantListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for productVariants.
		/// <returns>ProductVariant[]</returns>
		/// </summary>
		public List<ProductVariant> GetProductVariants()
		{
			return Data.Data;
		}
	}
}