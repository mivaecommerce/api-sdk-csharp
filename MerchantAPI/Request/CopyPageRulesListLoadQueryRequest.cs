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
	/// Handles API Request CopyPageRulesList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copypageruleslist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyPageRulesListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"name",
			"secure",
			"title",
			"template",
			"items",
			"settings",
			"jsres",
			"cssres",
			"cacheset"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"name",
			"secure",
			"title",
			"template",
			"items",
			"settings",
			"jsres",
			"cssres",
			"cacheset"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CopyPageRulesListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CopyPageRulesList_Load_Query";
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyPageRulesListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyPageRulesListLoadQueryResponse</returns>
		/// </summary>
		public new CopyPageRulesListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CopyPageRulesListLoadQueryRequest, CopyPageRulesListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyPageRulesListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CopyPageRulesListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyPageRulesListLoadQueryRequest, CopyPageRulesListLoadQueryResponse>(this);
		}
	}
}
