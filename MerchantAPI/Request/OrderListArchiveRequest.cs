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
	/// Handles API Request OrderList_Archive.
	/// <see>https://docs.miva.com/json-api/functions/orderlist_archive</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderListArchiveRequest : Request
	{
		/// Request field Delete_Payment_Data.
		[JsonPropertyName("Delete_Payment_Data")]
		public bool? DeletePaymentData { get; set; }

		/// Request field Delete_Shipping_Labels.
		[JsonPropertyName("Delete_Shipping_Labels")]
		public bool? DeleteShippingLabels { get; set; }

		/// Request field Order_IDs.
		public List<int> OrderIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public OrderListArchiveRequest(BaseClient client = null) :
			base(client)
		{
			Function = "OrderList_Archive";
		}

		/// <summary>
		/// Getter for Delete_Payment_Data.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDeletePaymentData()
		{
			return DeletePaymentData;
		}

		/// <summary>
		/// Getter for Delete_Shipping_Labels.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDeleteShippingLabels()
		{
			return DeleteShippingLabels;
		}

		/// <summary>
		/// Setter for Delete_Payment_Data.
		/// <param name="value">bool</param>
		/// <returns>OrderListArchiveRequest</returns>
		/// </summary>
		public OrderListArchiveRequest SetDeletePaymentData(bool? value)
		{
			DeletePaymentData = value;
			return this;
		}

		/// <summary>
		/// Setter for Delete_Shipping_Labels.
		/// <param name="value">bool</param>
		/// <returns>OrderListArchiveRequest</returns>
		/// </summary>
		public OrderListArchiveRequest SetDeleteShippingLabels(bool? value)
		{
			DeleteShippingLabels = value;
			return this;
		}

		/// <summary>
		/// Add Order_IDs.
		///	- orderId: Int
		/// - Returns: Self
		/// </summary>
		public OrderListArchiveRequest AddOrderId(int orderId)
		{
			OrderIds.Add(orderId);
			return this;
		}

		/// <summary>
		/// Add Order model.
		/// <param name="order">Order></param>
		/// <returns>OrderListArchiveRequest</returns>
		/// </summary>
		public OrderListArchiveRequest AddOrder(Order order)
		{
			if (order.Id > 0)
			{
				OrderIds.Add(order.Id);
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

			if (DeletePaymentData.HasValue)
			{
				writer.WriteBoolean("Delete_Payment_Data", DeletePaymentData.Value);
			}

			if (DeleteShippingLabels.HasValue)
			{
				writer.WriteBoolean("Delete_Shipping_Labels", DeleteShippingLabels.Value);
			}

			writer.WritePropertyName("Order_IDs");
			JsonSerializer.Serialize(writer, this.OrderIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderListArchiveResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderListArchiveResponse</returns>
		/// </summary>
		public new OrderListArchiveResponse Send()
		{
			return Client.SendRequestAsync<OrderListArchiveRequest, OrderListArchiveResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderListArchiveResponse></returns>
		/// </summary>
		public new async Task<OrderListArchiveResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderListArchiveRequest, OrderListArchiveResponse>(this);
		}
	}
}
