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
	/// Handles API Request OrderPriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/orderpricegrouplist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderPriceGroupListLoadQueryRequest : PriceGroupListLoadQueryRequest
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
		public OrderPriceGroupListLoadQueryRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderPriceGroupList_Load_Query";
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
		/// <returns>OrderPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public OrderPriceGroupListLoadQueryRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>OrderPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public OrderPriceGroupListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>OrderPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public OrderPriceGroupListLoadQueryRequest SetUnassigned(bool? value)
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

			if (OrderId > 0)
			{
				writer.WriteNumber("Order_ID", OrderId);
			}

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
			return JsonSerializer.Deserialize<OrderPriceGroupListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderPriceGroupListLoadQueryResponse</returns>
		/// </summary>
		public new OrderPriceGroupListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<OrderPriceGroupListLoadQueryRequest, OrderPriceGroupListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderPriceGroupListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<OrderPriceGroupListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderPriceGroupListLoadQueryRequest, OrderPriceGroupListLoadQueryResponse>(this);
		}
	}
}
