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
	/// API Response for CategoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/categorylist_load_query</see>
	/// </summary>
	public class CategoryListLoadQueryResponse : ListQueryResponse<Category>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CategoryListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for categories.
		/// <returns>Category[]</returns>
		/// </summary>
		public List<Category> GetCategories()
		{
			return Data.Data;
		}
	}
}