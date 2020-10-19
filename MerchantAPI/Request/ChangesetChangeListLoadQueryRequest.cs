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
	/// Handles API Request ChangesetChangeList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetchangelist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ChangesetChangeListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Changeset_ID.
		[JsonPropertyName("Changeset_ID")]
		public int ChangesetId { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"item_type",
			"item_id",
			"item_version_id",
			"item_identifier"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"item_type",
			"item_id",
			"item_version_id",
			"item_identifier"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="changeset">Changeset</param>
		/// </summary>
		public ChangesetChangeListLoadQueryRequest(BaseClient client = null, Changeset changeset = null) :
			base(client)
		{
			Function = "ChangesetChangeList_Load_Query";
			if (changeset != null) {
				ChangesetId = changeset.Id;
			}
		}

		/// <summary>
		/// Getter for Changeset_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetChangesetId()
		{
			return ChangesetId;
		}

		/// <summary>
		/// Setter for Changeset_ID.
		/// <param name="value">int</param>
		/// <returns>ChangesetChangeListLoadQueryRequest</returns>
		/// </summary>
		public ChangesetChangeListLoadQueryRequest SetChangesetId(int value)
		{
			ChangesetId = value;
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

			writer.WriteNumber("Changeset_ID", ChangesetId);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ChangesetChangeListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ChangesetChangeListLoadQueryResponse</returns>
		/// </summary>
		public new ChangesetChangeListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ChangesetChangeListLoadQueryRequest, ChangesetChangeListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ChangesetChangeListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ChangesetChangeListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ChangesetChangeListLoadQueryRequest, ChangesetChangeListLoadQueryResponse>(this);
		}
	}
}
