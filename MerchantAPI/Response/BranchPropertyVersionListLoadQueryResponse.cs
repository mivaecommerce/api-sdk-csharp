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
	/// API Response for BranchPropertyVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchpropertyversionlist_load_query</see>
	/// </summary>
	public class BranchPropertyVersionListLoadQueryResponse : ListQueryResponse<BranchPropertyVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchPropertyVersionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branchPropertyVersions.
		/// <returns>BranchPropertyVersion[]</returns>
		/// </summary>
		public List<BranchPropertyVersion> GetBranchPropertyVersions()
		{
			return Data.Data;
		}
	}
}