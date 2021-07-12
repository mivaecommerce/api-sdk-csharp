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
	/// API Response for AvailabilityGroupCategoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupcategorylist_load_query</see>
	/// </summary>
	public class AvailabilityGroupCategoryListLoadQueryResponse : ListQueryResponse<AvailabilityGroupCategory>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupCategoryListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for availabilityGroupCategories.
		/// <returns>AvailabilityGroupCategory[]</returns>
		/// </summary>
		public List<AvailabilityGroupCategory> GetAvailabilityGroupCategories()
		{
			return Data.Data;
		}
	}
}