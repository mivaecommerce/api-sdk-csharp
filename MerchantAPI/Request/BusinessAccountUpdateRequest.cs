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
	/// Handles API Request BusinessAccount_Update.
	/// <see>https://docs.miva.com/json-api/functions/businessaccount_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BusinessAccountUpdateRequest : Request
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

		/// Request field BusinessAccount_Tax_Exempt.
		[JsonPropertyName("BusinessAccount_Tax_Exempt")]
		public bool? BusinessAccountTaxExempt { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="businessAccount">BusinessAccount</param>
		/// </summary>
		public BusinessAccountUpdateRequest(BaseClient client = null, BusinessAccount businessAccount = null) :
			base(client)
		{
			Function = "BusinessAccount_Update";
			if (businessAccount != null) {
				if (businessAccount.Id > 0)
				{
					BusinessAccountId = businessAccount.Id;
				}

				BusinessAccountTitle = businessAccount.Title;
				BusinessAccountTaxExempt = businessAccount.TaxExempt;
			}
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
		/// Getter for BusinessAccount_Tax_Exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetBusinessAccountTaxExempt()
		{
			return BusinessAccountTaxExempt;
		}

		/// <summary>
		/// Setter for BusinessAccount_ID.
		/// <param name="value">int</param>
		/// <returns>BusinessAccountUpdateRequest</returns>
		/// </summary>
		public BusinessAccountUpdateRequest SetBusinessAccountId(int? value)
		{
			BusinessAccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_BusinessAccount.
		/// <param name="value">int</param>
		/// <returns>BusinessAccountUpdateRequest</returns>
		/// </summary>
		public BusinessAccountUpdateRequest SetEditBusinessAccount(int? value)
		{
			EditBusinessAccount = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountUpdateRequest</returns>
		/// </summary>
		public BusinessAccountUpdateRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Tax_Exempt.
		/// <param name="value">bool</param>
		/// <returns>BusinessAccountUpdateRequest</returns>
		/// </summary>
		public BusinessAccountUpdateRequest SetBusinessAccountTaxExempt(bool? value)
		{
			BusinessAccountTaxExempt = value;
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

			if (BusinessAccountTitle != null && BusinessAccountTitle.Length > 0)
			{
				writer.WriteString("BusinessAccount_Title", BusinessAccountTitle);
			}

			if (BusinessAccountTaxExempt.HasValue)
			{
				writer.WriteBoolean("BusinessAccount_Tax_Exempt", BusinessAccountTaxExempt.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<BusinessAccountUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BusinessAccountUpdateResponse</returns>
		/// </summary>
		public new BusinessAccountUpdateResponse Send()
		{
			return Client.SendRequestAsync<BusinessAccountUpdateRequest, BusinessAccountUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BusinessAccountUpdateResponse></returns>
		/// </summary>
		public new async Task<BusinessAccountUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BusinessAccountUpdateRequest, BusinessAccountUpdateResponse>(this);
		}
	}
}
