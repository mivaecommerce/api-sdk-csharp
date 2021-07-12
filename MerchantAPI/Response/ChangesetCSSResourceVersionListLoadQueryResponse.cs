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
	/// API Response for ChangesetCSSResourceVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetcssresourceversionlist_load_query</see>
	/// </summary>
	public class ChangesetCSSResourceVersionListLoadQueryResponse : ListQueryResponse<ChangesetCSSResourceVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetCSSResourceVersionListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for changesetCSSResourceVersions.
		/// <returns>ChangesetCSSResourceVersion[]</returns>
		/// </summary>
		public List<ChangesetCSSResourceVersion> GetChangesetCSSResourceVersions()
		{
			return Data.Data;
		}
	}
}