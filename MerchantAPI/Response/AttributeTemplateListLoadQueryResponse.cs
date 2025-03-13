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
	/// API Response for AttributeTemplateList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplatelist_load_query</see>
	/// </summary>
	public class AttributeTemplateListLoadQueryResponse : ListQueryResponse<AttributeTemplate>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AttributeTemplateListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for attributeTemplates.
		/// <returns>AttributeTemplate[]</returns>
		/// </summary>
		public List<AttributeTemplate> GetAttributeTemplates()
		{
			return Data.Data;
		}
	}
}