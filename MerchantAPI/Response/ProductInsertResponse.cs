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
	/// API Response for Product_Insert.
	/// <see>https://docs.miva.com/json-api/functions/product_insert</see>
	/// </summary>
	public class ProductInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Product Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for product.
		/// <returns>Product</returns>
		/// </summary>
		public Product GetProduct()
		{
			return Data;
		}
	}
}