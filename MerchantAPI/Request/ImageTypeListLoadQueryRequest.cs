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
	/// Handles API Request ImageTypeList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/imagetypelist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ImageTypeListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"code",
			"descrip"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ImageTypeListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "ImageTypeList_Load_Query";
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ImageTypeListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ImageTypeListLoadQueryResponse</returns>
		/// </summary>
		public new ImageTypeListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ImageTypeListLoadQueryRequest, ImageTypeListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ImageTypeListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ImageTypeListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ImageTypeListLoadQueryRequest, ImageTypeListLoadQueryResponse>(this);
		}
	}
}
