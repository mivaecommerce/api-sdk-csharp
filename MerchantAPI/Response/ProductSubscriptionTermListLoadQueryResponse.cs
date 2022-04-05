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
	/// API Response for ProductSubscriptionTermList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productsubscriptiontermlist_load_query</see>
	/// </summary>
	public class ProductSubscriptionTermListLoadQueryResponse : ListQueryResponse<ProductSubscriptionTerm>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductSubscriptionTermListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for productSubscriptionTerms.
		/// <returns>ProductSubscriptionTerm[]</returns>
		/// </summary>
		public List<ProductSubscriptionTerm> GetProductSubscriptionTerms()
		{
			return Data.Data;
		}
	}
}