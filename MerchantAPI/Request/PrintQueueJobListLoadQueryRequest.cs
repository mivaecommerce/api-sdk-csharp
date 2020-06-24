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
	/// Handles API Request PrintQueueJobList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/printqueuejoblist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PrintQueueJobListLoadQueryRequest : ListQueryRequest
	{
		/// Request field PrintQueue_ID.
		[JsonPropertyName("PrintQueue_ID")]
		public int? PrintQueueId { get; set; }

		/// Request field Edit_PrintQueue.
		[JsonPropertyName("Edit_PrintQueue")]
		public String EditPrintQueue { get; set; }

		/// Request field PrintQueue_Description.
		[JsonPropertyName("PrintQueue_Description")]
		public String PrintQueueDescription { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"queue_id",
			"store_id",
			"user_id",
			"descrip",
			"job_fmt",
			"job_data",
			"dt_created"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"queue_id",
			"store_id",
			"user_id",
			"descrip",
			"job_fmt",
			"job_data",
			"dt_created"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"job_data"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="printQueue">PrintQueue</param>
		/// </summary>
		public PrintQueueJobListLoadQueryRequest(Client client = null, PrintQueue printQueue = null) :
			base(client)
		{
			Function = "PrintQueueJobList_Load_Query";
			if (printQueue != null) {
				if (printQueue.Id > 0)
				{
					PrintQueueId = printQueue.Id;
				}
				else if (printQueue.Description.Length > 0)
				{
					EditPrintQueue = printQueue.Description;
				}
			}
		}

		/// <summary>
		/// Getter for PrintQueue_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPrintQueueId()
		{
			return PrintQueueId;
		}

		/// <summary>
		/// Getter for Edit_PrintQueue.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditPrintQueue()
		{
			return EditPrintQueue;
		}

		/// <summary>
		/// Getter for PrintQueue_Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrintQueueDescription()
		{
			return PrintQueueDescription;
		}

		/// <summary>
		/// Setter for PrintQueue_ID.
		/// <param name="value">int</param>
		/// <returns>PrintQueueJobListLoadQueryRequest</returns>
		/// </summary>
		public PrintQueueJobListLoadQueryRequest SetPrintQueueId(int? value)
		{
			PrintQueueId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_PrintQueue.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobListLoadQueryRequest</returns>
		/// </summary>
		public PrintQueueJobListLoadQueryRequest SetEditPrintQueue(String value)
		{
			EditPrintQueue = value;
			return this;
		}

		/// <summary>
		/// Setter for PrintQueue_Description.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobListLoadQueryRequest</returns>
		/// </summary>
		public PrintQueueJobListLoadQueryRequest SetPrintQueueDescription(String value)
		{
			PrintQueueDescription = value;
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

			if (PrintQueueId.HasValue)
			{
				writer.WriteNumber("PrintQueue_ID", PrintQueueId.Value);
			}
			else if (EditPrintQueue != null && EditPrintQueue.Length > 0)
			{
				writer.WriteString("Edit_PrintQueue", EditPrintQueue);
			}
			else if (PrintQueueDescription != null && PrintQueueDescription.Length > 0)
			{
				writer.WriteString("PrintQueue_Description", PrintQueueDescription);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PrintQueueJobListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PrintQueueJobListLoadQueryResponse</returns>
		/// </summary>
		public new PrintQueueJobListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<PrintQueueJobListLoadQueryRequest, PrintQueueJobListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PrintQueueJobListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<PrintQueueJobListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PrintQueueJobListLoadQueryRequest, PrintQueueJobListLoadQueryResponse>(this);
		}
	}
}
