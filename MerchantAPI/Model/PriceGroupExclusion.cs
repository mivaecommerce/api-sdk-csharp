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
	[JsonConverter(typeof(PriceGroupExclusionConverter))]
	public class PriceGroupExclusion : Model
	{
		/// Enumeration ExclusionScope
		public enum ExclusionScope
		{
			Basket,
			Group,
			Item,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String ExclusionScopeToString(ExclusionScope value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static ExclusionScope? ExclusionScopeFromString(String value)
		{
			switch(value)
			{
				case "basket": return ExclusionScope.Basket;
				case "group": return ExclusionScope.Group;
				case "item": return ExclusionScope.Item;
				default: return null;
			}
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Scope - String</value>
		[JsonPropertyName("scope")]
		public String Scope { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for scope.
		/// <returns>String</returns>
		/// </summary>
		public String GetScope()
		{
			return Scope;
		}

		/// <summary>
		/// Enum Getter for scope.
		/// <returns>ExclusionScope?</returns>
		/// </summary>
		public ExclusionScope? GetScopeConst()
		{
			return ExclusionScopeFromString(Scope);
		}

		/// <summary>
		/// Setter for id.
		/// <param name="value">int</param>
		/// <returns>PriceGroupExclusion</returns>
		/// </summary>
		public PriceGroupExclusion SetId(int value)
		{
			Id = value;
			return this;
		}

		/// <summary>
		/// Setter for scope.
		/// <param name="value">String</param>
		/// <returns>PriceGroupExclusion</returns>
		/// </summary>
		public PriceGroupExclusion SetScope(String value)
		{
			Scope = value;
			return this;
		}

		/// <summary>
		/// Setter for scope.
		/// <param name="value">ExclusionScope</param>
		/// <returns>PriceGroupExclusion</returns>
		/// </summary>
		public PriceGroupExclusion SetScope(ExclusionScope value)
		{
			Scope = value.ToConstString();
			return this;
		}
	}

	/// <summary>
	/// Converter for model PriceGroupExclusion
	/// </summary>
	public class PriceGroupExclusionConverter : BaseJsonConverter<PriceGroupExclusion>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(PriceGroupExclusion) || typeToConvert.IsSubclassOf(typeof(PriceGroupExclusion));
		}

		public override PriceGroupExclusion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			PriceGroupExclusion value = new PriceGroupExclusion();

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

				if (String.Equals(property, "id", StringComparison.OrdinalIgnoreCase))
				{
					value.Id = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "scope", StringComparison.OrdinalIgnoreCase))
				{
					value.Scope = ReadNextString(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, PriceGroupExclusion value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			writer.WriteNumber("id", value.Id);

			if (value.Scope != null && value.Scope.Length > 0)
			{
				writer.WriteString("scope", value.Scope);
			}

			writer.WriteEndObject();
		}
	}

	/// Enum Extensions
	public static class PriceGroupExclusionExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this PriceGroupExclusion.ExclusionScope e)
	    {
			switch(e)
			{
				case PriceGroupExclusion.ExclusionScope.Basket: return "basket";
				case PriceGroupExclusion.ExclusionScope.Group: return "group";
				case PriceGroupExclusion.ExclusionScope.Item: return "item";
			}
			return "";
		}
	}
}
