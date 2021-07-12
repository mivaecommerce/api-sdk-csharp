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
	/// API Response for Store_Load.
	/// <see>https://docs.miva.com/json-api/functions/store_load</see>
	/// </summary>
	public class StoreLoadResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Store Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public StoreLoadResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for store.
		/// <returns>Store</returns>
		/// </summary>
		public Store GetStore()
		{
			return Data;
		}
	}
}