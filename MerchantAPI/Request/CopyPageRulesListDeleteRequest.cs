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
	/// Handles API Request CopyPageRulesList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/copypageruleslist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyPageRulesListDeleteRequest : Request
	{
		/// Request field CopyPageRules_IDs.
		public List<int> CopyPageRulesIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CopyPageRulesListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CopyPageRulesList_Delete";
		}

		/// <summary>
		/// Add CopyPageRules_IDs.
		///	- copyPageRuleId: Int
		/// - Returns: Self
		/// </summary>
		public CopyPageRulesListDeleteRequest AddCopyPageRuleId(int copyPageRuleId)
		{
			CopyPageRulesIds.Add(copyPageRuleId);
			return this;
		}

		/// <summary>
		/// Add CopyPageRule model.
		/// <param name="copyPageRule">CopyPageRule></param>
		/// <returns>CopyPageRulesListDeleteRequest</returns>
		/// </summary>
		public CopyPageRulesListDeleteRequest AddCopyPageRule(CopyPageRule copyPageRule)
		{
			if (copyPageRule.Id > 0)
			{
				CopyPageRulesIds.Add(copyPageRule.Id);
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

			writer.WritePropertyName("CopyPageRules_IDs");
			JsonSerializer.Serialize(writer, this.CopyPageRulesIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyPageRulesListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyPageRulesListDeleteResponse</returns>
		/// </summary>
		public new CopyPageRulesListDeleteResponse Send()
		{
			return Client.SendRequestAsync<CopyPageRulesListDeleteRequest, CopyPageRulesListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyPageRulesListDeleteResponse></returns>
		/// </summary>
		public new async Task<CopyPageRulesListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyPageRulesListDeleteRequest, CopyPageRulesListDeleteResponse>(this);
		}
	}
}
