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
	/// API Response for CopyProductRulesModuleList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copyproductrulesmodulelist_load_query</see>
	/// </summary>
	public class CopyProductRulesModuleListLoadQueryResponse : ListQueryResponse<CopyProductRulesModule>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CopyProductRulesModuleListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for copyProductRulesModules.
		/// <returns>CopyProductRulesModule[]</returns>
		/// </summary>
		public List<CopyProductRulesModule> GetCopyProductRulesModules()
		{
			return Data.Data;
		}
	}
}