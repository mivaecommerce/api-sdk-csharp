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
	/// Handles API Request OrderItemList_CreateReturn.
	/// <see>https://docs.miva.com/json-api/functions/orderitemlist_createreturn</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderItemListCreateReturnRequest : Request
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
		public OrderItemListCreateReturnRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderItemList_CreateReturn";
			if (order != null) {
				if (order.Id > 0)
				{
					OrderId = order.Id;
				}
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
		/// <returns>OrderItemListCreateReturnRequest</returns>
		/// </summary>
		public OrderItemListCreateReturnRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Add Line_IDs.
		///	- lineId: Int
		/// - Returns: Self
		/// </summary>
		public OrderItemListCreateReturnRequest AddLineId(int lineId)
		{
			LineIds.Add(lineId);
			return this;
		}

		/// <summary>
		/// Add OrderItem model.
		/// <param name="orderItem">OrderItem></param>
		/// <returns>OrderItemListCreateReturnRequest</returns>
		/// </summary>
		public OrderItemListCreateReturnRequest AddOrderItem(OrderItem orderItem)
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

			if (OrderId > 0)
			{
				writer.WriteNumber("Order_ID", OrderId);
			}

			writer.WritePropertyName("Line_IDs");
			JsonSerializer.Serialize(writer, this.LineIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderItemListCreateReturnResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderItemListCreateReturnResponse</returns>
		/// </summary>
		public new OrderItemListCreateReturnResponse Send()
		{
			return Client.SendRequestAsync<OrderItemListCreateReturnRequest, OrderItemListCreateReturnResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderItemListCreateReturnResponse></returns>
		/// </summary>
		public new async Task<OrderItemListCreateReturnResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderItemListCreateReturnRequest, OrderItemListCreateReturnResponse>(this);
		}
	}
}
