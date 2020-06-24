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
	/// Handles API Request Note_Update.
	/// <see>https://docs.miva.com/json-api/functions/note_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class NoteUpdateRequest : Request
	{
		/// Request field Note_ID.
		[JsonPropertyName("Note_ID")]
		public int NoteId { get; set; }

		/// Request field NoteText.
		[JsonPropertyName("NoteText")]
		public String NoteText { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="note">Note</param>
		/// </summary>
		public NoteUpdateRequest(Client client = null, Note note = null) :
			base(client)
		{
			Function = "Note_Update";
			if (note != null) {
				NoteId = note.Id;
				NoteText = note.NoteText;
			}
		}

		/// <summary>
		/// Getter for Note_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetNoteId()
		{
			return NoteId;
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
		/// Setter for Note_ID.
		/// <param name="value">int</param>
		/// <returns>NoteUpdateRequest</returns>
		/// </summary>
		public NoteUpdateRequest SetNoteId(int value)
		{
			NoteId = value;
			return this;
		}

		/// <summary>
		/// Setter for NoteText.
		/// <param name="value">String</param>
		/// <returns>NoteUpdateRequest</returns>
		/// </summary>
		public NoteUpdateRequest SetNoteText(String value)
		{
			NoteText = value;
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

			writer.WriteNumber("Note_ID", NoteId);

			writer.WriteString("NoteText", NoteText);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<NoteUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>NoteUpdateResponse</returns>
		/// </summary>
		public new NoteUpdateResponse Send()
		{
			return Client.SendRequestAsync<NoteUpdateRequest, NoteUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<NoteUpdateResponse></returns>
		/// </summary>
		public new async Task<NoteUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<NoteUpdateRequest, NoteUpdateResponse>(this);
		}
	}
}
