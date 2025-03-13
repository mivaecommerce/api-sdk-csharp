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
	/// API Response for ChangesetPropertyVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetpropertyversionlist_load_query</see>
	/// </summary>
	public class ChangesetPropertyVersionListLoadQueryResponse : ListQueryResponse<ChangesetPropertyVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetPropertyVersionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for changesetPropertyVersions.
		/// <returns>ChangesetPropertyVersion[]</returns>
		/// </summary>
		public List<ChangesetPropertyVersion> GetChangesetPropertyVersions()
		{
			return Data.Data;
		}
	}
}