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
	/// API Response for ChangesetItemVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetitemversionlist_load_query</see>
	/// </summary>
	public class ChangesetItemVersionListLoadQueryResponse : ListQueryResponse<ChangesetItemVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetItemVersionListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for changesetItemVersions.
		/// <returns>ChangesetItemVersion[]</returns>
		/// </summary>
		public List<ChangesetItemVersion> GetChangesetItemVersions()
		{
			return Data.Data;
		}
	}
}