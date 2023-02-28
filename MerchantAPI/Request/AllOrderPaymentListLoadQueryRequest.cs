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
	/// Handles API Request AllOrderPaymentList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/allorderpaymentlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AllOrderPaymentListLoadQueryRequest : OrderListLoadQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"type",
			"refnum",
			"available",
			"expires,",
			"payment_ip",
			"amount",
			"payment_dtstamp",
			"id",
			"batch_id",
			"status",
			"pay_status",
			"orderdate",
			"dt_instock",
			"ship_res",
			"ship_fname",
			"ship_lname",
			"ship_email",
			"ship_comp",
			"ship_phone",
			"ship_fax",
			"ship_addr1",
			"ship_addr2",
			"ship_city",
			"ship_state",
			"ship_zip",
			"ship_cntry",
			"bill_fname",
			"bill_lname",
			"bill_email",
			"bill_comp",
			"bill_phone",
			"bill_fax",
			"bill_addr1",
			"bill_addr2",
			"bill_city",
			"bill_state",
			"bill_zip",
			"bill_cntry",
			"ship_data",
			"source",
			"source_id",
			"total",
			"total_ship",
			"total_tax",
			"total_auth",
			"total_capt",
			"total_rfnd",
			"net_capt",
			"pend_count",
			"bord_count",
			"cust_login",
			"cust_pw_email",
			"business_title",
			"note_count",
			"payment_module"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"type",
			"refnum",
			"available",
			"expires,",
			"payment_ip",
			"amount",
			"payment_dtstamp"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public AllOrderPaymentListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "AllOrderPaymentList_Load_Query";
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
			return JsonSerializer.Deserialize<AllOrderPaymentListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AllOrderPaymentListLoadQueryResponse</returns>
		/// </summary>
		public new AllOrderPaymentListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<AllOrderPaymentListLoadQueryRequest, AllOrderPaymentListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AllOrderPaymentListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<AllOrderPaymentListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AllOrderPaymentListLoadQueryRequest, AllOrderPaymentListLoadQueryResponse>(this);
		}
	}
}
