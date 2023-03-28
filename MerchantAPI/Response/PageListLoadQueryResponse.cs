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
	/// API Response for PageList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pagelist_load_query</see>
	/// </summary>
	public class PageListLoadQueryResponse : ListQueryResponse<Page>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PageListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for pages.
		/// <returns>Page[]</returns>
		/// </summary>
		public List<Page> GetPages()
		{
			return Data.Data;
		}
	}
}