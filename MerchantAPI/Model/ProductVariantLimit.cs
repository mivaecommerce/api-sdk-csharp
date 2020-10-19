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
	[JsonConverter(typeof(ProductVariantLimitConverter))]
	public class ProductVariantLimit : Model
	{
		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int? AttributeId { get; set; }

		/// <value>Property AttributeTemplateId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int? AttributeTemplateId { get; set; }

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
		public int? GetAttributeTemplateId()
		{
			return AttributeTemplateId;
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
		/// <returns>ProductVariantLimit</returns>
		/// </summary>
		public ProductVariantLimit SetAttributeId(int value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for attmpat_id.
		/// <param name="value">int</param>
		/// <returns>ProductVariantLimit</returns>
		/// </summary>
		public ProductVariantLimit SetAttributeTemplateId(int value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for option_id.
		/// <param name="value">int</param>
		/// <returns>ProductVariantLimit</returns>
		/// </summary>
		public ProductVariantLimit SetOptionId(int value)
		{
			OptionId = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ProductVariantLimit
	/// </summary>
	public class ProductVariantLimitConverter : BaseJsonConverter<ProductVariantLimit>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ProductVariantLimit) || typeToConvert.IsSubclassOf(typeof(ProductVariantLimit));
		}

		public override ProductVariantLimit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ProductVariantLimit value = new ProductVariantLimit();

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
					value.AttributeTemplateId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "option_id", StringComparison.OrdinalIgnoreCase))
				{
					value.OptionId = ReadNextInteger(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for ProductVariantLimit", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ProductVariantLimit value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.AttributeId.HasValue)
			{
				writer.WriteNumber("attr_id", value.AttributeId.Value);
			}

			if (value.AttributeTemplateId.HasValue)
			{
				writer.WriteNumber("attmpat_id", value.AttributeTemplateId.Value);
			}

			if (value.OptionId.HasValue)
			{
				writer.WriteNumber("option_id", value.OptionId.Value);
			}

			writer.WriteEndObject();
		}
	}
}
