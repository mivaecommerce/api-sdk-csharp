/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;

namespace MerchantAPI
{
	/// <summary>
	/// Base logger class all loggers inheirt from
	/// </summary>
	abstract public class Logger
	{
		/// <summary>
		/// Logs the request
		/// </summary>
		/// <param name="request"></param>
		/// <param name="headers"></param>
		/// <param name="requestData"></param>
		virtual public void LogRequest(Request request, Dictionary<String, String> headers, String requestData)
		{
			if (headers != null && headers.Count > 0)
			{
				WriteLine(String.Format("\r\n============= Request: {0} [HEADERS] =============\r\n", request.GetFunction()));

				foreach (var header in headers)
				{
					WriteLine(String.Format("{0} = {1}", header.Key, header.Value));
				}
			}

			WriteLine(String.Format("\r\n============= Request: {0} [BODY] =============\r\n", request.GetFunction()));
			WriteLine(requestData);
		}

		/// <summary>
		/// Logs the response
		/// </summary>
		/// <param name="response"></param>
		/// <param name="responseMessage"></param>
		virtual public void LogResponse(Response response, HttpResponseMessage responseMessage)
		{
			WriteLine(String.Format("\r\n============= Response: {0} [HEADERS] =============\r\n", response != null ? response.GetRequest().GetFunction() : ""));

			foreach (var header in responseMessage.Headers)
			{

				WriteLine(String.Format("{0} = {1}", header.Key, String.Join("", header.Value)));
			}

			WriteLine(String.Format("\r\n============= Response: {0} [BODY] =============\r\n", response != null ? response.GetRequest().GetFunction() : ""));
			WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
		}

		/// <summary>
		/// Logs the response
		/// </summary>
		/// <param name="responseMessage"></param>
		virtual public void LogResponse(HttpResponseMessage responseMessage)
		{
			LogResponse(null, responseMessage);
		}

		/// <summary>
		/// Write to the log
		/// </summary>
		/// <param name="data"></param>
		abstract public void Write(String data);

		/// <summary>
		/// Write a line to the log
		/// </summary>
		/// <param name="data"></param>
		abstract public void WriteLine(String data);
	}

	/// <summary>
	/// A console logger that logs to either STDOUT or STDERR
	/// </summary>
	public class ConsoleLogger : Logger
	{
		public enum OutputDestination
		{
			StdOut,
			StdErr
		}

		/// The destination to output to
		public OutputDestination Destination { get; set; } = OutputDestination.StdOut;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="destination"></param>
		public ConsoleLogger(OutputDestination destination = OutputDestination.StdOut)
		{
			Destination = destination;
		}

		/// <summary>
		/// Write to the log
		/// </summary>
		/// <param name="data"></param>
		override public void Write(String data)
		{
			if (Destination == OutputDestination.StdErr)
			{
				Console.Error.Write(data);
			}
			else
			{
				Console.Out.Write(data);
			}
		}

		/// <summary>
		/// Write a line to the log
		/// </summary>
		/// <param name="data"></param>
		override public void WriteLine(String data)
		{
			if (Destination == OutputDestination.StdErr)
			{
				Console.Error.WriteLine(data);
			}
			else
			{
				Console.Out.WriteLine(data);
			}
		}
	}

	/// <summary>
	/// A logger that logs to a local file
	/// </summary>
	public class FileLogger : Logger
	{
		public String FilePath { get; }

		protected StreamWriter Writer { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="filePath">The absolute path to the file</param>
		public FileLogger(String filePath)
		{
			Writer = new StreamWriter(@filePath, true);
			Writer.AutoFlush = true;

			FilePath = filePath;
		}

		/// <summary>
		/// Write to the log
		/// </summary>
		/// <param name="data"></param>
		override public void Write(String data)
		{
			Writer.Write(data);
		}

		/// <summary>
		/// Write a line to the log
		/// </summary>
		/// <param name="data"></param>
		override public void WriteLine(String data)
		{
			Writer.WriteLine(data);
		}
	}
}
