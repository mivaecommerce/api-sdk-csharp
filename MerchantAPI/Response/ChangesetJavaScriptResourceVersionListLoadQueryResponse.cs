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
	/// API Response for ChangesetJavaScriptResourceVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetjavascriptresourceversionlist_load_query</see>
	/// </summary>
	public class ChangesetJavaScriptResourceVersionListLoadQueryResponse : ListQueryResponse<ChangesetJavaScriptResourceVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetJavaScriptResourceVersionListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for changesetJavaScriptResourceVersions.
		/// <returns>ChangesetJavaScriptResourceVersion[]</returns>
		/// </summary>
		public List<ChangesetJavaScriptResourceVersion> GetChangesetJavaScriptResourceVersions()
		{
			return Data.Data;
		}
	}
}