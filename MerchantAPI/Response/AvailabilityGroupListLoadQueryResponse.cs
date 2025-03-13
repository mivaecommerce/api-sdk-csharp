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
	/// API Response for AvailabilityGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygrouplist_load_query</see>
	/// </summary>
	public class AvailabilityGroupListLoadQueryResponse : ListQueryResponse<AvailabilityGroup>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for availabilityGroups.
		/// <returns>AvailabilityGroup[]</returns>
		/// </summary>
		public List<AvailabilityGroup> GetAvailabilityGroups()
		{
			return Data.Data;
		}
	}
}