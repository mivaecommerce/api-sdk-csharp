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
	/// API Response for AvailabilityGroupProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupproductlist_load_query</see>
	/// </summary>
	public class AvailabilityGroupProductListLoadQueryResponse : ListQueryResponse<AvailabilityGroupProduct>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupProductListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for availabilityGroupProducts.
		/// <returns>AvailabilityGroupProduct[]</returns>
		/// </summary>
		public List<AvailabilityGroupProduct> GetAvailabilityGroupProducts()
		{
			return Data.Data;
		}
	}
}