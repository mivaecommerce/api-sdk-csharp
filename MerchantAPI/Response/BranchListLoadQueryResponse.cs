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
	/// API Response for BranchList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchlist_load_query</see>
	/// </summary>
	public class BranchListLoadQueryResponse : ListQueryResponse<Branch>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public BranchListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branches.
		/// <returns>Branch[]</returns>
		/// </summary>
		public List<Branch> GetBranches()
		{
			return Data.Data;
		}
	}
}