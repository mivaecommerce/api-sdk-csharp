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
	/// API Response for PrintQueueJobList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/printqueuejoblist_load_query</see>
	/// </summary>
	public class PrintQueueJobListLoadQueryResponse : ListQueryResponse<PrintQueueJob>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public PrintQueueJobListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for printQueueJobs.
		/// <returns>PrintQueueJob[]</returns>
		/// </summary>
		public List<PrintQueueJob> GetPrintQueueJobs()
		{
			return Data.Data;
		}
	}
}