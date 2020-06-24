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
	public class ProductInventoryAdjustment : Model
	{
		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property ProductCode - String</value>
		[JsonPropertyName("product_code")]
		public String ProductCode { get; set; }

		/// <value>Property ProductSku - String</value>
		[JsonPropertyName("product_sku")]
		public String ProductSku { get; set; }

		/// <value>Property Adjustment - float</value>
		[JsonPropertyName("adjustment")]
		public float Adjustment { get; set; }

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for product_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
		}

		/// <summary>
		/// Getter for product_sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for adjustment.
		/// <returns>float</returns>
		/// </summary>
		public float GetAdjustment()
		{
			return Adjustment;
		}

		/// <summary>
		/// Setter for product_id.
		/// <param name="value">int</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
		public ProductInventoryAdjustment SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for product_code.
		/// <param name="value">String</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
		public ProductInventoryAdjustment SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for product_sku.
		/// <param name="value">String</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
		public ProductInventoryAdjustment SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for adjustment.
		/// <param name="value">float</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
	   public ProductInventoryAdjustment SetAdjustment(float value)
	   {
			Adjustment = value;
			return this;
		}

		/// <summary>
		/// Setter for adjustment.
		/// <param name="value">double</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
	   public ProductInventoryAdjustment SetAdjustment(double value)
	   {
			Adjustment = (float) value;
			return this;
		}
	}
}
