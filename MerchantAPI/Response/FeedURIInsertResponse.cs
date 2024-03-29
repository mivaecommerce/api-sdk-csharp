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
	/// API Response for FeedURI_Insert.
	/// <see>https://docs.miva.com/json-api/functions/feeduri_insert</see>
	/// </summary>
	public class FeedURIInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Uri Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public FeedURIInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for uri.
		/// <returns>Uri</returns>
		/// </summary>
		public Uri GetUri()
		{
			return Data;
		}
	}
}