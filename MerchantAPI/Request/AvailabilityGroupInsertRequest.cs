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
	/// Handles API Request AvailabilityGroup_Insert.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroup_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupInsertRequest : Request
	{
		/// Request field AvailabilityGroup_Name.
		[JsonPropertyName("AvailabilityGroup_Name")]
		public String AvailabilityGroupName { get; set; }

		/// Request field AvailabilityGroup_Tax_Exempt.
		[JsonPropertyName("AvailabilityGroup_Tax_Exempt")]
		public bool? AvailabilityGroupTaxExempt { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public AvailabilityGroupInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "AvailabilityGroup_Insert";
		}

		/// <summary>
		/// Getter for AvailabilityGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetAvailabilityGroupName()
		{
			return AvailabilityGroupName;
		}

		/// <summary>
		/// Getter for AvailabilityGroup_Tax_Exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAvailabilityGroupTaxExempt()
		{
			return AvailabilityGroupTaxExempt;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupInsertRequest</returns>
		/// </summary>
		public AvailabilityGroupInsertRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Tax_Exempt.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupInsertRequest</returns>
		/// </summary>
		public AvailabilityGroupInsertRequest SetAvailabilityGroupTaxExempt(bool? value)
		{
			AvailabilityGroupTaxExempt = value;
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

			writer.WriteString("AvailabilityGroup_Name", AvailabilityGroupName);

			if (AvailabilityGroupTaxExempt.HasValue)
			{
				writer.WriteBoolean("AvailabilityGroup_Tax_Exempt", AvailabilityGroupTaxExempt.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AvailabilityGroupInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupInsertResponse</returns>
		/// </summary>
		public new AvailabilityGroupInsertResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupInsertRequest, AvailabilityGroupInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupInsertResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupInsertRequest, AvailabilityGroupInsertResponse>(this);
		}
	}
}
