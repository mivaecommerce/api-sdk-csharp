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
	/// Handles API Request ChangesetList_Merge.
	/// <see>https://docs.miva.com/json-api/functions/changesetlist_merge</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ChangesetListMergeRequest : Request
	{
		/// Request field Source_Changeset_IDs.
		public List<int> SourceChangesetIds { get; set; } = new List<int>();

		/// Request field Destination_Branch_ID.
		[JsonPropertyName("Destination_Branch_ID")]
		public int? DestinationBranchId { get; set; }

		/// Request field ChangesetList_Merge_Session_ID.
		[JsonPropertyName("ChangesetList_Merge_Session_ID")]
		public String ChangesetListMergeSessionId { get; set; }

		/// Request field Notes.
		[JsonPropertyName("Notes")]
		public String Notes { get; set; }

		/// Request field Tags.
		[JsonPropertyName("Tags")]
		public String Tags { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public ChangesetListMergeRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "ChangesetList_Merge";
			if (branch != null) {
				if (branch.Id > 0)
				{
					DestinationBranchId = branch.Id;
				}
			}
		}

		/// <summary>
		/// Getter for Destination_Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetDestinationBranchId()
		{
			return DestinationBranchId;
		}

		/// <summary>
		/// Getter for ChangesetList_Merge_Session_ID.
		/// <returns>String</returns>
		/// </summary>
		public String GetChangesetListMergeSessionId()
		{
			return ChangesetListMergeSessionId;
		}

		/// <summary>
		/// Getter for Notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetNotes()
		{
			return Notes;
		}

		/// <summary>
		/// Getter for Tags.
		/// <returns>String</returns>
		/// </summary>
		public String GetTags()
		{
			return Tags;
		}

		/// <summary>
		/// Setter for Destination_Branch_ID.
		/// <param name="value">int</param>
		/// <returns>ChangesetListMergeRequest</returns>
		/// </summary>
		public ChangesetListMergeRequest SetDestinationBranchId(int? value)
		{
			DestinationBranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for ChangesetList_Merge_Session_ID.
		/// <param name="value">String</param>
		/// <returns>ChangesetListMergeRequest</returns>
		/// </summary>
		public ChangesetListMergeRequest SetChangesetListMergeSessionId(String value)
		{
			ChangesetListMergeSessionId = value;
			return this;
		}

		/// <summary>
		/// Setter for Notes.
		/// <param name="value">String</param>
		/// <returns>ChangesetListMergeRequest</returns>
		/// </summary>
		public ChangesetListMergeRequest SetNotes(String value)
		{
			Notes = value;
			return this;
		}

		/// <summary>
		/// Setter for Tags.
		/// <param name="value">String</param>
		/// <returns>ChangesetListMergeRequest</returns>
		/// </summary>
		public ChangesetListMergeRequest SetTags(String value)
		{
			Tags = value;
			return this;
		}

		/// <summary>
		/// Add Source_Changeset_IDs.
		///	- sourceChangesetId: Int
		/// - Returns: Self
		/// </summary>
		public ChangesetListMergeRequest AddSourceChangesetID(int sourceChangesetId)
		{
			SourceChangesetIds.Add(sourceChangesetId);
			return this;
		}

		/// <summary>
		/// Add Changeset model.
		/// <param name="changeset">Changeset></param>
		/// <returns>ChangesetListMergeRequest</returns>
		/// </summary>
		public ChangesetListMergeRequest AddChangeset(Changeset changeset)
		{
			if (changeset.Id > 0)
			{
				SourceChangesetIds.Add(changeset.Id);
			}

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

			if (DestinationBranchId.HasValue)
			{
				writer.WriteNumber("Destination_Branch_ID", DestinationBranchId.Value);
			}

			writer.WritePropertyName("Source_Changeset_IDs");
			JsonSerializer.Serialize(writer, this.SourceChangesetIds, options);

			if (ChangesetListMergeSessionId != null && ChangesetListMergeSessionId.Length > 0)
			{
				writer.WriteString("ChangesetList_Merge_Session_ID", ChangesetListMergeSessionId);
			}

			if (Notes != null && Notes.Length > 0)
			{
				writer.WriteString("Notes", Notes);
			}

			if (Tags != null && Tags.Length > 0)
			{
				writer.WriteString("Tags", Tags);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ChangesetListMergeResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ChangesetListMergeResponse</returns>
		/// </summary>
		public new ChangesetListMergeResponse Send()
		{
			return Client.SendRequestAsync<ChangesetListMergeRequest, ChangesetListMergeResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ChangesetListMergeResponse></returns>
		/// </summary>
		public new async Task<ChangesetListMergeResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ChangesetListMergeRequest, ChangesetListMergeResponse>(this);
		}
	}
}
