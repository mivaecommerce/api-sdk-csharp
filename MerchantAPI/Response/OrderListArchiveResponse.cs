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
	/// API Response for OrderList_Archive.
	/// <see>https://docs.miva.com/json-api/functions/orderlist_archive</see>
	/// </summary>
	public class OrderListArchiveResponse : Response
	{
		/// Response field processed.
		[JsonPropertyName("processed")]
		public int Processed { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderListArchiveResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for processed.
		/// <returns>int</returns>
		/// </summary>
		public int GetProcessed()
		{
			return Processed;
		}
	}
}