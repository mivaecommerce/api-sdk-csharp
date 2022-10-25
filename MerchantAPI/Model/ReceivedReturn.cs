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
	[JsonConverter(typeof(ReceivedReturnConverter))]
	public class ReceivedReturn : Model
	{
		/// <value>Property ReturnId - int</value>
		[JsonPropertyName("return_id")]
		public int? ReturnId { get; set; }

		/// <value>Property AdjustInventory - int</value>
		[JsonPropertyName("adjust_inventory")]
		public int? AdjustInventory { get; set; }

		/// <summary>
		/// Getter for return_id.
		/// <returns>int</returns>
		/// </summary>
		public int? GetReturnId()
		{
			return ReturnId;
		}

		/// <summary>
		/// Getter for adjust_inventory.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAdjustInventory()
		{
			return AdjustInventory;
		}

		/// <summary>
		/// Setter for return_id.
		/// <param name="value">int</param>
		/// <returns>ReceivedReturn</returns>
		/// </summary>
		public ReceivedReturn SetReturnId(int value)
		{
			ReturnId = value;
			return this;
		}

		/// <summary>
		/// Setter for adjust_inventory.
		/// <param name="value">int</param>
		/// <returns>ReceivedReturn</returns>
		/// </summary>
		public ReceivedReturn SetAdjustInventory(int value)
		{
			AdjustInventory = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ReceivedReturn
	/// </summary>
	public class ReceivedReturnConverter : BaseJsonConverter<ReceivedReturn>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ReceivedReturn) || typeToConvert.IsSubclassOf(typeof(ReceivedReturn));
		}

		public override ReceivedReturn Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ReceivedReturn value = new ReceivedReturn();

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

				if (String.Equals(property, "return_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ReturnId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "adjust_inventory", StringComparison.OrdinalIgnoreCase))
				{
					value.AdjustInventory = ReadNextInteger(ref reader, options);
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ReceivedReturn value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.ReturnId.HasValue)
			{
				writer.WriteNumber("return_id", value.ReturnId.Value);
			}

			if (value.AdjustInventory.HasValue)
			{
				writer.WriteNumber("adjust_inventory", value.AdjustInventory.Value);
			}

			writer.WriteEndObject();
		}
	}
}
