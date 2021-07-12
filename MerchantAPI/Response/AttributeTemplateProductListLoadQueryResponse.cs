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
	/// API Response for AttributeTemplateProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateproductlist_load_query</see>
	/// </summary>
	public class AttributeTemplateProductListLoadQueryResponse : ListQueryResponse<AttributeTemplateProduct>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateProductListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for attributeTemplateProducts.
		/// <returns>AttributeTemplateProduct[]</returns>
		/// </summary>
		public List<AttributeTemplateProduct> GetAttributeTemplateProducts()
		{
			return Data.Data;
		}
	}
}