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
using System.Net.Sockets;
using System.Text;
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
			if (value == null)   return false;

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
	/// Structure of a JSON_DateTime value
	/// </summary>
	struct DateTimeStruct
	{
		public DateTime time_t;
		public int year;
		public int month;
		public int day;
		public int hour;
		public int minute;
		public int second;
		public int timezone;
	}

	/// <summary>
	/// Handles JSON serialization/deserialization of a DateTime to/from unix timestamp
	/// </summary>
	public class UnixTimestampConverter : BaseJsonConverter<DateTime>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(DateTime);
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
	/// Handles JSON serialization/deserialization of a DateTime to/from JSON_DateTime structure
	/// </summary>
	public class DateTimeStructConverter : BaseJsonConverter<DateTime>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(DateTime);
		}

		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			DateTimeStruct data = new DateTimeStruct();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while (reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						break;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "time_t", StringComparison.OrdinalIgnoreCase))
				{
					data.time_t = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "year", StringComparison.OrdinalIgnoreCase))
				{
					data.year = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "month", StringComparison.OrdinalIgnoreCase))
				{
					data.month = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "day", StringComparison.OrdinalIgnoreCase))
				{
					data.day = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "hour", StringComparison.OrdinalIgnoreCase))
				{
					data.hour = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "minute", StringComparison.OrdinalIgnoreCase))
				{
					data.minute = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "second", StringComparison.OrdinalIgnoreCase))
				{
					data.second = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "timezone", StringComparison.OrdinalIgnoreCase))
				{
					data.timezone = ReadNextInteger(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for DateTimeStruct", property));
				}
			}

			return data.time_t;
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(new DateTimeOffset(value).ToUnixTimeSeconds());
		}
	}

	/// <summary>
	/// Holds the value for response types that are not know until runtime. Supports any IConvertible, Arrays of VariableValue's, and Dictionarys of them as well.
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
		/// Default constructor, creates a null value of convertible type
		/// </summary>
		/// <param name="value"></param>
		public VariableValue()
		{
			ValueType = ValueDataType.ConvertibleType;
			ValueConvertible = null;
		}

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
		/// Check if this value is null
		/// </summary>
		/// <returns></returns>
		public bool IsNull()
		{
			if (ValueType == ValueDataType.DictionaryType && ValueDict == null)
			{
				return true;
			}
			else if (ValueType == ValueDataType.ArrayType && ValueArray == null)
			{
				return true;
			}
			else if (ValueType == ValueDataType.ConvertibleType && ValueArray == null)
			{
				return true;
			}

			return false;
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
	}

	/// <summary>
	/// Handles serializing/deserializing a single variable value
	/// </summary>
	public class VariableValueConverter : BaseJsonConverter<VariableValue>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(VariableValue) || typeToConvert.IsSubclassOf(typeof(VariableValue));
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
	/// Base converter that all converters inherit from.
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

		/// <summary>
		/// Reads the next value as a float
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="options"></param>
		/// <returns>float</returns>
		/// <exception cref="MerchantAPIException"></exception>
		protected float ReadNextFloat(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected number but encountered {0}", reader.TokenType));
			}

			return reader.GetSingle();
		}

		/// <summary>
		/// Reads the next value as a integer
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		/// <exception cref="MerchantAPIException"></exception>
		protected int ReadNextInteger(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected number but encountered {0}", reader.TokenType));
			}

			return reader.GetInt32();
		}

		/// <summary>
		/// Reads the next value as a boolean
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		/// <exception cref="MerchantAPIException"></exception>
		protected bool ReadNextBoolean(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.False && reader.TokenType != JsonTokenType.True)
			{
				throw new MerchantAPIException(String.Format("Expected true or false but encountered {0}", reader.TokenType));
			}

			return reader.GetBoolean();
		}

		/// <summary>
		/// Reads the next value as a long
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		/// <exception cref="MerchantAPIException"></exception>
		protected long ReadNextLong(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected true or false but encountered {0}", reader.TokenType));
			}

			return reader.GetInt64();
		}

		/// <summary>
		/// Reads the next value as a DateTime from a timestamp
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		/// <exception cref="MerchantAPIException"></exception>
		protected DateTime ReadNextTimestamp(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			reader.Read();

			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new MerchantAPIException(String.Format("Expected true or false but encountered {0}", reader.TokenType));
			}

			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(reader.GetInt64()));
		}

		/// <summary>
		/// Reads the next value as a DateTime from a timestamp structure
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		/// <exception cref="MerchantAPIException"></exception>
		protected DateTime ReadNextTimestampStruct(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			DateTimeStruct data = new DateTimeStruct();

			reader.Read();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while (reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						break;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "time_t", StringComparison.OrdinalIgnoreCase))
				{
					data.time_t = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "year", StringComparison.OrdinalIgnoreCase))
				{
					data.year = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "month", StringComparison.OrdinalIgnoreCase))
				{
					data.month = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "day", StringComparison.OrdinalIgnoreCase))
				{
					data.day = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "hour", StringComparison.OrdinalIgnoreCase))
				{
					data.hour = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "minute", StringComparison.OrdinalIgnoreCase))
				{
					data.minute = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "second", StringComparison.OrdinalIgnoreCase))
				{
					data.second = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "timezone", StringComparison.OrdinalIgnoreCase))
				{
					data.timezone = ReadNextInteger(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for DateTimeStruct", property));
				}
			}

			return data.time_t;
		}

		public void WriteDynamicDictionary(Dictionary<String, dynamic> Data, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			JSONEncoderHelper.Write(Data, writer, options);
		}
	}

	/// <summary>
	/// Helper class for encoding various dynamic data types to a writer.
	/// </summary>
	public class JSONEncoderHelper
	{
		/// <summary>
		/// Serializes the Request to JSON for sending to the API, called from RequestConverter
		/// <param name="writer">Utf8JsonWriter</param>
		/// <returns>void</returns>
		/// </summary>
		static public void Write(Dictionary<String, dynamic> Data, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			foreach (KeyValuePair<String, dynamic> entry in Data)
			{
				WriteEntry(entry, writer, options);
			}
		}

		/// <summary>
		/// Writes a key value pair
		/// </summary>
		/// <param name="entry"></param>
		/// <param name="writer"></param>
		/// <param name="options"></param>
		static public void WriteEntry(KeyValuePair<String, dynamic> entry, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (entry.Value is IConvertible)
			{
				WriteConvertibleKeyValue(entry.Key, entry.Value, writer, options);
			}
			else if (entry.Value is Dictionary<String, dynamic>)
			{
				WriteDictionary(entry.Key, entry.Value, writer, options);
			}
			else if (entry.Value is List<dynamic>)
			{
				WriteList(entry.Key, entry.Value, writer, options);
			}
			else if (entry.Value is Model)
			{
				writer.WritePropertyName(entry.Key);
				JsonSerializer.Serialize(writer, entry.Value, options);
			}
			else
			{
				throw new MerchantAPIException(String.Format("Unsupported data type for entry"));
			}
		}

		/// <summary>
		/// Writes a dictionary
		/// </summary>
		/// <param name="key"></param>
		/// <param name="dict"></param>
		/// <param name="writer"></param>
		/// <param name="options"></param>
		static public void WriteDictionary(String key, Dictionary<String, dynamic> dict, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (key.Length > 0)
			{
				writer.WritePropertyName(key);
			}

			writer.WriteStartObject();

			foreach (KeyValuePair<String, dynamic> entry in dict)
			{
				WriteEntry(entry, writer, options);
			}

			writer.WriteEndObject();
		}

		/// <summary>
		/// Writes a list of values
		/// </summary>
		/// <param name="key"></param>
		/// <param name="list"></param>
		/// <param name="writer"></param>
		/// <param name="options"></param>
		static public void WriteList(String key, List<dynamic> list, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (key.Length > 0)
			{
				writer.WritePropertyName(key);
			}

			writer.WriteStartArray();

			foreach (dynamic entry in list)
			{
				if (entry is IConvertible)
				{
					WriteConvertibleValue(entry, writer, options);
				}
				else if (entry is Model)
				{
					JsonSerializer.Serialize(writer, entry, options);
				}
				else if (entry is Dictionary<String, dynamic>)
				{
					WriteDictionary("", entry, writer, options);
				}
				else if (entry is List<dynamic>)
				{
					WriteList("", entry, writer, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unsupported data type for list entry"));
				}
			}

			writer.WriteEndArray();
		}

		/// <summary>
		/// Writes an IConvertible key and value
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <param name="writer"></param>
		/// <param name="options"></param>
		static public void WriteConvertibleKeyValue(String key, IConvertible value, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (Util.IsDecimal(value))
			{
				if (Util.IsFloat(value))
				{
					writer.WriteNumber(key, (float)value);
				}
				else
				{
					writer.WriteNumber(key, (double)value);
				}
			}
			else if (Util.IsBoolean(value))
			{
				writer.WriteBoolean(key, (bool)value);
			}
			else if (Util.IsNumeric(value))
			{
				writer.WriteNumber(key, (int)value);
			}
			else
			{
				writer.WriteString(key, value.ToString());
			}
		}

		/// <summary>
		/// Writes an IConvertible value
		/// </summary>
		/// <param name="value"></param>
		/// <param name="writer"></param>
		/// <param name="options"></param>
		static public void WriteConvertibleValue(IConvertible value, Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			if (Util.IsDecimal(value))
			{
				if (Util.IsFloat(value))
				{
					writer.WriteNumberValue((float)value);
				}
				else
				{
					writer.WriteNumberValue((double)value);
				}
			}
			else if (Util.IsBoolean(value))
			{
				writer.WriteBooleanValue((bool)value);
			}
			else if (Util.IsNumeric(value))
			{
				writer.WriteNumberValue((int)value);
			}
			else
			{
				writer.WriteStringValue(value.ToString());
			}
		}
	}
}

