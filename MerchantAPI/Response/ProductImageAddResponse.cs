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
	/// API Response for ProductImage_Add.
	/// <see>https://docs.miva.com/json-api/functions/productimage_add</see>
	/// </summary>
	public class ProductImageAddResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public ProductImageData Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductImageAddResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productImageData.
		/// <returns>ProductImageData</returns>
		/// </summary>
		public ProductImageData GetProductImageData()
		{
			return Data;
		}
	}
}