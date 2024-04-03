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
	/// Handles API Request Page_Copy_Branch.
	/// <see>https://docs.miva.com/json-api/functions/page_copy_branch</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageCopyBranchRequest : Request
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

		/// Request field Dest_Branch_ID.
		[JsonPropertyName("Dest_Branch_ID")]
		public int? DestinationBranchId { get; set; }

		/// Request field Dest_Edit_Branch.
		[JsonPropertyName("Dest_Edit_Branch")]
		public String DestinationEditBranch { get; set; }

		/// Request field Dest_Branch_Name.
		[JsonPropertyName("Dest_Branch_Name")]
		public String DestinationBranchName { get; set; }

		/// Request field CopyPageRules_ID.
		[JsonPropertyName("CopyPageRules_ID")]
		public int? CopyPageRulesId { get; set; }

		/// Request field CopyPageRules_Name.
		[JsonPropertyName("CopyPageRules_Name")]
		public String CopyPageRulesName { get; set; }

		/// Request field Changeset_Notes.
		[JsonPropertyName("Changeset_Notes")]
		public String ChangesetNotes { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="page">Page</param>
		/// </summary>
		public PageCopyBranchRequest(BaseClient client = null, Page page = null) :
			base(client)
		{
			Function = "Page_Copy_Branch";
			if (page != null) {
				if (page.Id > 0)
				{
					SourcePageId = page.Id;
				}
				else if (page.Code.Length > 0)
				{
					SourceEditPage = page.Code;
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
		/// Getter for Dest_Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetDestinationBranchId()
		{
			return DestinationBranchId;
		}

		/// <summary>
		/// Getter for Dest_Edit_Branch.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationEditBranch()
		{
			return DestinationEditBranch;
		}

		/// <summary>
		/// Getter for Dest_Branch_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationBranchName()
		{
			return DestinationBranchName;
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
		/// Getter for Changeset_Notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetChangesetNotes()
		{
			return ChangesetNotes;
		}

		/// <summary>
		/// Setter for Source_Page_ID.
		/// <param name="value">int</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetSourcePageId(int? value)
		{
			SourcePageId = value;
			return this;
		}

		/// <summary>
		/// Setter for Source_Edit_Page.
		/// <param name="value">String</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetSourceEditPage(String value)
		{
			SourceEditPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Source_Page_Code.
		/// <param name="value">String</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetSourcePageCode(String value)
		{
			SourcePageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Branch_ID.
		/// <param name="value">int</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetDestinationBranchId(int? value)
		{
			DestinationBranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Edit_Branch.
		/// <param name="value">String</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetDestinationEditBranch(String value)
		{
			DestinationEditBranch = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Branch_Name.
		/// <param name="value">String</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetDestinationBranchName(String value)
		{
			DestinationBranchName = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_ID.
		/// <param name="value">int</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetCopyPageRulesId(int? value)
		{
			CopyPageRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_Name.
		/// <param name="value">String</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetCopyPageRulesName(String value)
		{
			CopyPageRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Changeset_Notes.
		/// <param name="value">String</param>
		/// <returns>PageCopyBranchRequest</returns>
		/// </summary>
		public PageCopyBranchRequest SetChangesetNotes(String value)
		{
			ChangesetNotes = value;
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

			if (DestinationBranchId.HasValue)
			{
				writer.WriteNumber("Dest_Branch_ID", DestinationBranchId.Value);
			}
			else if (DestinationEditBranch != null && DestinationEditBranch.Length > 0)
			{
				writer.WriteString("Dest_Edit_Branch", DestinationEditBranch);
			}
			else if (DestinationBranchName != null && DestinationBranchName.Length > 0)
			{
				writer.WriteString("Dest_Branch_Name", DestinationBranchName);
			}

			if (CopyPageRulesId.HasValue)
			{
				writer.WriteNumber("CopyPageRules_ID", CopyPageRulesId.Value);
			}
			else if (CopyPageRulesName != null && CopyPageRulesName.Length > 0)
			{
				writer.WriteString("CopyPageRules_Name", CopyPageRulesName);
			}

			if (ChangesetNotes != null && ChangesetNotes.Length > 0)
			{
				writer.WriteString("Changeset_Notes", ChangesetNotes);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PageCopyBranchResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageCopyBranchResponse</returns>
		/// </summary>
		public new PageCopyBranchResponse Send()
		{
			return Client.SendRequestAsync<PageCopyBranchRequest, PageCopyBranchResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageCopyBranchResponse></returns>
		/// </summary>
		public new async Task<PageCopyBranchResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageCopyBranchRequest, PageCopyBranchResponse>(this);
		}
	}
}
