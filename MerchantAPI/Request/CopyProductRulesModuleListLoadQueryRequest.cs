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
	/// Handles API Request CopyProductRulesModuleList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copyproductrulesmodulelist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyProductRulesModuleListLoadQueryRequest : ListQueryRequest
	{
		/// Request field CopyProductRules_ID.
		[JsonPropertyName("CopyProductRules_ID")]
		public int? CopyProductRulesId { get; set; }

		/// Request field CopyProductRules_Name.
		[JsonPropertyName("CopyProductRules_Name")]
		public String CopyProductRulesName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"module_name"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"module_name"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="copyProductRule">CopyProductRule</param>
		/// </summary>
		public CopyProductRulesModuleListLoadQueryRequest(BaseClient client = null, CopyProductRule copyProductRule = null) :
			base(client)
		{
			Function = "CopyProductRulesModuleList_Load_Query";
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
		/// Setter for CopyProductRules_ID.
		/// <param name="value">int</param>
		/// <returns>CopyProductRulesModuleListLoadQueryRequest</returns>
		/// </summary>
		public CopyProductRulesModuleListLoadQueryRequest SetCopyProductRulesId(int? value)
		{
			CopyProductRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyProductRules_Name.
		/// <param name="value">String</param>
		/// <returns>CopyProductRulesModuleListLoadQueryRequest</returns>
		/// </summary>
		public CopyProductRulesModuleListLoadQueryRequest SetCopyProductRulesName(String value)
		{
			CopyProductRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesModuleListLoadQueryRequest</returns>
		/// </summary>
		public CopyProductRulesModuleListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesModuleListLoadQueryRequest</returns>
		/// </summary>
		public CopyProductRulesModuleListLoadQueryRequest SetUnassigned(bool? value)
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

			if (CopyProductRulesId.HasValue)
			{
				writer.WriteNumber("CopyProductRules_ID", CopyProductRulesId.Value);
			}
			else if (CopyProductRulesName != null && CopyProductRulesName.Length > 0)
			{
				writer.WriteString("CopyProductRules_Name", CopyProductRulesName);
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
			return JsonSerializer.Deserialize<CopyProductRulesModuleListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyProductRulesModuleListLoadQueryResponse</returns>
		/// </summary>
		public new CopyProductRulesModuleListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CopyProductRulesModuleListLoadQueryRequest, CopyProductRulesModuleListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyProductRulesModuleListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CopyProductRulesModuleListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyProductRulesModuleListLoadQueryRequest, CopyProductRulesModuleListLoadQueryResponse>(this);
		}
	}
}
