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
	[JsonConverter(typeof(VariantPartConverter))]
	public class VariantPart : Model
	{
		/// <value>Property PartId - int</value>
		[JsonPropertyName("part_id")]
		public int? PartId { get; set; }

		/// <value>Property PartCode - String</value>
		[JsonPropertyName("part_code")]
		public String PartCode { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int? Quantity { get; set; }

		/// <summary>
		/// Getter for part_id.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPartId()
		{
			return PartId;
		}

		/// <summary>
		/// Getter for part_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetPartCode()
		{
			return PartCode;
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
		/// Setter for part_id.
		/// <param name="value">int</param>
		/// <returns>VariantPart</returns>
		/// </summary>
		public VariantPart SetPartId(int value)
		{
			PartId = value;
			return this;
		}

		/// <summary>
		/// Setter for part_code.
		/// <param name="value">String</param>
		/// <returns>VariantPart</returns>
		/// </summary>
		public VariantPart SetPartCode(String value)
		{
			PartCode = value;
			return this;
		}

		/// <summary>
		/// Setter for quantity.
		/// <param name="value">int</param>
		/// <returns>VariantPart</returns>
		/// </summary>
		public VariantPart SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model VariantPart
	/// </summary>
	public class VariantPartConverter : BaseJsonConverter<VariantPart>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(VariantPart) || typeToConvert.IsSubclassOf(typeof(VariantPart));
		}

		public override VariantPart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			VariantPart value = new VariantPart();

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

				if (String.Equals(property, "part_id", StringComparison.OrdinalIgnoreCase))
				{
					value.PartId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "part_code", StringComparison.OrdinalIgnoreCase))
				{
					value.PartCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "quantity", StringComparison.OrdinalIgnoreCase))
				{
					value.Quantity = ReadNextInteger(ref reader, options);
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, VariantPart value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.PartId.HasValue)
			{
				writer.WriteNumber("part_id", value.PartId.Value);
			}

			if (value.PartCode != null && value.PartCode.Length > 0)
			{
				writer.WriteString("part_code", value.PartCode);
			}

			if (value.Quantity.HasValue)
			{
				writer.WriteNumber("quantity", value.Quantity.Value);
			}

			writer.WriteEndObject();
		}
	}
}
