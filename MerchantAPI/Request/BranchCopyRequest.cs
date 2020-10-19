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
	/// Handles API Request Branch_Copy.
	/// <see>https://docs.miva.com/json-api/functions/branch_copy</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BranchCopyRequest : Request
	{
		/// Request field Source_Branch_ID.
		[JsonPropertyName("Source_Branch_ID")]
		public int? SourceBranchId { get; set; }

		/// Request field Destination_Branch_ID.
		[JsonPropertyName("Destination_Branch_ID")]
		public int? DestinationBranchId { get; set; }

		/// Request field Notes.
		[JsonPropertyName("Notes")]
		public String Notes { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public BranchCopyRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "Branch_Copy";
			if (branch != null) {
				if (branch.Id > 0)
				{
					SourceBranchId = branch.Id;
				}
			}
		}

		/// <summary>
		/// Getter for Source_Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetSourceBranchId()
		{
			return SourceBranchId;
		}

		/// <summary>
		/// Getter for Destination_Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetDestinationBranchId()
		{
			return DestinationBranchId;
		}

		/// <summary>
		/// Getter for Notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetNotes()
		{
			return Notes;
		}

		/// <summary>
		/// Setter for Source_Branch_ID.
		/// <param name="value">int</param>
		/// <returns>BranchCopyRequest</returns>
		/// </summary>
		public BranchCopyRequest SetSourceBranchId(int? value)
		{
			SourceBranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Destination_Branch_ID.
		/// <param name="value">int</param>
		/// <returns>BranchCopyRequest</returns>
		/// </summary>
		public BranchCopyRequest SetDestinationBranchId(int? value)
		{
			DestinationBranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Notes.
		/// <param name="value">String</param>
		/// <returns>BranchCopyRequest</returns>
		/// </summary>
		public BranchCopyRequest SetNotes(String value)
		{
			Notes = value;
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

			if (SourceBranchId.HasValue)
			{
				writer.WriteNumber("Source_Branch_ID", SourceBranchId.Value);
			}

			if (DestinationBranchId.HasValue)
			{
				writer.WriteNumber("Destination_Branch_ID", DestinationBranchId.Value);
			}

			if (Notes != null && Notes.Length > 0)
			{
				writer.WriteString("Notes", Notes);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BranchCopyResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BranchCopyResponse</returns>
		/// </summary>
		public new BranchCopyResponse Send()
		{
			return Client.SendRequestAsync<BranchCopyRequest, BranchCopyResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BranchCopyResponse></returns>
		/// </summary>
		public new async Task<BranchCopyResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BranchCopyRequest, BranchCopyResponse>(this);
		}
	}
}
