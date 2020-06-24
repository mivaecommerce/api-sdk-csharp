/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
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

	public class UnixTimestampConverter : JsonConverter<DateTime>
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
}
