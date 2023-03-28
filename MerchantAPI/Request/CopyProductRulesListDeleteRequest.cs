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
	/// Handles API Request CopyProductRulesList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/copyproductruleslist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyProductRulesListDeleteRequest : Request
	{
		/// Request field CopyProductRules_IDs.
		public List<int> CopyProductRulesIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CopyProductRulesListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CopyProductRulesList_Delete";
		}

		/// <summary>
		/// Add CopyProductRules_IDs.
		///	- copyProductRuleId: Int
		/// - Returns: Self
		/// </summary>
		public CopyProductRulesListDeleteRequest AddCopyProductRuleId(int copyProductRuleId)
		{
			CopyProductRulesIds.Add(copyProductRuleId);
			return this;
		}

		/// <summary>
		/// Add CopyProductRule model.
		/// <param name="copyProductRule">CopyProductRule></param>
		/// <returns>CopyProductRulesListDeleteRequest</returns>
		/// </summary>
		public CopyProductRulesListDeleteRequest AddCopyProductRule(CopyProductRule copyProductRule)
		{
			if (copyProductRule.Id > 0)
			{
				CopyProductRulesIds.Add(copyProductRule.Id);
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

			writer.WritePropertyName("CopyProductRules_IDs");
			JsonSerializer.Serialize(writer, this.CopyProductRulesIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyProductRulesListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyProductRulesListDeleteResponse</returns>
		/// </summary>
		public new CopyProductRulesListDeleteResponse Send()
		{
			return Client.SendRequestAsync<CopyProductRulesListDeleteRequest, CopyProductRulesListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyProductRulesListDeleteResponse></returns>
		/// </summary>
		public new async Task<CopyProductRulesListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyProductRulesListDeleteRequest, CopyProductRulesListDeleteResponse>(this);
		}
	}
}
