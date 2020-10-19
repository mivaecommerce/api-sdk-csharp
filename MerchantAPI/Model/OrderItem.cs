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

namespace MerchantAPI
{
	[JsonConverter(typeof(OrderItemConverter))]
	public class OrderItem : Model
	{
		/// Enumeration OrderItemStatus
		public enum OrderItemStatus
		{
			Pending = 0,
			Processing = 100,
			Shipped = 200,
			PartiallyShipped = 201,
			GiftCertNotRedeemed = 210,
			GiftCertRedeemed = 211,
			DigitalNotDownloaded = 220,
			DigitalDownloaded = 221,
			Cancelled = 300,
			Backordered = 400,
			RmaIssued = 500,
			Returned = 600,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String OrderItemStatusToString(OrderItemStatus value)
		{
			switch(value)
			{
				case OrderItemStatus.Pending: return "0";
				case OrderItemStatus.Processing: return "100";
				case OrderItemStatus.Shipped: return "200";
				case OrderItemStatus.PartiallyShipped: return "201";
				case OrderItemStatus.GiftCertNotRedeemed: return "210";
				case OrderItemStatus.GiftCertRedeemed: return "211";
				case OrderItemStatus.DigitalNotDownloaded: return "220";
				case OrderItemStatus.DigitalDownloaded: return "221";
				case OrderItemStatus.Cancelled: return "300";
				case OrderItemStatus.Backordered: return "400";
				case OrderItemStatus.RmaIssued: return "500";
				case OrderItemStatus.Returned: return "600";
			}
			return "";
		}

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property LineId - int</value>
		[JsonPropertyName("line_id")]
		public int LineId { get; set; }

		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property SubscriptionId - int</value>
		[JsonPropertyName("subscrp_id")]
		public int SubscriptionId { get; set; }

		/// <value>Property SubscriptionTermId - int</value>
		[JsonPropertyName("subterm_id")]
		public int SubscriptionTermId { get; set; }

		/// <value>Property RmaId - int</value>
		[JsonPropertyName("rma_id")]
		public int RmaId { get; set; }

		/// <value>Property RmaCode - String</value>
		[JsonPropertyName("rma_code")]
		public String RmaCode { get; set; }

