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
	/// API Response for CustomerAddressList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customeraddresslist_load_query</see>
	/// </summary>
	public class CustomerAddressListLoadQueryResponse : ListQueryResponse<CustomerAddress>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerAddressListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customerAddresses.
		/// <returns>CustomerAddress[]</returns>
		/// </summary>
		public List<CustomerAddress> GetCustomerAddresses()
		{
			return Data.Data;
		}
	}
}