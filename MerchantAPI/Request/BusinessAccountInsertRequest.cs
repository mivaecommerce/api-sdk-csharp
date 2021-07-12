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
	/// Handles API Request BusinessAccount_Insert.
	/// <see>https://docs.miva.com/json-api/functions/businessaccount_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class BusinessAccountInsertRequest : Request
	{
		/// Request field BusinessAccount_Title.
		[JsonPropertyName("BusinessAccount_Title")]
		public String BusinessAccountTitle { get; set; }

		/// Request field BusinessAccount_Tax_Exempt.
		[JsonPropertyName("BusinessAccount_Tax_Exempt")]
		public bool? BusinessAccountTaxExempt { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public BusinessAccountInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "BusinessAccount_Insert";
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
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>BusinessAccountInsertRequest</returns>
		/// </summary>
		public BusinessAccountInsertRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Tax_Exempt.
		/// <param name="value">bool</param>
		/// <returns>BusinessAccountInsertRequest</returns>
		/// </summary>
		public BusinessAccountInsertRequest SetBusinessAccountTaxExempt(bool? value)
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
			return JsonSerializer.Deserialize<BusinessAccountInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>BusinessAccountInsertResponse</returns>
		/// </summary>
		public new BusinessAccountInsertResponse Send()
		{
			return Client.SendRequestAsync<BusinessAccountInsertRequest, BusinessAccountInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<BusinessAccountInsertResponse></returns>
		/// </summary>
		public new async Task<BusinessAccountInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<BusinessAccountInsertRequest, BusinessAccountInsertResponse>(this);
		}
	}
}
