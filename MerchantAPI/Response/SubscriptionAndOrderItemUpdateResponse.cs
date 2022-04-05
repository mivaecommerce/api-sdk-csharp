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
	/// API Response for SubscriptionAndOrderItem_Update.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionandorderitem_update</see>
	/// </summary>
	public class SubscriptionAndOrderItemUpdateResponse : Response
	{
		/// Response field total.
		[JsonPropertyName("total")]
		public float Total { get; set; }

		/// Response field formatted_total.
		[JsonPropertyName("formatted_total")]
		public String FormattedTotal { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public SubscriptionAndOrderItemUpdateResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for total.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotal()
		{
			return Total;
		}

		/// <summary>
		/// Getter for formatted_total.
		/// <returns>string</returns>
		/// </summary>
		public String GetFormattedTotal()
		{
			return FormattedTotal;
		}
	}
}