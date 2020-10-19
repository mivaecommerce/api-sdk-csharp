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
	/// API Response for BranchJavaScriptResourceVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchjavascriptresourceversionlist_load_query</see>
	/// </summary>
	public class BranchJavaScriptResourceVersionListLoadQueryResponse : ListQueryResponse<BranchJavaScriptResourceVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchJavaScriptResourceVersionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branchJavaScriptResourceVersions.
		/// <returns>BranchJavaScriptResourceVersion[]</returns>
		/// </summary>
		public List<BranchJavaScriptResourceVersion> GetBranchJavaScriptResourceVersions()
		{
			return Data.Data;
		}
	}
}