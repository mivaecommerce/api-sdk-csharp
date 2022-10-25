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
	/// API Response for PrintQueueJob_Insert.
	/// <see>https://docs.miva.com/json-api/functions/printqueuejob_insert</see>
	/// </summary>
	public class PrintQueueJobInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public PrintQueueJob Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public PrintQueueJobInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for printQueueJob.
		/// <returns>PrintQueueJob</returns>
		/// </summary>
		public PrintQueueJob GetPrintQueueJob()
		{
			return Data;
		}
	}
}