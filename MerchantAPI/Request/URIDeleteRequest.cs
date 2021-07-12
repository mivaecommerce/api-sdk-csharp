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
	/// Handles API Request URI_Delete.
	/// <see>https://docs.miva.com/json-api/functions/uri_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class URIDeleteRequest : Request
	{
		/// Request field URI_ID.
		[JsonPropertyName("URI_ID")]
		public int UriId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="uri">Uri</param>
		/// </summary>
		public URIDeleteRequest(BaseClient client = null, Uri uri = null) :
			base(client)
		{
			Function = "URI_Delete";
			Scope = RequestScope.Domain;
			if (uri != null) {
				if (uri.Id > 0)
				{
					UriId = uri.Id;
				}
			}
		}

		/// <summary>
		/// Getter for URI_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetUriId()
		{
			return UriId;
		}

		/// <summary>
		/// Setter for URI_ID.
		/// <param name="value">int</param>
		/// <returns>URIDeleteRequest</returns>
		/// </summary>
		public URIDeleteRequest SetUriId(int value)
		{
			UriId = value;
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

			if (UriId > 0)
			{
				writer.WriteNumber("URI_ID", UriId);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<URIDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>URIDeleteResponse</returns>
		/// </summary>
		public new URIDeleteResponse Send()
		{
			return Client.SendRequestAsync<URIDeleteRequest, URIDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<URIDeleteResponse></returns>
		/// </summary>
		public new async Task<URIDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<URIDeleteRequest, URIDeleteResponse>(this);
		}
	}
}
