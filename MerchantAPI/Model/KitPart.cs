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
	[JsonConverter(typeof(KitPartConverter))]
	public class KitPart : Model
	{
		/// <value>Property PartId - int</value>
		[JsonPropertyName("part_id")]
		public int? PartId { get; set; }

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
		/// <returns>KitPart</returns>
		/// </summary>
		public KitPart SetPartId(int value)
		{
			PartId = value;
			return this;
		}

		/// <summary>
		/// Setter for quantity.
		/// <param name="value">int</param>
		/// <returns>KitPart</returns>
		/// </summary>
		public KitPart SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model KitPart
	/// </summary>
	public class KitPartConverter : BaseJsonConverter<KitPart>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(KitPart) || typeToConvert.IsSubclassOf(typeof(KitPart));
		}

		public override KitPart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			KitPart value = new KitPart();

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
				else if (String.Equals(property, "quantity", StringComparison.OrdinalIgnoreCase))
				{
					value.Quantity = ReadNextInteger(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for KitPart", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, KitPart value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.PartId.HasValue)
			{
				writer.WriteNumber("part_id", value.PartId.Value);
			}

			if (value.Quantity.HasValue)
			{
				writer.WriteNumber("quantity", value.Quantity.Value);
			}

			writer.WriteEndObject();
		}
	}
}
