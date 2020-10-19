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
	/// Handles API Request OrderItemList_CreateShipment.
	/// <see>https://docs.miva.com/json-api/functions/orderitemlist_createshipment</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderItemListCreateShipmentRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Line_IDs.
		public List<int> LineIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderItemListCreateShipmentRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderItemList_CreateShipment";
			if (order != null) {
				OrderId = order.Id;
			}
		}

		/// <summary>
		/// Getter for Order_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemListCreateShipmentRequest</returns>
		/// </summary>
		public OrderItemListCreateShipmentRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Add Line_IDs.
		///	- lineId: Int
		/// - Returns: Self
		/// </summary>
		public OrderItemListCreateShipmentRequest AddLineId(int lineId)
		{
			LineIds.Add(lineId);
			return this;
		}

		/// <summary>
		/// Add OrderItem model.
		/// <param name="orderItem">OrderItem></param>
		/// <returns>OrderItemListCreateShipmentRequest</returns>
		/// </summary>
		public OrderItemListCreateShipmentRequest AddOrderItem(OrderItem orderItem)
		{
			if (orderItem.LineId > 0)
			{
				LineIds.Add(orderItem.LineId);
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

			writer.WriteNumber("Order_ID", OrderId);

			writer.WritePropertyName("Line_IDs");
			JsonSerializer.Serialize(writer, this.LineIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderItemListCreateShipmentResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderItemListCreateShipmentResponse</returns>
		/// </summary>
		public new OrderItemListCreateShipmentResponse Send()
		{
			return Client.SendRequestAsync<OrderItemListCreateShipmentRequest, OrderItemListCreateShipmentResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderItemListCreateShipmentResponse></returns>
		/// </summary>
		public new async Task<OrderItemListCreateShipmentResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderItemListCreateShipmentRequest, OrderItemListCreateShipmentResponse>(this);
		}
	}
}
