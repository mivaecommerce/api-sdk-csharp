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
	public class ProductShippingRules : Model
	{
		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property OwnPackage - bool</value>
		[JsonPropertyName("ownpackage")]
		public bool OwnPackage { get; set; }

		/// <value>Property Width - float</value>
		[JsonPropertyName("width")]
		public float Width { get; set; }

		/// <value>Property Length - float</value>
		[JsonPropertyName("length")]
		public float Length { get; set; }

		/// <value>Property Height - float</value>
		[JsonPropertyName("height")]
		public float Height { get; set; }

		/// <value>Property LimitMethods - bool</value>
		[JsonPropertyName("limitmeths")]
		public bool LimitMethods { get; set; }

		/// <value>Property Methods - List<ProductShippingMethod></value>
		[JsonPropertyName("methods")]
		public List<ProductShippingMethod> Methods { get; set; } = new List<ProductShippingMethod>();

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for ownpackage.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetOwnPackage()
		{
			return OwnPackage;
		}

		/// <summary>
		/// Getter for width.
		/// <returns>float</returns>
		/// </summary>
		public float GetWidth()
		{
			return Width;
		}

		/// <summary>
		/// Getter for length.
		/// <returns>float</returns>
		/// </summary>
		public float GetLength()
		{
			return Length;
		}

		/// <summary>
		/// Getter for height.
		/// <returns>float</returns>
		/// </summary>
		public float GetHeight()
		{
			return Height;
		}

		/// <summary>
		/// Getter for limitmeths.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetLimitMethods()
		{
			return LimitMethods;
		}

		/// <summary>
		/// Getter for methods.
		/// <returns>List<ProductShippingMethod></returns>
		/// </summary>
		public List<ProductShippingMethod> GetMethods()
		{
			return Methods;
		}
	}
}
