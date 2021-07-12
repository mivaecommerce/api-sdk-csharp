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
	/// Handles API Request OrderItem_Split.
	/// <see>https://docs.miva.com/json-api/functions/orderitem_split</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderItemSplitRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Line_ID.
		[JsonPropertyName("Line_ID")]
		public int LineId { get; set; }

		/// Request field Quantity.
		[JsonPropertyName("Quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="orderItem">OrderItem</param>
		/// </summary>
		public OrderItemSplitRequest(BaseClient client = null, OrderItem orderItem = null) :
			base(client)
		{
			Function = "OrderItem_Split";
			if (orderItem != null) {
				if (orderItem.OrderId > 0)
				{
					OrderId = orderItem.OrderId;
				}

				if (orderItem.LineId > 0)
				{
					LineId = orderItem.LineId;
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
		/// Getter for Line_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetLineId()
		{
			return LineId;
		}

		/// <summary>
		/// Getter for Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemSplitRequest</returns>
		/// </summary>
		public OrderItemSplitRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Line_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemSplitRequest</returns>
		/// </summary>
		public OrderItemSplitRequest SetLineId(int value)
		{
			LineId = value;
			return this;
		}

		/// <summary>
		/// Setter for Quantity.
		/// <param name="value">int</param>
		/// <returns>OrderItemSplitRequest</returns>
		/// </summary>
		public OrderItemSplitRequest SetQuantity(int value)
		{
			Quantity = value;
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

			if (LineId > 0)
			{
				writer.WriteNumber("Line_ID", LineId);
			}

			writer.WriteNumber("Quantity", Quantity);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderItemSplitResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderItemSplitResponse</returns>
		/// </summary>
		public new OrderItemSplitResponse Send()
		{
			return Client.SendRequestAsync<OrderItemSplitRequest, OrderItemSplitResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderItemSplitResponse></returns>
		/// </summary>
		public new async Task<OrderItemSplitResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderItemSplitRequest, OrderItemSplitResponse>(this);
		}
	}
}
