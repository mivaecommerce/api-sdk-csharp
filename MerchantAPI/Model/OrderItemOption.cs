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
	[JsonConverter(typeof(OrderItemOptionConverter))]
	public class OrderItemOption : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property LineId - int</value>
		[JsonPropertyName("line_id")]
		public int LineId { get; set; }

		/// <value>Property OptionId - int</value>
		[JsonPropertyName("option_id")]
		public int OptionId { get; set; }

		/// <value>Property OptionCode - String</value>
		[JsonPropertyName("opt_code")]
		public String OptionCode { get; set; }

		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int? AttributeId { get; set; }

		/// <value>Property AttributeTemplateAttributeId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int? AttributeTemplateAttributeId { get; set; }

		/// <value>Property Value - String</value>
		[JsonPropertyName("value")]
		public String Value { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float? Weight { get; set; }

		/// <value>Property Retail - float</value>
		[JsonPropertyName("retail")]
		public float? Retail { get; set; }

		/// <value>Property BasePrice - float</value>
		[JsonPropertyName("base_price")]
		public float? BasePrice { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float? Price { get; set; }

		/// <value>Property OptionData - String</value>
		[JsonPropertyName("data")]
		public String OptionData { get; set; }

		/// <value>Property OptionDataLong - String</value>
		[JsonPropertyName("data_long")]
		public String OptionDataLong { get; set; }

		/// <value>Property AttributePrompt - String</value>
		[JsonPropertyName("attr_prompt")]
		public String AttributePrompt { get; set; }

		/// <value>Property OptionPrompt - String</value>
		[JsonPropertyName("opt_prompt")]
		public String OptionPrompt { get; set; }

		/// <value>Property Discounts - List<OrderItemOptionDiscount></value>
		[JsonPropertyName("discounts")]
		public List<OrderItemOptionDiscount> Discounts { get; set; } = new List<OrderItemOptionDiscount>();

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

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
		/// Getter for option_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOptionId()
		{
			return OptionId;
		}

		/// <summary>
		/// Getter for opt_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCode()
		{
			return OptionCode;
		}

		/// <summary>
		/// Getter for attr_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeCode()
		{
			return AttributeCode;
		}

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for attmpat_id.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeTemplateAttributeId()
		{
			return AttributeTemplateAttributeId;
		}

		/// <summary>
		/// Getter for value.
		/// <returns>String</returns>
		/// </summary>
		public String GetValue()
		{
			return Value;
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
		/// Getter for retail.
		/// <returns>float</returns>
		/// </summary>
		public float? GetRetail()
		{
			return Retail;
		}

		/// <summary>
		/// Getter for base_price.
		/// <returns>float</returns>
		/// </summary>
		public float? GetBasePrice()
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
		/// Getter for data.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionData()
		{
			return OptionData;
		}

		/// <summary>
		/// Getter for data_long.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionDataLong()
		{
			return OptionDataLong;
		}

		/// <summary>
		/// Getter for attr_prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributePrompt()
		{
			return AttributePrompt;
		}

		/// <summary>
		/// Getter for opt_prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionPrompt()
		{
			return OptionPrompt;
		}

		/// <summary>
		/// Getter for discounts.
		/// <returns>List<OrderItemOptionDiscount></returns>
		/// </summary>
		public List<OrderItemOptionDiscount> GetDiscounts()
		{
			return Discounts;
		}

		/// <summary>
		/// Setter for attr_code.
		/// <param name="value">String</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
		public OrderItemOption SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for attr_id.
		/// <param name="value">int</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
		public OrderItemOption SetAttributeId(int value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for attmpat_id.
		/// <param name="value">int</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
		public OrderItemOption SetAttributeTemplateAttributeId(int value)
		{
			AttributeTemplateAttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for value.
		/// <param name="value">String</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
		public OrderItemOption SetValue(String value)
		{
			Value = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for retail.
		/// <param name="value">float</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetRetail(float value)
	   {
			Retail = value;
			return this;
		}

		/// <summary>
		/// Setter for retail.
		/// <param name="value">double</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetRetail(double value)
	   {
			Retail = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for base_price.
		/// <param name="value">float</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetBasePrice(float value)
	   {
			BasePrice = value;
			return this;
		}

		/// <summary>
		/// Setter for base_price.
		/// <param name="value">double</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetBasePrice(double value)
	   {
			BasePrice = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">float</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetPrice(float value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">double</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
	   public OrderItemOption SetPrice(double value)
	   {
			Price = (float) value;
			return this;
		}
	}

	/// <summary>
	/// This is used only for OrderItemOption since key names are different in different situations
	/// </summary>
	public class OrderItemOptionConverter : BaseJsonConverter<OrderItemOption>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(OrderItemOption);
		}

		public override OrderItemOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			OrderItemOption option = new OrderItemOption();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
			}

			while(reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					return option;
				}

				String property = reader.GetString();

				if (String.Equals(property, "id", StringComparison.OrdinalIgnoreCase))
				{
					option.Id = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "order_id", StringComparison.OrdinalIgnoreCase))
				{
					option.OrderId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "line_id", StringComparison.OrdinalIgnoreCase))
				{
					option.LineId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "option_id", StringComparison.OrdinalIgnoreCase))
				{
					option.OptionId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "attribute", StringComparison.OrdinalIgnoreCase) || String.Equals(property, "attr_code", StringComparison.OrdinalIgnoreCase))
				{
					option.AttributeCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "attr_id", StringComparison.OrdinalIgnoreCase))
				{
					option.AttributeId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "attmpat_id", StringComparison.OrdinalIgnoreCase))
				{
					option.AttributeTemplateAttributeId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "value", StringComparison.OrdinalIgnoreCase) || String.Equals(property, "opt_code_or_data", StringComparison.OrdinalIgnoreCase))
				{
					option.Value = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "weight", StringComparison.OrdinalIgnoreCase))
				{
					option.Weight = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "retail", StringComparison.OrdinalIgnoreCase))
				{
					option.Retail = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "base_price", StringComparison.OrdinalIgnoreCase))
				{
					option.BasePrice = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "price", StringComparison.OrdinalIgnoreCase))
				{
					option.Price = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "opt_code", StringComparison.OrdinalIgnoreCase))
				{
					option.OptionCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "attr_prompt", StringComparison.OrdinalIgnoreCase))
				{
					option.AttributePrompt = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "opt_prompt", StringComparison.OrdinalIgnoreCase))
				{
					option.OptionPrompt = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "data", StringComparison.OrdinalIgnoreCase))
				{
					option.OptionData = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "data_long", StringComparison.OrdinalIgnoreCase))
				{
					option.OptionDataLong = ReadNextString(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return option;
		}

		public override void Write(Utf8JsonWriter writer, OrderItemOption value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			writer.WriteString("attr_code", value.GetAttributeCode());
			writer.WriteString("opt_code_or_data", value.GetValue());

			if (value.GetAttributeId().HasValue) writer.WriteNumber("attr_id", value.GetAttributeId().Value);
			if (value.GetAttributeTemplateAttributeId().HasValue) writer.WriteNumber("attmpat_id", value.GetAttributeTemplateAttributeId().Value);
			if (value.GetWeight().HasValue) writer.WriteNumber("weight", value.GetWeight().Value);
			if (value.GetRetail().HasValue) writer.WriteNumber("retail", value.GetRetail().Value);
			if (value.GetBasePrice().HasValue) writer.WriteNumber("base_price", value.GetBasePrice().Value);
			if (value.GetPrice().HasValue) writer.WriteNumber("price", value.GetPrice().Value);

			writer.WriteEndObject();
		}
	}}
