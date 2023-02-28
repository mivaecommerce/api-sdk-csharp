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
	[JsonConverter(typeof(ModuleChangeConverter))]
	public class ModuleChange : Model
	{
		/// <value>Property ModuleCode - String</value>
		[JsonPropertyName("Module_Code")]
		public String ModuleCode { get; set; }

		/// <value>Property ModuleOperation - String</value>
		[JsonPropertyName("Module_Operation")]
		public String ModuleOperation { get; set; }

		/// <value>Property ModuleData - VersionSettings</value>
		[JsonPropertyName("Module_Data")]
		public VersionSettings ModuleData { get; set; }

		/// <summary>
		/// Getter for Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for Module_Operation.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleOperation()
		{
			return ModuleOperation;
		}

		/// <summary>
		/// Getter for Module_Data.
		/// <returns>VersionSettings</returns>
		/// </summary>
		public VersionSettings GetModuleData()
		{
			return ModuleData;
		}

		/// <summary>
		/// Setter for Module_Code.
		/// <param name="value">String</param>
		/// <returns>ModuleChange</returns>
		/// </summary>
		public ModuleChange SetModuleCode(String value)
		{
			ModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_Operation.
		/// <param name="value">String</param>
		/// <returns>ModuleChange</returns>
		/// </summary>
		public ModuleChange SetModuleOperation(String value)
		{
			ModuleOperation = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ModuleChange
	/// </summary>
	public class ModuleChangeConverter : BaseJsonConverter<ModuleChange>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ModuleChange) || typeToConvert.IsSubclassOf(typeof(ModuleChange));
		}

		public override ModuleChange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ModuleChange value = new ModuleChange();

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

				if (String.Equals(property, "Module_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.ModuleCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Module_Operation", StringComparison.OrdinalIgnoreCase))
				{
					value.ModuleOperation = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Module_Data", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.ModuleData = JsonSerializer.Deserialize<VersionSettings>(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ModuleChange value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.ModuleCode != null && value.ModuleCode.Length > 0)
			{
				writer.WriteString("Module_Code", value.ModuleCode);
			}

			if (value.ModuleOperation != null && value.ModuleOperation.Length > 0)
			{
				writer.WriteString("Module_Operation", value.ModuleOperation);
			}

			writer.WritePropertyName("Module_Data");
			JsonSerializer.Serialize(writer, value.ModuleData, options);

			writer.WriteEndObject();
		}
	}
}
