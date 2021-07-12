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
	/// Handles API Request ProductURIList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/producturilist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductURIListDeleteRequest : Request
	{
		/// Request field URI_IDs.
		public List<int> UriIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ProductURIListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "ProductURIList_Delete";
		}

		/// <summary>
		/// Add URI_IDs.
		///	- uriId: Int
		/// - Returns: Self
		/// </summary>
		public ProductURIListDeleteRequest AddUriID(int uriId)
		{
			UriIds.Add(uriId);
			return this;
		}

		/// <summary>
		/// Add Uri model.
		/// <param name="uri">Uri></param>
		/// <returns>ProductURIListDeleteRequest</returns>
		/// </summary>
		public ProductURIListDeleteRequest AddUri(Uri uri)
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
			return JsonSerializer.Deserialize<ProductURIListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductURIListDeleteResponse</returns>
		/// </summary>
		public new ProductURIListDeleteResponse Send()
		{
			return Client.SendRequestAsync<ProductURIListDeleteRequest, ProductURIListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductURIListDeleteResponse></returns>
		/// </summary>
		public new async Task<ProductURIListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductURIListDeleteRequest, ProductURIListDeleteResponse>(this);
		}
	}
}
