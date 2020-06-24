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
		public Dictionary<String, Dictionary<String, CustomFieldValue>> Values { get; set; } = new Dictionary<String, Dictionary<String, CustomFieldValue>>();

		/// <summary>
		/// Set a custom field value
		/// </summary>
		/// <param name="field">String</param>
		/// <param name="value">String</param>
		/// <param name="module">String</param>
		public CustomFieldValues SetValue(String field, String value, String module = "customfields")
		{
			if (!HasModule(module))
			{
				Values[module] = new Dictionary<String, CustomFieldValue>();
			}

			Values[module][field] = new CustomFieldValue(value);
			return this;
		}

		/// <summary>
		/// Set a custom field value array for multitext
		/// </summary>
		/// <param name="field">String</param>
		/// <param name="value">List<String></param>
		/// <param name="module">String</param>
		public CustomFieldValues SetValue(String field, List<String> values, String module = "customfields")
		{
			if (!HasModule(module))
			{
				Values[module] = new Dictionary<String, CustomFieldValue>();
			}

			Values[module][field] = new CustomFieldValue(values);
			return this;
		}

		/// <summary>
		/// Set a custom field value from a CustomFieldValue instance
		/// </summary>
		/// <param name="field">String</param>
		/// <param name="value">List<String></param>
		/// <param name="module">String</param>
		public CustomFieldValues SetValue(String field, CustomFieldValue value, String module = "customfields")
		{
			if (!HasModule(module))
			{
				Values[module] = new Dictionary<String, CustomFieldValue>();
			}

			Values[module][field] = value;
			return this;
		}

		/// <summary>
		/// Get all values for all modules.
		/// </summary>
		/// <returns></returns>
		public Dictionary<String, Dictionary<String, CustomFieldValue>> GetValues()
		{
			return Values;
		}

		/// <summary>
		/// Get a value for a module by its code.
		/// </summary>
		/// <param name="field"></param>
		/// <param name="module"></param>
		/// <returns></returns>
		public CustomFieldValue GetValue(String field, String module = "customfields")
		{
			return Values[module][field];
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
		/// Get a specific modules custom field values.
		/// </summary>
		/// <param name="module"></param>
		/// <returns></returns>
		public Dictionary<String, CustomFieldValue> GetModule(String module)
		{
			return Values[module];
		}
	}

	/// <summary>
	/// Holds the value for a custom field. Either holds string data, or an array of strings.
	/// </summary>
	[JsonConverter(typeof(CustomFieldValueConverter))]
	public class CustomFieldValue
	{
		public enum CustomFieldValueType
		{
			StringType,
			ArrayType
		};

		public String Value { get; set; }

		public List<String> Values { get; set; } = new List<String>();

		public CustomFieldValueType ValueType { get; } = CustomFieldValueType.StringType;

		public CustomFieldValue(String value)
		{
			ValueType = CustomFieldValueType.StringType;
			Value = value;
		}

		public CustomFieldValue(List<String> values)
		{
			ValueType = CustomFieldValueType.ArrayType;
			Value = "";
			Values = values;
		}

		override public String ToString()
		{
			if (ValueType == CustomFieldValueType.ArrayType)
			{
				return String.Join(",", Values);
			}

			return Value;
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

					CustomFieldValue value = JsonSerializer.Deserialize<CustomFieldValue>(ref reader, options);

					values.SetValue(field, value, module);
				}
			}

			return values;
		}

		public override void Write(Utf8JsonWriter writer, CustomFieldValues model, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			foreach(KeyValuePair<String, Dictionary<String, CustomFieldValue>> moduleEntry in model.Values)
			{
				writer.WritePropertyName(moduleEntry.Key);

				writer.WriteStartObject();

				foreach(KeyValuePair<String, CustomFieldValue> valueEntry in moduleEntry.Value)
				{
					writer.WritePropertyName(valueEntry.Key);

					JsonSerializer.Serialize<CustomFieldValue>(writer, valueEntry.Value, options);
				}

				writer.WriteEndObject();
			}

			writer.WriteEndObject();
		}
	}

	/// <summary>
	/// Handles converting a single custom field value
	/// </summary>
	public class CustomFieldValueConverter : JsonConverter<CustomFieldValue>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override CustomFieldValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.StartArray)
			{
				List<String> values = new List<String>();

				while (reader.Read())
				{
					if (reader.TokenType != JsonTokenType.String)
					{
						if (reader.TokenType == JsonTokenType.EndArray)
						{
							return new CustomFieldValue(values);
						}

						throw new MerchantAPIException(String.Format("Expected String or EndArray but got {0}", reader.TokenType));
					}

					values.Add(reader.GetString());
				}
			}
			else if (reader.TokenType == JsonTokenType.String)
			{
				return new CustomFieldValue(reader.GetString());
			}

			throw new MerchantAPIException(String.Format("Expected String or StartArray but got {0}", reader.TokenType));
		}

		public override void Write(Utf8JsonWriter writer, CustomFieldValue value, JsonSerializerOptions options)
		{
			if (value.ValueType == CustomFieldValue.CustomFieldValueType.StringType)
			{
				writer.WriteStringValue(value.Value);
			}
			else
			{
				writer.WriteStartArray();

				foreach (var v in value.Values)
				{
					writer.WriteStringValue(v);
				}

				writer.WriteEndArray();
				return;
			}
		}
	}
}
