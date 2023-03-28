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
	/// API Response for CSSResourceList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/cssresourcelist_load_query</see>
	/// </summary>
	public class CSSResourceListLoadQueryResponse : ListQueryResponse<CSSResource>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CSSResourceListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for CSSResources.
		/// <returns>CSSResource[]</returns>
		/// </summary>
		public List<CSSResource> GetCSSResources()
		{
			return Data.Data;
		}
	}
}