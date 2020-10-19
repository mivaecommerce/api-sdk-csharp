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
	/// Handles API Request OrderCustomFields_Update.
	/// <see>https://docs.miva.com/json-api/functions/ordercustomfields_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderCustomFieldsUpdateRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderCustomFieldsUpdateRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderCustomFields_Update";
			CustomFieldValues = new CustomFieldValues();
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
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderCustomFieldsUpdateRequest</returns>
		/// </summary>
		public OrderCustomFieldsUpdateRequest SetOrderId(int value)
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

			if (OrderId > 0)
			{
				writer.WriteNumber("Order_ID", OrderId);
			}

			writer.WritePropertyName("CustomField_Values");
			JsonSerializer.Serialize(writer, this.CustomFieldValues, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderCustomFieldsUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderCustomFieldsUpdateResponse</returns>
		/// </summary>
		public new OrderCustomFieldsUpdateResponse Send()
		{
			return Client.SendRequestAsync<OrderCustomFieldsUpdateRequest, OrderCustomFieldsUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderCustomFieldsUpdateResponse></returns>
		/// </summary>
		public new async Task<OrderCustomFieldsUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderCustomFieldsUpdateRequest, OrderCustomFieldsUpdateResponse>(this);
		}
	}
}
