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
	/// Handles API Request Branch_Create.
	/// <see>https://docs.miva.com/json-api/functions/branch_create</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BranchCreateRequest : Request
	{
		/// Request field Parent_Branch_ID.
		[JsonPropertyName("Parent_Branch_ID")]
		public int? ParentBranchId { get; set; }

		/// Request field Name.
		[JsonPropertyName("Name")]
		public String Name { get; set; }

		/// Request field Color.
		[JsonPropertyName("Color")]
		public String Color { get; set; }

		/// Request field Changeset_ID.
		[JsonPropertyName("Changeset_ID")]
		public int? ChangesetId { get; set; }

		/// Request field Tags.
		[JsonPropertyName("Tags")]
		public String Tags { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public BranchCreateRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "Branch_Create";
			if (branch != null) {
				if (branch.Id > 0)
				{
					ParentBranchId = branch.Id;
				}
			}
		}

		/// <summary>
		/// Getter for Parent_Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetParentBranchId()
		{
			return ParentBranchId;
		}

		/// <summary>
		/// Getter for Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for Color.
		/// <returns>String</returns>
		/// </summary>
		public String GetColor()
		{
			return Color;
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
		/// Getter for Tags.
		/// <returns>String</returns>
		/// </summary>
		public String GetTags()
		{
			return Tags;
		}

		/// <summary>
		/// Setter for Parent_Branch_ID.
		/// <param name="value">int</param>
		/// <returns>BranchCreateRequest</returns>
		/// </summary>
		public BranchCreateRequest SetParentBranchId(int? value)
		{
			ParentBranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Name.
		/// <param name="value">String</param>
		/// <returns>BranchCreateRequest</returns>
		/// </summary>
		public BranchCreateRequest SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for Color.
		/// <param name="value">String</param>
		/// <returns>BranchCreateRequest</returns>
		/// </summary>
		public BranchCreateRequest SetColor(String value)
		{
			Color = value;
			return this;
		}

		/// <summary>
		/// Setter for Changeset_ID.
		/// <param name="value">int</param>
		/// <returns>BranchCreateRequest</returns>
		/// </summary>
		public BranchCreateRequest SetChangesetId(int? value)
		{
			ChangesetId = value;
			return this;
		}

		/// <summary>
		/// Setter for Tags.
		/// <param name="value">String</param>
		/// <returns>BranchCreateRequest</returns>
		/// </summary>
		public BranchCreateRequest SetTags(String value)
		{
			Tags = value;
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

			if (ParentBranchId.HasValue)
			{
				writer.WriteNumber("Parent_Branch_ID", ParentBranchId.Value);
			}

			if (Name != null && Name.Length > 0)
			{
				writer.WriteString("Name", Name);
			}

			if (Color != null && Color.Length > 0)
			{
				writer.WriteString("Color", Color);
			}

			if (ChangesetId.HasValue)
			{
				writer.WriteNumber("Changeset_ID", ChangesetId.Value);
			}

			if (Tags != null && Tags.Length > 0)
			{
				writer.WriteString("Tags", Tags);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BranchCreateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BranchCreateResponse</returns>
		/// </summary>
		public new BranchCreateResponse Send()
		{
			return Client.SendRequestAsync<BranchCreateRequest, BranchCreateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BranchCreateResponse></returns>
		/// </summary>
		public new async Task<BranchCreateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BranchCreateRequest, BranchCreateResponse>(this);
		}
	}
}
