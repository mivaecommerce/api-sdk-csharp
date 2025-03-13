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
	/// API Response for CopyPageRulesList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copypageruleslist_load_query</see>
	/// </summary>
	public class CopyPageRulesListLoadQueryResponse : ListQueryResponse<CopyPageRule>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CopyPageRulesListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for copyPageRules.
		/// <returns>CopyPageRule[]</returns>
		/// </summary>
		public List<CopyPageRule> GetCopyPageRules()
		{
			return Data.Data;
		}
	}
}