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
	/// <summary>
	/// Represents a sequence of iterations for the same request type.
	/// </summary>
	[JsonConverter(typeof(MultiCallOperationConverter))]
	public class MultiCallOperation
	{
		/// <summary>
		/// The container holding all the requests in the opearation
		/// </summary>
		public List<Request> Requests { get; set; } = new List<Request>();

		/// <summary>
		/// The container holding the shared data common to all requests
		/// </summary>
		public Dictionary<String, IConvertible> SharedData { get; set; } = new Dictionary<String, IConvertible>();

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="request"></param>
		/// <param name="sharedData"></param>
		public MultiCallOperation(Request request = null, Dictionary<String, IConvertible> sharedData = null)
		{
			if (request != null)
			{
				Requests.Add(request);
			}

			if (sharedData != null)
			{
				SharedData = sharedData;
			}
		}

		/// <summary>
		/// Get the request list
		/// </summary>
		/// <returns>List<Request></returns>
		public List<Request> GetRequests()
		{
			return Requests;
		}

		/// <summary>
		/// Add a request operation
		/// </summary>
		/// <param name="request"></param>
		/// <throws>When request is not of the same existing type</throws>
		/// <returns></returns>
		public MultiCallOperation AddRequest(Request request)
		{
			if (request is MultiCallRequest)
			{
				throw new MerchantAPIException("Nested MultiCall is not allowed");
			}

			if (Requests.Count > 0)
			{
				if ( request.GetFunction() != Requests[0].GetFunction())
				{
					throw new MerchantAPIException("Request is not of the same type");
				}
			}

			Requests.Add(request);

			return this;
		}

		/// <summary>
		/// Add an array of requests to process
		/// </summary>
		/// <param name="requests"></param>
		/// <throws>When request is not of the same existing type</throws>
		/// <returns></returns>
		public MultiCallOperation AddRequests(List<Request> requests)
		{
			foreach (Request request in requests)
			{
				AddRequest(request);
			}

			return this;
		}

		/// <summary>
		/// Clear and set the requests to process
		/// </summary>
		/// <param name="requests"></param>
		/// <throws>When request is not of the same existing type</throws>
		/// <returns>MultiCallOperation</returns>
		public MultiCallOperation SetRequests(List<Request> requests)
		{
			Requests.Clear();
			AddRequests(requests);
			return this;
		}

		/// <summary>
		/// Get the current shared data for the operation
		/// </summary>
		/// <returns>Dictionary<String, IConvertible></returns>
		public Dictionary<String, IConvertible> GetSharedData()
		{
			return SharedData;
		}

		/// <summary>
		/// Add shared data to the operation
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns>MultiCallOperation</returns>
		public MultiCallOperation AddSharedData(String key, IConvertible value)
		{
			SharedData[key] = value;
			return this;
		}

		/// <summary>
		/// Clear and set the shared data
		/// </summary>
		/// <param name="data"></param>
		/// <returns>MultiCallOperation</returns>
		public MultiCallOperation SetSharedData(Dictionary<String, IConvertible> data)
		{
			SharedData = data;
			return this;
		}

		/// <summary>
		/// Get the function for this operation
		/// </summary>
		/// <returns>String</returns>
		public String GetFunction()
		{
			if (Requests.Count > 0)
			{
				return Requests[0].GetFunction();
			}

			return "";
		}
	}

	/// <summary>
	/// Handles serializing a MultiCallOperation to JSON
	/// </summary>
	public class MultiCallOperationConverter : BaseJsonConverter<MultiCallOperation>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override MultiCallOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}

		public override void Write(Utf8JsonWriter writer, MultiCallOperation operation, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			writer.WriteString("Function", operation.GetFunction());

			foreach(KeyValuePair<String, IConvertible> entry in operation.GetSharedData())
			{
				if (Util.IsDecimal(entry.Value))
				{
					if (Util.IsFloat(entry.Value))
					{
						writer.WriteNumber(entry.Key, (float)entry.Value);
					}
					else
					{
						writer.WriteNumber(entry.Key, (double)entry.Value);
					}
				}
				else if (Util.IsNumeric(entry.Value))
				{
					writer.WriteNumber(entry.Key, (int)entry.Value);
				}
				else if (Util.IsBoolean(entry.Value))
				{
					writer.WriteBoolean(entry.Key, (bool)entry.Value);
				}
				else
				{
					writer.WriteString(entry.Key, entry.Value.ToString());
				}
			}

			writer.WriteStartArray("Iterations");

			foreach(Request request in operation.GetRequests())
			{
				writer.WriteStartObject();
				request.Write(writer, options);
				writer.WriteEndObject();
			}

			writer.WriteEndArray();
			writer.WriteEndObject();
		}
	}
}