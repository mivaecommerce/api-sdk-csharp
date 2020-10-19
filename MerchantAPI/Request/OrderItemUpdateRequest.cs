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
	/// Handles API Request OrderItem_Update.
	/// <see>https://docs.miva.com/json-api/functions/orderitem_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderItemUpdateRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int OrderId { get; set; }

		/// Request field Line_ID.
		[JsonPropertyName("Line_ID")]
		public int LineId { get; set; }

		/// Request field Code.
		[JsonPropertyName("Code")]
		public String Code { get; set; }

		/// Request field Name.
		[JsonPropertyName("Name")]
		public String Name { get; set; }

		/// Request field Sku.
		[JsonPropertyName("Sku")]
		public String Sku { get; set; }

		/// Request field Quantity.
		[JsonPropertyName("Quantity")]
		public int? Quantity { get; set; }

		/// Request field Price.
		[JsonPropertyName("Price")]
		public float? Price { get; set; }

		/// Request field Weight.
		[JsonPropertyName("Weight")]
		public float? Weight { get; set; }

		/// Request field Taxable.
		[JsonPropertyName("Taxable")]
		public bool? Taxable { get; set; }

		/// Request field Options.
		[JsonPropertyName("Options")]
		public List<OrderItemOption> Options { get; set; } = new List<OrderItemOption>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="orderItem">OrderItem</param>
		/// </summary>
		public OrderItemUpdateRequest(BaseClient client = null, OrderItem orderItem = null) :
			base(client)
		{
			Function = "OrderItem_Update";
			if (orderItem != null) {
				OrderId = orderItem.OrderId;
				LineId = orderItem.LineId;
				Code = orderItem.Code;
				Name = orderItem.Name;
				Sku = orderItem.Sku;
				Quantity = orderItem.Quantity;
				Price = orderItem.Price;
				Weight = orderItem.Weight;
				Taxable = orderItem.Taxable;

				if (orderItem.Options.Count > 0)
				{
					Options = orderItem.Options;
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
		/// Getter for Line_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetLineId()
		{
			return LineId;
		}

		/// <summary>
		/// Getter for Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for Sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
		}

		/// <summary>
		/// Getter for Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int? GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for Price.
		/// <returns>float</returns>
		/// </summary>
		public float? GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Getter for Taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTaxable()
		{
			return Taxable;
		}

		/// <summary>
		/// Getter for Options.
		/// <returns>List<OrderItemOption></returns>
		/// </summary>
		public List<OrderItemOption> GetOptions()
		{
			return Options;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetOrderId(int value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Line_ID.
		/// <param name="value">int</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetLineId(int value)
		{
			LineId = value;
			return this;
		}

		/// <summary>
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Name.
		/// <param name="value">String</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for Sku.
		/// <param name="value">String</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetSku(String value)
		{
			Sku = value;
			return this;
		}

		/// <summary>
		/// Setter for Quantity.
		/// <param name="value">int</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetQuantity(int? value)
		{
			Quantity = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">float</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
	   public OrderItemUpdateRequest SetPrice(float? value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for Price.
		/// <param name="value">double</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
	   public OrderItemUpdateRequest SetPrice(double? value)
	   {
			Price = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">float</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
	   public OrderItemUpdateRequest SetWeight(float? value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for Weight.
		/// <param name="value">double</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
	   public OrderItemUpdateRequest SetWeight(double? value)
	   {
			Weight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Taxable.
		/// <param name="value">bool</param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest SetTaxable(bool? value)
		{
			Taxable = value;
			return this;
		}

		/// <summary>
		/// Add a OrderItemOption.
		/// - option: OrderItemOption
		/// - Returns: Self
		/// </summary>
		public OrderItemUpdateRequest AddOption(OrderItemOption option)
		{
			Options.Add(option);
			return this;
		}

		/// <summary>
		/// Add an array of OrderItemOption.
		/// <param name="options">List<OrderItemOption></param>
		/// <returns>OrderItemUpdateRequest</returns>
		/// </summary>
		public OrderItemUpdateRequest AddOptions(List<OrderItemOption> options)
		{
			foreach(OrderItemOption e in options)
			{
				Options.Add(e);
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

			writer.WriteNumber("Order_ID", OrderId);

			writer.WriteNumber("Line_ID", LineId);

			if (Code != null && Code.Length > 0)
			{
				writer.WriteString("Code", Code);
			}

			if (Name != null && Name.Length > 0)
			{
				writer.WriteString("Name", Name);
			}

			if (Sku != null && Sku.Length > 0)
			{
				writer.WriteString("Sku", Sku);
			}

			if (Quantity.HasValue)
			{
				writer.WriteNumber("Quantity", Quantity.Value);
			}

			if (Price.HasValue)
			{
				writer.WriteNumber("Price", Price.Value);
			}

			if (Weight.HasValue)
			{
				writer.WriteNumber("Weight", Weight.Value);
			}

			if (Taxable.HasValue)
			{
				writer.WriteBoolean("Taxable", Taxable.Value);
			}

			if (Options.Count > 0)
			{
				writer.WritePropertyName("Options");
				JsonSerializer.Serialize(writer, this.Options, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderItemUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderItemUpdateResponse</returns>
		/// </summary>
		public new OrderItemUpdateResponse Send()
		{
			return Client.SendRequestAsync<OrderItemUpdateRequest, OrderItemUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderItemUpdateResponse></returns>
		/// </summary>
		public new async Task<OrderItemUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderItemUpdateRequest, OrderItemUpdateResponse>(this);
		}
	}
}
