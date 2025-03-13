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
	/// API Response for AvailabilityGroupShippingMethodList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupshippingmethodlist_load_query</see>
	/// </summary>
	public class AvailabilityGroupShippingMethodListLoadQueryResponse : ListQueryResponse<AvailabilityGroupShippingMethod>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupShippingMethodListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for availabilityGroupShippingMethods.
		/// <returns>AvailabilityGroupShippingMethod[]</returns>
		/// </summary>
		public List<AvailabilityGroupShippingMethod> GetAvailabilityGroupShippingMethods()
		{
			return Data.Data;
		}
	}
}