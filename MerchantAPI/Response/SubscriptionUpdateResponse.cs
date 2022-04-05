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
	/// API Response for Subscription_Update.
	/// <see>https://docs.miva.com/json-api/functions/subscription_update</see>
	/// </summary>
	public class SubscriptionUpdateResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Subscription Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public SubscriptionUpdateResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for subscription.
		/// <returns>Subscription</returns>
		/// </summary>
		public Subscription GetSubscription()
		{
			return Data;
		}
	}
}