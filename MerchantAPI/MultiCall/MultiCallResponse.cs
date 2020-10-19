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
using System.Linq;

namespace MerchantAPI
{
	//[JsonConverter(typeof(MultiCallResponseConverter))]
	public class MultiCallResponse : Response
	{
		/// The initating request
		public new MultiCallRequest Request { get; set; }

		public int Completed { get; set; } = 0;

		public int Total { get; set; } = 0;

		public bool Timeout { get; set; } = false;

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
		/// Check if the operation was timedout
		/// </summary>
		/// <returns></returns>
		public bool IsTimeout()
		{
			return Timeout;
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

		/// <summary>
		/// Handles continuing after timeout. The owning request must have AutoTimeoutContinue flag specified.
		/// </summary>
		public void AutoContinue()
		{
			if (Request == null || !Request.AutoTimeoutContinue)
			{
				return;
			}

			Request._InitialResponse = this;

			Tuple<int, int> range;
			IEnumerable<String> matches;

			if (HttpResponse.Content.Headers.TryGetValues("Content-Range", out matches))
			{
				range = ReadRange(matches.First());

				if (range.Item1 <= 0 || range.Item2 <= 0)
				{
					return;
				}

				Completed = range.Item1;
				Total = range.Item2;

				ProcessContinue();
			}
		}

		/// <summary>
		/// Used internally to process continuing after timeout.
		/// </summary>
		protected void ProcessContinue()
		{
			while (Completed != Total)
			{
				var response = Request.Send();

				if (!response.IsSuccess())
				{
					break;
				}

				Responses.AddRange(response.GetResponses());

				Tuple<int, int> range;
				IEnumerable<String> matches;

				if (response.HttpResponse.Content.Headers.TryGetValues("Content-Range", out matches))
				{
					range = ReadRange(matches.First());

					Completed += range.Item1;
				}
				else
				{
					if (Total - Completed == response.GetResponses().Count)
					{
						Completed = Total;
					}
				}
			}

			if (Completed == Total)
			{
				Timeout = false;
			}
		}

		/// <summary>
		/// Read the range header string into its integer values.
		/// </summary>
		/// <param name="range"></param>
		/// <returns></returns>
		protected Tuple<int, int> ReadRange(String range)
		{
			int completed = 0;
			int total = 0;

			if (range.Length > 0)
			{
				String[] ranges = range.Split('/');
				if (ranges.Length == 2)
				{
					int.TryParse(ranges[0], out completed);
					int.TryParse(ranges[1], out total);
				}
			}

			return new Tuple<int, int>(completed, total);
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
			return typeToConvert == typeof(MultiCallResponse);
		}

		public override MultiCallResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			MultiCallResponse response = new MultiCallResponse();
			JsonSerializerOptions optionsReset = new JsonSerializerOptions();

			if (reader.TokenType != JsonTokenType.StartArray)
			{
				throw new MerchantAPIException(String.Format("Excepted start of array but encountered {0}", reader.TokenType));
			}

			var continueIndex = 0;

			foreach (var entry in Request.GetRequests())
			{
				if (Request._InitialResponse != null && continueIndex != Request._InitialResponse.Responses.Count - 1)
				{
					continueIndex++;
					continue;
				}

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
							throw new MerchantAPIException(String.Format("Excepted start of object but encountered {0}", reader.TokenType));
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
						if (reader.TokenType == JsonTokenType.EndArray)
						{
							return response; // We did not receive everything, or we encountered a timeout.
						}

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