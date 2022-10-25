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
	/// API Response for AttributeTemplate_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplate_insert</see>
	/// </summary>
	public class AttributeTemplateInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public AttributeTemplate Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for attributeTemplate.
		/// <returns>AttributeTemplate</returns>
		/// </summary>
		public AttributeTemplate GetAttributeTemplate()
		{
			return Data;
		}
	}
}