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
	/// Handles API Request BusinessAccountCustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/businessaccountcustomerlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BusinessAccountCustomerListLoadQueryRequest : CustomerListLoadQueryRequest
	{
		/// Request field BusinessAccount_ID.
		[JsonPropertyName("BusinessAccount_ID")]
		public int? BusinessAccountId { get; set; }

		/// Request field Edit_BusinessAccount.
		[JsonPropertyName("Edit_BusinessAccount")]
		public int? EditBusinessAccount { get; set; }

		/// Request field BusinessAccount_Title.
		[JsonPropertyName("BusinessAccount_Title")]
		public String BusinessAccountTitle { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public BusinessAccountCustomerListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "BusinessAccountCustomerList_Load_Query";
		}

		/// <summary>
		/// Getter for BusinessAccount_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBusinessAccountId()
		{
			return BusinessAccountId;
		}

		/// <summary>
		/// Getter for Edit_BusinessAccount.
		/// <returns>int</returns>
		/// </summary>
		public int? GetEditBusinessAccount()
		{
			return EditBusinessAccount;
		}

		/// <summary>
		/// Getter for BusinessAccount_Title.
		/// <returns>String</returns>
		/// </summary>
		public String GetBusinessAccountTitle()
		{
			return BusinessAccountTitle;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Getter for Unassigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUnassigned()
		{
			return Unassigned;
		}

		/// <summary>
		/// Setter for BusinessAccount_ID.
		/// <param name="value">int</param>
		/// <returns>BusinessAccountCustomerListLoadQueryRequest</returns>
		/// </summary>
		public BusinessAccountCustomerListLoadQueryRequest SetBusinessAccountId(int? value)
		{
			BusinessAccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_BusinessAccount.
		/// <param name="value">int</param>
		/// <returns>BusinessAccountCustomerListLoadQueryRequest</returns>
		/// </summary>
		public BusinessAccountCustomerListLoadQueryRequest SetEditBusinessAccount(int? value)
		{
			EditBusinessAccount = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountCustomerListLoadQueryRequest</returns>
		/// </summary>
		public BusinessAccountCustomerListLoadQueryRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>BusinessAccountCustomerListLoadQueryRequest</returns>
		/// </summary>
		public BusinessAccountCustomerListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>BusinessAccountCustomerListLoadQueryRequest</returns>
		/// </summary>
		public BusinessAccountCustomerListLoadQueryRequest SetUnassigned(bool? value)
		{
			Unassigned = value;
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

			if (BusinessAccountId.HasValue)
			{
				writer.WriteNumber("BusinessAccount_ID", BusinessAccountId.Value);
			}
			else if (EditBusinessAccount.HasValue)
			{
				writer.WriteNumber("Edit_BusinessAccount", EditBusinessAccount.Value);
			}
			else if (BusinessAccountTitle != null && BusinessAccountTitle.Length > 0)
			{
				writer.WriteString("BusinessAccount_Title", BusinessAccountTitle);
			}

			if (BusinessAccountId.HasValue)
			{
				writer.WriteNumber("BusinessAccount_ID", BusinessAccountId.Value);
			}

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}

			if (Unassigned.HasValue)
			{
				writer.WriteBoolean("Unassigned", Unassigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BusinessAccountCustomerListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BusinessAccountCustomerListLoadQueryResponse</returns>
		/// </summary>
		public new BusinessAccountCustomerListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<BusinessAccountCustomerListLoadQueryRequest, BusinessAccountCustomerListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BusinessAccountCustomerListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<BusinessAccountCustomerListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BusinessAccountCustomerListLoadQueryRequest, BusinessAccountCustomerListLoadQueryResponse>(this);
		}
	}
}
