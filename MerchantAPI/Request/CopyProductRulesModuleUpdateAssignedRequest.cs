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
	/// Handles API Request CopyProductRulesModule_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/copyproductrulesmodule_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyProductRulesModuleUpdateAssignedRequest : Request
	{
		/// Request field CopyProductRules_ID.
		[JsonPropertyName("CopyProductRules_ID")]
		public int? CopyProductRulesId { get; set; }

		/// Request field CopyProductRules_Name.
		[JsonPropertyName("CopyProductRules_Name")]
		public String CopyProductRulesName { get; set; }

		/// Request field Module_Code.
		[JsonPropertyName("Module_Code")]
		public String ModuleCode { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="copyProductRule">CopyProductRule</param>
		/// </summary>
		public CopyProductRulesModuleUpdateAssignedRequest(BaseClient client = null, CopyProductRule copyProductRule = null) :
			base(client)
		{
			Function = "CopyProductRulesModule_Update_Assigned";
			if (copyProductRule != null) {
				if (copyProductRule.Id > 0)
				{
					CopyProductRulesId = copyProductRule.Id;
				}
				else if (copyProductRule.Name.Length > 0)
				{
					CopyProductRulesName = copyProductRule.Name;
				}
			}
		}

		/// <summary>
		/// Getter for CopyProductRules_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCopyProductRulesId()
		{
			return CopyProductRulesId;
		}

		/// <summary>
		/// Getter for CopyProductRules_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCopyProductRulesName()
		{
			return CopyProductRulesName;
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
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for CopyProductRules_ID.
		/// <param name="value">int</param>
		/// <returns>CopyProductRulesModuleUpdateAssignedRequest</returns>
		/// </summary>
		public CopyProductRulesModuleUpdateAssignedRequest SetCopyProductRulesId(int? value)
		{
			CopyProductRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyProductRules_Name.
		/// <param name="value">String</param>
		/// <returns>CopyProductRulesModuleUpdateAssignedRequest</returns>
		/// </summary>
		public CopyProductRulesModuleUpdateAssignedRequest SetCopyProductRulesName(String value)
		{
			CopyProductRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_Code.
		/// <param name="value">String</param>
		/// <returns>CopyProductRulesModuleUpdateAssignedRequest</returns>
		/// </summary>
		public CopyProductRulesModuleUpdateAssignedRequest SetModuleCode(String value)
		{
			ModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesModuleUpdateAssignedRequest</returns>
		/// </summary>
		public CopyProductRulesModuleUpdateAssignedRequest SetAssigned(bool value)
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

			if (CopyProductRulesId.HasValue)
			{
				writer.WriteNumber("CopyProductRules_ID", CopyProductRulesId.Value);
			}
			else if (CopyProductRulesName != null && CopyProductRulesName.Length > 0)
			{
				writer.WriteString("CopyProductRules_Name", CopyProductRulesName);
			}

			writer.WriteString("Module_Code", ModuleCode);

			writer.WriteBoolean("Assigned", Assigned);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyProductRulesModuleUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyProductRulesModuleUpdateAssignedResponse</returns>
		/// </summary>
		public new CopyProductRulesModuleUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<CopyProductRulesModuleUpdateAssignedRequest, CopyProductRulesModuleUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyProductRulesModuleUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<CopyProductRulesModuleUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyProductRulesModuleUpdateAssignedRequest, CopyProductRulesModuleUpdateAssignedResponse>(this);
		}
	}
}
