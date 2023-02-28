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
	/// Handles API Request Page_Delete.
	/// <see>https://docs.miva.com/json-api/functions/page_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageDeleteRequest : Request
	{
		/// Request field Page_ID.
		[JsonPropertyName("Page_ID")]
		public int? PageId { get; set; }

		/// Request field Edit_Page.
		[JsonPropertyName("Edit_Page")]
		public String EditPage { get; set; }

		/// Request field Page_Code.
		[JsonPropertyName("Page_Code")]
		public String PageCode { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="page">Page</param>
		/// </summary>
		public PageDeleteRequest(BaseClient client = null, Page page = null) :
			base(client)
		{
			Function = "Page_Delete";
			if (page != null) {
				if (page.Id > 0)
				{
					PageId = page.Id;
				}
				else if (page.Code.Length > 0)
				{
					EditPage = page.Code;
				}
				else if (page.Code.Length > 0)
				{
					PageCode = page.Code;
				}
			}
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
		/// Getter for Edit_Page.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditPage()
		{
			return EditPage;
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
		/// Setter for Page_ID.
		/// <param name="value">int</param>
		/// <returns>PageDeleteRequest</returns>
		/// </summary>
		public PageDeleteRequest SetPageId(int? value)
		{
			PageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageDeleteRequest</returns>
		/// </summary>
		public PageDeleteRequest SetEditPage(String value)
		{
			EditPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageDeleteRequest</returns>
		/// </summary>
		public PageDeleteRequest SetPageCode(String value)
		{
			PageCode = value;
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
			else if (EditPage != null && EditPage.Length > 0)
			{
				writer.WriteString("Edit_Page", EditPage);
			}
			else if (PageCode != null && PageCode.Length > 0)
			{
				writer.WriteString("Page_Code", PageCode);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PageDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageDeleteResponse</returns>
		/// </summary>
		public new PageDeleteResponse Send()
		{
			return Client.SendRequestAsync<PageDeleteRequest, PageDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageDeleteResponse></returns>
		/// </summary>
		public new async Task<PageDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageDeleteRequest, PageDeleteResponse>(this);
		}
	}
}
