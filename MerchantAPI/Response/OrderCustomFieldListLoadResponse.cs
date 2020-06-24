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
	/// API Response for OrderCustomFieldList_Load.
	/// <see>https://docs.miva.com/json-api/functions/ordercustomfieldlist_load</see>
	/// </summary>
	public class OrderCustomFieldListLoadResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<OrderCustomField> Data { get; set; } = new List<OrderCustomField>();

		/// <summary>
		///  Constructor
		/// </summary>
		public OrderCustomFieldListLoadResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for orderCustomFields.
		/// <returns>OrderCustomField[]</returns>
		/// </summary>
		public List<OrderCustomField> GetOrderCustomFields()
		{
			return Data;
		}
	}
}