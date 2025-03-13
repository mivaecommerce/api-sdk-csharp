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
	/// API Response for AvailabilityGroupBusinessAccountList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupbusinessaccountlist_load_query</see>
	/// </summary>
	public class AvailabilityGroupBusinessAccountListLoadQueryResponse : ListQueryResponse<AvailabilityGroupBusinessAccount>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupBusinessAccountListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for availabilityGroupBusinessAccounts.
		/// <returns>AvailabilityGroupBusinessAccount[]</returns>
		/// </summary>
		public List<AvailabilityGroupBusinessAccount> GetAvailabilityGroupBusinessAccounts()
		{
			return Data.Data;
		}
	}
}