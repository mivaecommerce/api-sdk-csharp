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
	/// API Response for AttributeTemplateAttributeList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateattributelist_load_query</see>
	/// </summary>
	public class AttributeTemplateAttributeListLoadQueryResponse : ListQueryResponse<AttributeTemplateAttribute>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateAttributeListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for attributeTemplateAttributes.
		/// <returns>AttributeTemplateAttribute[]</returns>
		/// </summary>
		public List<AttributeTemplateAttribute> GetAttributeTemplateAttributes()
		{
			return Data.Data;
		}
	}
}