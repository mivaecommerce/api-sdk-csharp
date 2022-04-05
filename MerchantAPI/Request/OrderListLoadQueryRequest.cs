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
	/// Handles API Request OrderList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/orderlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderListLoadQueryRequest : ListQueryRequest
	{
		/// Enumeration PayStatusFilter
		public enum PayStatusFilter
		{
			AuthOnly,
			PartialCapture,
			CapturedNotShipped,
			ShippedNotCaptured,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String PayStatusFilterToString(PayStatusFilter value)
		{
			switch(value) {
				case PayStatusFilter.AuthOnly: return "auth_0_capt";
				case PayStatusFilter.PartialCapture: return "partial_capt";
				case PayStatusFilter.CapturedNotShipped: return "capt_not_ship";
				case PayStatusFilter.ShippedNotCaptured: return "ship_not_capt";
			}
			return "";
		}
		/// Request field Passphrase.
		[JsonPropertyName("Passphrase")]
		public String Passphrase { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
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
			"ship_id",
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
			"note_count"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
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

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"ship_method",
			"cust_login",
			"cust_pw_email",
			"business_title",
			"payment_module",
			"customer",
			"items",
			"charges",
			"coupons",
			"discounts",
			"payments",
			"notes",
			"parts",
			"shipments",
			"returns"
		};

		/// The available custom fileters applicable to the request.
		override public String[] AvailableCustomFilters { get; } =
		{
			"Customer_ID",
			"BusinessAccount_ID",
			"pay_id",
			"payment",
			"product_code"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public OrderListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "OrderList_Load_Query";
		}

		/// <summary>
		/// Getter for Passphrase.
		/// <returns>String</returns>
		/// </summary>
		public String GetPassphrase()
		{
			return Passphrase;
		}

		/// <summary>
		/// Setter for Passphrase.
		/// <param name="value">String</param>
		/// <returns>OrderListLoadQueryRequest</returns>
		/// </summary>
		public OrderListLoadQueryRequest SetPassphrase(String value)
		{
			Passphrase = value;
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

			if (Passphrase != null && Passphrase.Length > 0)
			{
				writer.WriteString("Passphrase", Passphrase);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderListLoadQueryResponse</returns>
		/// </summary>
		public new OrderListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<OrderListLoadQueryRequest, OrderListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<OrderListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderListLoadQueryRequest, OrderListLoadQueryResponse>(this);
		}
	}
}
