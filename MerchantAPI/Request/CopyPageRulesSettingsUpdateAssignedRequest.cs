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
	/// Handles API Request CopyPageRulesSettings_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/copypagerulessettings_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyPageRulesSettingsUpdateAssignedRequest : Request
	{
		/// Request field CopyPageRules_ID.
		[JsonPropertyName("CopyPageRules_ID")]
		public int? CopyPageRulesId { get; set; }

		/// Request field CopyPageRules_Name.
		[JsonPropertyName("CopyPageRules_Name")]
		public String CopyPageRulesName { get; set; }

		/// Request field Item_Code.
		[JsonPropertyName("Item_Code")]
		public String ItemCode { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="copyPageRule">CopyPageRule</param>
		/// </summary>
		public CopyPageRulesSettingsUpdateAssignedRequest(BaseClient client = null, CopyPageRule copyPageRule = null) :
			base(client)
		{
			Function = "CopyPageRulesSettings_Update_Assigned";
			if (copyPageRule != null) {
				if (copyPageRule.Id > 0)
				{
					CopyPageRulesId = copyPageRule.Id;
				}
				else if (copyPageRule.Name.Length > 0)
				{
					CopyPageRulesName = copyPageRule.Name;
				}
			}
		}

		/// <summary>
		/// Getter for CopyPageRules_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCopyPageRulesId()
		{
			return CopyPageRulesId;
		}

		/// <summary>
		/// Getter for CopyPageRules_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCopyPageRulesName()
		{
			return CopyPageRulesName;
		}

		/// <summary>
		/// Getter for Item_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetItemCode()
		{
			return ItemCode;
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
		/// Setter for CopyPageRules_ID.
		/// <param name="value">int</param>
		/// <returns>CopyPageRulesSettingsUpdateAssignedRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsUpdateAssignedRequest SetCopyPageRulesId(int? value)
		{
			CopyPageRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_Name.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesSettingsUpdateAssignedRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsUpdateAssignedRequest SetCopyPageRulesName(String value)
		{
			CopyPageRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Item_Code.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesSettingsUpdateAssignedRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsUpdateAssignedRequest SetItemCode(String value)
		{
			ItemCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesSettingsUpdateAssignedRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsUpdateAssignedRequest SetAssigned(bool value)
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

			if (CopyPageRulesId.HasValue)
			{
				writer.WriteNumber("CopyPageRules_ID", CopyPageRulesId.Value);
			}
			else if (CopyPageRulesName != null && CopyPageRulesName.Length > 0)
			{
				writer.WriteString("CopyPageRules_Name", CopyPageRulesName);
			}

			writer.WriteString("Item_Code", ItemCode);

			writer.WriteBoolean("Assigned", Assigned);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyPageRulesSettingsUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyPageRulesSettingsUpdateAssignedResponse</returns>
		/// </summary>
		public new CopyPageRulesSettingsUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<CopyPageRulesSettingsUpdateAssignedRequest, CopyPageRulesSettingsUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyPageRulesSettingsUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<CopyPageRulesSettingsUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyPageRulesSettingsUpdateAssignedRequest, CopyPageRulesSettingsUpdateAssignedResponse>(this);
		}
	}
}
