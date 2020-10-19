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
	/// Handles API Request Note_Insert.
	/// <see>https://docs.miva.com/json-api/functions/note_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class NoteInsertRequest : Request
	{
		/// Request field NoteText.
		[JsonPropertyName("NoteText")]
		public String NoteText { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Account_ID.
		[JsonPropertyName("Account_ID")]
		public int? AccountId { get; set; }

		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int? OrderId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public NoteInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "Note_Insert";
		}

		/// <summary>
		/// Getter for NoteText.
		/// <returns>String</returns>
		/// </summary>
		public String GetNoteText()
		{
			return NoteText;
		}

		/// <summary>
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Getter for Account_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAccountId()
		{
			return AccountId;
		}

		/// <summary>
		/// Getter for Order_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Setter for NoteText.
		/// <param name="value">String</param>
		/// <returns>NoteInsertRequest</returns>
		/// </summary>
		public NoteInsertRequest SetNoteText(String value)
		{
			NoteText = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>NoteInsertRequest</returns>
		/// </summary>
		public NoteInsertRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Account_ID.
		/// <param name="value">int</param>
		/// <returns>NoteInsertRequest</returns>
		/// </summary>
		public NoteInsertRequest SetAccountId(int? value)
		{
			AccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>NoteInsertRequest</returns>
		/// </summary>
		public NoteInsertRequest SetOrderId(int? value)
		{
			OrderId = value;
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

			writer.WriteString("NoteText", NoteText);

			if (CustomerId.HasValue)
			{
				writer.WriteNumber("Customer_ID", CustomerId.Value);
			}

			if (AccountId.HasValue)
			{
				writer.WriteNumber("Account_ID", AccountId.Value);
			}

			if (OrderId.HasValue)
			{
				writer.WriteNumber("Order_ID", OrderId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<NoteInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>NoteInsertResponse</returns>
		/// </summary>
		public new NoteInsertResponse Send()
		{
			return Client.SendRequestAsync<NoteInsertRequest, NoteInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<NoteInsertResponse></returns>
		/// </summary>
		public new async Task<NoteInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<NoteInsertRequest, NoteInsertResponse>(this);
		}
	}
}
