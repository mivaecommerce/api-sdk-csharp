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
	/// Handles API Request OrderPayment_Refund.
	/// <see>https://docs.miva.com/json-api/functions/orderpayment_refund</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderPaymentRefundRequest : Request
	{
		/// Request field OrderPayment_ID.
		[JsonPropertyName("OrderPayment_ID")]
		public int OrderPaymentId { get; set; }

		/// Request field Amount.
		[JsonPropertyName("Amount")]
		public float? Amount { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="orderPayment">OrderPayment</param>
		/// </summary>
		public OrderPaymentRefundRequest(BaseClient client = null, OrderPayment orderPayment = null) :
			base(client)
		{
			Function = "OrderPayment_Refund";
			if (orderPayment != null) {
				OrderPaymentId = orderPayment.Id;
			}
		}

		/// <summary>
		/// Getter for OrderPayment_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderPaymentId()
		{
			return OrderPaymentId;
		}

		/// <summary>
		/// Getter for Amount.
		/// <returns>float</returns>
		/// </summary>
		public float? GetAmount()
		{
			return Amount;
		}

		/// <summary>
		/// Setter for OrderPayment_ID.
		/// <param name="value">int</param>
		/// <returns>OrderPaymentRefundRequest</returns>
		/// </summary>
		public OrderPaymentRefundRequest SetOrderPaymentId(int value)
		{
			OrderPaymentId = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">float</param>
		/// <returns>OrderPaymentRefundRequest</returns>
		/// </summary>
	   public OrderPaymentRefundRequest SetAmount(float? value)
	   {
			Amount = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">double</param>
		/// <returns>OrderPaymentRefundRequest</returns>
		/// </summary>
	   public OrderPaymentRefundRequest SetAmount(double? value)
	   {
			Amount = (float?) value;
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

			writer.WriteNumber("OrderPayment_ID", OrderPaymentId);

			if (Amount.HasValue)
			{
				writer.WriteNumber("Amount", Amount.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderPaymentRefundResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderPaymentRefundResponse</returns>
		/// </summary>
		public new OrderPaymentRefundResponse Send()
		{
			return Client.SendRequestAsync<OrderPaymentRefundRequest, OrderPaymentRefundResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderPaymentRefundResponse></returns>
		/// </summary>
		public new async Task<OrderPaymentRefundResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderPaymentRefundRequest, OrderPaymentRefundResponse>(this);
		}
	}
}
