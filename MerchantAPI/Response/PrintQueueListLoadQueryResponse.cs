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
	/// API Response for PrintQueueList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/printqueuelist_load_query</see>
	/// </summary>
	public class PrintQueueListLoadQueryResponse : ListQueryResponse<PrintQueue>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PrintQueueListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for printQueues.
		/// <returns>PrintQueue[]</returns>
		/// </summary>
		public List<PrintQueue> GetPrintQueues()
		{
			return Data.Data;
		}
	}
}