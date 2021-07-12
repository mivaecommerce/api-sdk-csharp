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
	/// Handles API Request Store_Load.
	/// <see>https://docs.miva.com/json-api/functions/store_load</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class StoreLoadRequest : Request
	{

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public StoreLoadRequest(BaseClient client = null) :
			base(client)
		{
			Function = "Store_Load";
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
			return JsonSerializer.Deserialize<StoreLoadResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>StoreLoadResponse</returns>
		/// </summary>
		public new StoreLoadResponse Send()
		{
			return Client.SendRequestAsync<StoreLoadRequest, StoreLoadResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<StoreLoadResponse></returns>
		/// </summary>
		public new async Task<StoreLoadResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<StoreLoadRequest, StoreLoadResponse>(this);
		}
	}
}