		/// <value>Property RmaDataTimeIssued - int</value>
		[JsonPropertyName("rma_dt_issued")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime RmaDataTimeIssued { get; set; }

		/// <value>Property RmaDateTimeReceived - int</value>
		[JsonPropertyName("rma_dt_recvd")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime RmaDateTimeReceived { get; set; }

		/// <value>Property DateInStock - int</value>
		[JsonPropertyName("dt_instock")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateInStock { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Sku - String</value>
		[JsonPropertyName("sku")]
		public String Sku { get; set; }

		/// <value>Property Retail - float</value>
		[JsonPropertyName("retail")]
		public float Retail { get; set; }

		/// <value>Property BasePrice - float</value>
		[JsonPropertyName("base_price")]
		public float BasePrice { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float? Price { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float? Weight { get; set; }

		/// <value>Property Taxable - bool</value>
		[JsonPropertyName("taxable")]
		public bool? Taxable { get; set; }

		/// <value>Property Upsold - bool</value>
		[JsonPropertyName("upsold")]
		public bool? Upsold { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int? Quantity { get; set; }

		/// <value>Property Shipment - OrderShipment</value>
		[JsonPropertyName("shipment")]
		public OrderShipment Shipment { get; set; }

		/// <value>Property Discounts - List<OrderItemDiscount></value>
		[JsonPropertyName("discounts")]
		public List<OrderItemDiscount> Discounts { get; set; } = new List<OrderItemDiscount>();

		/// <value>Property Options - List<OrderItemOption></value>
		[JsonPropertyName("options")]
		public List<OrderItemOption> Options { get; set; } = new List<OrderItemOption>();

		/// <value>Property Subscription - OrderItemSubscription</value>
		[JsonPropertyName("subscription")]
		public OrderItemSubscription Subscription { get; set; }

		/// <value>Property Total - float</value>
		[JsonPropertyName("total")]
		public float Total { get; set; }

		/// <value>Property TrackingType - String</value>
		[JsonPropertyName("tracktype")]
		public String TrackingType { get; set; }

		/// <value>Property TrackingNumber - String</value>
		[JsonPropertyName("tracknum")]
		public String TrackingNumber { get; set; }

		/// <summary>
		/// Getter for order_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for line_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetLineId()
		{
			return LineId;
		}

		/// <summary>
		/// Getter for status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for subscrp_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionId()
		{
			return SubscriptionId;
		}

		/// <summary>
		/// Getter for subterm_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionTermId()
		{
			return SubscriptionTermId;
		}

		/// <summary>
		/// Getter for rma_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetRmaId()
		{
			return RmaId;
		}

		/// <summary>
		/// Getter for rma_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetRmaCode()
		{
			return RmaCode;
		}

		/// <summary>
		/// Getter for rma_dt_issued.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetRmaDataTimeIssued()
		{
			return RmaDataTimeIssued;
		}

		/// <summary>
		/// Getter for rma_dt_recvd.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetRmaDateTimeReceived()
		{
			return RmaDateTimeReceived;
		}

		/// <summary>
		/// Getter for dt_instock.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateInStock()
		{
			return DateInStock;
		}

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
		}

		/// <summary>
		/// Getter for retail.
		/// <returns>float</returns>
		/// </summary>
		public float GetRetail()
		{
			return Retail;
		}

		/// <summary>
		/// Getter for base_price.
		/// <returns>float</returns>
		/// </summary>
		public float GetBasePrice()
		{
			return BasePrice;
		}

		/// <summary>
		/// Getter for price.
		/// <returns>float</returns>
		/// </summary>
		public float? GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Getter for taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTaxable()
		{
			return Taxable;
		}

		/// <summary>
		/// Getter for upsold.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUpsold()
		{
			return Upsold;
		}

		/// <summary>
		/// Getter for quantity.
		/// <returns>int</returns>
		/// </summary>
		public int? GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for shipment.
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment GetShipment()
		{
			return Shipment;
		}

		/// <summary>
		/// Getter for discounts.
		/// <returns>List<OrderItemDiscount></returns>
		/// </summary>
		public List<OrderItemDiscount> GetDiscounts()
		{
			return Discounts;
		}

		/// <summary>
		/// Getter for options.
		/// <returns>List<OrderItemOption></returns>
		/// </summary>
		public List<OrderItemOption> GetOptions()
		{
			return Options;
		}

		/// <summary>
		/// Getter for subscription.
		/// <returns>OrderItemSubscription</returns>
		/// </summary>
		public OrderItemSubscription GetSubscription()
		{
			return Subscription;
		}

		/// <summary>
		/// Getter for total.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotal()
		{
			return Total;
		}

		/// <summary>
		/// Getter for tracktype.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingType()
		{
			return TrackingType;
		}

		/// <summary>
		/// Getter for tracknum.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingNumber()
		{
			return TrackingNumber;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for name.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for sku.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetSku(String value)
		{
			Sku = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">float</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetPrice(float value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">double</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetPrice(double value)
	   {
			Price = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>OrderItem</returns>
		/// </summary>
	   public OrderItem SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for taxable.
		/// <param name="value">bool</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetTaxable(bool value)
		{
			Taxable = value;
			return this;
		}

		/// <summary>
		/// Setter for upsold.
		/// <param name="value">bool</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetUpsold(bool value)
		{
			Upsold = value;
			return this;
		}

		/// <summary>
		/// Setter for quantity.
		/// <param name="value">int</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}

		/// <summary>
		/// Setter for tracktype.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetTrackingType(String value)
		{
			TrackingType = value;
			return this;
		}

		/// <summary>
		/// Setter for tracknum.
		/// <param name="value">String</param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem SetTrackingNumber(String value)
		{
			TrackingNumber = value;
			return this;
		}

		/// <summary>
		/// Add a OrderItemOption.
		/// <param name="OrderItemOption"></param>
		/// <returns>OrderItem</returns>
		/// </summary>
		public OrderItem AddOption(OrderItemOption model)
		{
			Options.Add(model);
			return this;
		}
	}

	/// <summary>
	/// Converter for model OrderItem
	/// </summary>
	public class OrderItemConverter : BaseJsonConverter<OrderItem>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(OrderItem) || typeToConvert.IsSubclassOf(typeof(OrderItem));
		}

		public override OrderItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			OrderItem value = new OrderItem();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while(reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return value;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "order_id", StringComparison.OrdinalIgnoreCase))
				{
					value.OrderId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "line_id", StringComparison.OrdinalIgnoreCase))
				{
					value.LineId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "status", StringComparison.OrdinalIgnoreCase))
				{
					value.Status = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "subscrp_id", StringComparison.OrdinalIgnoreCase))
				{
					value.SubscriptionId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "subterm_id", StringComparison.OrdinalIgnoreCase))
				{
					value.SubscriptionTermId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "rma_id", StringComparison.OrdinalIgnoreCase))
				{
					value.RmaId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "rma_code", StringComparison.OrdinalIgnoreCase))
				{
					value.RmaCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "rma_dt_issued", StringComparison.OrdinalIgnoreCase))
				{
					value.RmaDataTimeIssued = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "rma_dt_recvd", StringComparison.OrdinalIgnoreCase))
				{
					value.RmaDateTimeReceived = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "dt_instock", StringComparison.OrdinalIgnoreCase))
				{
					value.DateInStock = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "code", StringComparison.OrdinalIgnoreCase))
				{
					value.Code = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "name", StringComparison.OrdinalIgnoreCase))
				{
					value.Name = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "sku", StringComparison.OrdinalIgnoreCase))
				{
					value.Sku = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "retail", StringComparison.OrdinalIgnoreCase))
				{
					value.Retail = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "base_price", StringComparison.OrdinalIgnoreCase))
				{
					value.BasePrice = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "price", StringComparison.OrdinalIgnoreCase))
				{
					value.Price = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "weight", StringComparison.OrdinalIgnoreCase))
				{
					value.Weight = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "taxable", StringComparison.OrdinalIgnoreCase))
				{
					value.Taxable = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "upsold", StringComparison.OrdinalIgnoreCase))
				{
					value.Upsold = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "quantity", StringComparison.OrdinalIgnoreCase))
				{
					value.Quantity = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "shipment", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.Shipment = JsonSerializer.Deserialize<OrderShipment>(ref reader, options);
				}
				else if (String.Equals(property, "discounts", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Discounts = JsonSerializer.Deserialize<List<OrderItemDiscount>>(ref reader, options);
				}
				else if (String.Equals(property, "options", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Options = JsonSerializer.Deserialize<List<OrderItemOption>>(ref reader, options);
				}
				else if (String.Equals(property, "subscription", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.Subscription = JsonSerializer.Deserialize<OrderItemSubscription>(ref reader, options);
				}
				else if (String.Equals(property, "total", StringComparison.OrdinalIgnoreCase))
				{
					value.Total = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "tracktype", StringComparison.OrdinalIgnoreCase))
				{
					value.TrackingType = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "tracknum", StringComparison.OrdinalIgnoreCase))
				{
					value.TrackingNumber = ReadNextString(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for OrderItem", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, OrderItem value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.Code != null && value.Code.Length > 0)
			{
				writer.WriteString("code", value.Code);
			}

			if (value.Name != null && value.Name.Length > 0)
			{
				writer.WriteString("name", value.Name);
			}

			if (value.Sku != null && value.Sku.Length > 0)
			{
				writer.WriteString("sku", value.Sku);
			}

			if (value.Price.HasValue)
			{
				writer.WriteNumber("price", value.Price.Value);
			}

			if (value.Weight.HasValue)
			{
				writer.WriteNumber("weight", value.Weight.Value);
			}

			if (value.Taxable.HasValue)
			{
				writer.WriteBoolean("taxable", value.Taxable.Value);
			}

			if (value.Upsold.HasValue)
			{
				writer.WriteBoolean("upsold", value.Upsold.Value);
			}

			if (value.Quantity.HasValue)
			{
				writer.WriteNumber("quantity", value.Quantity.Value);
			}

			writer.WritePropertyName("options");
			JsonSerializer.Serialize(writer, value.Options, options);

			if (value.TrackingType != null && value.TrackingType.Length > 0)
			{
				writer.WriteString("tracktype", value.TrackingType);
			}

			if (value.TrackingNumber != null && value.TrackingNumber.Length > 0)
			{
				writer.WriteString("tracknum", value.TrackingNumber);
			}

			writer.WriteEndObject();
		}
	}
}
