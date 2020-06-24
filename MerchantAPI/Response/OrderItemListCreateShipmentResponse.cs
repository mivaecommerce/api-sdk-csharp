/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// API Response for OrderItemList_CreateShipment.
	/// <see>https://docs.miva.com/json-api/functions/orderitemlist_createshipment</see>
	/// </summary>
	public class OrderItemListCreateShipmentResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public OrderShipment Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderItemListCreateShipmentResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderShipment.
		/// <returns>OrderShipment</returns>
		/// </summary>
		public OrderShipment GetOrderShipment()
		{
			return Data;
		}
	}
}