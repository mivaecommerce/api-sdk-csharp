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
	/// Handles API Request ProductURI_Update.
	/// <see>https://docs.miva.com/json-api/functions/producturi_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductURIUpdateRequest : Request
	{
		/// Request field URI_ID.
		[JsonPropertyName("URI_ID")]
		public int? UriId { get; set; }

		/// Request field URI.
		[JsonPropertyName("URI")]
		public String Uri { get; set; }

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
		public ProductURIUpdateRequest(BaseClient client = null, Uri uri = null) :
			base(client)
		{
			Function = "ProductURI_Update";
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
		/// <returns>ProductURIUpdateRequest</returns>
		/// </summary>
		public ProductURIUpdateRequest SetUriId(int? value)
		{
			UriId = value;
			return this;
		}

		/// <summary>
		/// Setter for URI.
		/// <param name="value">String</param>
		/// <returns>ProductURIUpdateRequest</returns>
		/// </summary>
		public ProductURIUpdateRequest SetUri(String value)
		{
			Uri = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>ProductURIUpdateRequest</returns>
		/// </summary>
		public ProductURIUpdateRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for Canonical.
		/// <param name="value">bool</param>
		/// <returns>ProductURIUpdateRequest</returns>
		/// </summary>
		public ProductURIUpdateRequest SetCanonical(bool? value)
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
			return JsonSerializer.Deserialize<ProductURIUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductURIUpdateResponse</returns>
		/// </summary>
		public new ProductURIUpdateResponse Send()
		{
			return Client.SendRequestAsync<ProductURIUpdateRequest, ProductURIUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductURIUpdateResponse></returns>
		/// </summary>
		public new async Task<ProductURIUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductURIUpdateRequest, ProductURIUpdateResponse>(this);
		}
	}
}
