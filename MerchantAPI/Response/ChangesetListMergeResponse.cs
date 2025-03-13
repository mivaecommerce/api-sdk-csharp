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
	/// API Response for ChangesetList_Merge.
	/// <see>https://docs.miva.com/json-api/functions/changesetlist_merge</see>
	/// </summary>
	public class ChangesetListMergeResponse : Response
	{
		/// Response field completed.
		[JsonPropertyName("completed")]
		public bool Completed { get; set; }

		/// Response field changesetlist_merge_session_id.
		[JsonPropertyName("changesetlist_merge_session_id")]
		public String ChangesetlistMergeSessionId { get; set; }

		/// The response model
		[JsonPropertyName("data")]
		public Changeset Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetListMergeResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for completed.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCompleted()
		{
			return Completed;
		}

		/// <summary>
		/// Getter for changesetlist_merge_session_id.
		/// <returns>string</returns>
		/// </summary>
		public String GetChangesetlistMergeSessionId()
		{
			return ChangesetlistMergeSessionId;
		}

		/// <summary>
		///  Getter for changeset.
		/// <returns>Changeset</returns>
		/// </summary>
		public Changeset GetChangeset()
		{
			return Data;
		}
	}
}