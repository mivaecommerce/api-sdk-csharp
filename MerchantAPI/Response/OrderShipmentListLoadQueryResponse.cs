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
	/// API Response for OrderShipmentList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/ordershipmentlist_load_query</see>
	/// </summary>
	public class OrderShipmentListLoadQueryResponse : ListQueryResponse<OrderShipment>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public OrderShipmentListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderShipments.
		/// <returns>OrderShipment[]</returns>
		/// </summary>
		public List<OrderShipment> GetOrderShipments()
		{
			return Data.Data;
		}
	}
}