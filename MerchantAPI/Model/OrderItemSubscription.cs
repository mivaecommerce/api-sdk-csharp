/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MerchantAPI
{
	public class OrderItemSubscription : BaseSubscription
	{
		/// <value>Property Method - String</value>
		[JsonPropertyName("method")]
		public String Method { get; set; }

		/// <value>Property ProductSubscriptionTerm - ProductSubscriptionTerm</value>
		[JsonPropertyName("productsubscriptionterm")]
		public ProductSubscriptionTerm ProductSubscriptionTerm { get; set; }

		/// <value>Property Options - List<SubscriptionOption></value>
		[JsonPropertyName("options")]
		public List<SubscriptionOption> Options { get; set; } = new List<SubscriptionOption>();

		/// <summary>
		/// Getter for method.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethod()
		{
			return Method;
		}

		/// <summary>
		/// Getter for productsubscriptionterm.
		/// <returns>ProductSubscriptionTerm</returns>
		/// </summary>
		public ProductSubscriptionTerm GetProductSubscriptionTerm()
		{
			return ProductSubscriptionTerm;
		}

		/// <summary>
		/// Getter for options.
		/// <returns>List<SubscriptionOption></returns>
		/// </summary>
		public List<SubscriptionOption> GetOptions()
		{
			return Options;
		}
	}
}
