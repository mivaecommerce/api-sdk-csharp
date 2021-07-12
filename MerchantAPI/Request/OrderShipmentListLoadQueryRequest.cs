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
	/// Handles API Request OrderShipmentList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/ordershipmentlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderShipmentListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"order_id",
			"code",
			"tracknum",
			"tracktype",
			"weight",
			"cost",
			"status",
			"ship_date",
			"batch_id",
			"order_batch_id",
			"order_pay_id",
			"order_status",
			"order_pay_status",
			"order_stk_status",
			"order_orderdate",
			"order_dt_instock",
			"order_cust_id",
			"order_ship_res",
			"order_ship_fname",
			"order_ship_lname",
			"order_ship_email",
			"order_ship_comp",
			"order_ship_phone",
			"order_ship_fax",
			"order_ship_addr1",
			"order_ship_addr2",
			"order_ship_city",
			"order_ship_state",
			"order_ship_zip",
			"order_ship_cntry",
			"order_bill_fname",
			"order_bill_lname",
			"order_bill_email",
			"order_bill_comp",
			"order_bill_phone",
			"order_bill_fax",
			"order_bill_addr1",
			"order_bill_addr2",
			"order_bill_city",
			"order_bill_state",
			"order_bill_zip",
			"order_bill_cntry",
			"order_ship_id",
			"order_ship_data",
			"order_source",
			"order_source_id",
			"order_total",
			"order_total_ship",
			"order_total_tax",
			"order_total_auth",
			"order_total_capt",
			"order_total_rfnd",
			"order_net_capt",
			"order_pend_count",
			"order_bord_count",
			"order_note_count"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"order_id",
			"code",
			"tracknum",
			"tracktype",
			"weight",
			"cost",
			"status",
			"ship_date",
			"batch_id",
			"order_batch_id",
			"order_pay_id",
			"order_status",
			"order_pay_status",
			"order_stk_status",
			"order_dt_instock",
			"order_orderdate",
			"order_cust_id",
			"order_ship_res",
			"order_ship_fname",
			"order_ship_lname",
			"order_ship_email",
			"order_ship_comp",
			"order_ship_phone",
			"order_ship_fax",
			"order_ship_addr1",
			"order_ship_addr2",
			"order_ship_city",
			"order_ship_state",
			"order_ship_zip",
			"order_ship_cntry",
			"order_bill_fname",
			"order_bill_lname",
			"order_bill_email",
			"order_bill_comp",
			"order_bill_phone",
			"order_bill_fax",
			"order_bill_addr1",
			"order_bill_addr2",
			"order_bill_city",
			"order_bill_state",
			"order_bill_zip",
			"order_bill_cntry",
			"order_ship_id",
			"order_ship_data",
			"order_source",
			"order_source_id",
			"order_total",
			"order_total_ship",
			"order_total_tax",
			"order_total_auth",
			"order_total_capt",
			"order_total_rfnd",
			"order_net_capt",
			"order_pend_count",
			"order_bord_count",
			"order_note_count"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"items",
			"include_order"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public OrderShipmentListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "OrderShipmentList_Load_Query";
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
			return JsonSerializer.Deserialize<OrderShipmentListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderShipmentListLoadQueryResponse</returns>
		/// </summary>
		public new OrderShipmentListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<OrderShipmentListLoadQueryRequest, OrderShipmentListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderShipmentListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<OrderShipmentListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderShipmentListLoadQueryRequest, OrderShipmentListLoadQueryResponse>(this);
		}
	}
}
