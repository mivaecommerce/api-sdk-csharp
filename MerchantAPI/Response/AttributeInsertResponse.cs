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
	/// API Response for Attribute_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attribute_insert</see>
	/// </summary>
	public class AttributeInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public ProductAttribute Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productAttribute.
		/// <returns>ProductAttribute</returns>
		/// </summary>
		public ProductAttribute GetProductAttribute()
		{
			return Data;
		}
	}
}