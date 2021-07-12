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
	/// Handles API Request StoreList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/storelist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class StoreListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"code",
			"license",
			"name",
			"owner",
			"email",
			"company",
			"address",
			"city",
			"state",
			"zip",
			"phone",
			"fax",
			"country"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"code",
			"license",
			"name",
			"owner",
			"email",
			"company",
			"address",
			"city",
			"state",
			"zip",
			"phone",
			"fax",
			"country"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public StoreListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "StoreList_Load_Query";
			Scope = RequestScope.Domain;
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
			return JsonSerializer.Deserialize<StoreListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>StoreListLoadQueryResponse</returns>
		/// </summary>
		public new StoreListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<StoreListLoadQueryRequest, StoreListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<StoreListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<StoreListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<StoreListLoadQueryRequest, StoreListLoadQueryResponse>(this);
		}
	}
}
