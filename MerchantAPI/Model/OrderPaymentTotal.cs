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
	public class OrderPaymentTotal : Model
	{
		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property TotalAuthorized - float</value>
		[JsonPropertyName("total_auth")]
		public float TotalAuthorized { get; set; }

		/// <value>Property FormattedTotalAuthorized - String</value>
		[JsonPropertyName("formatted_total_auth")]
		public String FormattedTotalAuthorized { get; set; }

		/// <value>Property TotalCaptured - float</value>
		[JsonPropertyName("total_capt")]
		public float TotalCaptured { get; set; }

		/// <value>Property FormattedTotalCaptured - String</value>
		[JsonPropertyName("formatted_total_capt")]
		public String FormattedTotalCaptured { get; set; }

		/// <value>Property TotalRefunded - float</value>
		[JsonPropertyName("total_rfnd")]
		public float TotalRefunded { get; set; }

		/// <value>Property FormattedTotalRefunded - String</value>
		[JsonPropertyName("formatted_total_rfnd")]
		public String FormattedTotalRefunded { get; set; }

		/// <value>Property NetCaptured - float</value>
		[JsonPropertyName("net_capt")]
		public float NetCaptured { get; set; }

		/// <value>Property FormattedNetCaptured - String</value>
		[JsonPropertyName("formatted_net_capt")]
		public String FormattedNetCaptured { get; set; }

		/// <summary>
		/// Getter for order_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for total_auth.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalAuthorized()
		{
			return TotalAuthorized;
		}

		/// <summary>
		/// Getter for formatted_total_auth.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalAuthorized()
		{
			return FormattedTotalAuthorized;
		}

		/// <summary>
		/// Getter for total_capt.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalCaptured()
		{
			return TotalCaptured;
		}

		/// <summary>
		/// Getter for formatted_total_capt.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalCaptured()
		{
			return FormattedTotalCaptured;
		}

		/// <summary>
		/// Getter for total_rfnd.
		/// <returns>float</returns>
		/// </summary>
		public float GetTotalRefunded()
		{
			return TotalRefunded;
		}

		/// <summary>
		/// Getter for formatted_total_rfnd.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTotalRefunded()
		{
			return FormattedTotalRefunded;
		}

		/// <summary>
		/// Getter for net_capt.
		/// <returns>float</returns>
		/// </summary>
		public float GetNetCaptured()
		{
			return NetCaptured;
		}

		/// <summary>
		/// Getter for formatted_net_capt.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedNetCaptured()
		{
			return FormattedNetCaptured;
		}
	}
}
