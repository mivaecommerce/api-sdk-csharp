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
		/// <value>Property Attribute - String</value>
		[JsonPropertyName("attribute")]
		public String Attribute { get; set; }

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

		/// <summary>
		/// Getter for attribute.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttribute()
		{
			return Attribute;
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
		/// Setter for attribute.
		/// <param name="value">String</param>
		/// <returns>OrderItemOption</returns>
		/// </summary>
		public OrderItemOption SetAttribute(String value)
		{
			Attribute = value;
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
			return true;
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

				if ( property == "attribute" || property == "attr_code")
				{
					option.Attribute = ReadNextString(ref reader, options);
				}
				else if (property == "value" || property == "opt_code_or_data")
				{
					option.Value = ReadNextString(ref reader, options);
				}
				else if (property == "weight")
				{
					option.Weight = ReadNextFloat(ref reader, options);
				}
				else if (property == "retail")
				{
					option.Retail = ReadNextFloat(ref reader, options);
				}
				else if (property == "base_price")
				{
					option.BasePrice = ReadNextFloat(ref reader, options);
				}
				else if (property == "price")
				{
					option.Price = ReadNextFloat(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0}", property));
				}
			}

			return option;
		}

		public override void Write(Utf8JsonWriter writer, OrderItemOption value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteString("attr_code", value.GetAttribute());
			writer.WriteString("opt_code_or_data", value.GetValue());

			if (value.Weight.HasValue)
			{
				writer.WriteNumber("weight", value.Weight.Value);
			}

			if (value.Retail.HasValue)
			{
				writer.WriteNumber("retail", value.Retail.Value);
			}

			if (value.BasePrice.HasValue)
			{
				writer.WriteNumber("base_price", value.BasePrice.Value);
			}

			if (value.Price.HasValue)
			{
				writer.WriteNumber("price", value.Price.Value);
			}

			writer.WriteEndObject();
		}
	}}
