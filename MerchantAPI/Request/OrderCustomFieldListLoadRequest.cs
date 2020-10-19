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
	/// Handles API Request OrderCustomFieldList_Load.
	/// <see>https://docs.miva.com/json-api/functions/ordercustomfieldlist_load</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderCustomFieldListLoadRequest : Request
	{

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public OrderCustomFieldListLoadRequest(BaseClient client = null) :
			base(client)
		{
			Function = "OrderCustomFieldList_Load";
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
			return JsonSerializer.Deserialize<OrderCustomFieldListLoadResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderCustomFieldListLoadResponse</returns>
		/// </summary>
		public new OrderCustomFieldListLoadResponse Send()
		{
			return Client.SendRequestAsync<OrderCustomFieldListLoadRequest, OrderCustomFieldListLoadResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderCustomFieldListLoadResponse></returns>
		/// </summary>
		public new async Task<OrderCustomFieldListLoadResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderCustomFieldListLoadRequest, OrderCustomFieldListLoadResponse>(this);
		}
	}
}
