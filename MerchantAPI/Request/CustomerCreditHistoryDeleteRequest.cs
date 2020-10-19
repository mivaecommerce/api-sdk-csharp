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
	/// Handles API Request CustomerCreditHistory_Delete.
	/// <see>https://docs.miva.com/json-api/functions/customercredithistory_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerCreditHistoryDeleteRequest : Request
	{
		/// Request field CustomerCreditHistory_ID.
		[JsonPropertyName("CustomerCreditHistory_ID")]
		public int CustomerCreditHistoryId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customerCreditHistory">CustomerCreditHistory</param>
		/// </summary>
		public CustomerCreditHistoryDeleteRequest(BaseClient client = null, CustomerCreditHistory customerCreditHistory = null) :
			base(client)
		{
			Function = "CustomerCreditHistory_Delete";
			if (customerCreditHistory != null) {
				CustomerCreditHistoryId = customerCreditHistory.Id;
			}
		}

		/// <summary>
		/// Getter for CustomerCreditHistory_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetCustomerCreditHistoryId()
		{
			return CustomerCreditHistoryId;
		}

		/// <summary>
		/// Setter for CustomerCreditHistory_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerCreditHistoryDeleteRequest</returns>
		/// </summary>
		public CustomerCreditHistoryDeleteRequest SetCustomerCreditHistoryId(int value)
		{
			CustomerCreditHistoryId = value;
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

			writer.WriteNumber("CustomerCreditHistory_ID", CustomerCreditHistoryId);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerCreditHistoryDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerCreditHistoryDeleteResponse</returns>
		/// </summary>
		public new CustomerCreditHistoryDeleteResponse Send()
		{
			return Client.SendRequestAsync<CustomerCreditHistoryDeleteRequest, CustomerCreditHistoryDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerCreditHistoryDeleteResponse></returns>
		/// </summary>
		public new async Task<CustomerCreditHistoryDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerCreditHistoryDeleteRequest, CustomerCreditHistoryDeleteResponse>(this);
		}
	}
}
