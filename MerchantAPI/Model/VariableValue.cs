using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// Holds a dynamic value that can be serialized and deserialized
	/// at runtime from values which are not known until runtime.
	/// Supports Array's, Lists, and Dictionaries of nested types and IConvertible values.
	/// </summary>
	[JsonConverter(typeof(VariableValueConverter))]
	public class VariableValue : Model
	{
		public enum ValueDataType
		{
			ConvertibleType,
			DictionaryType,
			ArrayType
		};

		protected dynamic Value { get; set; } = null;

		public ValueDataType ValueType { get; private set; } = ValueDataType.ConvertibleType;

		/// <summary>
		/// Indexer function allowing access by int key
		/// </summary>
		/// <param name="index"></param>
		public dynamic this[int idx] => GetValueIndexInt(idx);

		private dynamic GetValueIndexInt(int index)
		{
			if (IsArray())
			{
				int count = Util.IsNativeArray(Value.GetType()) ? Value.Length : Value.Count;
				if (count > index)
				{
					return Value[index];
				}

				throw new ArgumentOutOfRangeException("Index out of range");
			}

			throw new InvalidOperationException("Value is not an array type");
		}

		/// <summary>
		/// Indexer function allowing access by string key
		/// </summary>
		/// <param name="index"></param>
		public dynamic this[string idx] => GetValueIndexStr(idx);

		private dynamic GetValueIndexStr(String index)
		{
			if (IsDictionary())
			{
				if (Value.ContainsKey(index))
				{
					return Value[index];
				}

				throw new ArgumentOutOfRangeException("Index does not exist");
			}

			throw new InvalidOperationException("Value is not a dictionary type");
		}

		/// <summary>
		/// Default constructor, creates a null value of convertible type
		/// </summary>
		/// <param name="value"></param>
		public VariableValue()
		{
			ValueType = ValueDataType.ConvertibleType;
			Value = null;
		}

		/// <summary>
		/// Constructor for dynamic types
		/// </summary>
		/// <param name="values"></param>
		public VariableValue(dynamic value)
		{
			SetValue(value);
		}

		/// <summary>
		/// Get the dictionary value, will be null if not convertible type
		/// </summary>
		/// <returns></returns>
		[Obsolete("GetValueDictionary Dropped. Use GetValue instead")]
		public Dictionary<String, VariableValue> GetValueDictionary()
		{
			return null;
		}

		/// <summary>
		/// Get the array value, will be null if not convertible type
		/// </summary>
		/// <returns></returns>
		[Obsolete("GetValueArray Dropped. Use GetValue instead")]
		public List<VariableValue> GetValueArray()
		{
			return null;
		}

		/// <summary>
		/// Get the convertible value, will be null if not convertible type
		/// </summary>
		/// <returns></returns>
		[Obsolete("GetValue Dropped. Use GetValue instead")]
		public IConvertible GetValueConvertible()
		{
			return IsConvertible() ? GetValue() : null;
		}

		/// <summary>
		/// Set the underlying value
		/// </summary>
		/// <returns></returns>
		public void SetValue(dynamic value)
		{
			if (value is IConvertible)
			{
				ValueType = ValueDataType.ConvertibleType;
			}
			else if (Util.IsDictionaryType(value.GetType()))
			{
				ValueType = ValueDataType.DictionaryType;
			}
			else if (Util.IsListType(value.GetType()) || Util.IsNativeArray(value.GetType()))
			{
				ValueType = ValueDataType.ArrayType;
			}
			else
			{
				throw new MerchantAPIException("Invalid Dynamic Type");
			}

			Value = value;
		}

		/// <summary>
		/// Get the underlying value
		/// </summary>
		/// <returns></returns>
		public dynamic GetValue()
		{
			return Value;
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
			return Value == null;
		}

		/// <summary>
		/// Get a string value from this object. Only returns a value for convertible type
		/// </summary>
		/// <returns></returns>
		public new String ToString()
		{
			if (IsConvertible())
			{
				return Value.ToString();
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
			return new VariableValue(Read(ref reader, options));
		}

		public override void Write(Utf8JsonWriter writer, VariableValue value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<dynamic>(writer, value.GetValue(), options);
		}

		protected dynamic Read(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.StartArray)
			{
				List<dynamic> values = new List<dynamic>();

				ReadList(values, ref reader, options);

				return values;
			}
			else if (reader.TokenType == JsonTokenType.StartObject)
			{
				Dictionary<String, dynamic> values = new Dictionary<String, dynamic>();

				ReadDictionary(values, ref reader, options);

				return values;
			}
			else if(reader.TokenType == JsonTokenType.String)
			{
				return reader.GetString();
			}
			else if (reader.TokenType == JsonTokenType.Number)
			{
				float ftest;
				double dtest;
				decimal detest;
				int itest;

				if (reader.TryGetSingle(out ftest))
				{
					return ftest;
				}
				else if (reader.TryGetDouble(out dtest))
				{
					return dtest;
				}
				else if (reader.TryGetDecimal(out detest))
				{
					return detest;
				}
				else if (reader.TryGetInt32(out itest))
				{
					return itest;
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected IConvertible type {0}", reader.TokenType));
				}
			}
			else if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
			{
				return reader.GetBoolean();
			}
			else if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			else if(reader.TokenType == JsonTokenType.Comment)
			{
				reader.Read();
				return Read(ref reader, options);
			}

			throw new MerchantAPIException(String.Format("Unhandled Token Type {0}", reader.TokenType));
		}

		protected void ReadList(List<dynamic> list, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndArray)
				{
					return;
				}

				list.Add(Read(ref reader, options));
			}
		}

		protected void ReadDictionary(Dictionary<String, dynamic> dictionary, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			String property = "";

			while(reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					return;
				}
				else if (reader.TokenType != JsonTokenType.PropertyName)
				{
					throw new MerchantAPIException(String.Format("Expected PropertyName or EndObject but got {0}", reader.TokenType));
				}

				property = reader.GetString();

				reader.Read();

				dictionary[property] = Read(ref reader, options);
			}
		}
	}
}

