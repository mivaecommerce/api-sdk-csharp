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
	/// API Response for CategoryURIList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/categoryurilist_load_query</see>
	/// </summary>
	public class CategoryURIListLoadQueryResponse : ListQueryResponse<Uri>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CategoryURIListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for uris.
		/// <returns>Uri[]</returns>
		/// </summary>
		public List<Uri> GetUris()
		{
			return Data.Data;
		}
	}
}