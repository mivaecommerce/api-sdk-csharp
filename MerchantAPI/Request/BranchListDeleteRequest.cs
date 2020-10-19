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
	/// Handles API Request BranchList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/branchlist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BranchListDeleteRequest : Request
	{
		/// Request field Branch_IDs.
		public List<int> BranchIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public BranchListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "BranchList_Delete";
		}

		/// <summary>
		/// Add Branch_IDs.
		///	- branchId: Int
		/// - Returns: Self
		/// </summary>
		public BranchListDeleteRequest AddBranchId(int branchId)
		{
			BranchIds.Add(branchId);
			return this;
		}

		/// <summary>
		/// Add Branch model.
		/// <param name="branch">Branch></param>
		/// <returns>BranchListDeleteRequest</returns>
		/// </summary>
		public BranchListDeleteRequest AddBranch(Branch branch)
		{
			if (branch.Id > 0)
			{
				BranchIds.Add(branch.Id);
			}

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

			writer.WritePropertyName("Branch_IDs");
			JsonSerializer.Serialize(writer, this.BranchIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BranchListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BranchListDeleteResponse</returns>
		/// </summary>
		public new BranchListDeleteResponse Send()
		{
			return Client.SendRequestAsync<BranchListDeleteRequest, BranchListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BranchListDeleteResponse></returns>
		/// </summary>
		public new async Task<BranchListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BranchListDeleteRequest, BranchListDeleteResponse>(this);
		}
	}
}
