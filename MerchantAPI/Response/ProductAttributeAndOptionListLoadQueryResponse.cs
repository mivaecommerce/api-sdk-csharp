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
	/// API Response for ProductAttributeAndOptionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productattributeandoptionlist_load_query</see>
	/// </summary>
	public class ProductAttributeAndOptionListLoadQueryResponse : ListQueryResponse<ProductAttributeListAttribute>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductAttributeAndOptionListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for attributes.
		/// <returns>ProductAttributeListAttribute[]</returns>
		/// </summary>
		public List<ProductAttributeListAttribute> GetAttributes()
		{
			return Data.Data;
		}
	}
}