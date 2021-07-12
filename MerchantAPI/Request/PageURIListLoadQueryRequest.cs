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
	/// Handles API Request PageURIList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pageurilist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageURIListLoadQueryRequest : ListQueryRequest
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

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"canonical",
			"status",
			"uri"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"uri"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public PageURIListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "PageURIList_Load_Query";
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
		/// <returns>PageURIListLoadQueryRequest</returns>
		/// </summary>
		public PageURIListLoadQueryRequest SetPageId(int? value)
		{
			PageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageURIListLoadQueryRequest</returns>
		/// </summary>
		public PageURIListLoadQueryRequest SetEditPage(String value)
		{
			EditPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageURIListLoadQueryRequest</returns>
		/// </summary>
		public PageURIListLoadQueryRequest SetPageCode(String value)
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

			writer.WriteString("Page_Code", PageCode);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PageURIListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageURIListLoadQueryResponse</returns>
		/// </summary>
		public new PageURIListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<PageURIListLoadQueryRequest, PageURIListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageURIListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<PageURIListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageURIListLoadQueryRequest, PageURIListLoadQueryResponse>(this);
		}
	}
}
