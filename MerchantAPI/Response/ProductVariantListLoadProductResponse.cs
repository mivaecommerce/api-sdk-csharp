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
	/// API Response for ProductVariantList_Load_Product.
	/// <see>https://docs.miva.com/json-api/functions/productvariantlist_load_product</see>
	/// </summary>
	public class ProductVariantListLoadProductResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<ProductVariant> Data { get; set; } = new List<ProductVariant>();

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductVariantListLoadProductResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productVariants.
		/// <returns>ProductVariant[]</returns>
		/// </summary>
		public List<ProductVariant> GetProductVariants()
		{
			return Data;
		}
	}
}