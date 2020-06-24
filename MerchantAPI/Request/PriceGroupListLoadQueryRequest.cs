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
	/// Handles API Request PriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/pricegrouplist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"name",
			"type",
			"module_id",
			"custscope",
			"rate",
			"discount",
			"markup",
			"dt_start",
			"dt_end",
			"priority",
			"exclusion",
			"descrip",
			"display",
			"qmn_subtot",
			"qmx_subtot",
			"qmn_quan",
			"qmx_quan",
			"qmn_weight",
			"qmx_weight",
			"bmn_subtot",
			"bmx_subtot",
			"bmn_quan",
			"bmx_quan",
			"bmn_weight",
			"bmx_weight"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"name",
			"type",
			"module_id",
			"custscope",
			"rate",
			"discount",
			"markup",
			"dt_start",
			"dt_end",
			"priority",
			"exclusion",
			"descrip",
			"display",
			"qmn_subtot",
			"qmx_subtot",
			"qmn_quan",
			"qmx_quan",
			"qmn_weight",
			"qmx_weight",
			"bmn_subtot",
			"bmx_subtot",
			"bmn_quan",
			"bmx_quan",
			"bmn_weight",
			"bmx_weight"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// </summary>
		public PriceGroupListLoadQueryRequest(Client client = null) :
			base(client)
		{
			Function = "PriceGroupList_Load_Query";
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
			return JsonSerializer.Deserialize<PriceGroupListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupListLoadQueryResponse</returns>
		/// </summary>
		public new PriceGroupListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupListLoadQueryRequest, PriceGroupListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<PriceGroupListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupListLoadQueryRequest, PriceGroupListLoadQueryResponse>(this);
		}
	}
}