// copied from https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Unix/UnixEndPoint.cs
// see also: https://stackoverflow.com/questions/40195290/how-to-connect-to-a-unix-domain-socket-in-net-core-in-c-sharp
//
// Mono.Unix.UnixEndPoint: EndPoint derived class for AF_UNIX family sockets.
//
// Authors:
//  Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) 2003 Ximian, Inc (http://www.ximian.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Net
{

	public class UnixEndPoint : EndPoint
	{
		string filename;

		public UnixEndPoint(string filename)
		{
			if (filename == null)
				throw new ArgumentNullException("filename");

			if (filename == "")
				throw new ArgumentException("Cannot be empty.", "filename");
			this.filename = filename;
		}

		public string Filename
		{
			get
			{
				return (filename);
			}
			set
			{
				filename = value;
			}
		}

		public override AddressFamily AddressFamily
		{
			get { return AddressFamily.Unix; }
		}

		public override EndPoint Create(SocketAddress socketAddress)
		{
			/*
             * Should also check this
             *
            int addr = (int) AddressFamily.Unix;
            if (socketAddress [0] != (addr & 0xFF))
                throw new ArgumentException ("socketAddress is not a unix socket address.");
            if (socketAddress [1] != ((addr & 0xFF00) >> 8))
                throw new ArgumentException ("socketAddress is not a unix socket address.");
             */

			if (socketAddress.Size == 2)
			{
				// Empty filename.
				// Probably from RemoteEndPoint which on linux does not return the file name.
				UnixEndPoint uep = new UnixEndPoint("a");
				uep.filename = "";
				return uep;
			}
			int size = socketAddress.Size - 2;
			byte[] bytes = new byte[size];
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = socketAddress[i + 2];
				// There may be junk after the null terminator, so ignore it all.
				if (bytes[i] == 0)
				{
					size = i;
					break;
				}
			}

			string name = Encoding.UTF8.GetString(bytes, 0, size);
			return new UnixEndPoint(name);
		}

		public override SocketAddress Serialize()
		{
			byte[] bytes = Encoding.UTF8.GetBytes(filename);
			SocketAddress sa = new SocketAddress(AddressFamily, 2 + bytes.Length + 1);
			// sa [0] -> family low byte, sa [1] -> family high byte
			for (int i = 0; i < bytes.Length; i++)
				sa[2 + i] = bytes[i];

			//NULL suffix for non-abstract path
			sa[2 + bytes.Length] = 0;

			return sa;
		}

		public override string ToString()
		{
			return (filename);
		}

		public override int GetHashCode()
		{
			return filename.GetHashCode();
		}

		public override bool Equals(object o)
		{
			UnixEndPoint other = o as UnixEndPoint;
			if (other == null)
				return false;

			return (other.filename == filename);
		}
	}
}