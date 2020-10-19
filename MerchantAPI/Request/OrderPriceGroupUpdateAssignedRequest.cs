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
	/// Handles API Request OrderPriceGroup_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/orderpricegroup_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderPriceGroupUpdateAssignedRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field PriceGroup_ID.
		[JsonPropertyName("PriceGroup_ID")]
		public int? PriceGroupId { get; set; }

		/// Request field PriceGroup_Name.
		[JsonPropertyName("PriceGroup_Name")]
		public String PriceGroupName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderPriceGroupUpdateAssignedRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "OrderPriceGroup_Update_Assigned";
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
		/// Getter for PriceGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPriceGroupId()
		{
			return PriceGroupId;
		}

		/// <summary>
		/// Getter for PriceGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetPriceGroupName()
		{
			return PriceGroupName;
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
		/// <returns>OrderPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public OrderPriceGroupUpdateAssignedRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>OrderPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public OrderPriceGroupUpdateAssignedRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>OrderPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public OrderPriceGroupUpdateAssignedRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>OrderPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public OrderPriceGroupUpdateAssignedRequest SetAssigned(bool? value)
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

			if (PriceGroupId.HasValue)
			{
				writer.WriteNumber("PriceGroup_ID", PriceGroupId.Value);
			}
			else if (PriceGroupName != null && PriceGroupName.Length > 0)
			{
				writer.WriteString("PriceGroup_Name", PriceGroupName);
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
			return JsonSerializer.Deserialize<OrderPriceGroupUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderPriceGroupUpdateAssignedResponse</returns>
		/// </summary>
		public new OrderPriceGroupUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<OrderPriceGroupUpdateAssignedRequest, OrderPriceGroupUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderPriceGroupUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<OrderPriceGroupUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderPriceGroupUpdateAssignedRequest, OrderPriceGroupUpdateAssignedResponse>(this);
		}
	}
}
