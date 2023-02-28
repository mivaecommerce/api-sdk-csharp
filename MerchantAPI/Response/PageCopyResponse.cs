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
	/// API Response for Page_Copy.
	/// <see>https://docs.miva.com/json-api/functions/page_copy</see>
	/// </summary>
	public class PageCopyResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Page Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public PageCopyResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for page.
		/// <returns>Page</returns>
		/// </summary>
		public Page GetPage()
		{
			return Data;
		}
	}
}