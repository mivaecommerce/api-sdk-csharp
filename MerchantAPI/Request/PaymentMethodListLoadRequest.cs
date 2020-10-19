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
	/// Handles API Request PaymentMethodList_Load.
	/// <see>https://docs.miva.com/json-api/functions/paymentmethodlist_load</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PaymentMethodListLoadRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int? OrderId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public PaymentMethodListLoadRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "PaymentMethodList_Load";
			if (order != null) {
				OrderId = order.Id;
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
		/// <returns>PaymentMethodListLoadRequest</returns>
		/// </summary>
		public PaymentMethodListLoadRequest SetOrderId(int? value)
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
			return JsonSerializer.Deserialize<PaymentMethodListLoadResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PaymentMethodListLoadResponse</returns>
		/// </summary>
		public new PaymentMethodListLoadResponse Send()
		{
			return Client.SendRequestAsync<PaymentMethodListLoadRequest, PaymentMethodListLoadResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PaymentMethodListLoadResponse></returns>
		/// </summary>
		public new async Task<PaymentMethodListLoadResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PaymentMethodListLoadRequest, PaymentMethodListLoadResponse>(this);
		}
	}
}
