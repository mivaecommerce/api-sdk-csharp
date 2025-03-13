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
	/// API Response for SubscriptionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionlist_load_query</see>
	/// </summary>
	public class SubscriptionListLoadQueryResponse : ListQueryResponse<Subscription>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public SubscriptionListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for subscriptions.
		/// <returns>Subscription[]</returns>
		/// </summary>
		public List<Subscription> GetSubscriptions()
		{
			return Data.Data;
		}
	}
}