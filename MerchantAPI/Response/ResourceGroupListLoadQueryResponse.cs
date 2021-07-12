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
	/// API Response for ResourceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/resourcegrouplist_load_query</see>
	/// </summary>
	public class ResourceGroupListLoadQueryResponse : ListQueryResponse<ResourceGroup>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ResourceGroupListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for resourceGroups.
		/// <returns>ResourceGroup[]</returns>
		/// </summary>
		public List<ResourceGroup> GetResourceGroups()
		{
			return Data.Data;
		}
	}
}