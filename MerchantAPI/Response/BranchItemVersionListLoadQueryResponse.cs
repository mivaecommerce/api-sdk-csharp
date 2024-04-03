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
	/// API Response for BranchItemVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchitemversionlist_load_query</see>
	/// </summary>
	public class BranchItemVersionListLoadQueryResponse : ListQueryResponse<BranchItemVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchItemVersionListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for branchItemVersions.
		/// <returns>BranchItemVersion[]</returns>
		/// </summary>
		public List<BranchItemVersion> GetBranchItemVersions()
		{
			return Data.Data;
		}
	}
}