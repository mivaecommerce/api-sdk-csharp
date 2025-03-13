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
	/// API Response for CopyProductRulesCustomFieldList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copyproductrulescustomfieldlist_load_query</see>
	/// </summary>
	public class CopyProductRulesCustomFieldListLoadQueryResponse : ListQueryResponse<CopyProductRulesCustomField>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CopyProductRulesCustomFieldListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for copyProductRulesCustomFields.
		/// <returns>CopyProductRulesCustomField[]</returns>
		/// </summary>
		public List<CopyProductRulesCustomField> GetCopyProductRulesCustomFields()
		{
			return Data.Data;
		}
	}
}