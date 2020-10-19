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
	/// API Response for MivaMerchantVersion.
	/// <see>https://docs.miva.com/json-api/functions/mivamerchantversion</see>
	/// </summary>
	public class MivaMerchantVersionResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public MerchantVersion Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public MivaMerchantVersionResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for merchantVersion.
		/// <returns>MerchantVersion</returns>
		/// </summary>
		public MerchantVersion GetMerchantVersion()
		{
			return Data;
		}
	}
}