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
	/// Handles API Request ChangesetItemVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/changesetitemversionlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ChangesetItemVersionListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Changeset_ID.
		[JsonPropertyName("Changeset_ID")]
		public int ChangesetId { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"item_id",
			"user_id",
			"user_name",
			"code",
			"module_code",
			"module_name"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"item_id",
			"user_id",
			"user_name",
			"code",
			"module_id",
			"module_code",
			"module_name"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="changeset">Changeset</param>
		/// </summary>
		public ChangesetItemVersionListLoadQueryRequest(BaseClient client = null, Changeset changeset = null) :
			base(client)
		{
			Function = "ChangesetItemVersionList_Load_Query";
			if (changeset != null) {
				if (changeset.Id > 0)
				{
					ChangesetId = changeset.Id;
				}
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
		/// <returns>ChangesetItemVersionListLoadQueryRequest</returns>
		/// </summary>
		public ChangesetItemVersionListLoadQueryRequest SetChangesetId(int value)
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

			if (ChangesetId > 0)
			{
				writer.WriteNumber("Changeset_ID", ChangesetId);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ChangesetItemVersionListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ChangesetItemVersionListLoadQueryResponse</returns>
		/// </summary>
		public new ChangesetItemVersionListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ChangesetItemVersionListLoadQueryRequest, ChangesetItemVersionListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ChangesetItemVersionListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ChangesetItemVersionListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ChangesetItemVersionListLoadQueryRequest, ChangesetItemVersionListLoadQueryResponse>(this);
		}
	}
}
