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
	/// Handles API Request CustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customerlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerListLoadQueryRequest : ListQueryRequest
	{
		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"login",
			"pw_email",
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
			"ship_res",
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
			"business_title",
			"note_count",
			"dt_created",
			"dt_login",
			"credit"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"login",
			"pw_email",
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
			"ship_res",
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
			"business_title",
			"note_count",
			"dt_created",
			"dt_login",
			"credit"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// </summary>
		public CustomerListLoadQueryRequest(Client client = null) :
			base(client)
		{
			Function = "CustomerList_Load_Query";
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
			return JsonSerializer.Deserialize<CustomerListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerListLoadQueryResponse</returns>
		/// </summary>
		public new CustomerListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CustomerListLoadQueryRequest, CustomerListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CustomerListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerListLoadQueryRequest, CustomerListLoadQueryResponse>(this);
		}
	}
}
