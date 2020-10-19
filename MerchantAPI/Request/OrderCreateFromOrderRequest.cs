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
	/// Handles API Request Order_Create_FromOrder.
	/// <see>https://docs.miva.com/json-api/functions/order_create_fromorder</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderCreateFromOrderRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int? OrderId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderCreateFromOrderRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "Order_Create_FromOrder";
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
		public int? GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderCreateFromOrderRequest</returns>
		/// </summary>
		public OrderCreateFromOrderRequest SetOrderId(int? value)
		{
			OrderId = value;
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

			if (OrderId.HasValue)
			{
				writer.WriteNumber("Order_ID", OrderId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderCreateFromOrderResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderCreateFromOrderResponse</returns>
		/// </summary>
		public new OrderCreateFromOrderResponse Send()
		{
			return Client.SendRequestAsync<OrderCreateFromOrderRequest, OrderCreateFromOrderResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderCreateFromOrderResponse></returns>
		/// </summary>
		public new async Task<OrderCreateFromOrderResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderCreateFromOrderRequest, OrderCreateFromOrderResponse>(this);
		}
	}
}
