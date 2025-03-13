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
	/// API Response for Product_Copy.
	/// <see>https://docs.miva.com/json-api/functions/product_copy</see>
	/// </summary>
	public class ProductCopyResponse : Response
	{
		/// Response field completed.
		[JsonPropertyName("completed")]
		public bool Completed { get; set; }

		/// Response field product_copy_session_id.
		[JsonPropertyName("product_copy_session_id")]
		public String ProductCopySessionId { get; set; }

		/// The response model
		[JsonPropertyName("data")]
		public Product Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ProductCopyResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for completed.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCompleted()
		{
			return Completed;
		}

		/// <summary>
		/// Getter for product_copy_session_id.
		/// <returns>string</returns>
		/// </summary>
		public String GetProductCopySessionId()
		{
			return ProductCopySessionId;
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