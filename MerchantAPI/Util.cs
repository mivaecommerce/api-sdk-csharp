/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	public static class Util
	{
		/// <summary>
		/// Check if a value is a numeric type
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		static public bool IsNumeric(IConvertible value)
		{
			if (value == null)	return false;

			switch (value.GetTypeCode())
			{
				case TypeCode.Byte:
				case TypeCode.Decimal:
				case TypeCode.Double:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.SByte:
				case TypeCode.Single:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					return true;
			}

			return false;
		}

		/// <summary>
		/// Check if a value is a decimal type
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		static public bool IsDecimal(IConvertible value)
		{
			if (value == null) return false;

			switch (value.GetTypeCode())
			{
				case TypeCode.Decimal:
				case TypeCode.Double:
				case TypeCode.Single:
					return true;
			}

			return false;
		}

		/// <summary>
		/// Check if a value is a float
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		static public bool IsFloat(IConvertible value)
		{
			if (value == null) return false;

			return value.GetTypeCode() == TypeCode.Single;
		}

		/// <summary>
		/// Check if a value is a bool
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		static public bool IsBoolean(IConvertible value)
		{
			if (value == null) return false;

			return value.GetTypeCode() == TypeCode.Boolean;
		}
	}

	/// <summary>
	/// Handles JSON serialization/deserialization of a DateTime to/from unix timestamp
	/// </summary>
	public class UnixTimestampConverter : BaseJsonConverter<DateTime>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected number but got {0}", reader.TokenType));
			}

			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(reader.GetInt64()));
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(new DateTimeOffset(value).ToUnixTimeSeconds());
		}
	}

	/// <summary>
	/// Holds the value for response types that are not know until runtime. Supports any IConvertible, Arrays of VariableValue's, and Dictionartys of them as well.
	/// </summary>
	[JsonConverter(typeof(VariableValueConverter))]
	public class VariableValue
	{
		public enum ValueDataType
		{
			ConvertibleType,
			DictionaryType,
			ArrayType
		};

		protected IConvertible ValueConvertible { get; set; } = null;

		protected List<VariableValue> ValueArray { get; set; } = null;

		protected Dictionary<String, VariableValue> ValueDict { get; set; } = null;

		public ValueDataType ValueType { get; } = ValueDataType.ConvertibleType;

		/// <summary>
		/// Constructor for convertible type
		/// </summary>
		/// <param name="value"></param>
		public VariableValue(IConvertible value)
		{
			ValueType = ValueDataType.ConvertibleType;
			ValueConvertible = value;
		}

		/// <summary>
		/// Constructor for array type
		/// </summary>
		/// <param name="values"></param>
		public VariableValue(List<VariableValue> values)
		{
			ValueType = ValueDataType.ArrayType;
			ValueArray = values;
		}

		/// <summary>
		/// Constructor for Dictionary type
		/// </summary>
		/// <param name="values"></param>
		public VariableValue(Dictionary<String, VariableValue> values)
		{
			ValueType = ValueDataType.DictionaryType;
			ValueDict = values;
		}

		/// <summary>
		/// Get the dictionary value, will be null if not convertible type
		/// </summary>
		/// <returns></returns>
		public Dictionary<String, VariableValue> GetValueDictionary()
		{
			return ValueDict;
		}

		/// <summary>
		/// Get the array value, will be null if not convertible type
		/// </summary>
		/// <returns></returns>
		public List<VariableValue> GetValueArray()
		{
			return ValueArray;
		}

		/// <summary>
		/// Get the convertible value, will be null if not convertible type
		/// </summary>
		/// <returns></returns>
		public IConvertible GetValueConvertible()
		{
			return ValueConvertible;
		}

		/// <summary>
		/// Check if the underlying type is a convertible 
		/// </summary>
		/// <returns></returns>
		public bool IsConvertible()
		{
			return ValueType == ValueDataType.ConvertibleType;
		}

		/// <summary>
		/// Check if the underlying type is a dictionary
		/// </summary>
		/// <returns></returns>
		public bool IsDictionary()
		{
			return ValueType == ValueDataType.DictionaryType;
		}

		/// <summary>
		/// Check if the underlying type is a array
		/// </summary>
		/// <returns></returns>
		public bool IsArray()
		{
			return ValueType == ValueDataType.ArrayType;
		}

		/// <summary>
		/// Add an entry to the value array only if it is an array type
		/// </summary>
		/// <param name="value"></param>
		public void AddToArray(VariableValue value)
		{
			if (ValueType == ValueDataType.ArrayType)
			{
				ValueArray.Add(value);
			}
		}

		/// <summary>
		/// Add an entry to the dictionary only if it is a dictionary type
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public void AddToDictionary(String key, VariableValue value)
		{
			if (ValueType == ValueDataType.DictionaryType)
			{
				ValueDict[key] = value;
			}
		}

		/// <summary>
		/// Set the convertible value, only if it is a convertible type
		/// </summary>
		/// <param name="value"></param>
		public void SetConvertible(IConvertible value)
		{
			if (ValueType == ValueDataType.ConvertibleType)
			{
				ValueConvertible = value;
			}
		}

		/// <summary>
		/// Get a string value from this object. Only returns a value for convertible type
		/// </summary>
		/// <returns></returns>
		public new String ToString()
		{
			if (ValueType == ValueDataType.ConvertibleType)
			{
				return ValueConvertible.ToString();
			}

			return "";
		}

		/// <summary>
		/// Equals operator overload
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator ==(VariableValue a, VariableValue b)
		{
			if (a.ValueType == b.ValueType)
			{
				if (a.ValueType == ValueDataType.ConvertibleType)
				{
					return a.GetValueConvertible() == b.GetValueConvertible();
				}
			}

			return false;
		}

		/// <summary>
		/// Not equals operator overload. 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator !=(VariableValue a, VariableValue b)
		{
			if (a.ValueType == b.ValueType)
			{
				if (a.ValueType == ValueDataType.ConvertibleType)
				{
					return a.GetValueConvertible() != b.GetValueConvertible();
				}
			}

			return true;
		}
	}

	/// <summary>
	/// Handles serializing/deserializing a single variable value
	/// </summary>
	public class VariableValueConverter : BaseJsonConverter<VariableValue>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override VariableValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.StartArray)
			{
				List<VariableValue> values = new List<VariableValue>();

				while (reader.Read())
				{
					if (reader.TokenType == JsonTokenType.EndArray)
					{
						return new VariableValue(values);
					}

					values.Add(JsonSerializer.Deserialize<VariableValue>(ref reader, options));
				}
			}
			else if (reader.TokenType == JsonTokenType.StartObject)
			{
				Dictionary<String, VariableValue> properties = new Dictionary<String, VariableValue>();
				String property = null;

				while (reader.Read())
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return new VariableValue(properties);
					}
					else if (reader.TokenType == JsonTokenType.PropertyName)
					{
						property = reader.GetString();

						properties[property] = JsonSerializer.Deserialize<VariableValue>(ref reader, options);
					}
					else
					{
						throw new MerchantAPIException(String.Format("Expected PropertyName or EndObject but got {0}", reader.TokenType));
					}
				}
			}
			else if (reader.TokenType == JsonTokenType.String)
			{
				return new VariableValue(reader.GetString());
			}
			else if (reader.TokenType == JsonTokenType.Number)
			{
				float ftest;
				double dtest;
				decimal detest;
				int itest;

				if (reader.TryGetSingle(out ftest))
				{
					return new VariableValue(ftest);
				}
				else if (reader.TryGetDouble(out dtest))
				{
					return new VariableValue(dtest);
				}
				else if (reader.TryGetDecimal(out detest))
				{
					return new VariableValue(detest);
				}
				else if (reader.TryGetInt32(out itest))
				{
					return new VariableValue(itest);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected IConvertible type {0}", reader.TokenType));
				}
			}
			else if (reader.TokenType == JsonTokenType.False || reader.TokenType == JsonTokenType.True)
			{
				return new VariableValue(reader.GetBoolean());
			}

			throw new MerchantAPIException(String.Format("Expected StartArray, StartObject, or value type but got {0}", reader.TokenType));
		}

		public override void Write(Utf8JsonWriter writer, VariableValue value, JsonSerializerOptions options)
		{

			if (value.IsConvertible())
			{
				IConvertible val = value.GetValueConvertible();

				if (val is String)
				{
					writer.WriteStringValue(val.ToString());
				}
				else if (Util.IsBoolean(val))
				{
					writer.WriteBooleanValue((bool)val);
				}
				else if (Util.IsNumeric(val))
				{
					if (Util.IsFloat(val))
					{
						writer.WriteNumberValue((float)val);
					}
					else if (Util.IsDecimal(val))
					{
						writer.WriteNumberValue((decimal)val);
					}
					else
					{
						writer.WriteNumberValue((int)val);
					}
				}
			}
			else if (value.IsArray())
			{
				writer.WriteStartArray();

				foreach (VariableValue v in value.GetValueArray())
				{
					JsonSerializer.Serialize<VariableValue>(writer, v, options);
				}

				writer.WriteEndArray();
			}
			else if (value.IsDictionary())
			{
				writer.WriteStartObject();

				foreach (KeyValuePair<String, VariableValue> v in value.GetValueDictionary())
				{
					writer.WritePropertyName(v.Key);

					JsonSerializer.Serialize<VariableValue>(writer, v.Value, options);
				}

				writer.WriteEndObject();
			}
			else
			{
				throw new MerchantAPIException(String.Format("Invalid value data type {0}", value.ValueType));
			}
		}
	}

	/// <summary>
	/// Base Converter all converters inheirt from
	/// </summary>
	/// <typeparam name="T"></typeparam>
	abstract public class BaseJsonConverter<T> : JsonConverter<T>
	{
		protected String ReadNextString(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.String)
			{
				throw new MerchantAPIException(String.Format("Expected string but encountered {0}", reader.TokenType));
			}

			return reader.GetString();
		}

		protected float ReadNextFloat(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected number but encountered {0}", reader.TokenType));
			}

			return reader.GetSingle();
		}

		protected int ReadNextInteger(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected number but encountered {0}", reader.TokenType));
			}

			return reader.GetInt32();
		}

		protected bool ReadNextBoolean(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.False && reader.TokenType != JsonTokenType.True)
			{
				throw new MerchantAPIException(String.Format("Expected true or false but encountered {0}", reader.TokenType));
			}

			return reader.GetBoolean();
		}

		protected DateTime ReadNextTimestamp(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected true or false but encountered {0}", reader.TokenType));
			}

			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(reader.GetInt64()));
		}
	}
}