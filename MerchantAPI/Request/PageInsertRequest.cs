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
	/// Handles API Request Page_Insert.
	/// <see>https://docs.miva.com/json-api/functions/page_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageInsertRequest : Request
	{
		/// Request field Page_Code.
		[JsonPropertyName("Page_Code")]
		public String PageCode { get; set; }

		/// Request field Page_Name.
		[JsonPropertyName("Page_Name")]
		public String PageName { get; set; }

		/// Request field Page_Title.
		[JsonPropertyName("Page_Title")]
		public String PageTitle { get; set; }

		/// Request field Page_Template.
		[JsonPropertyName("Page_Template")]
		public String PageTemplate { get; set; }

		/// Request field Page_Layout.
		[JsonPropertyName("Page_Layout")]
		public bool? PageLayout { get; set; }

		/// Request field Page_Secure.
		[JsonPropertyName("Page_Secure")]
		public bool? PageSecure { get; set; }

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

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public PageInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "Page_Insert";
			CustomFieldValues = new CustomFieldValues();
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
		/// Getter for Page_Template.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageTemplate()
		{
			return PageTemplate;
		}

		/// <summary>
		/// Getter for Page_Layout.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetPageLayout()
		{
			return PageLayout;
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
		/// Setter for Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageCode(String value)
		{
			PageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Name.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageName(String value)
		{
			PageName = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Title.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageTitle(String value)
		{
			PageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Template.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageTemplate(String value)
		{
			PageTemplate = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Layout.
		/// <param name="value">bool</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageLayout(bool? value)
		{
			PageLayout = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Secure.
		/// <param name="value">bool</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageSecure(bool? value)
		{
			PageSecure = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_Cache.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageCache(String value)
		{
			PageCache = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">Page.PageCacheType</param>
		/// <returns></returns>
		/// </summary>
		public PageInsertRequest SetPageCache(Page.PageCacheType value)
		{
			PageCache = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Changeset_Notes.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetChangesetNotes(String value)
		{
			ChangesetNotes = value;
			return this;
		}

		/// <summary>
		/// Setter for Page_URI.
		/// <param name="value">String</param>
		/// <returns>PageInsertRequest</returns>
		/// </summary>
		public PageInsertRequest SetPageUri(String value)
		{
			PageUri = value;
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

			writer.WriteString("Page_Code", PageCode);

			writer.WriteString("Page_Name", PageName);

			if (PageTitle != null && PageTitle.Length > 0)
			{
				writer.WriteString("Page_Title", PageTitle);
			}

			if (PageTemplate != null && PageTemplate.Length > 0)
			{
				writer.WriteString("Page_Template", PageTemplate);
			}

			if (PageLayout.HasValue)
			{
				writer.WriteBoolean("Page_Layout", PageLayout.Value);
			}

			if (PageSecure.HasValue)
			{
				writer.WriteBoolean("Page_Secure", PageSecure.Value);
			}

			if (PageCache != null && PageCache.Length > 0)
			{
				writer.WriteString("Page_Cache", PageCache);
			}

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
			return JsonSerializer.Deserialize<PageInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageInsertResponse</returns>
		/// </summary>
		public new PageInsertResponse Send()
		{
			return Client.SendRequestAsync<PageInsertRequest, PageInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageInsertResponse></returns>
		/// </summary>
		public new async Task<PageInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageInsertRequest, PageInsertResponse>(this);
		}
	}
}
