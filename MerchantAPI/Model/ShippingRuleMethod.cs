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
	[JsonConverter(typeof(ShippingRuleMethodConverter))]
	public class ShippingRuleMethod : Model
	{
		/// <value>Property ModuleCode - String</value>
		[JsonPropertyName("module_code")]
		public String ModuleCode { get; set; }

		/// <value>Property MethodCode - String</value>
		[JsonPropertyName("method_code")]
		public String MethodCode { get; set; }

		/// <summary>
		/// Getter for module_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for method_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodCode()
		{
			return MethodCode;
		}

		/// <summary>
		/// Setter for module_code.
		/// <param name="value">String</param>
		/// <returns>ShippingRuleMethod</returns>
		/// </summary>
		public ShippingRuleMethod SetModuleCode(String value)
		{
			ModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for method_code.
		/// <param name="value">String</param>
		/// <returns>ShippingRuleMethod</returns>
		/// </summary>
		public ShippingRuleMethod SetMethodCode(String value)
		{
			MethodCode = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ShippingRuleMethod
	/// </summary>
	public class ShippingRuleMethodConverter : BaseJsonConverter<ShippingRuleMethod>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ShippingRuleMethod) || typeToConvert.IsSubclassOf(typeof(ShippingRuleMethod));
		}

		public override ShippingRuleMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ShippingRuleMethod value = new ShippingRuleMethod();

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

				if (String.Equals(property, "module_code", StringComparison.OrdinalIgnoreCase))
				{
					value.ModuleCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "method_code", StringComparison.OrdinalIgnoreCase))
				{
					value.MethodCode = ReadNextString(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ShippingRuleMethod value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.ModuleCode != null && value.ModuleCode.Length > 0)
			{
				writer.WriteString("module_code", value.ModuleCode);
			}

			if (value.MethodCode != null && value.MethodCode.Length > 0)
			{
				writer.WriteString("method_code", value.MethodCode);
			}

			writer.WriteEndObject();
		}
	}
}
