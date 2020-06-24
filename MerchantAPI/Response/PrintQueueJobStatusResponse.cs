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
	/// API Response for PrintQueueJob_Status.
	/// <see>https://docs.miva.com/json-api/functions/printqueuejob_status</see>
	/// </summary>
	public class PrintQueueJobStatusResponse : Response
	{
		[JsonPropertyName("data")]
		public DataFields Data { get; set; }

		/// Non model data container containing the response fields in the data propery
		public struct DataFields
		{
			/// Response field status.
			[JsonPropertyName("status")]
			public String Status { get; set; }
		}

		/// <summary>
		///  Constructor
		/// </summary>
		public PrintQueueJobStatusResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for status.
		/// <returns>string</returns>
		/// </summary>
		public String GetStatus()
		{
			return Data.Status;
		}
	}
}