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
	/// API Response for OrderPriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/orderpricegrouplist_load_query</see>
	/// </summary>
	public class OrderPriceGroupListLoadQueryResponse : ListQueryResponse<OrderPriceGroup>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public OrderPriceGroupListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for orderPriceGroups.
		/// <returns>OrderPriceGroup[]</returns>
		/// </summary>
		public List<OrderPriceGroup> GetOrderPriceGroups()
		{
			return Data.Data;
		}
	}
}