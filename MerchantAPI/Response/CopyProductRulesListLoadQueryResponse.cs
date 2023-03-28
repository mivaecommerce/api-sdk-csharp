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
	/// API Response for CopyProductRulesList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copyproductruleslist_load_query</see>
	/// </summary>
	public class CopyProductRulesListLoadQueryResponse : ListQueryResponse<CopyProductRule>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CopyProductRulesListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for copyProductRules.
		/// <returns>CopyProductRule[]</returns>
		/// </summary>
		public List<CopyProductRule> GetCopyProductRules()
		{
			return Data.Data;
		}
	}
}