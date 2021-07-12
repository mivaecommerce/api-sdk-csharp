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
	/// API Response for CategoryURIList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/categoryurilist_delete</see>
	/// </summary>
	public class CategoryURIListDeleteResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<Uri> Data { get; set; } = new List<Uri>();

		/// <summary>
		///  Constructor
		/// </summary>
		public CategoryURIListDeleteResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for uris.
		/// <returns>Uri[]</returns>
		/// </summary>
		public List<Uri> GetUris()
		{
			return Data;
		}
	}
}