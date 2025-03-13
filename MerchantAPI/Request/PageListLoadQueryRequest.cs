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
	/// Handles API Request PageList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pagelist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PageListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Branch_ID.
		[JsonPropertyName("Branch_ID")]
		public int? BranchId { get; set; }

		/// Request field Branch_Name.
		[JsonPropertyName("Branch_Name")]
		public String BranchName { get; set; }

		/// Request field Edit_Branch.
		[JsonPropertyName("Edit_Branch")]
		public String EditBranch { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"code",
			"name",
			"secure",
			"title",
			"cache",
			"admin",
			"layout",
			"public",
			"fragment"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"code",
			"name",
			"secure",
			"title",
			"cache",
			"admin",
			"layout",
			"public",
			"fragment"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"notes",
			"source",
			"settings",
			"url",
			"uris"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public PageListLoadQueryRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "PageList_Load_Query";
			if (branch != null) {
				if (branch.Id > 0)
				{
					BranchId = branch.Id;
				}
				else if (branch.Name.Length > 0)
				{
					EditBranch = branch.Name;
				}
			}
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
		/// Getter for Branch_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetBranchName()
		{
			return BranchName;
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
		/// Setter for Branch_ID.
		/// <param name="value">int</param>
		/// <returns>PageListLoadQueryRequest</returns>
		/// </summary>
		public PageListLoadQueryRequest SetBranchId(int? value)
		{
			BranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_Name.
		/// <param name="value">String</param>
		/// <returns>PageListLoadQueryRequest</returns>
		/// </summary>
		public PageListLoadQueryRequest SetBranchName(String value)
		{
			BranchName = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Branch.
		/// <param name="value">String</param>
		/// <returns>PageListLoadQueryRequest</returns>
		/// </summary>
		public PageListLoadQueryRequest SetEditBranch(String value)
		{
			EditBranch = value;
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

			if (BranchId.HasValue)
			{
				writer.WriteNumber("Branch_ID", BranchId.Value);
			}
			else if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}
			else if (EditBranch != null && EditBranch.Length > 0)
			{
				writer.WriteString("Edit_Branch", EditBranch);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PageListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PageListLoadQueryResponse</returns>
		/// </summary>
		public new PageListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<PageListLoadQueryRequest, PageListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PageListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<PageListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PageListLoadQueryRequest, PageListLoadQueryResponse>(this);
		}
	}
}
