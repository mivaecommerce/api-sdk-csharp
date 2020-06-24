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
	[JsonConverter(typeof(OrderItemAttributeConverter))]
	public class OrderItemAttribute : Model
	{
		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property OptionCodeOrData - String</value>
		[JsonPropertyName("opt_code_or_data")]
		public String OptionCodeOrData { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float? Price { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float? Weight { get; set; }

		/// <summary>
		/// Getter for attr_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeCode()
		{
			return AttributeCode;
		}

		/// <summary>
		/// Getter for opt_code_or_data.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCodeOrData()
		{
			return OptionCodeOrData;
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
		/// Setter for attr_code.
		/// <param name="value">String</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
		public OrderItemAttribute SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for opt_code_or_data.
		/// <param name="value">String</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
		public OrderItemAttribute SetOptionCodeOrData(String value)
		{
			OptionCodeOrData = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">float</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetPrice(float value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">double</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetPrice(double value)
	   {
			Price = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>OrderItemAttribute</returns>
		/// </summary>
	   public OrderItemAttribute SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model OrderItemAttribute
	/// </summary>
	public class OrderItemAttributeConverter : BaseJsonConverter<OrderItemAttribute>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override OrderItemAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			OrderItemAttribute value = new OrderItemAttribute();

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

				if (String.Equals(property, "attr_code", StringComparison.OrdinalIgnoreCase))
				{
					value.AttributeCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "opt_code_or_data", StringComparison.OrdinalIgnoreCase))
				{
					value.OptionCodeOrData = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "price", StringComparison.OrdinalIgnoreCase))
				{
					value.Price = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "weight", StringComparison.OrdinalIgnoreCase))
				{
					value.Weight = ReadNextFloat(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for OrderItemAttribute", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, OrderItemAttribute value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.AttributeCode != null && value.AttributeCode.Length > 0)
			{
				writer.WriteString("attr_code", value.AttributeCode);
			}

			if (value.OptionCodeOrData != null && value.OptionCodeOrData.Length > 0)
			{
				writer.WriteString("opt_code_or_data", value.OptionCodeOrData);
			}

			if (value.Price.HasValue)
			{
				writer.WriteNumber("price", value.Price.Value);
			}

			if (value.Weight.HasValue)
			{
				writer.WriteNumber("weight", value.Weight.Value);
			}

			writer.WriteEndObject();
		}
	}
}
