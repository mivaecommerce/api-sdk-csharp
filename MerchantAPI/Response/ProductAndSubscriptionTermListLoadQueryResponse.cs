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
	/// API Response for ProductAndSubscriptionTermList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productandsubscriptiontermlist_load_query</see>
	/// </summary>
	public class ProductAndSubscriptionTermListLoadQueryResponse : ListQueryResponse<ProductAndSubscriptionTerm>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductAndSubscriptionTermListLoadQueryResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productAndSubscriptionTerms.
		/// <returns>ProductAndSubscriptionTerm[]</returns>
		/// </summary>
		public List<ProductAndSubscriptionTerm> GetProductAndSubscriptionTerms()
		{
			return Data.Data;
		}
	}
}