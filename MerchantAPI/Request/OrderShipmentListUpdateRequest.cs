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
	/// Handles API Request OrderShipmentList_Update.
	/// <see>https://docs.miva.com/json-api/functions/ordershipmentlist_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderShipmentListUpdateRequest : Request
	{
		/// Request field Shipment_Updates.
		[JsonPropertyName("Shipment_Updates")]
		public List<OrderShipmentUpdate> ShipmentUpdates { get; set; } = new List<OrderShipmentUpdate>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public OrderShipmentListUpdateRequest(BaseClient client = null) :
			base(client)
		{
			Function = "OrderShipmentList_Update";
		}

		/// <summary>
		/// Getter for Shipment_Updates.
		/// <returns>List<OrderShipmentUpdate></returns>
		/// </summary>
		public List<OrderShipmentUpdate> GetShipmentUpdates()
		{
			return ShipmentUpdates;
		}

		/// <summary>
		/// Add a OrderShipmentUpdate.
		/// - shipmentUpdate: OrderShipmentUpdate
		/// - Returns: Self
		/// </summary>
		public OrderShipmentListUpdateRequest AddShipmentUpdate(OrderShipmentUpdate shipmentUpdate)
		{
			ShipmentUpdates.Add(shipmentUpdate);
			return this;
		}

		/// <summary>
		/// Add an array of OrderShipmentUpdate.
		/// <param name="shipmentUpdates">List<OrderShipmentUpdate></param>
		/// <returns>OrderShipmentListUpdateRequest</returns>
		/// </summary>
		public OrderShipmentListUpdateRequest AddShipmentUpdates(List<OrderShipmentUpdate> shipmentUpdates)
		{
			foreach(OrderShipmentUpdate e in shipmentUpdates)
			{
				ShipmentUpdates.Add(e);
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

			writer.WritePropertyName("Shipment_Updates");
			JsonSerializer.Serialize(writer, this.ShipmentUpdates, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderShipmentListUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderShipmentListUpdateResponse</returns>
		/// </summary>
		public new OrderShipmentListUpdateResponse Send()
		{
			return Client.SendRequestAsync<OrderShipmentListUpdateRequest, OrderShipmentListUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderShipmentListUpdateResponse></returns>
		/// </summary>
		public new async Task<OrderShipmentListUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderShipmentListUpdateRequest, OrderShipmentListUpdateResponse>(this);
		}
	}
}
