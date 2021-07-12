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
	/// API Response for PriceGroupExcludedProduct_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupexcludedproduct_update_assigned</see>
	/// </summary>
	public class PriceGroupExcludedProductUpdateAssignedResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<PriceGroupProduct> Data { get; set; } = new List<PriceGroupProduct>();

		/// <summary>
		///  Constructor
		/// </summary>
		public PriceGroupExcludedProductUpdateAssignedResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for priceGroupProducts.
		/// <returns>PriceGroupProduct[]</returns>
		/// </summary>
		public List<PriceGroupProduct> GetPriceGroupProducts()
		{
			return Data;
		}
	}
}