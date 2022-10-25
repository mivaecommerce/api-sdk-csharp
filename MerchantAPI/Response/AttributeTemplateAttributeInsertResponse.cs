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
	/// API Response for AttributeTemplateAttribute_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateattribute_insert</see>
	/// </summary>
	public class AttributeTemplateAttributeInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public AttributeTemplateAttribute Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateAttributeInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for attributeTemplateAttribute.
		/// <returns>AttributeTemplateAttribute</returns>
		/// </summary>
		public AttributeTemplateAttribute GetAttributeTemplateAttribute()
		{
			return Data;
		}
	}
}