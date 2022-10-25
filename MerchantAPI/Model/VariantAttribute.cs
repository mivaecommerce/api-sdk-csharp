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
	[JsonConverter(typeof(VariantAttributeConverter))]
	public class VariantAttribute : Model
	{
		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int? AttributeId { get; set; }

		/// <value>Property AttributeTemplateAttributeId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int? AttributeTemplateAttributeId { get; set; }

		/// <value>Property OptionId - int</value>
		[JsonPropertyName("option_id")]
		public int? OptionId { get; set; }

		/// <value>Property AttributeCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttributeCode { get; set; }

		/// <value>Property AttributeTemplateAttributeCode - String</value>
		[JsonPropertyName("attmpat_code")]
		public String AttributeTemplateAttributeCode { get; set; }

		/// <value>Property OptionCode - String</value>
		[JsonPropertyName("option_code")]
		public String OptionCode { get; set; }

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
		/// Getter for option_id.
		/// <returns>int</returns>
		/// </summary>
		public int? GetOptionId()
		{
			return OptionId;
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
		/// Getter for attmpat_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeTemplateAttributeCode()
		{
			return AttributeTemplateAttributeCode;
		}

		/// <summary>
		/// Getter for option_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCode()
		{
			return OptionCode;
		}

		/// <summary>
		/// Setter for attr_id.
		/// <param name="value">int</param>
		/// <returns>VariantAttribute</returns>
		/// </summary>
		public VariantAttribute SetAttributeId(int value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for attmpat_id.
		/// <param name="value">int</param>
		/// <returns>VariantAttribute</returns>
		/// </summary>
		public VariantAttribute SetAttributeTemplateAttributeId(int value)
		{
			AttributeTemplateAttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for option_id.
		/// <param name="value">int</param>
		/// <returns>VariantAttribute</returns>
		/// </summary>
		public VariantAttribute SetOptionId(int value)
		{
			OptionId = value;
			return this;
		}

		/// <summary>
		/// Setter for attr_code.
		/// <param name="value">String</param>
		/// <returns>VariantAttribute</returns>
		/// </summary>
		public VariantAttribute SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for attmpat_code.
		/// <param name="value">String</param>
		/// <returns>VariantAttribute</returns>
		/// </summary>
		public VariantAttribute SetAttributeTemplateAttributeCode(String value)
		{
			AttributeTemplateAttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for option_code.
		/// <param name="value">String</param>
		/// <returns>VariantAttribute</returns>
		/// </summary>
		public VariantAttribute SetOptionCode(String value)
		{
			OptionCode = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model VariantAttribute
	/// </summary>
	public class VariantAttributeConverter : BaseJsonConverter<VariantAttribute>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(VariantAttribute) || typeToConvert.IsSubclassOf(typeof(VariantAttribute));
		}

		public override VariantAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			VariantAttribute value = new VariantAttribute();

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

				if (String.Equals(property, "attr_id", StringComparison.OrdinalIgnoreCase))
				{
					value.AttributeId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "attmpat_id", StringComparison.OrdinalIgnoreCase))
				{
					value.AttributeTemplateAttributeId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "option_id", StringComparison.OrdinalIgnoreCase))
				{
					value.OptionId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "attr_code", StringComparison.OrdinalIgnoreCase))
				{
					value.AttributeCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "attmpat_code", StringComparison.OrdinalIgnoreCase))
				{
					value.AttributeTemplateAttributeCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "option_code", StringComparison.OrdinalIgnoreCase))
				{
					value.OptionCode = ReadNextString(ref reader, options);
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, VariantAttribute value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.AttributeId.HasValue)
			{
				writer.WriteNumber("attr_id", value.AttributeId.Value);
			}

			if (value.AttributeTemplateAttributeId.HasValue)
			{
				writer.WriteNumber("attmpat_id", value.AttributeTemplateAttributeId.Value);
			}

			if (value.OptionId.HasValue)
			{
				writer.WriteNumber("option_id", value.OptionId.Value);
			}

			if (value.AttributeCode != null && value.AttributeCode.Length > 0)
			{
				writer.WriteString("attr_code", value.AttributeCode);
			}

			if (value.AttributeTemplateAttributeCode != null && value.AttributeTemplateAttributeCode.Length > 0)
			{
				writer.WriteString("attmpat_code", value.AttributeTemplateAttributeCode);
			}

			if (value.OptionCode != null && value.OptionCode.Length > 0)
			{
				writer.WriteString("option_code", value.OptionCode);
			}

			writer.WriteEndObject();
		}
	}
}
