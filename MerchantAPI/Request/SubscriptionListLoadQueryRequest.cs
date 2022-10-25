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
	/// Handles API Request SubscriptionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class SubscriptionListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"order_id",
			"quantity",
			"termrem",
			"termproc",
			"firstdate",
			"lastdate",
			"nextdate",
			"status",
			"message",
			"cncldate",
			"tax",
			"shipping",
			"subtotal",
			"total",
			"authfails",
			"lastafail",
			"frequency",
			"term",
			"descrip",
			"n",
			"fixed_dow",
			"fixed_dom",
			"sub_count",
			"customer_login",
			"customer_pw_email",
			"customer_business_title",
			"product_code",
			"product_name",
			"product_sku",
			"product_price",
			"product_cost",
			"product_weight",
			"product_descrip",
			"product_taxable",
			"product_thumbnail",
			"product_image",
			"product_active",
			"product_page_title",
			"product_cancat_code",
			"product_page_code",
			"address_descrip",
			"address_fname",
			"address_lname",
			"address_email",
			"address_phone",
			"address_fax",
			"address_comp",
			"address_addr1",
			"address_addr2",
			"address_city",
			"address_state",
			"address_zip",
			"address_cntry",
			"product_inventory_active"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"order_id",
			"custpc_id",
			"quantity",
			"termrem",
			"termproc",
			"firstdate",
			"lastdate",
			"nextdate",
			"status",
			"message",
			"cncldate",
			"tax",
			"shipping",
			"subtotal",
			"total",
			"authfails",
			"lastafail",
			"frequency",
			"term",
			"descrip",
			"n",
			"fixed_dow",
			"fixed_dom",
			"sub_count",
			"customer_login",
			"customer_pw_email",
			"customer_business_title",
			"product_code",
			"product_name",
			"product_sku",
			"product_cancat_code",
			"product_page_code",
			"product_price",
			"product_cost",
			"product_weight",
			"product_descrip",
			"product_taxable",
			"product_thumbnail",
			"product_image",
			"product_active",
			"product_page_title",
			"address_descrip",
			"address_fname",
			"address_lname",
			"address_email",
			"address_phone",
			"address_fax",
			"address_comp",
			"address_addr1",
			"address_addr2",
			"address_city",
			"address_state",
			"address_zip",
			"address_cntry",
			"product_inventory"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"imagetypes",
			"imagetype_count",
			"product_descrip"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public SubscriptionListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "SubscriptionList_Load_Query";
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
			return JsonSerializer.Deserialize<SubscriptionListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>SubscriptionListLoadQueryResponse</returns>
		/// </summary>
		public new SubscriptionListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<SubscriptionListLoadQueryRequest, SubscriptionListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<SubscriptionListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<SubscriptionListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<SubscriptionListLoadQueryRequest, SubscriptionListLoadQueryResponse>(this);
		}
	}
}
