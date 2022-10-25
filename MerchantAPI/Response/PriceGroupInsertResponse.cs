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
	/// API Response for PriceGroup_Insert.
	/// <see>https://docs.miva.com/json-api/functions/pricegroup_insert</see>
	/// </summary>
	public class PriceGroupInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public PriceGroup Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for priceGroup.
		/// <returns>PriceGroup</returns>
		/// </summary>
		public PriceGroup GetPriceGroup()
		{
			return Data;
		}
	}
}