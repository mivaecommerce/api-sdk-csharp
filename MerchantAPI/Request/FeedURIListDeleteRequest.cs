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
	/// Handles API Request FeedURIList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/feedurilist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class FeedURIListDeleteRequest : Request
	{
		/// Request field URI_IDs.
		public List<int> UriIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public FeedURIListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "FeedURIList_Delete";
		}

		/// <summary>
		/// Add URI_IDs.
		///	- uriId: Int
		/// - Returns: Self
		/// </summary>
		public FeedURIListDeleteRequest AddUriID(int uriId)
		{
			UriIds.Add(uriId);
			return this;
		}

		/// <summary>
		/// Add Uri model.
		/// <param name="uri">Uri></param>
		/// <returns>FeedURIListDeleteRequest</returns>
		/// </summary>
		public FeedURIListDeleteRequest AddUri(Uri uri)
		{
			if (uri.Id > 0)
			{
				UriIds.Add(uri.Id);
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

			writer.WritePropertyName("URI_IDs");
			JsonSerializer.Serialize(writer, this.UriIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<FeedURIListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>FeedURIListDeleteResponse</returns>
		/// </summary>
		public new FeedURIListDeleteResponse Send()
		{
			return Client.SendRequestAsync<FeedURIListDeleteRequest, FeedURIListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<FeedURIListDeleteResponse></returns>
		/// </summary>
		public new async Task<FeedURIListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<FeedURIListDeleteRequest, FeedURIListDeleteResponse>(this);
		}
	}
}
