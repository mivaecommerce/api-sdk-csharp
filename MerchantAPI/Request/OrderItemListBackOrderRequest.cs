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
	/// Handles API Request OrderItemList_BackOrder.
	/// <see>https://docs.miva.com/json-api/functions/orderitemlist_backorder</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderItemListBackOrderRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Line_IDs.
		public List<int> LineIds { get; set; } = new List<int>();

		/// Request field Date_InStock.
		[JsonPropertyName("Date_InStock")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? DateInStock { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderItemListBackOrderRequest(Client client = null, Order order = null) :
			base(client)
		{
			Function = "OrderItemList_BackOrder";
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
		/// Getter for Date_InStock.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime? GetDateInStock()
		{
			return DateInStock;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemListBackOrderRequest</returns>
		/// </summary>
		public OrderItemListBackOrderRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Date_InStock.
		/// <param name="value">DateTime</param>
		/// <returns>OrderItemListBackOrderRequest</returns>
		/// </summary>
		public OrderItemListBackOrderRequest SetDateInStock(DateTime? value)
		{
			DateInStock = value;
			return this;
		}

		/// <summary>
		/// Setter for Date_InStock using a unix timestamp.
		/// <param name="value">long</param>
		/// <returns>OrderItemListBackOrderRequest</returns>
		/// </summary>
		public OrderItemListBackOrderRequest SetDateInStock(long? value)
		{
			if (!value.HasValue)
			{
				DateInStock = null;
				return this;
			}

			DateInStock = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value.Value));
			return this;
		}

		/// <summary>
		/// Add Line_IDs.
		///	- lineId: Int
		/// - Returns: Self
		/// </summary>
		public OrderItemListBackOrderRequest AddLineId(int lineId)
		{
			LineIds.Add(lineId);
			return this;
		}

		/// <summary>
		/// Add OrderItem model.
		/// <param name="orderItem">OrderItem></param>
		/// <returns>OrderItemListBackOrderRequest</returns>
		/// </summary>
		public OrderItemListBackOrderRequest AddOrderItem(OrderItem orderItem)
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

			if (DateInStock.HasValue)
			{
				writer.WriteNumber("Date_InStock", new DateTimeOffset(DateInStock.Value).ToUnixTimeSeconds());
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderItemListBackOrderResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderItemListBackOrderResponse</returns>
		/// </summary>
		public new OrderItemListBackOrderResponse Send()
		{
			return Client.SendRequestAsync<OrderItemListBackOrderRequest, OrderItemListBackOrderResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderItemListBackOrderResponse></returns>
		/// </summary>
		public new async Task<OrderItemListBackOrderResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderItemListBackOrderRequest, OrderItemListBackOrderResponse>(this);
		}
	}
}
