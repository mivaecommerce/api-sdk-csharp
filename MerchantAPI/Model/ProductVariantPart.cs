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
	public class ProductVariantPart : Model
	{
		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property ProductCode - String</value>
		[JsonPropertyName("product_code")]
		public String ProductCode { get; set; }

		/// <value>Property ProductName - String</value>
		[JsonPropertyName("product_name")]
		public String ProductName { get; set; }

		/// <value>Property ProductSku - String</value>
		[JsonPropertyName("product_sku")]
		public String ProductSku { get; set; }

		/// <value>Property Quantity - int</value>
		[JsonPropertyName("quantity")]
		public int Quantity { get; set; }

		/// <value>Property Offset - int</value>
		[JsonPropertyName("offset")]
		public int Offset { get; set; }

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
		/// Getter for product_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductName()
		{
			return ProductName;
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
		/// Getter for quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for offset.
		/// <returns>int</returns>
		/// </summary>
		public int GetOffset()
		{
			return Offset;
		}
	}
}
