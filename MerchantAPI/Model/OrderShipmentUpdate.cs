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
	[JsonConverter(typeof(OrderShipmentUpdateConverter))]
	public class OrderShipmentUpdate : Model
	{
		/// <value>Property ShipmentId - int</value>
		[JsonPropertyName("shpmnt_id")]
		public int ShipmentId { get; set; }

		/// <value>Property MarkShipped - bool</value>
		[JsonPropertyName("mark_shipped")]
		public bool? MarkShipped { get; set; }

		/// <value>Property TrackingNumber - String</value>
		[JsonPropertyName("tracknum")]
		public String TrackingNumber { get; set; }

		/// <value>Property TrackingType - String</value>
		[JsonPropertyName("tracktype")]
		public String TrackingType { get; set; }

		/// <value>Property Cost - float</value>
		[JsonPropertyName("cost")]
		public float? Cost { get; set; }

		/// <summary>
		/// Getter for shpmnt_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetShipmentId()
		{
			return ShipmentId;
		}

		/// <summary>
		/// Getter for mark_shipped.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetMarkShipped()
		{
			return MarkShipped;
		}

		/// <summary>
		/// Getter for tracknum.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingNumber()
		{
			return TrackingNumber;
		}

		/// <summary>
		/// Getter for tracktype.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackingType()
		{
			return TrackingType;
		}

		/// <summary>
		/// Getter for cost.
		/// <returns>float</returns>
		/// </summary>
		public float? GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Setter for shpmnt_id.
		/// <param name="value">int</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetShipmentId(int value)
		{
			ShipmentId = value;
			return this;
		}

		/// <summary>
		/// Setter for mark_shipped.
		/// <param name="value">bool</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetMarkShipped(bool value)
		{
			MarkShipped = value;
			return this;
		}

		/// <summary>
		/// Setter for tracknum.
		/// <param name="value">String</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetTrackingNumber(String value)
		{
			TrackingNumber = value;
			return this;
		}

		/// <summary>
		/// Setter for tracktype.
		/// <param name="value">String</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
		public OrderShipmentUpdate SetTrackingType(String value)
		{
			TrackingType = value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">float</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
	   public OrderShipmentUpdate SetCost(float value)
	   {
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">double</param>
		/// <returns>OrderShipmentUpdate</returns>
		/// </summary>
	   public OrderShipmentUpdate SetCost(double value)
	   {
			Cost = (float) value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model OrderShipmentUpdate
	/// </summary>
	public class OrderShipmentUpdateConverter : BaseJsonConverter<OrderShipmentUpdate>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(OrderShipmentUpdate) || typeToConvert.IsSubclassOf(typeof(OrderShipmentUpdate));
		}

		public override OrderShipmentUpdate Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			OrderShipmentUpdate value = new OrderShipmentUpdate();

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

				if (String.Equals(property, "shpmnt_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ShipmentId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "mark_shipped", StringComparison.OrdinalIgnoreCase))
				{
					value.MarkShipped = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "tracknum", StringComparison.OrdinalIgnoreCase))
				{
					value.TrackingNumber = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "tracktype", StringComparison.OrdinalIgnoreCase))
				{
					value.TrackingType = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "cost", StringComparison.OrdinalIgnoreCase))
				{
					value.Cost = ReadNextFloat(ref reader, options);
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, OrderShipmentUpdate value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			writer.WriteNumber("shpmnt_id", value.ShipmentId);

			if (value.MarkShipped.HasValue)
			{
				writer.WriteBoolean("mark_shipped", value.MarkShipped.Value);
			}

			if (value.TrackingNumber != null && value.TrackingNumber.Length > 0)
			{
				writer.WriteString("tracknum", value.TrackingNumber);
			}

			if (value.TrackingType != null && value.TrackingType.Length > 0)
			{
				writer.WriteString("tracktype", value.TrackingType);
			}

			if (value.Cost.HasValue)
			{
				writer.WriteNumber("cost", value.Cost.Value);
			}

			writer.WriteEndObject();
		}
	}
}
