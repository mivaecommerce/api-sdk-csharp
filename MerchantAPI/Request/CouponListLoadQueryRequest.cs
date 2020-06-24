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
	/// Handles API Request CouponList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/couponlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"code",
			"descrip",
			"custscope",
			"dt_start",
			"dt_end",
			"max_use",
			"max_per",
			"active",
			"use_count"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"code",
			"descrip",
			"custscope",
			"dt_start",
			"dt_end",
			"max_use",
			"max_per",
			"active",
			"use_count"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// </summary>
		public CouponListLoadQueryRequest(Client client = null) :
			base(client)
		{
			Function = "CouponList_Load_Query";
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
			return JsonSerializer.Deserialize<CouponListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponListLoadQueryResponse</returns>
		/// </summary>
		public new CouponListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CouponListLoadQueryRequest, CouponListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CouponListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponListLoadQueryRequest, CouponListLoadQueryResponse>(this);
		}
	}
}
