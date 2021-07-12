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
	/// Handles API Request BusinessAccountList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/businessaccountlist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BusinessAccountListDeleteRequest : Request
	{
		/// Request field BusinessAccount_IDs.
		public List<int> BusinessAccountIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public BusinessAccountListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "BusinessAccountList_Delete";
		}

		/// <summary>
		/// Add BusinessAccount_IDs.
		///	- businessAccountId: Int
		/// - Returns: Self
		/// </summary>
		public BusinessAccountListDeleteRequest AddBusinessAccountId(int businessAccountId)
		{
			BusinessAccountIds.Add(businessAccountId);
			return this;
		}

		/// <summary>
		/// Add BusinessAccount model.
		/// <param name="businessAccount">BusinessAccount></param>
		/// <returns>BusinessAccountListDeleteRequest</returns>
		/// </summary>
		public BusinessAccountListDeleteRequest AddBusinessAccount(BusinessAccount businessAccount)
		{
			if (businessAccount.Id > 0)
			{
				BusinessAccountIds.Add(businessAccount.Id);
			}

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

			writer.WritePropertyName("BusinessAccount_IDs");
			JsonSerializer.Serialize(writer, this.BusinessAccountIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BusinessAccountListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BusinessAccountListDeleteResponse</returns>
		/// </summary>
		public new BusinessAccountListDeleteResponse Send()
		{
			return Client.SendRequestAsync<BusinessAccountListDeleteRequest, BusinessAccountListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BusinessAccountListDeleteResponse></returns>
		/// </summary>
		public new async Task<BusinessAccountListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BusinessAccountListDeleteRequest, BusinessAccountListDeleteResponse>(this);
		}
	}
}
