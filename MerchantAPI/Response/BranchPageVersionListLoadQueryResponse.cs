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
	/// API Response for BranchPageVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchpageversionlist_load_query</see>
	/// </summary>
	public class BranchPageVersionListLoadQueryResponse : ListQueryResponse<BranchPageVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchPageVersionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branchPageVersions.
		/// <returns>BranchPageVersion[]</returns>
		/// </summary>
		public List<BranchPageVersion> GetBranchPageVersions()
		{
			return Data.Data;
		}
	}
}