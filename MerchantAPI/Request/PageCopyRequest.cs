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
	/// Handles API Request Page_Copy.
	/// <see>https://docs.miva.com/json-api/functions/page_copy</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageCopyRequest : Request
	{
		/// Request field Source_Page_ID.
		[JsonPropertyName("Source_Page_ID")]
		public int? SourcePageId { get; set; }

		/// Request field Source_Edit_Page.
		[JsonPropertyName("Source_Edit_Page")]
		public String SourceEditPage { get; set; }

		/// Request field Source_Page_Code.
		[JsonPropertyName("Source_Page_Code")]
		public String SourcePageCode { get; set; }

		/// Request field CopyPageRules_ID.
		[JsonPropertyName("CopyPageRules_ID")]
		public int? CopyPageRulesId { get; set; }

		/// Request field CopyPageRules_Name.
		[JsonPropertyName("CopyPageRules_Name")]
		public String CopyPageRulesName { get; set; }

		/// Request field Dest_Page_ID.
		[JsonPropertyName("Dest_Page_ID")]
		public int? DestinationPageId { get; set; }

		/// Request field Dest_Edit_Page.
		[JsonPropertyName("Dest_Edit_Page")]
		public String DestinationEditPage { get; set; }

		/// Request field Dest_Page_Code.
		[JsonPropertyName("Dest_Page_Code")]
		public String DestinationPageCode { get; set; }

		/// Request field Dest_Page_Create.
		[JsonPropertyName("Dest_Page_Create")]
		public bool? DestinationPageCreate { get; set; }

		/// Request field Changeset_Notes.
		[JsonPropertyName("Changeset_Notes")]
		public String ChangesetNotes { get; set; }

		/// Request field Dest_Page_Name.
		[JsonPropertyName("Dest_Page_Name")]
		public String DestinationPageName { get; set; }

		/// Request field Dest_Page_Layout.
		[JsonPropertyName("Dest_Page_Layout")]
		public bool? DestinationPageLayout { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="page">Page</param>
		/// </summary>
		public PageCopyRequest(BaseClient client = null, Page page = null) :
			base(client)
		{
			Function = "Page_Copy";
			if (page != null) {
				if (page.Id > 0)
				{
					SourcePageId = page.Id;
				}
				else if (page.Code.Length > 0)
				{
					SourceEditPage = page.Code;
				}
				else if (page.Code.Length > 0)
				{
					SourcePageCode = page.Code;
				}
			}
		}

		/// <summary>
		/// Getter for Source_Page_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetSourcePageId()
		{
			return SourcePageId;
		}

		/// <summary>
		/// Getter for Source_Edit_Page.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceEditPage()
		{
			return SourceEditPage;
		}

		/// <summary>
		/// Getter for Source_Page_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourcePageCode()
		{
			return SourcePageCode;
		}

		/// <summary>
		/// Getter for CopyPageRules_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCopyPageRulesId()
		{
			return CopyPageRulesId;
		}

		/// <summary>
		/// Getter for CopyPageRules_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCopyPageRulesName()
		{
			return CopyPageRulesName;
		}

		/// <summary>
		/// Getter for Dest_Page_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetDestinationPageId()
		{
			return DestinationPageId;
		}

		/// <summary>
		/// Getter for Dest_Edit_Page.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationEditPage()
		{
			return DestinationEditPage;
		}

		/// <summary>
		/// Getter for Dest_Page_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationPageCode()
		{
			return DestinationPageCode;
		}

		/// <summary>
		/// Getter for Dest_Page_Create.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDestinationPageCreate()
		{
			return DestinationPageCreate;
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
		/// Getter for Dest_Page_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationPageName()
		{
			return DestinationPageName;
		}

		/// <summary>
		/// Getter for Dest_Page_Layout.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDestinationPageLayout()
		{
			return DestinationPageLayout;
		}

		/// <summary>
		/// Setter for Source_Page_ID.
		/// <param name="value">int</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetSourcePageId(int? value)
		{
			SourcePageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Source_Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetSourceEditPage(String value)
		{
			SourceEditPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Source_Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetSourcePageCode(String value)
		{
			SourcePageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_ID.
		/// <param name="value">int</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetCopyPageRulesId(int? value)
		{
			CopyPageRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_Name.
		/// <param name="value">String</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetCopyPageRulesName(String value)
		{
			CopyPageRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Page_ID.
		/// <param name="value">int</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetDestinationPageId(int? value)
		{
			DestinationPageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetDestinationEditPage(String value)
		{
			DestinationEditPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetDestinationPageCode(String value)
		{
			DestinationPageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Page_Create.
		/// <param name="value">bool</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetDestinationPageCreate(bool? value)
		{
			DestinationPageCreate = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Page_Name.
		/// <param name="value">String</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetDestinationPageName(String value)
		{
			DestinationPageName = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Page_Layout.
		/// <param name="value">bool</param>
		/// <returns>PageCopyRequest</returns>
		/// </summary>
		public PageCopyRequest SetDestinationPageLayout(bool? value)
		{
			DestinationPageLayout = value;
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

			if (SourcePageId.HasValue)
			{
				writer.WriteNumber("Source_Page_ID", SourcePageId.Value);
			}
			else if (SourceEditPage != null && SourceEditPage.Length > 0)
			{
				writer.WriteString("Source_Edit_Page", SourceEditPage);
			}
			else if (SourcePageCode != null && SourcePageCode.Length > 0)
			{
				writer.WriteString("Source_Page_Code", SourcePageCode);
			}

			if (DestinationPageId.HasValue)
			{
				writer.WriteNumber("Dest_Page_ID", DestinationPageId.Value);
			}
			else if (DestinationEditPage != null && DestinationEditPage.Length > 0)
			{
				writer.WriteString("Dest_Edit_Page", DestinationEditPage);
			}

			if (CopyPageRulesId.HasValue)
			{
				writer.WriteNumber("CopyPageRules_ID", CopyPageRulesId.Value);
			}
			else if (CopyPageRulesName != null && CopyPageRulesName.Length > 0)
			{
				writer.WriteString("CopyPageRules_Name", CopyPageRulesName);
			}

			writer.WriteString("Dest_Page_Code", DestinationPageCode);

			if (DestinationPageCreate.HasValue)
			{
				writer.WriteBoolean("Dest_Page_Create", DestinationPageCreate.Value);
			}

			if (ChangesetNotes != null && ChangesetNotes.Length > 0)
			{
				writer.WriteString("Changeset_Notes", ChangesetNotes);
			}

			writer.WriteString("Dest_Page_Name", DestinationPageName);

			if (DestinationPageLayout.HasValue)
			{
				writer.WriteBoolean("Dest_Page_Layout", DestinationPageLayout.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PageCopyResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageCopyResponse</returns>
		/// </summary>
		public new PageCopyResponse Send()
		{
			return Client.SendRequestAsync<PageCopyRequest, PageCopyResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageCopyResponse></returns>
		/// </summary>
		public new async Task<PageCopyResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageCopyRequest, PageCopyResponse>(this);
		}
	}
}
