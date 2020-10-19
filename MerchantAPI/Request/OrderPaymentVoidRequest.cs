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
	/// Handles API Request OrderPayment_VOID.
	/// <see>https://docs.miva.com/json-api/functions/orderpayment_void</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderPaymentVoidRequest : Request
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
		public OrderPaymentVoidRequest(BaseClient client = null, OrderPayment orderPayment = null) :
			base(client)
		{
			Function = "OrderPayment_VOID";
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
		/// <returns>OrderPaymentVoidRequest</returns>
		/// </summary>
		public OrderPaymentVoidRequest SetOrderPaymentId(int value)
		{
			OrderPaymentId = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">float</param>
		/// <returns>OrderPaymentVoidRequest</returns>
		/// </summary>
	   public OrderPaymentVoidRequest SetAmount(float? value)
	   {
			Amount = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">double</param>
		/// <returns>OrderPaymentVoidRequest</returns>
		/// </summary>
	   public OrderPaymentVoidRequest SetAmount(double? value)
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
			return JsonSerializer.Deserialize<OrderPaymentVoidResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderPaymentVoidResponse</returns>
		/// </summary>
		public new OrderPaymentVoidResponse Send()
		{
			return Client.SendRequestAsync<OrderPaymentVoidRequest, OrderPaymentVoidResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderPaymentVoidResponse></returns>
		/// </summary>
		public new async Task<OrderPaymentVoidResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderPaymentVoidRequest, OrderPaymentVoidResponse>(this);
		}
	}
}
