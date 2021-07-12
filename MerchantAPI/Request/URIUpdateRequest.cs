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
	/// Handles API Request URI_Update.
	/// <see>https://docs.miva.com/json-api/functions/uri_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class URIUpdateRequest : Request
	{
		/// Request field URI_ID.
		[JsonPropertyName("URI_ID")]
		public int? UriId { get; set; }

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
		/// <param name="uri">Uri</param>
		/// </summary>
		public URIUpdateRequest(BaseClient client = null, Uri uri = null) :
			base(client)
		{
			Function = "URI_Update";
			Scope = RequestScope.DomainOptionalStore;
			if (uri != null) {
				if (uri.Id > 0)
				{
					UriId = uri.Id;
				}
			}
		}

		/// <summary>
		/// Getter for URI_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetUriId()
		{
			return UriId;
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
		/// Setter for URI_ID.
		/// <param name="value">int</param>
		/// <returns>URIUpdateRequest</returns>
		/// </summary>
		public URIUpdateRequest SetUriId(int? value)
		{
			UriId = value;
			return this;
		}

		/// <summary>
		/// Setter for URI.
		/// <param name="value">String</param>
		/// <returns>URIUpdateRequest</returns>
		/// </summary>
		public URIUpdateRequest SetUri(String value)
		{
			Uri = value;
			return this;
		}

		/// <summary>
		/// Setter for Destination_Type.
		/// <param name="value">String</param>
		/// <returns>URIUpdateRequest</returns>
		/// </summary>
		public URIUpdateRequest SetDestinationType(String value)
		{
			DestinationType = value;
			return this;
		}

		/// <summary>
		/// Setter for Destination.
		/// <param name="value">String</param>
		/// <returns>URIUpdateRequest</returns>
		/// </summary>
		public URIUpdateRequest SetDestination(String value)
		{
			Destination = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>URIUpdateRequest</returns>
		/// </summary>
		public URIUpdateRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for Canonical.
		/// <param name="value">bool</param>
		/// <returns>URIUpdateRequest</returns>
		/// </summary>
		public URIUpdateRequest SetCanonical(bool? value)
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

			if (UriId.HasValue)
			{
				writer.WriteNumber("URI_ID", UriId.Value);
			}

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
			return JsonSerializer.Deserialize<URIUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>URIUpdateResponse</returns>
		/// </summary>
		public new URIUpdateResponse Send()
		{
			return Client.SendRequestAsync<URIUpdateRequest, URIUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<URIUpdateResponse></returns>
		/// </summary>
		public new async Task<URIUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<URIUpdateRequest, URIUpdateResponse>(this);
		}
	}
}
