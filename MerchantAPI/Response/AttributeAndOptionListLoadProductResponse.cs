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
	/// API Response for AttributeAndOptionList_Load_Product.
	/// <see>https://docs.miva.com/json-api/functions/attributeandoptionlist_load_product</see>
	/// </summary>
	public class AttributeAndOptionListLoadProductResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<ProductAttribute> Data { get; set; } = new List<ProductAttribute>();

		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeAndOptionListLoadProductResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productAttributes.
		/// <returns>ProductAttribute[]</returns>
		/// </summary>
		public List<ProductAttribute> GetProductAttributes()
		{
			return Data;
		}
	}
}