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
	/// API Response for CSSResource_Insert.
	/// <see>https://docs.miva.com/json-api/functions/cssresource_insert</see>
	/// </summary>
	public class CSSResourceInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public CSSResource Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CSSResourceInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for CSSResource.
		/// <returns>CSSResource</returns>
		/// </summary>
		public CSSResource GetCSSResource()
		{
			return Data;
		}
	}
}