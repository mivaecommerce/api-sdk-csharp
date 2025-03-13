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
	/// Handles API Request Order_Authorize.
	/// <see>https://docs.miva.com/json-api/functions/order_authorize</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderAuthorizeRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int? OrderId { get; set; }

		/// Request field Module_ID.
		[JsonPropertyName("Module_ID")]
		public int? ModuleId { get; set; }

		/// Request field Module_Data.
		[JsonPropertyName("Module_Data")]
		public String ModuleData { get; set; }

		/// Request field Amount.
		[JsonPropertyName("Amount")]
		public float Amount { get; set; }

		/// User set request fields
		public Dictionary<String, IConvertible> ModuleFields { get; set; } = new Dictionary<String, IConvertible>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="order">Order</param>
		/// </summary>
		public OrderAuthorizeRequest(BaseClient client = null, Order order = null) :
			base(client)
		{
			Function = "Order_Authorize";
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
		/// Getter for Module_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetModuleId()
		{
			return ModuleId;
		}

		/// <summary>
		/// Getter for Module_Data.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleData()
		{
			return ModuleData;
		}

		/// <summary>
		/// Getter for Amount.
		/// <returns>float</returns>
		/// </summary>
		public float GetAmount()
		{
			return Amount;
		}

		/// <summary>
		///  Get user set request fields.
		/// <returns>Dictionary<String, IConvertible></returns>
		/// </summary>
		public Dictionary<String, IConvertible> GetModuleFields()
		{
			return ModuleFields;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderAuthorizeRequest</returns>
		/// </summary>
		public OrderAuthorizeRequest SetOrderId(int? value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_ID.
		/// <param name="value">int</param>
		/// <returns>OrderAuthorizeRequest</returns>
		/// </summary>
		public OrderAuthorizeRequest SetModuleId(int? value)
		{
			ModuleId = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_Data.
		/// <param name="value">String</param>
		/// <returns>OrderAuthorizeRequest</returns>
		/// </summary>
		public OrderAuthorizeRequest SetModuleData(String value)
		{
			ModuleData = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">float</param>
		/// <returns>OrderAuthorizeRequest</returns>
		/// </summary>
		public OrderAuthorizeRequest SetAmount(float value)
		{
			Amount = value;
			return this;
		}

		/// <summary>
		/// Setter for Amount.
		/// <param name="value">double</param>
		/// <returns>OrderAuthorizeRequest</returns>
		/// </summary>
		public OrderAuthorizeRequest SetAmount(double value)
		{
			Amount = (float) value;
			return this;
		}
		/// <summary>
		/// Set user request data.
		/// <param name="name">String<String></param>
		/// <param name="value">IConvertible<String></param>
		/// <returns>OrderAuthorizeRequest</returns>
		/// </summary>
		public OrderAuthorizeRequest SetModuleField(String name, IConvertible value)
		{
			ModuleFields[name] = value;
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

			if (ModuleId.HasValue)
			{
				writer.WriteNumber("Module_ID", ModuleId.Value);
			}

			if (ModuleData != null && ModuleData.Length > 0)
			{
				writer.WriteString("Module_Data", ModuleData);
			}

			writer.WriteNumber("Amount", Amount);

			if (ModuleFields.Count > 0)
			{
				foreach(KeyValuePair<String, IConvertible> entry in ModuleFields)
				{
					if (Util.IsDecimal(entry.Value))
					{
						if (Util.IsFloat(entry.Value))
						{
							writer.WriteNumber(entry.Key, (float)entry.Value);
						}
						else
						{
							writer.WriteNumber(entry.Key, (double)entry.Value);
						}
					}
					else if (Util.IsNumeric(entry.Value))
					{
						writer.WriteNumber(entry.Key, (int)entry.Value);
					}
					else if (Util.IsBoolean(entry.Value))
					{
						writer.WriteBoolean(entry.Key, (bool)entry.Value);
					}
					else
					{
						writer.WriteString(entry.Key, entry.Value.ToString());
					}
				}
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderAuthorizeResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderAuthorizeResponse</returns>
		/// </summary>
		public new OrderAuthorizeResponse Send()
		{
			return Client.SendRequestAsync<OrderAuthorizeRequest, OrderAuthorizeResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderAuthorizeResponse></returns>
		/// </summary>
		public new async Task<OrderAuthorizeResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderAuthorizeRequest, OrderAuthorizeResponse>(this);
		}
	}
}
