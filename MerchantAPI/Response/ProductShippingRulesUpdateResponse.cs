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
	/// API Response for ProductShippingRules_Update.
	/// <see>https://docs.miva.com/json-api/functions/productshippingrules_update</see>
	/// </summary>
	public class ProductShippingRulesUpdateResponse : Response
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductShippingRulesUpdateResponse() :
			base()
		{
		}
	}
}