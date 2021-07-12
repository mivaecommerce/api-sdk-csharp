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
	/// Handles API Request FeedURI_Insert.
	/// <see>https://docs.miva.com/json-api/functions/feeduri_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class FeedURIInsertRequest : Request
	{
		/// Request field Feed_ID.
		[JsonPropertyName("Feed_ID")]
		public int? FeedId { get; set; }

		/// Request field Feed_Code.
		[JsonPropertyName("Feed_Code")]
		public String FeedCode { get; set; }

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
		/// </summary>
		public FeedURIInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "FeedURI_Insert";
		}

		/// <summary>
		/// Getter for Feed_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetFeedId()
		{
			return FeedId;
		}

		/// <summary>
		/// Getter for Feed_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetFeedCode()
		{
			return FeedCode;
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
		/// Setter for Feed_ID.
		/// <param name="value">int</param>
		/// <returns>FeedURIInsertRequest</returns>
		/// </summary>
		public FeedURIInsertRequest SetFeedId(int? value)
		{
			FeedId = value;
			return this;
		}

		/// <summary>
		/// Setter for Feed_Code.
		/// <param name="value">String</param>
		/// <returns>FeedURIInsertRequest</returns>
		/// </summary>
		public FeedURIInsertRequest SetFeedCode(String value)
		{
			FeedCode = value;
			return this;
		}

		/// <summary>
		/// Setter for URI.
		/// <param name="value">String</param>
		/// <returns>FeedURIInsertRequest</returns>
		/// </summary>
		public FeedURIInsertRequest SetUri(String value)
		{
			Uri = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>FeedURIInsertRequest</returns>
		/// </summary>
		public FeedURIInsertRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for Canonical.
		/// <param name="value">bool</param>
		/// <returns>FeedURIInsertRequest</returns>
		/// </summary>
		public FeedURIInsertRequest SetCanonical(bool? value)
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

			if (FeedId.HasValue)
			{
				writer.WriteNumber("Feed_ID", FeedId.Value);
			}
			else if (FeedCode != null && FeedCode.Length > 0)
			{
				writer.WriteString("Feed_Code", FeedCode);
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
			return JsonSerializer.Deserialize<FeedURIInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>FeedURIInsertResponse</returns>
		/// </summary>
		public new FeedURIInsertResponse Send()
		{
			return Client.SendRequestAsync<FeedURIInsertRequest, FeedURIInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<FeedURIInsertResponse></returns>
		/// </summary>
		public new async Task<FeedURIInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<FeedURIInsertRequest, FeedURIInsertResponse>(this);
		}
	}
}
