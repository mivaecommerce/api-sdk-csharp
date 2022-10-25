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
	public class OrderItemOptionDiscount : Model
	{
		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property LineId - int</value>
		[JsonPropertyName("line_id")]
		public int LineId { get; set; }

		/// <value>Property AttributeId - int</value>
		[JsonPropertyName("attr_id")]
		public int AttributeId { get; set; }

		/// <value>Property AttributeTemplateAttributeId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int AttributeTemplateAttributeId { get; set; }

		/// <value>Property PriceGroupId - int</value>
		[JsonPropertyName("pgrp_id")]
		public int PriceGroupId { get; set; }

		/// <value>Property Display - bool</value>
		[JsonPropertyName("display")]
		public bool Display { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property Discount - float</value>
		[JsonPropertyName("discount")]
		public float Discount { get; set; }

		/// <summary>
		/// Getter for order_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for line_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetLineId()
		{
			return LineId;
		}

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for attmpat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeTemplateAttributeId()
		{
			return AttributeTemplateAttributeId;
		}

		/// <summary>
		/// Getter for pgrp_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPriceGroupId()
		{
			return PriceGroupId;
		}

		/// <summary>
		/// Getter for display.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetDisplay()
		{
			return Display;
		}

		/// <summary>
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for discount.
		/// <returns>float</returns>
		/// </summary>
		public float GetDiscount()
		{
			return Discount;
		}
	}
}
