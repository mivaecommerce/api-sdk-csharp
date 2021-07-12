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
	/// API Response for ChangesetList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetlist_load_query</see>
	/// </summary>
	public class ChangesetListLoadQueryResponse : ListQueryResponse<Changeset>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for changesets.
		/// <returns>Changeset[]</returns>
		/// </summary>
		public List<Changeset> GetChangesets()
		{
			return Data.Data;
		}
	}
}