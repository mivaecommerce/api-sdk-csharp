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
	/// API Response for JavaScriptResource_Insert.
	/// <see>https://docs.miva.com/json-api/functions/javascriptresource_insert</see>
	/// </summary>
	public class JavaScriptResourceInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public JavaScriptResource Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public JavaScriptResourceInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for javaScriptResource.
		/// <returns>JavaScriptResource</returns>
		/// </summary>
		public JavaScriptResource GetJavaScriptResource()
		{
			return Data;
		}
	}
}