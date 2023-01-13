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
	[JsonConverter(typeof(OrderProductAttributeConverter))]
	public class OrderProductAttribute : Model
	{
		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property TemplateCode - String</value>
		[JsonPropertyName("template_code")]
		public String TemplateCode { get; set; }

		/// <value>Property Value - String</value>
		[JsonPropertyName("value")]
		public String Value { get; set; }

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for template_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetTemplateCode()
		{
			return TemplateCode;
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
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>OrderProductAttribute</returns>
		/// </summary>
		public OrderProductAttribute SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for template_code.
		/// <param name="value">String</param>
		/// <returns>OrderProductAttribute</returns>
		/// </summary>
		public OrderProductAttribute SetTemplateCode(String value)
		{
			TemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for value.
		/// <param name="value">String</param>
		/// <returns>OrderProductAttribute</returns>
		/// </summary>
		public OrderProductAttribute SetValue(String value)
		{
			Value = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model OrderProductAttribute
	/// </summary>
	public class OrderProductAttributeConverter : BaseJsonConverter<OrderProductAttribute>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(OrderProductAttribute) || typeToConvert.IsSubclassOf(typeof(OrderProductAttribute));
		}

		public override OrderProductAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			OrderProductAttribute value = new OrderProductAttribute();

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

				if (String.Equals(property, "code", StringComparison.OrdinalIgnoreCase))
				{
					value.Code = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "template_code", StringComparison.OrdinalIgnoreCase))
				{
					value.TemplateCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "value", StringComparison.OrdinalIgnoreCase))
				{
					value.Value = ReadNextString(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, OrderProductAttribute value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.Code != null && value.Code.Length > 0)
			{
				writer.WriteString("code", value.Code);
			}

			if (value.TemplateCode != null && value.TemplateCode.Length > 0)
			{
				writer.WriteString("template_code", value.TemplateCode);
			}

			if (value.Value != null && value.Value.Length > 0)
			{
				writer.WriteString("value", value.Value);
			}

			writer.WriteEndObject();
		}
	}
}
