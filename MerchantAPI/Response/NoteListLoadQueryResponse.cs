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
	/// API Response for NoteList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/notelist_load_query</see>
	/// </summary>
	public class NoteListLoadQueryResponse : ListQueryResponse<Note>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public NoteListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for notes.
		/// <returns>Note[]</returns>
		/// </summary>
		public List<Note> GetNotes()
		{
			return Data.Data;
		}
	}
}