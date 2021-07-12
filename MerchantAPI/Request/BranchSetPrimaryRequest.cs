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
	/// Handles API Request Branch_SetPrimary.
	/// <see>https://docs.miva.com/json-api/functions/branch_setprimary</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BranchSetPrimaryRequest : Request
	{
		/// Request field Branch_ID.
		[JsonPropertyName("Branch_ID")]
		public int BranchId { get; set; }

		/// Request field Edit_Branch.
		[JsonPropertyName("Edit_Branch")]
		public String EditBranch { get; set; }

		/// Request field Branch_Name.
		[JsonPropertyName("Branch_Name")]
		public String BranchName { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public BranchSetPrimaryRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "Branch_SetPrimary";
			if (branch != null) {
				if (branch.Id > 0)
				{
					BranchId = branch.Id;
				}
				else if (branch.Name.Length > 0)
				{
					EditBranch = branch.Name;
				}
				else if (branch.Name.Length > 0)
				{
					BranchName = branch.Name;
				}
			}
		}

		/// <summary>
		/// Getter for Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetBranchId()
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
		/// Setter for Branch_ID.
		/// <param name="value">int</param>
		/// <returns>BranchSetPrimaryRequest</returns>
		/// </summary>
		public BranchSetPrimaryRequest SetBranchId(int value)
		{
			BranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Branch.
		/// <param name="value">String</param>
		/// <returns>BranchSetPrimaryRequest</returns>
		/// </summary>
		public BranchSetPrimaryRequest SetEditBranch(String value)
		{
			EditBranch = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_Name.
		/// <param name="value">String</param>
		/// <returns>BranchSetPrimaryRequest</returns>
		/// </summary>
		public BranchSetPrimaryRequest SetBranchName(String value)
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

			if (BranchId > 0)
			{
				writer.WriteNumber("Branch_ID", BranchId);
			}
			else if (EditBranch != null && EditBranch.Length > 0)
			{
				writer.WriteString("Edit_Branch", EditBranch);
			}
			else if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BranchSetPrimaryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BranchSetPrimaryResponse</returns>
		/// </summary>
		public new BranchSetPrimaryResponse Send()
		{
			return Client.SendRequestAsync<BranchSetPrimaryRequest, BranchSetPrimaryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BranchSetPrimaryResponse></returns>
		/// </summary>
		public new async Task<BranchSetPrimaryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BranchSetPrimaryRequest, BranchSetPrimaryResponse>(this);
		}
	}
}
