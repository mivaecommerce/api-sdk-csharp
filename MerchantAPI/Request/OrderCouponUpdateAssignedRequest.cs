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
	/// Handles API Request OrderCoupon_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/ordercoupon_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderCouponUpdateAssignedRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Coupon_ID.
		[JsonPropertyName("Coupon_ID")]
		public int? CouponId { get; set; }

		/// Request field Edit_Coupon.
		[JsonPropertyName("Edit_Coupon")]
		public String EditCoupon { get; set; }

		/// Request field Coupon_Code.
		[JsonPropertyName("Coupon_Code")]
		public String CouponCode { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderCouponUpdateAssignedRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderCoupon_Update_Assigned";
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
		/// Getter for Coupon_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCouponId()
		{
			return CouponId;
		}

		/// <summary>
		/// Getter for Edit_Coupon.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCoupon()
		{
			return EditCoupon;
		}

		/// <summary>
		/// Getter for Coupon_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCouponCode()
		{
			return CouponCode;
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
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderCouponUpdateAssignedRequest</returns>
		/// </summary>
		public OrderCouponUpdateAssignedRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_ID.
		/// <param name="value">int</param>
		/// <returns>OrderCouponUpdateAssignedRequest</returns>
		/// </summary>
		public OrderCouponUpdateAssignedRequest SetCouponId(int? value)
		{
			CouponId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Coupon.
		/// <param name="value">String</param>
		/// <returns>OrderCouponUpdateAssignedRequest</returns>
		/// </summary>
		public OrderCouponUpdateAssignedRequest SetEditCoupon(String value)
		{
			EditCoupon = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_Code.
		/// <param name="value">String</param>
		/// <returns>OrderCouponUpdateAssignedRequest</returns>
		/// </summary>
		public OrderCouponUpdateAssignedRequest SetCouponCode(String value)
		{
			CouponCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>OrderCouponUpdateAssignedRequest</returns>
		/// </summary>
		public OrderCouponUpdateAssignedRequest SetAssigned(bool? value)
		{
			Assigned = value;
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

			if (CouponId.HasValue)
			{
				writer.WriteNumber("Coupon_ID", CouponId.Value);
			}
			else if (EditCoupon != null && EditCoupon.Length > 0)
			{
				writer.WriteString("Edit_Coupon", EditCoupon);
			}
			else if (CouponCode != null && CouponCode.Length > 0)
			{
				writer.WriteString("Coupon_Code", CouponCode);
			}

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderCouponUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderCouponUpdateAssignedResponse</returns>
		/// </summary>
		public new OrderCouponUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<OrderCouponUpdateAssignedRequest, OrderCouponUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderCouponUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<OrderCouponUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderCouponUpdateAssignedRequest, OrderCouponUpdateAssignedResponse>(this);
		}
	}
}
