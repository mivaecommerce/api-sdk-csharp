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
	/// API Response for AttributeTemplateOption_Insert.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateoption_insert</see>
	/// </summary>
	public class AttributeTemplateOptionInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public AttributeTemplateOption Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateOptionInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for attributeTemplateOption.
		/// <returns>AttributeTemplateOption</returns>
		/// </summary>
		public AttributeTemplateOption GetAttributeTemplateOption()
		{
			return Data;
		}
	}
}