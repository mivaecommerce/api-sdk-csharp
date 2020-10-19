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
	[JsonConverter(typeof(ResourceAttributeConverter))]
	public class ResourceAttribute : Model
	{
		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Value - String</value>
		[JsonPropertyName("value")]
		public String Value { get; set; }

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
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
		/// Setter for name.
		/// <param name="value">String</param>
		/// <returns>ResourceAttribute</returns>
		/// </summary>
		public ResourceAttribute SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for value.
		/// <param name="value">String</param>
		/// <returns>ResourceAttribute</returns>
		/// </summary>
		public ResourceAttribute SetValue(String value)
		{
			Value = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ResourceAttribute
	/// </summary>
	public class ResourceAttributeConverter : BaseJsonConverter<ResourceAttribute>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ResourceAttribute) || typeToConvert.IsSubclassOf(typeof(ResourceAttribute));
		}

		public override ResourceAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ResourceAttribute value = new ResourceAttribute();

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

				if (String.Equals(property, "name", StringComparison.OrdinalIgnoreCase))
				{
					value.Name = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "value", StringComparison.OrdinalIgnoreCase))
				{
					value.Value = ReadNextString(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for ResourceAttribute", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ResourceAttribute value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.Name != null && value.Name.Length > 0)
			{
				writer.WriteString("name", value.Name);
			}

			if (value.Value != null && value.Value.Length > 0)
			{
				writer.WriteString("value", value.Value);
			}

			writer.WriteEndObject();
		}
	}
}
