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
	/// Handles API Request AvailabilityGroupPaymentMethod_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygrouppaymentmethod_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupPaymentMethodUpdateAssignedRequest : Request
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

		/// Request field Module_Code.
		[JsonPropertyName("Module_Code")]
		public String ModuleCode { get; set; }

		/// Request field Method_Code.
		[JsonPropertyName("Method_Code")]
		public String MethodCode { get; set; }

		/// Request field PaymentCardType_ID.
		[JsonPropertyName("PaymentCardType_ID")]
		public int? PaymentCardTypeId { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="availabilityGroup">AvailabilityGroup</param>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest(Client client = null, AvailabilityGroup availabilityGroup = null) :
			base(client)
		{
			Function = "AvailabilityGroupPaymentMethod_Update_Assigned";
			if (availabilityGroup != null) {
				if (availabilityGroup.Id > 0)
				{
					AvailabilityGroupId = availabilityGroup.Id;
				}
				else if (availabilityGroup.Name.Length > 0)
				{
					EditAvailabilityGroup = availabilityGroup.Name;
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
		/// Getter for Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for Method_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodCode()
		{
			return MethodCode;
		}

		/// <summary>
		/// Getter for PaymentCardType_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPaymentCardTypeId()
		{
			return PaymentCardTypeId;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetAvailabilityGroupId(int? value)
		{
			AvailabilityGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AvailabilityGroup.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetEditAvailabilityGroup(String value)
		{
			EditAvailabilityGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_Code.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetModuleCode(String value)
		{
			ModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Method_Code.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetMethodCode(String value)
		{
			MethodCode = value;
			return this;
		}

		/// <summary>
		/// Setter for PaymentCardType_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetPaymentCardTypeId(int? value)
		{
			PaymentCardTypeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupPaymentMethodUpdateAssignedRequest SetAssigned(bool value)
		{
			Assigned = value;
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

			writer.WriteString("Module_Code", ModuleCode);

			writer.WriteString("Method_Code", MethodCode);

			if (PaymentCardTypeId.HasValue)
			{
				writer.WriteNumber("PaymentCardType_ID", PaymentCardTypeId.Value);
			}

			writer.WriteBoolean("Assigned", Assigned);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AvailabilityGroupPaymentMethodUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupPaymentMethodUpdateAssignedResponse</returns>
		/// </summary>
		public new AvailabilityGroupPaymentMethodUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupPaymentMethodUpdateAssignedRequest, AvailabilityGroupPaymentMethodUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupPaymentMethodUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupPaymentMethodUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupPaymentMethodUpdateAssignedRequest, AvailabilityGroupPaymentMethodUpdateAssignedResponse>(this);
		}
	}
}
