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
	/// Handles API Request CustomerAddress_Update_Residential.
	/// <see>https://docs.miva.com/json-api/functions/customeraddress_update_residential</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerAddressUpdateResidentialRequest : Request
	{
		/// Request field Address_ID.
		[JsonPropertyName("Address_ID")]
		public int? AddressId { get; set; }

		/// Request field CustomerAddress_ID.
		[JsonPropertyName("CustomerAddress_ID")]
		public int? CustomerAddressId { get; set; }

		/// Request field Residential.
		[JsonPropertyName("Residential")]
		public bool? Residential { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customerAddress">CustomerAddress</param>
		/// </summary>
		public CustomerAddressUpdateResidentialRequest(BaseClient client = null, CustomerAddress customerAddress = null) :
			base(client)
		{
			Function = "CustomerAddress_Update_Residential";
			if (customerAddress != null) {
				if (customerAddress.Id > 0)
				{
					AddressId = customerAddress.Id;
				}
			}
		}

		/// <summary>
		/// Getter for Address_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAddressId()
		{
			return AddressId;
		}

		/// <summary>
		/// Getter for CustomerAddress_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerAddressId()
		{
			return CustomerAddressId;
		}

		/// <summary>
		/// Getter for Residential.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetResidential()
		{
			return Residential;
		}

		/// <summary>
		/// Setter for Address_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressUpdateResidentialRequest</returns>
		/// </summary>
		public CustomerAddressUpdateResidentialRequest SetAddressId(int? value)
		{
			AddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerAddress_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerAddressUpdateResidentialRequest</returns>
		/// </summary>
		public CustomerAddressUpdateResidentialRequest SetCustomerAddressId(int? value)
		{
			CustomerAddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for Residential.
		/// <param name="value">bool</param>
		/// <returns>CustomerAddressUpdateResidentialRequest</returns>
		/// </summary>
		public CustomerAddressUpdateResidentialRequest SetResidential(bool? value)
		{
			Residential = value;
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

			if (AddressId.HasValue)
			{
				writer.WriteNumber("Address_ID", AddressId.Value);
			}
			else if (CustomerAddressId.HasValue)
			{
				writer.WriteNumber("CustomerAddress_ID", CustomerAddressId.Value);
			}

			if (Residential.HasValue)
			{
				writer.WriteBoolean("Residential", Residential.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CustomerAddressUpdateResidentialResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerAddressUpdateResidentialResponse</returns>
		/// </summary>
		public new CustomerAddressUpdateResidentialResponse Send()
		{
			return Client.SendRequestAsync<CustomerAddressUpdateResidentialRequest, CustomerAddressUpdateResidentialResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerAddressUpdateResidentialResponse></returns>
		/// </summary>
		public new async Task<CustomerAddressUpdateResidentialResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerAddressUpdateResidentialRequest, CustomerAddressUpdateResidentialResponse>(this);
		}
	}
}
