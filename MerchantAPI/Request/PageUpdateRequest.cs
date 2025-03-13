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
	/// Handles API Request Page_Update.
	/// <see>https://docs.miva.com/json-api/functions/page_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageUpdateRequest : Request
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

		/// Request field Page_Name.
		[JsonPropertyName("Page_Name")]
		public String PageName { get; set; }

		/// Request field Page_Title.
		[JsonPropertyName("Page_Title")]
		public String PageTitle { get; set; }

		/// Request field Page_Secure.
		[JsonPropertyName("Page_Secure")]
		public bool? PageSecure { get; set; }

		/// Request field Page_Public.
		[JsonPropertyName("Page_Public")]
		public bool? PagePublic { get; set; }

		/// Request field Page_Cache.
		[JsonPropertyName("Page_Cache")]
		public String PageCache { get; set; }

		/// Request field Changeset_Notes.
		[JsonPropertyName("Changeset_Notes")]
		public String ChangesetNotes { get; set; }

		/// Request field Page_URI.
		[JsonPropertyName("Page_URI")]
		public String PageUri { get; set; }

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// Request field Branch_ID.
		[JsonPropertyName("Branch_ID")]
		public int? BranchId { get; set; }

		/// Request field Edit_Branch.
		[JsonPropertyName("Edit_Branch")]
		public String EditBranch { get; set; }

		/// Request field Branch_Name.
		[JsonPropertyName("Branch_Name")]
		public String BranchName { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="page">Page</param>
		/// </summary>
		public PageUpdateRequest(BaseClient client = null, Page page = null) :
			base(client)
		{
			Function = "Page_Update";
			CustomFieldValues = new CustomFieldValues();
			if (page != null) {
				if (page.Id > 0)
				{
					PageId = page.Id;
				}
				else if (page.Code.Length > 0)
				{
					EditPage = page.Code;
				}

				PageCode = page.Code;
				CustomFieldValues = page.CustomFieldValues;
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
		/// Getter for Page_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageName()
		{
			return PageName;
		}

		/// <summary>
		/// Getter for Page_Title.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageTitle()
		{
			return PageTitle;
		}

		/// <summary>
		/// Getter for Page_Secure.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetPageSecure()
		{
			return PageSecure;
		}

		/// <summary>
		/// Getter for Page_Public.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetPagePublic()
		{
			return PagePublic;
		}

		/// <summary>
		/// Getter for Page_Cache.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageCache()
		{
			return PageCache;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>Page.PageCacheType?</returns>
		/// </summary>
		public Page.PageCacheType? GetPageCacheConst()
		{
			return Page.PageCacheTypeFromString(PageCache);
		}

		/// <summary>
		/// Getter for Changeset_Notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetChangesetNotes()
		{
			return ChangesetNotes;
		}

		/// <summary>
		/// Getter for Page_URI.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageUri()
		{
			return PageUri;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Getter for Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBranchId()
		{
			return BranchId;
		}

		/// <summary>
		/// Getter for Edit_Branch.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditBranch()
		{
			return EditBranch;
		}

		/// <summary>
		/// Getter for Branch_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetBranchName()
		{
			return BranchName;
		}

		/// <summary>
		/// Setter for Page_ID.
		/// <param name="value">int</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageId(int? value)
		{
			PageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetEditPage(String value)
		{
			EditPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageCode(String value)
		{
			PageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Name.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageName(String value)
		{
			PageName = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Title.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageTitle(String value)
		{
			PageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Secure.
		/// <param name="value">bool</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageSecure(bool? value)
		{
			PageSecure = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Public.
		/// <param name="value">bool</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPagePublic(bool? value)
		{
			PagePublic = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Cache.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageCache(String value)
		{
			PageCache = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">Page.PageCacheType</param>
		/// <returns></returns>
		/// </summary>
		public PageUpdateRequest SetPageCache(Page.PageCacheType value)
		{
			PageCache = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Changeset_Notes.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetChangesetNotes(String value)
		{
			ChangesetNotes = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_URI.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetPageUri(String value)
		{
			PageUri = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_ID.
		/// <param name="value">int</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetBranchId(int? value)
		{
			BranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Branch.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetEditBranch(String value)
		{
			EditBranch = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_Name.
		/// <param name="value">String</param>
		/// <returns>PageUpdateRequest</returns>
		/// </summary>
		public PageUpdateRequest SetBranchName(String value)
		{
			BranchName = value;
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

			if (BranchId.HasValue)
			{
				writer.WriteNumber("Branch_ID", BranchId.Value);
			}
			else if (EditBranch != null && EditBranch.Length > 0)
			{
				writer.WriteString("Edit_Branch", EditBranch);
			}
			else if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}

			if (PageCode != null && PageCode.Length > 0)
			{
				writer.WriteString("Page_Code", PageCode);
			}

			writer.WriteString("Page_Name", PageName);

			if (PageTitle != null && PageTitle.Length > 0)
			{
				writer.WriteString("Page_Title", PageTitle);
			}

			if (PageSecure.HasValue)
			{
				writer.WriteBoolean("Page_Secure", PageSecure.Value);
			}

			if (PagePublic.HasValue)
			{
				writer.WriteBoolean("Page_Public", PagePublic.Value);
			}

			writer.WriteString("Page_Cache", PageCache);

			if (ChangesetNotes != null && ChangesetNotes.Length > 0)
			{
				writer.WriteString("Changeset_Notes", ChangesetNotes);
			}

			if (PageUri != null && PageUri.Length > 0)
			{
				writer.WriteString("Page_URI", PageUri);
			}

			if (CustomFieldValues != null)
			{
				writer.WritePropertyName("CustomField_Values");
				JsonSerializer.Serialize(writer, this.CustomFieldValues, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PageUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageUpdateResponse</returns>
		/// </summary>
		public new PageUpdateResponse Send()
		{
			return Client.SendRequestAsync<PageUpdateRequest, PageUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageUpdateResponse></returns>
		/// </summary>
		public new async Task<PageUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageUpdateRequest, PageUpdateResponse>(this);
		}
	}
}
