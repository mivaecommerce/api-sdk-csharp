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
	/// API Response for CustomerPriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customerpricegrouplist_load_query</see>
	/// </summary>
	public class CustomerPriceGroupListLoadQueryResponse : ListQueryResponse<CustomerPriceGroup>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerPriceGroupListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customerPriceGroups.
		/// <returns>CustomerPriceGroup[]</returns>
		/// </summary>
		public List<CustomerPriceGroup> GetCustomerPriceGroups()
		{
			return Data.Data;
		}
	}
}