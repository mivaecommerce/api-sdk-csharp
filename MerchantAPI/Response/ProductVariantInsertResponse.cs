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
	/// API Response for ProductVariant_Insert.
	/// <see>https://docs.miva.com/json-api/functions/productvariant_insert</see>
	/// </summary>
	public class ProductVariantInsertResponse : Response
	{
		[JsonPropertyName("data")]
		public DataFields Data { get; set; }

		/// Non model data container containing the response fields in the data propery
		public struct DataFields
		{
			/// Response field product_id.
			[JsonPropertyName("product_id")]
			public int ProductId { get; set; }
			/// Response field variant_id.
			[JsonPropertyName("variant_id")]
			public int VariantId { get; set; }
		}

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductVariantInsertResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return Data.ProductId;
		}

		/// <summary>
		/// Getter for variant_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetVariantId()
		{
			return Data.VariantId;
		}
	}
}