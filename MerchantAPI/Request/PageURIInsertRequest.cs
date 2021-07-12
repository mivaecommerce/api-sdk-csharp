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
	/// Handles API Request PageURI_Insert.
	/// <see>https://docs.miva.com/json-api/functions/pageuri_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageURIInsertRequest : Request
	{
		/// Request field URI.
		[JsonPropertyName("URI")]
		public String Uri { get; set; }

		/// Request field Status.
		[JsonPropertyName("Status")]
		public int? Status { get; set; }

		/// Request field Canonical.
		[JsonPropertyName("Canonical")]
		public bool? Canonical { get; set; }

		/// Request field Page_ID.
		[JsonPropertyName("Page_ID")]
		public int? PageId { get; set; }

		/// Request field Page_Code.
		[JsonPropertyName("Page_Code")]
		public String PageCode { get; set; }

		/// Request field Edit_Page.
		[JsonPropertyName("Edit_Page")]
		public String EditPage { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="page">Page</param>
		/// </summary>
		public PageURIInsertRequest(BaseClient client = null, Page page = null) :
			base(client)
		{
			Function = "PageURI_Insert";
			if (page != null) {
				if (page.Id > 0)
				{
					PageId = page.Id;
				}
				else if (page.Code.Length > 0)
				{
					PageCode = page.Code;
				}
			}
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
		/// Getter for Page_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPageId()
		{
			return PageId;
		}

		/// <summary>
		/// Getter for Page_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageCode()
		{
			return PageCode;
		}

		/// <summary>
		/// Getter for Edit_Page.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditPage()
		{
			return EditPage;
		}

		/// <summary>
		/// Setter for URI.
		/// <param name="value">String</param>
		/// <returns>PageURIInsertRequest</returns>
		/// </summary>
		public PageURIInsertRequest SetUri(String value)
		{
			Uri = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>PageURIInsertRequest</returns>
		/// </summary>
		public PageURIInsertRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Setter for Canonical.
		/// <param name="value">bool</param>
		/// <returns>PageURIInsertRequest</returns>
		/// </summary>
		public PageURIInsertRequest SetCanonical(bool? value)
		{
			Canonical = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_ID.
		/// <param name="value">int</param>
		/// <returns>PageURIInsertRequest</returns>
		/// </summary>
		public PageURIInsertRequest SetPageId(int? value)
		{
			PageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageURIInsertRequest</returns>
		/// </summary>
		public PageURIInsertRequest SetPageCode(String value)
		{
			PageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageURIInsertRequest</returns>
		/// </summary>
		public PageURIInsertRequest SetEditPage(String value)
		{
			EditPage = value;
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

			if (PageId.HasValue)
			{
				writer.WriteNumber("Page_ID", PageId.Value);
			}
			else if (PageCode != null && PageCode.Length > 0)
			{
				writer.WriteString("Page_Code", PageCode);
			}
			else if (EditPage != null && EditPage.Length > 0)
			{
				writer.WriteString("Edit_Page", EditPage);
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
			return JsonSerializer.Deserialize<PageURIInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageURIInsertResponse</returns>
		/// </summary>
		public new PageURIInsertResponse Send()
		{
			return Client.SendRequestAsync<PageURIInsertRequest, PageURIInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageURIInsertResponse></returns>
		/// </summary>
		public new async Task<PageURIInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageURIInsertRequest, PageURIInsertResponse>(this);
		}
	}
}
