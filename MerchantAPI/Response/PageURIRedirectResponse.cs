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
	/// API Response for PageURI_Redirect.
	/// <see>https://docs.miva.com/json-api/functions/pageuri_redirect</see>
	/// </summary>
	public class PageURIRedirectResponse : ListQueryResponse<Uri>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PageURIRedirectResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for uris.
		/// <returns>Uri[]</returns>
		/// </summary>
		public List<Uri> GetUris()
		{
			return Data.Data;
		}
	}
}