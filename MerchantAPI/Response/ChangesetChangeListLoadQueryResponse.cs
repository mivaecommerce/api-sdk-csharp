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
	/// API Response for ChangesetChangeList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetchangelist_load_query</see>
	/// </summary>
	public class ChangesetChangeListLoadQueryResponse : ListQueryResponse<ChangesetChange>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetChangeListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for changesetChanges.
		/// <returns>ChangesetChange[]</returns>
		/// </summary>
		public List<ChangesetChange> GetChangesetChanges()
		{
			return Data.Data;
		}
	}
}