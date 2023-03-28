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
	public class ProductSubscriptionSettings : Model
	{
		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property Enabled - bool</value>
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }

		/// <value>Property Mandatory - bool</value>
		[JsonPropertyName("mandatory")]
		public bool Mandatory { get; set; }

		/// <value>Property CanCancel - bool</value>
		[JsonPropertyName("can_cancel")]
		public bool CanCancel { get; set; }

		/// <value>Property CancelMinimumRequiredOrders - int</value>
		[JsonPropertyName("cncl_min")]
		public int CancelMinimumRequiredOrders { get; set; }

		/// <value>Property CanChangeQuantities - bool</value>
		[JsonPropertyName("can_qty")]
		public bool CanChangeQuantities { get; set; }

		/// <value>Property QuantitiesMinimumRequiredOrders - int</value>
		[JsonPropertyName("qty_min")]
		public int QuantitiesMinimumRequiredOrders { get; set; }

		/// <value>Property CanChangeTerm - bool</value>
		[JsonPropertyName("can_term")]
		public bool CanChangeTerm { get; set; }

		/// <value>Property TermMinimumRequiredOrders - int</value>
		[JsonPropertyName("term_min")]
		public int TermMinimumRequiredOrders { get; set; }

		/// <value>Property CanChangeNextDeliveryDate - bool</value>
		[JsonPropertyName("can_date")]
		public bool CanChangeNextDeliveryDate { get; set; }

		/// <value>Property NextDeliveryDateMinimumRequiredOrders - int</value>
		[JsonPropertyName("date_min")]
		public int NextDeliveryDateMinimumRequiredOrders { get; set; }

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for enabled.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetEnabled()
		{
			return Enabled;
		}

		/// <summary>
		/// Getter for mandatory.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetMandatory()
		{
			return Mandatory;
		}

		/// <summary>
		/// Getter for can_cancel.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCanCancel()
		{
			return CanCancel;
		}

		/// <summary>
		/// Getter for cncl_min.
		/// <returns>int</returns>
		/// </summary>
		public int GetCancelMinimumRequiredOrders()
		{
			return CancelMinimumRequiredOrders;
		}

		/// <summary>
		/// Getter for can_qty.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCanChangeQuantities()
		{
			return CanChangeQuantities;
		}

		/// <summary>
		/// Getter for qty_min.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantitiesMinimumRequiredOrders()
		{
			return QuantitiesMinimumRequiredOrders;
		}

		/// <summary>
		/// Getter for can_term.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCanChangeTerm()
		{
			return CanChangeTerm;
		}

		/// <summary>
		/// Getter for term_min.
		/// <returns>int</returns>
		/// </summary>
		public int GetTermMinimumRequiredOrders()
		{
			return TermMinimumRequiredOrders;
		}

		/// <summary>
		/// Getter for can_date.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCanChangeNextDeliveryDate()
		{
			return CanChangeNextDeliveryDate;
		}

		/// <summary>
		/// Getter for date_min.
		/// <returns>int</returns>
		/// </summary>
		public int GetNextDeliveryDateMinimumRequiredOrders()
		{
			return NextDeliveryDateMinimumRequiredOrders;
		}
	}
}
