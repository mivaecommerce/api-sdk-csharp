/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request URI_Insert.
	/// <see>https://docs.miva.com/json-api/functions/uri_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class URIInsertRequest : Request
	{
		/// Request field URI.
		[JsonPropertyName("URI")]
		public String Uri { get; set; }

		/// Request field Destination_Type.
		[JsonPropertyName("Destination_Type")]
		public String DestinationType { get; set; }

		/// Request field Destination.
		[JsonPropertyName("Destination")]
		public String Destination { get; set; }

		/// Request field Status.
		[JsonPropertyName("Status")]
		public int? Status { get; set; }

		/// Request field Canonical.
		[JsonPropertyName("Canonical")]
		public bool? Canonical { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public URIInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "URI_Insert";
			Scope = RequestScope.DomainOptionalStore;
		}

		/// <summary>
		/// Getter for URI.
		/// <returns>String</returns>
		/// </summary>
		public String GetUri()
		{
			return Uri;
		}

		/// <summary>
		/// Getter for Destination_Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationType()
		{
			return DestinationType;
		}

		/// <summary>
		/// Getter for Destination.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestination()
		{
			return Destination;
		}

		/// <summary>
		/// Getter for Status.
		/// <returns>int</returns>
		/// </summary>
		public int? GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for Canonical.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCanonical()
		{
			return Canonical;
		}

		/// <summary>
		/// Setter for URI.
		/// <param name="value">String</param>
		/// <returns>URIInsertRequest</returns>
		/// </summary>
		public URIInsertRequest SetUri(String value)
		{
			Uri = value;
			return this;
		}

		/// <summary>
		/// Setter for Destination_Type.
		/// <param name="value">String</param>
		/// <returns>URIInsertRequest</returns>
		/// </summary>
		public URIInsertRequest SetDestinationType(String value)
		{
			DestinationType = value;
			return this;
		}

		/// <summary>
		/// Setter for Destination.
		/// <param name="value">String</param>
		/// <returns>URIInsertRequest</returns>
		/// </summary>
		public URIInsertRequest SetDestination(String value)
		{
			Destination = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>URIInsertRequest</returns>
		/// </summary>
		public URIInsertRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for Canonical.
		/// <param name="value">bool</param>
		/// <returns>URIInsertRequest</returns>
		/// </summary>
		public URIInsertRequest SetCanonical(bool? value)
		{
			Canonical = value;
			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			if (Uri != null && Uri.Length > 0)
			{
				writer.WriteString("URI", Uri);
			}

			if (DestinationType != null && DestinationType.Length > 0)
			{
				writer.WriteString("Destination_Type", DestinationType);
			}

			if (Destination != null && Destination.Length > 0)
			{
				writer.WriteString("Destination", Destination);
			}

			if (Status.HasValue)
			{
				writer.WriteNumber("Status", Status.Value);
			}

			if (Canonical.HasValue)
			{
				writer.WriteBoolean("Canonical", Canonical.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<URIInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>URIInsertResponse</returns>
		/// </summary>
		public new URIInsertResponse Send()
		{
			return Client.SendRequestAsync<URIInsertRequest, URIInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<URIInsertResponse></returns>
		/// </summary>
		public new async Task<URIInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<URIInsertRequest, URIInsertResponse>(this);
		}
	}
}
