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
	/// API Response for CopyProductRules_Insert.
	/// <see>https://docs.miva.com/json-api/functions/copyproductrules_insert</see>
	/// </summary>
	public class CopyProductRulesInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public CopyProductRule Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CopyProductRulesInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for copyProductRule.
		/// <returns>CopyProductRule</returns>
		/// </summary>
		public CopyProductRule GetCopyProductRule()
		{
			return Data;
		}
	}
}