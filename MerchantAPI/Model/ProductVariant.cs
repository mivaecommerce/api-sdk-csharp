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
	public class ProductVariant : Model
	{
		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property VariantId - int</value>
		[JsonPropertyName("variant_id")]
		public int VariantId { get; set; }

		/// <value>Property Parts - List<ProductVariantPart></value>
		[JsonPropertyName("parts")]
		public List<ProductVariantPart> Parts { get; set; } = new List<ProductVariantPart>();

		/// <value>Property Dimensions - List<ProductVariantDimension></value>
		[JsonPropertyName("dimensions")]
		public List<ProductVariantDimension> Dimensions { get; set; } = new List<ProductVariantDimension>();

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for variant_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetVariantId()
		{
			return VariantId;
		}

		/// <summary>
		/// Getter for parts.
		/// <returns>List<ProductVariantPart></returns>
		/// </summary>
		public List<ProductVariantPart> GetParts()
		{
			return Parts;
		}

		/// <summary>
		/// Getter for dimensions.
		/// <returns>List<ProductVariantDimension></returns>
		/// </summary>
		public List<ProductVariantDimension> GetDimensions()
		{
			return Dimensions;
		}
	}
}
