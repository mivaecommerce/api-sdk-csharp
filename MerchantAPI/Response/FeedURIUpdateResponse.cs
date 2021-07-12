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
	/// API Response for FeedURI_Update.
	/// <see>https://docs.miva.com/json-api/functions/feeduri_update</see>
	/// </summary>
	public class FeedURIUpdateResponse : Response
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public FeedURIUpdateResponse() :
			base()
		{
		}
	}
}