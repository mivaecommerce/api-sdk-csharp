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
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// Templated class which represents a list query response collection of models
	/// </summary>
	/// <typeparam name="T">The model type expected</typeparam>
	public class ListQueryResult<T> where T : Model
	{
		// The total records returned
		[JsonPropertyName("total_count")]
		public int TotalCount { get; set; }

		// The starting offset of the records
		[JsonPropertyName("start_offset")]
		public int StartOffset { get; set; }

		// Templated data container
		[JsonPropertyName("data")]
		public List<T> Data { get; set; } = new List<T>();
	}

	/// <summary>
	/// All ListQueryRequest functions inherit from this class
	/// </summary>
	/// <typeparam name="T"></typeparam>
	abstract public class ListQueryResponse<T> : Response where T : Model
	{
		[JsonPropertyName("data")]
		virtual public ListQueryResult<T> Data { get; set; } = new ListQueryResult<T>();

		public ListQueryResponse() :
			base()
		{

		}
	}

	/// <summary>
	/// Handles deserialization of a ListQueryResult of a given type.
	/// </summary>
	/// <typeparam name="T">The model type expected</typeparam>
	public class ListQueryResultConverter<T> : BaseJsonConverter<ListQueryResult<T>> where T : Model
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override ListQueryResult<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ListQueryResult<T> result = new ListQueryResult<T>();

			while(reader.Read())
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					String key = reader.GetString();

					if (key == "total_count")
					{
						reader.Read();
						result.TotalCount = reader.GetInt32();
					}
					else if (key == "start_offset")
					{
						reader.Read();
						result.StartOffset = reader.GetInt32();
					}
					else if (key == "data")
					{
						result.Data = JsonSerializer.Deserialize<List<T>>(ref reader, options);
						reader.Read(); // read before returning so we can continue the process down the chain
						return result;
					}
				}
			}

			return result;
		}

		public override void Write(Utf8JsonWriter writer, ListQueryResult<T> value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}