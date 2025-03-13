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
	/// API Response for BranchCSSResourceVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchcssresourceversionlist_load_query</see>
	/// </summary>
	public class BranchCSSResourceVersionListLoadQueryResponse : ListQueryResponse<BranchCSSResourceVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchCSSResourceVersionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branchCSSResourceVersions.
		/// <returns>BranchCSSResourceVersion[]</returns>
		/// </summary>
		public List<BranchCSSResourceVersion> GetBranchCSSResourceVersions()
		{
			return Data.Data;
		}
	}
}