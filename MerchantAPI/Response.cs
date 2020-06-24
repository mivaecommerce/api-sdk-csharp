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
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// Base class for all Responses
	/// </summary>
	public class Response
	{
		/// The associated Request
		[JsonIgnore]
		public Request Request { get; set; }

		/// The HTTP Response
		[JsonIgnore]
		public HttpResponseMessage HttpResponse { get; set; }

		/// Field success
		[JsonPropertyName("success")]
		public int Success { get; set;  } = 0;

		/// Field error_code
		[JsonPropertyName("error_code")]
		public String ErrorCode { get; set; } = "";

		/// Field error_message
		[JsonPropertyName("error_message")]
		public String ErrorMessage { get; set; } = "";

		/// Field input_errors
		[JsonPropertyName("input_errors")]
		public bool InputErrors { get; set; } = false;

		/// Field error_field
		[JsonPropertyName("error_fields")]
		public Dictionary<String, String>[] ErrorFields { get; set; } = { };

		/// Field error_string
		[JsonPropertyName("error_string")]
		public String ErrorField { get; set; } = "";

		/// Field error_field_message
		[JsonPropertyName("error_field_message")]
		public String ErrorFieldMessage { get; set; } = "";

		/// Field list_error
		[JsonPropertyName("list_error")]
		public bool ListError { get; set; } = false;

		/// Field input_error
		[JsonPropertyName("input_error")]
		public bool InputError { get; set; } = false;

		/// Field errors
		[JsonPropertyName("errors")]
		public Dictionary<String, String>[] errors { get; set; } = {};

		/// Validation error
		[JsonPropertyName("vaidation_error")]
		public bool ValidationError { get; set; } = false;

		/// <summary>
		/// Constructor
		/// </summary>
		public Response()
		{

		}

		/// <summary>
		/// Check if the response was successful
		/// </summary>
		/// <returns></returns>
		virtual public bool IsSuccess()
		{
			return Success > 0;
		}

		/// <summary>
		/// Check if the response is an error
		/// </summary>
		/// <returns></returns>
		virtual public bool IsError()
		{
			return !IsSuccess();
		}

		/// <summary>
		/// Get the error messages
		/// </summary>
		/// <returns></returns>
		virtual public String GetErrorMessage()
		{
			return ErrorMessage;
		}

		/// <summary>
		/// Get the error code
		/// </summary>
		/// <returns></returns>
		virtual public String GetErrorCode()
		{
			return ErrorCode;
		}

		/// <summary>
		/// Check if the error was a list error
		/// </summary>
		/// <returns></returns>
		public bool IsListError()
		{
			return ListError;
		}

		/// <summary>
		/// Get the field associated with the error
		/// </summary>
		/// <returns></returns>
		public String GetErrorField()
		{
			return ErrorField;
		}

		/// <summary>
		/// Get all error field messages
		/// </summary>
		/// <returns></returns>
		public String getErrorFieldMessage()
		{
			return ErrorFieldMessage;
		}

		/// <summary>
		/// Get the request that was sent
		/// </summary>
		/// <returns></returns>
		public Request GetRequest()
		{
			return Request;
		}

		/// <summary>
		/// Get the HTTP Response that was received
		/// </summary>
		/// <returns></returns>
		public HttpResponseMessage GetHttpResponse()
		{
			return HttpResponse;
		}
	}
}