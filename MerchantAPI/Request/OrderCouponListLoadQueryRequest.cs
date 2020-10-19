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
	/// Handles API Request OrderCouponList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/ordercouponlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderCouponListLoadQueryRequest : CouponListLoadQueryRequest
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderCouponListLoadQueryRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderCouponList_Load_Query";
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
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Getter for Unassigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUnassigned()
		{
			return Unassigned;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderCouponListLoadQueryRequest</returns>
		/// </summary>
		public OrderCouponListLoadQueryRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>OrderCouponListLoadQueryRequest</returns>
		/// </summary>
		public OrderCouponListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>OrderCouponListLoadQueryRequest</returns>
		/// </summary>
		public OrderCouponListLoadQueryRequest SetUnassigned(bool? value)
		{
			Unassigned = value;
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

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}

			if (Unassigned.HasValue)
			{
				writer.WriteBoolean("Unassigned", Unassigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderCouponListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderCouponListLoadQueryResponse</returns>
		/// </summary>
		public new OrderCouponListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<OrderCouponListLoadQueryRequest, OrderCouponListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderCouponListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<OrderCouponListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderCouponListLoadQueryRequest, OrderCouponListLoadQueryResponse>(this);
		}
	}
}
