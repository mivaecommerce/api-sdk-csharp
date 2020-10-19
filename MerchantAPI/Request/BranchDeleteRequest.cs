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
	/// Handles API Request Branch_Delete.
	/// <see>https://docs.miva.com/json-api/functions/branch_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BranchDeleteRequest : Request
	{
		/// Request field Branch_ID.
		[JsonPropertyName("Branch_ID")]
		public int? BranchId { get; set; }

		/// Request field Branch_Name.
		[JsonPropertyName("Branch_Name")]
		public String BranchName { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public BranchDeleteRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "Branch_Delete";
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
		/// Setter for Branch_ID.
		/// <param name="value">int</param>
		/// <returns>BranchDeleteRequest</returns>
		/// </summary>
		public BranchDeleteRequest SetBranchId(int? value)
		{
			BranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_Name.
		/// <param name="value">String</param>
		/// <returns>BranchDeleteRequest</returns>
		/// </summary>
		public BranchDeleteRequest SetBranchName(String value)
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

			if (BranchId.HasValue)
			{
				writer.WriteNumber("Branch_ID", BranchId.Value);
			}
			else if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}

			if (BranchName != null && BranchName.Length > 0)
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
			return JsonSerializer.Deserialize<BranchDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BranchDeleteResponse</returns>
		/// </summary>
		public new BranchDeleteResponse Send()
		{
			return Client.SendRequestAsync<BranchDeleteRequest, BranchDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BranchDeleteResponse></returns>
		/// </summary>
		public new async Task<BranchDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BranchDeleteRequest, BranchDeleteResponse>(this);
		}
	}
}
