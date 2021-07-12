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
	/// Handles API Request BusinessAccountList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/businessaccountlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BusinessAccountListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"title",
			"note_count",
			"tax_exempt",
			"order_cnt",
			"order_avg",
			"order_tot"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"title",
			"note_count",
			"tax_exempt",
			"order_cnt",
			"order_avg",
			"order_tot"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public BusinessAccountListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "BusinessAccountList_Load_Query";
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
			return JsonSerializer.Deserialize<BusinessAccountListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BusinessAccountListLoadQueryResponse</returns>
		/// </summary>
		public new BusinessAccountListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<BusinessAccountListLoadQueryRequest, BusinessAccountListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BusinessAccountListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<BusinessAccountListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BusinessAccountListLoadQueryRequest, BusinessAccountListLoadQueryResponse>(this);
		}
	}
}
