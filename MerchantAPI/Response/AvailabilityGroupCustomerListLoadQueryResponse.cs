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
	/// API Response for AvailabilityGroupCustomerList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupcustomerlist_load_query</see>
	/// </summary>
	public class AvailabilityGroupCustomerListLoadQueryResponse : ListQueryResponse<AvailabilityGroupCustomer>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupCustomerListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for availabilityGroupCustomers.
		/// <returns>AvailabilityGroupCustomer[]</returns>
		/// </summary>
		public List<AvailabilityGroupCustomer> GetAvailabilityGroupCustomers()
		{
			return Data.Data;
		}
	}
}