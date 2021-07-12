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
	/// Handles API Request FeedURIList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/feedurilist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class FeedURIListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Feed_ID.
		[JsonPropertyName("Feed_ID")]
		public int? FeedId { get; set; }

		/// Request field Feed_Code.
		[JsonPropertyName("Feed_Code")]
		public String FeedCode { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"canonical",
			"status",
			"uri"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"uri"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public FeedURIListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "FeedURIList_Load_Query";
		}

		/// <summary>
		/// Getter for Feed_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetFeedId()
		{
			return FeedId;
		}

		/// <summary>
		/// Getter for Feed_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetFeedCode()
		{
			return FeedCode;
		}

		/// <summary>
		/// Setter for Feed_ID.
		/// <param name="value">int</param>
		/// <returns>FeedURIListLoadQueryRequest</returns>
		/// </summary>
		public FeedURIListLoadQueryRequest SetFeedId(int? value)
		{
			FeedId = value;
			return this;
		}

		/// <summary>
		/// Setter for Feed_Code.
		/// <param name="value">String</param>
		/// <returns>FeedURIListLoadQueryRequest</returns>
		/// </summary>
		public FeedURIListLoadQueryRequest SetFeedCode(String value)
		{
			FeedCode = value;
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

			if (FeedId.HasValue)
			{
				writer.WriteNumber("Feed_ID", FeedId.Value);
			}
			else if (FeedCode != null && FeedCode.Length > 0)
			{
				writer.WriteString("Feed_Code", FeedCode);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<FeedURIListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>FeedURIListLoadQueryResponse</returns>
		/// </summary>
		public new FeedURIListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<FeedURIListLoadQueryRequest, FeedURIListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<FeedURIListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<FeedURIListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<FeedURIListLoadQueryRequest, FeedURIListLoadQueryResponse>(this);
		}
	}
}
