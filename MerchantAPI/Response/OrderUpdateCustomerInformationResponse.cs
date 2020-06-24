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
	/// API Response for Order_Update_Customer_Information.
	/// <see>https://docs.miva.com/json-api/functions/order_update_customer_information</see>
	/// </summary>
	public class OrderUpdateCustomerInformationResponse : Response
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public OrderUpdateCustomerInformationResponse() :
			base()
		{
		}
	}
}