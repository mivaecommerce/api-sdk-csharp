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
	/// Handles API Request ProductAndSubscriptionTermList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productandsubscriptiontermlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductAndSubscriptionTermListLoadQueryRequest : ProductListLoadQueryRequest
	{

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ProductAndSubscriptionTermListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "ProductAndSubscriptionTermList_Load_Query";
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
			return JsonSerializer.Deserialize<ProductAndSubscriptionTermListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductAndSubscriptionTermListLoadQueryResponse</returns>
		/// </summary>
		public new ProductAndSubscriptionTermListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ProductAndSubscriptionTermListLoadQueryRequest, ProductAndSubscriptionTermListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductAndSubscriptionTermListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ProductAndSubscriptionTermListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductAndSubscriptionTermListLoadQueryRequest, ProductAndSubscriptionTermListLoadQueryResponse>(this);
		}
	}
}
