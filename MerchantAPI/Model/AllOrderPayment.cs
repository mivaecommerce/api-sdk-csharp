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
	public class AllOrderPayment : Order
	{
		/// <value>Property OrderPayment - OrderPayment</value>
		[JsonPropertyName("orderpayment")]
		public OrderPayment OrderPayment { get; set; }

		/// <summary>
		/// Getter for orderpayment.
		/// <returns>OrderPayment</returns>
		/// </summary>
		public OrderPayment GetOrderPayment()
		{
			return OrderPayment;
		}
	}
}
