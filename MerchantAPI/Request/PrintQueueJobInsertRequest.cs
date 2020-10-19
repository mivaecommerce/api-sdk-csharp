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
	/// Handles API Request PrintQueueJob_Insert.
	/// <see>https://docs.miva.com/json-api/functions/printqueuejob_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PrintQueueJobInsertRequest : Request
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

		/// Request field PrintQueueJob_Description.
		[JsonPropertyName("PrintQueueJob_Description")]
		public String PrintQueueJobDescription { get; set; }

		/// Request field PrintQueueJob_Format.
		[JsonPropertyName("PrintQueueJob_Format")]
		public String PrintQueueJobFormat { get; set; }

		/// Request field PrintQueueJob_Data.
		[JsonPropertyName("PrintQueueJob_Data")]
		public String PrintQueueJobData { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="printQueue">PrintQueue</param>
		/// </summary>
		public PrintQueueJobInsertRequest(BaseClient client = null, PrintQueue printQueue = null) :
			base(client)
		{
			Function = "PrintQueueJob_Insert";
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
		/// Getter for PrintQueueJob_Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrintQueueJobDescription()
		{
			return PrintQueueJobDescription;
		}

		/// <summary>
		/// Getter for PrintQueueJob_Format.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrintQueueJobFormat()
		{
			return PrintQueueJobFormat;
		}

		/// <summary>
		/// Getter for PrintQueueJob_Data.
		/// <returns>String</returns>
		/// </summary>
		public String GetPrintQueueJobData()
		{
			return PrintQueueJobData;
		}

		/// <summary>
		/// Setter for PrintQueue_ID.
		/// <param name="value">int</param>
		/// <returns>PrintQueueJobInsertRequest</returns>
		/// </summary>
		public PrintQueueJobInsertRequest SetPrintQueueId(int? value)
		{
			PrintQueueId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_PrintQueue.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobInsertRequest</returns>
		/// </summary>
		public PrintQueueJobInsertRequest SetEditPrintQueue(String value)
		{
			EditPrintQueue = value;
			return this;
		}

		/// <summary>
		/// Setter for PrintQueue_Description.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobInsertRequest</returns>
		/// </summary>
		public PrintQueueJobInsertRequest SetPrintQueueDescription(String value)
		{
			PrintQueueDescription = value;
			return this;
		}

		/// <summary>
		/// Setter for PrintQueueJob_Description.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobInsertRequest</returns>
		/// </summary>
		public PrintQueueJobInsertRequest SetPrintQueueJobDescription(String value)
		{
			PrintQueueJobDescription = value;
			return this;
		}

		/// <summary>
		/// Setter for PrintQueueJob_Format.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobInsertRequest</returns>
		/// </summary>
		public PrintQueueJobInsertRequest SetPrintQueueJobFormat(String value)
		{
			PrintQueueJobFormat = value;
			return this;
		}

		/// <summary>
		/// Setter for PrintQueueJob_Data.
		/// <param name="value">String</param>
		/// <returns>PrintQueueJobInsertRequest</returns>
		/// </summary>
		public PrintQueueJobInsertRequest SetPrintQueueJobData(String value)
		{
			PrintQueueJobData = value;
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

			if (PrintQueueJobDescription != null && PrintQueueJobDescription.Length > 0)
			{
				writer.WriteString("PrintQueueJob_Description", PrintQueueJobDescription);
			}

			if (PrintQueueJobFormat != null && PrintQueueJobFormat.Length > 0)
			{
				writer.WriteString("PrintQueueJob_Format", PrintQueueJobFormat);
			}

			if (PrintQueueJobData != null && PrintQueueJobData.Length > 0)
			{
				writer.WriteString("PrintQueueJob_Data", PrintQueueJobData);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PrintQueueJobInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PrintQueueJobInsertResponse</returns>
		/// </summary>
		public new PrintQueueJobInsertResponse Send()
		{
			return Client.SendRequestAsync<PrintQueueJobInsertRequest, PrintQueueJobInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PrintQueueJobInsertResponse></returns>
		/// </summary>
		public new async Task<PrintQueueJobInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PrintQueueJobInsertRequest, PrintQueueJobInsertResponse>(this);
		}
	}
}
