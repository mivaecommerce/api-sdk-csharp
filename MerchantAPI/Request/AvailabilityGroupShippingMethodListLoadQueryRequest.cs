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
	/// Handles API Request AvailabilityGroupShippingMethodList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupshippingmethodlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupShippingMethodListLoadQueryRequest : ListQueryRequest
	{
		/// Request field AvailabilityGroup_ID.
		[JsonPropertyName("AvailabilityGroup_ID")]
		public int? AvailabilityGroupId { get; set; }

		/// Request field Edit_AvailabilityGroup.
		[JsonPropertyName("Edit_AvailabilityGroup")]
		public String EditAvailabilityGroup { get; set; }

		/// Request field AvailabilityGroup_Name.
		[JsonPropertyName("AvailabilityGroup_Name")]
		public String AvailabilityGroupName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"method_name"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="availabilityGroup">AvailabilityGroup</param>
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryRequest(BaseClient client = null, AvailabilityGroup availabilityGroup = null) :
			base(client)
		{
			Function = "AvailabilityGroupShippingMethodList_Load_Query";
			if (availabilityGroup != null) {
				if (availabilityGroup.Id > 0)
				{
					AvailabilityGroupId = availabilityGroup.Id;
				}
			}
		}

		/// <summary>
		/// Getter for AvailabilityGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAvailabilityGroupId()
		{
			return AvailabilityGroupId;
		}

		/// <summary>
		/// Getter for Edit_AvailabilityGroup.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAvailabilityGroup()
		{
			return EditAvailabilityGroup;
		}

		/// <summary>
		/// Getter for AvailabilityGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetAvailabilityGroupName()
		{
			return AvailabilityGroupName;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Getter for Unassigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUnassigned()
		{
			return Unassigned;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryRequest SetAvailabilityGroupId(int? value)
		{
			AvailabilityGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AvailabilityGroup.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryRequest SetEditAvailabilityGroup(String value)
		{
			EditAvailabilityGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryRequest SetUnassigned(bool? value)
		{
			Unassigned = value;
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

			if (AvailabilityGroupId.HasValue)
			{
				writer.WriteNumber("AvailabilityGroup_ID", AvailabilityGroupId.Value);
			}
			else if (EditAvailabilityGroup != null && EditAvailabilityGroup.Length > 0)
			{
				writer.WriteString("Edit_AvailabilityGroup", EditAvailabilityGroup);
			}
			else if (AvailabilityGroupName != null && AvailabilityGroupName.Length > 0)
			{
				writer.WriteString("AvailabilityGroup_Name", AvailabilityGroupName);
			}

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}

			if (Unassigned.HasValue)
			{
				writer.WriteBoolean("Unassigned", Unassigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AvailabilityGroupShippingMethodListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupShippingMethodListLoadQueryResponse</returns>
		/// </summary>
		public new AvailabilityGroupShippingMethodListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupShippingMethodListLoadQueryRequest, AvailabilityGroupShippingMethodListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupShippingMethodListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupShippingMethodListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupShippingMethodListLoadQueryRequest, AvailabilityGroupShippingMethodListLoadQueryResponse>(this);
		}
	}
}
