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
	/// Handles API Request OrderItemList_Cancel.
	/// <see>https://docs.miva.com/json-api/functions/orderitemlist_cancel</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderItemListCancelRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Line_IDs.
		public List<int> LineIds { get; set; } = new List<int>();

		/// Request field Reason.
		[JsonPropertyName("Reason")]
		public String Reason { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderItemListCancelRequest(Client client = null, Order order = null) :
			base(client)
		{
			Function = "OrderItemList_Cancel";
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
		/// Getter for Reason.
		/// <returns>String</returns>
		/// </summary>
		public String GetReason()
		{
			return Reason;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemListCancelRequest</returns>
		/// </summary>
		public OrderItemListCancelRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Reason.
		/// <param name="value">String</param>
		/// <returns>OrderItemListCancelRequest</returns>
		/// </summary>
		public OrderItemListCancelRequest SetReason(String value)
		{
			Reason = value;
			return this;
		}

		/// <summary>
		/// Add Line_IDs.
		///	- lineId: Int
		/// - Returns: Self
		/// </summary>
		public OrderItemListCancelRequest AddLineId(int lineId)
		{
			LineIds.Add(lineId);
			return this;
		}

		/// <summary>
		/// Add OrderItem model.
		/// <param name="orderItem">OrderItem></param>
		/// <returns>OrderItemListCancelRequest</returns>
		/// </summary>
		public OrderItemListCancelRequest AddOrderItem(OrderItem orderItem)
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

			if (Reason != null && Reason.Length > 0)
			{
				writer.WriteString("Reason", Reason);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderItemListCancelResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderItemListCancelResponse</returns>
		/// </summary>
		public new OrderItemListCancelResponse Send()
		{
			return Client.SendRequestAsync<OrderItemListCancelRequest, OrderItemListCancelResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderItemListCancelResponse></returns>
		/// </summary>
		public new async Task<OrderItemListCancelResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderItemListCancelRequest, OrderItemListCancelResponse>(this);
		}
	}
}
