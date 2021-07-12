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
	/// API Response for RelatedProduct_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/relatedproduct_update_assigned</see>
	/// </summary>
	public class RelatedProductUpdateAssignedResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<RelatedProduct> Data { get; set; } = new List<RelatedProduct>();

		/// <summary>
		///  Constructor
		/// </summary>
		public RelatedProductUpdateAssignedResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for relatedProducts.
		/// <returns>RelatedProduct[]</returns>
		/// </summary>
		public List<RelatedProduct> GetRelatedProducts()
		{
			return Data;
		}
	}
}