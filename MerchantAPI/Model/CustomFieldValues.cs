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
	[JsonConverter(typeof(CustomFieldValuesConverter))]
	public class CustomFieldValues : Model
	{
		public Dictionary<String, Dictionary<String, VariableValue>> Values { get; set; } = new Dictionary<String, Dictionary<String, VariableValue>>();

		/// <summary>
		/// Set a custom field value
		/// </summary>
		/// <param name="field">String</param>
		/// <param name="value">String</param>
		/// <param name="module">String</param>
		public CustomFieldValues SetValue(String field, IConvertible value, String module = "customfields")
		{
			if (!HasModule(module))
			{
				Values[module] = new Dictionary<String, VariableValue>();
			}

			Values[module][field] = new VariableValue(value);
			return this;
		}

		/// <summary>
		/// Set a custom field value array for multitext
		/// </summary>
		/// <param name="field">String</param>
		/// <param name="value">List<String></param>
		/// <param name="module">String</param>
		public CustomFieldValues SetValue(String field, List<VariableValue> values, String module = "customfields")
		{
			if (!HasModule(module))
			{
				Values[module] = new Dictionary<String, VariableValue>();
			}

			Values[module][field] = new VariableValue(values);
			return this;
		}

		/// <summary>
		/// Set a custom field value from a VariableValue instance
		/// </summary>
		/// <param name="field">String</param>
		/// <param name="value">List<String></param>
		/// <param name="module">String</param>
		public CustomFieldValues SetValue(String field, VariableValue value, String module = "customfields")
		{
			if (!HasModule(module))
			{
				Values[module] = new Dictionary<String, VariableValue>();
			}

			Values[module][field] = value;
			return this;
		}

		/// <summary>
		/// Get all values for all modules.
		/// </summary>
		/// <returns></returns>
		public Dictionary<String, Dictionary<String, VariableValue>> GetValues()
		{
			return Values;
		}

		/// <summary>
		/// Get a value for a module by its code if it exists, or null if it does not.
		/// </summary>
		/// <param name="field"></param>
		/// <param name="module"></param>
		/// <returns></returns>
		public VariableValue GetValue(String field, String module = "customfields")
		{
			if (HasValue(field, module))
			{
				return Values[module][field];
			}
			
			return null;
		}

		/// <summary>
		/// Check if a value for code and module exists.
		/// </summary>
		/// <param name="field"></param>
		/// <param name="module"></param>
		/// <returns></returns>
		public bool HasValue(String field, String module)
		{
			if (!Values.ContainsKey(module))
			{
				return false;
			}

			return Values[module].ContainsKey(field);
		}

		/// <summary>
		/// Check if a specific module is defined.
		/// </summary>
		/// <param name="module"></param>
		/// <returns></returns>
		public bool HasModule(String module)
		{
			return Values.ContainsKey(module);
		}

		/// <summary>
		/// Get a specific modules custom field values, or null if it does not exist;
		/// </summary>
		/// <param name="module"></param>
		/// <returns></returns>
		public Dictionary<String, VariableValue> GetModule(String module)
		{
			if (HasModule(module))
			{
				return Values[module];
			}
			
			return null;
		}
	}

	/// <summary>
	/// Handles converting the custom field values model
	/// </summary>
	public class CustomFieldValuesConverter : JsonConverter<CustomFieldValues>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override CustomFieldValues Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			CustomFieldValues values = new CustomFieldValues();

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
						return values;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String module = reader.GetString();

				reader.Read(); // Read to module object start

				if (reader.TokenType != JsonTokenType.StartObject)
				{
					throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
				}

				while(reader.Read())
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						break;
					}

					if(reader.TokenType != JsonTokenType.PropertyName)
					{
						throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
					}

					String field = reader.GetString();

					reader.Read(); // Read to value start

					VariableValue value = JsonSerializer.Deserialize<VariableValue>(ref reader, options);

					values.SetValue(field, value, module);
				}
			}

			return values;
		}

		public override void Write(Utf8JsonWriter writer, CustomFieldValues model, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			foreach(KeyValuePair<String, Dictionary<String, VariableValue>> moduleEntry in model.Values)
			{
				writer.WritePropertyName(moduleEntry.Key);

				writer.WriteStartObject();

				foreach(KeyValuePair<String, VariableValue> valueEntry in moduleEntry.Value)
				{
					writer.WritePropertyName(valueEntry.Key);

					JsonSerializer.Serialize<VariableValue>(writer, valueEntry.Value, options);
				}

				writer.WriteEndObject();
			}

			writer.WriteEndObject();
		}
	}
}
