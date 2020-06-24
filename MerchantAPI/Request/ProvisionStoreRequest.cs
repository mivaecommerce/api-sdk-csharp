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
	/// Handles API Request Provision_Store.
	/// <see>https://docs.miva.com/json-api/functions/provision_store</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProvisionStoreRequest : Request
	{
		/// Request field XML.
		[JsonPropertyName("XML")]
		public String Xml { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// </summary>
		public ProvisionStoreRequest(Client client = null) :
			base(client)
		{
			Function = "Provision_Store";
		}

		/// <summary>
		/// Getter for XML.
		/// <returns>String</returns>
		/// </summary>
		public String GetXml()
		{
			return Xml;
		}

		/// <summary>
		/// Setter for XML.
		/// <param name="value">String</param>
		/// <returns>ProvisionStoreRequest</returns>
		/// </summary>
		public ProvisionStoreRequest SetXml(String value)
		{
			Xml = value;
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

			writer.WriteString("XML", Xml);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProvisionStoreResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProvisionStoreResponse</returns>
		/// </summary>
		public new ProvisionStoreResponse Send()
		{
			return Client.SendRequestAsync<ProvisionStoreRequest, ProvisionStoreResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProvisionStoreResponse></returns>
		/// </summary>
		public new async Task<ProvisionStoreResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProvisionStoreRequest, ProvisionStoreResponse>(this);
		}
	}
}
