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
	/// API Response for AttributeTemplateOptionList_Load_Attribute.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateoptionlist_load_attribute</see>
	/// </summary>
	public class AttributeTemplateOptionListLoadAttributeResponse : ListQueryResponse<AttributeTemplateOption>
	{
		/// The response model collection
		[JsonPropertyName("data")]
		new public List<AttributeTemplateOption> Data { get; set; } = new List<AttributeTemplateOption>();

		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateOptionListLoadAttributeResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for attributeTemplateOptions.
		/// <returns>AttributeTemplateOption[]</returns>
		/// </summary>
		public List<AttributeTemplateOption> GetAttributeTemplateOptions()
		{
			return Data;
		}
	}
}