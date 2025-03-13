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
	/// API Response for CustomerSubscriptionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customersubscriptionlist_load_query</see>
	/// </summary>
	public class CustomerSubscriptionListLoadQueryResponse : ListQueryResponse<CustomerSubscription>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CustomerSubscriptionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for customerSubscriptions.
		/// <returns>CustomerSubscription[]</returns>
		/// </summary>
		public List<CustomerSubscription> GetCustomerSubscriptions()
		{
			return Data.Data;
		}
	}
}