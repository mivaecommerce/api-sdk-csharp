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
	/// API Response for ChangesetTemplateVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesettemplateversionlist_load_query</see>
	/// </summary>
	public class ChangesetTemplateVersionListLoadQueryResponse : ListQueryResponse<ChangesetTemplateVersion>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetTemplateVersionListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for changesetTemplateVersions.
		/// <returns>ChangesetTemplateVersion[]</returns>
		/// </summary>
		public List<ChangesetTemplateVersion> GetChangesetTemplateVersions()
		{
			return Data.Data;
		}
	}
}