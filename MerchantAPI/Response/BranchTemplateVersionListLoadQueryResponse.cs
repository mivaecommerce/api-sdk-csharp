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
	/// API Response for BranchTemplateVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchtemplateversionlist_load_query</see>
	/// </summary>
	public class BranchTemplateVersionListLoadQueryResponse : ListQueryResponse<BranchTemplateVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchTemplateVersionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branchTemplateVersions.
		/// <returns>BranchTemplateVersion[]</returns>
		/// </summary>
		public List<BranchTemplateVersion> GetBranchTemplateVersions()
		{
			return Data.Data;
		}
	}
}