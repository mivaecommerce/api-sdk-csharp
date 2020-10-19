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
	/// API Response for OrderItemList_CreateReturn.
	/// <see>https://docs.miva.com/json-api/functions/orderitemlist_createreturn</see>
	/// </summary>
	public class OrderItemListCreateReturnResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public OrderReturn Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderItemListCreateReturnResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderReturn.
		/// <returns>OrderReturn</returns>
		/// </summary>
		public OrderReturn GetOrderReturn()
		{
			return Data;
		}
	}
}