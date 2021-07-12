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
	/// API Response for ProductVariant_Update.
	/// <see>https://docs.miva.com/json-api/functions/productvariant_update</see>
	/// </summary>
	public class ProductVariantUpdateResponse : Response
	{
		/// Response field product_id.
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// Response field variant_id.
		[JsonPropertyName("variant_id")]
		public int VariantId { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductVariantUpdateResponse() :
			base()
		{
		}

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
	}
}