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
	//[JsonConverter(typeof(MultiCallResponseConverter))]
	public class MultiCallResponse : Response
	{
		/// The initating request
		public new MultiCallRequest Request { get; set; }

		/// The responses for each request sent
		public List<Response> Responses { get; set; } = new List<Response>();

		/// <summary>
		/// Check if the operation was successful
		/// </summary>
		/// <returns></returns>
		public override bool IsSuccess()
		{
			return true;
		}

		/// <summary>
		/// Check if the operation encountered an error
		/// </summary>
		/// <returns></returns>
		public override bool IsError()
		{
			return false;
		}

		/// <summary>
		/// Get the response container
		/// </summary>
		/// <returns></returns>
		public List<Response> GetResponses()
		{
			return Responses;
		}
	}

	/// <summary>
	/// Handles deserializing a MultiCallResponse from JSON
	/// </summary>
	public class MultiCallResponseConverter : BaseJsonConverter<MultiCallResponse>
	{
		protected MultiCallRequest Request;

		public MultiCallResponseConverter(MultiCallRequest request) :
			base()
		{
			Request = request;
		}

		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		public override MultiCallResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			MultiCallResponse response = new MultiCallResponse();
			JsonSerializerOptions optionsReset = new JsonSerializerOptions();

			if (reader.TokenType != JsonTokenType.StartArray)
			{
				throw new MerchantAPIException(String.Format("Excepted start of array but encountered {0}", reader.TokenType));
			}

			foreach (var entry in Request.GetRequests())
			{
				reader.Read();

				if (entry is MultiCallOperation operation)
				{
					if (reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Excepted start of array but encountered {0}", reader.TokenType));
					}

					foreach (Request request in operation.GetRequests())
					{
						reader.Read();

						if (reader.TokenType != JsonTokenType.StartObject)
						{
							throw new MerchantAPIException(String.Format("[3] Excepted start of object but encountered {0}", reader.TokenType));
						}

						response.Responses.Add(request.ReadResponse(ref reader, optionsReset));
					}

					reader.Read();

					if (reader.TokenType != JsonTokenType.EndArray)
					{
						throw new MerchantAPIException(String.Format("Excepted end of array but encountered {0}", reader.TokenType));
					} 
				}
				else if (entry is Request request)
				{
					if (reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Excepted start of object but encountered {0}", reader.TokenType));
					}

					response.Responses.Add(request.ReadResponse(ref reader, optionsReset));
				}
			}

			if (reader.TokenType != JsonTokenType.EndObject)
			{
				throw new MerchantAPIException(String.Format("Excepted end of object but encountered {0}", reader.TokenType));
			}

			reader.Read();

			return response;
		}

		public override void Write(Utf8JsonWriter writer, MultiCallResponse value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}