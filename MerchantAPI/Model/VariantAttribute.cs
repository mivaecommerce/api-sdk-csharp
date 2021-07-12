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
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for VariantAttribute", property));
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

			writer.WriteEndObject();
		}
	}
}
