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
	/// API Response for AllOrderPaymentList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/allorderpaymentlist_load_query</see>
	/// </summary>
	public class AllOrderPaymentListLoadQueryResponse : ListQueryResponse<AllOrderPayment>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public AllOrderPaymentListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for allOrderPayments.
		/// <returns>AllOrderPayment[]</returns>
		/// </summary>
		public List<AllOrderPayment> GetAllOrderPayments()
		{
			return Data.Data;
		}
	}
}