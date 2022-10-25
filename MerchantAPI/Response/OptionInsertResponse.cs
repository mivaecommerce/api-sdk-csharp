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
	/// API Response for Option_Insert.
	/// <see>https://docs.miva.com/json-api/functions/option_insert</see>
	/// </summary>
	public class OptionInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public ProductOption Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public OptionInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productOption.
		/// <returns>ProductOption</returns>
		/// </summary>
		public ProductOption GetProductOption()
		{
			return Data;
		}
	}
}