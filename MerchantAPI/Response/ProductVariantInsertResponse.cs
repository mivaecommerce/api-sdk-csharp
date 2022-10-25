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
		/// The response model
		[JsonPropertyName("data")]
		public ProductVariant Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductVariantInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productVariant.
		/// <returns>ProductVariant</returns>
		/// </summary>
		public ProductVariant GetProductVariant()
		{
			return Data;
		}
	}
}