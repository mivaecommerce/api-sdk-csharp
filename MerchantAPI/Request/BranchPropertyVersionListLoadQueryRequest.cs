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
	/// Handles API Request BranchPropertyVersionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/branchpropertyversionlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BranchPropertyVersionListLoadQueryRequest : ListQueryRequest
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

		/// Request field Changeset_ID.
		[JsonPropertyName("Changeset_ID")]
		public int? ChangesetId { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"prop_id",
			"type",
			"code",
			"product_id",
			"cat_id",
			"sync",
			"templ_id",
			"version_id",
			"version_user_id",
			"version_user_name",
			"source_user_id",
			"source_user_name"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"prop_id",
			"type",
			"code",
			"product_id",
			"cat_id",
			"sync",
			"templ_id",
			"version_id",
			"version_user_id",
			"version_user_name",
			"source_user_id",
			"source_user_name"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"settings",
			"product",
			"category",
			"source",
			"source_notes",
			"image"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public BranchPropertyVersionListLoadQueryRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "BranchPropertyVersionList_Load_Query";
			if (branch != null) {
				if (branch.Id > 0)
				{
					BranchId = branch.Id;
				}

				BranchName = branch.Name;
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
		/// Getter for Changeset_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetChangesetId()
		{
			return ChangesetId;
		}

		/// <summary>
		/// Setter for Branch_ID.
		/// <param name="value">int</param>
		/// <returns>BranchPropertyVersionListLoadQueryRequest</returns>
		/// </summary>
		public BranchPropertyVersionListLoadQueryRequest SetBranchId(int? value)
		{
			BranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_Name.
		/// <param name="value">String</param>
		/// <returns>BranchPropertyVersionListLoadQueryRequest</returns>
		/// </summary>
		public BranchPropertyVersionListLoadQueryRequest SetBranchName(String value)
		{
			BranchName = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Branch.
		/// <param name="value">String</param>
		/// <returns>BranchPropertyVersionListLoadQueryRequest</returns>
		/// </summary>
		public BranchPropertyVersionListLoadQueryRequest SetEditBranch(String value)
		{
			EditBranch = value;
			return this;
		}

		/// <summary>
		/// Setter for Changeset_ID.
		/// <param name="value">int</param>
		/// <returns>BranchPropertyVersionListLoadQueryRequest</returns>
		/// </summary>
		public BranchPropertyVersionListLoadQueryRequest SetChangesetId(int? value)
		{
			ChangesetId = value;
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

			if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}

			if (ChangesetId.HasValue)
			{
				writer.WriteNumber("Changeset_ID", ChangesetId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BranchPropertyVersionListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BranchPropertyVersionListLoadQueryResponse</returns>
		/// </summary>
		public new BranchPropertyVersionListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<BranchPropertyVersionListLoadQueryRequest, BranchPropertyVersionListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BranchPropertyVersionListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<BranchPropertyVersionListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BranchPropertyVersionListLoadQueryRequest, BranchPropertyVersionListLoadQueryResponse>(this);
		}
	}
}
