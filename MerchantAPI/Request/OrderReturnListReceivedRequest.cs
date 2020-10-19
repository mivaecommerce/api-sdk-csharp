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
	/// Handles API Request OrderReturnList_Received.
	/// <see>https://docs.miva.com/json-api/functions/orderreturnlist_received</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderReturnListReceivedRequest : Request
	{
		/// Request field Returns.
		[JsonPropertyName("Returns")]
		public List<ReceivedReturn> Returns { get; set; } = new List<ReceivedReturn>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public OrderReturnListReceivedRequest(BaseClient client = null) :
			base(client)
		{
			Function = "OrderReturnList_Received";
		}

		/// <summary>
		/// Getter for Returns.
		/// <returns>List<ReceivedReturn></returns>
		/// </summary>
		public List<ReceivedReturn> GetReturns()
		{
			return Returns;
		}

		/// <summary>
		/// Add a ReceivedReturn.
		/// - receivedReturn: ReceivedReturn
		/// - Returns: Self
		/// </summary>
		public OrderReturnListReceivedRequest AddReceivedReturn(ReceivedReturn receivedReturn)
		{
			Returns.Add(receivedReturn);
			return this;
		}

		/// <summary>
		/// Add an array of ReceivedReturn.
		/// <param name="returns">List<ReceivedReturn></param>
		/// <returns>OrderReturnListReceivedRequest</returns>
		/// </summary>
		public OrderReturnListReceivedRequest AddReturns(List<ReceivedReturn> returns)
		{
			foreach(ReceivedReturn e in returns)
			{
				Returns.Add(e);
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

			writer.WritePropertyName("Returns");
			JsonSerializer.Serialize(writer, this.Returns, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderReturnListReceivedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderReturnListReceivedResponse</returns>
		/// </summary>
		public new OrderReturnListReceivedResponse Send()
		{
			return Client.SendRequestAsync<OrderReturnListReceivedRequest, OrderReturnListReceivedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderReturnListReceivedResponse></returns>
		/// </summary>
		public new async Task<OrderReturnListReceivedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderReturnListReceivedRequest, OrderReturnListReceivedResponse>(this);
		}
	}
}
