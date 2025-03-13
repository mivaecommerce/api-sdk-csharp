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
	/// API Response for ProductKitList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productkitlist_load_query</see>
	/// </summary>
	public class ProductKitListLoadQueryResponse : ListQueryResponse<ProductKit>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductKitListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productKits.
		/// <returns>ProductKit[]</returns>
		/// </summary>
		public List<ProductKit> GetProductKits()
		{
			return Data.Data;
		}
	}
}