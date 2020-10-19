/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request PrintQueueJob_Delete.
	/// <see>https://docs.miva.com/json-api/functions/printqueuejob_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PrintQueueJobDeleteRequest : Request
	{
		/// Request field PrintQueueJob_ID.
		[JsonPropertyName("PrintQueueJob_ID")]
		public int? PrintQueueJobId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="printQueueJob">PrintQueueJob</param>
		/// </summary>
		public PrintQueueJobDeleteRequest(BaseClient client = null, PrintQueueJob printQueueJob = null) :
			base(client)
		{
			Function = "PrintQueueJob_Delete";
			if (printQueueJob != null) {
				if (printQueueJob.Id > 0)
				{
					PrintQueueJobId = printQueueJob.Id;
				}
			}
		}

		/// <summary>
		/// Getter for PrintQueueJob_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPrintQueueJobId()
		{
			return PrintQueueJobId;
		}

		/// <summary>
		/// Setter for PrintQueueJob_ID.
		/// <param name="value">int</param>
		/// <returns>PrintQueueJobDeleteRequest</returns>
		/// </summary>
		public PrintQueueJobDeleteRequest SetPrintQueueJobId(int? value)
		{
			PrintQueueJobId = value;
			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			if (PrintQueueJobId.HasValue)
			{
				writer.WriteNumber("PrintQueueJob_ID", PrintQueueJobId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PrintQueueJobDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PrintQueueJobDeleteResponse</returns>
		/// </summary>
		public new PrintQueueJobDeleteResponse Send()
		{
			return Client.SendRequestAsync<PrintQueueJobDeleteRequest, PrintQueueJobDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PrintQueueJobDeleteResponse></returns>
		/// </summary>
		public new async Task<PrintQueueJobDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PrintQueueJobDeleteRequest, PrintQueueJobDeleteResponse>(this);
		}
	}
}
