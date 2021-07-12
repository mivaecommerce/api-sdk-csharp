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
	/// API Response for ProductKit_Generate_Variants.
	/// <see>https://docs.miva.com/json-api/functions/productkit_generate_variants</see>
	/// </summary>
	public class ProductKitGenerateVariantsResponse : Response
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ProductKitGenerateVariantsResponse() :
			base()
		{
		}
	}
}