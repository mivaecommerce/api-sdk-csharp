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
	/// Handles API Request Note_Delete.
	/// <see>https://docs.miva.com/json-api/functions/note_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class NoteDeleteRequest : Request
	{
		/// Request field Note_ID.
		[JsonPropertyName("Note_ID")]
		public int NoteId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="note">Note</param>
		/// </summary>
		public NoteDeleteRequest(BaseClient client = null, Note note = null) :
			base(client)
		{
			Function = "Note_Delete";
			if (note != null) {
				NoteId = note.Id;
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
		/// Setter for Note_ID.
		/// <param name="value">int</param>
		/// <returns>NoteDeleteRequest</returns>
		/// </summary>
		public NoteDeleteRequest SetNoteId(int value)
		{
			NoteId = value;
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
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<NoteDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>NoteDeleteResponse</returns>
		/// </summary>
		public new NoteDeleteResponse Send()
		{
			return Client.SendRequestAsync<NoteDeleteRequest, NoteDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<NoteDeleteResponse></returns>
		/// </summary>
		public new async Task<NoteDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<NoteDeleteRequest, NoteDeleteResponse>(this);
		}
	}
}
