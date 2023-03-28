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
	/// Handles API Request CopyPageRulesSettingsList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copypagerulessettingslist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyPageRulesSettingsListLoadQueryRequest : ListQueryRequest
	{
		/// Request field CopyPageRules_ID.
		[JsonPropertyName("CopyPageRules_ID")]
		public int? CopyPageRulesId { get; set; }

		/// Request field CopyPageRules_Name.
		[JsonPropertyName("CopyPageRules_Name")]
		public String CopyPageRulesName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"code",
			"module_name"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"code",
			"module_name"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CopyPageRulesSettingsListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CopyPageRulesSettingsList_Load_Query";
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
		/// Setter for CopyPageRules_ID.
		/// <param name="value">int</param>
		/// <returns>CopyPageRulesSettingsListLoadQueryRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsListLoadQueryRequest SetCopyPageRulesId(int? value)
		{
			CopyPageRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_Name.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesSettingsListLoadQueryRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsListLoadQueryRequest SetCopyPageRulesName(String value)
		{
			CopyPageRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesSettingsListLoadQueryRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesSettingsListLoadQueryRequest</returns>
		/// </summary>
		public CopyPageRulesSettingsListLoadQueryRequest SetUnassigned(bool? value)
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

			if (CopyPageRulesId.HasValue)
			{
				writer.WriteNumber("CopyPageRules_ID", CopyPageRulesId.Value);
			}
			else if (CopyPageRulesName != null && CopyPageRulesName.Length > 0)
			{
				writer.WriteString("CopyPageRules_Name", CopyPageRulesName);
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
			return JsonSerializer.Deserialize<CopyPageRulesSettingsListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyPageRulesSettingsListLoadQueryResponse</returns>
		/// </summary>
		public new CopyPageRulesSettingsListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CopyPageRulesSettingsListLoadQueryRequest, CopyPageRulesSettingsListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyPageRulesSettingsListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CopyPageRulesSettingsListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyPageRulesSettingsListLoadQueryRequest, CopyPageRulesSettingsListLoadQueryResponse>(this);
		}
	}
}
