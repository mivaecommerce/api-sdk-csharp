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
	/// API Response for CopyPageRules_Insert.
	/// <see>https://docs.miva.com/json-api/functions/copypagerules_insert</see>
	/// </summary>
	public class CopyPageRulesInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public CopyPageRule Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CopyPageRulesInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for copyPageRule.
		/// <returns>CopyPageRule</returns>
		/// </summary>
		public CopyPageRule GetCopyPageRule()
		{
			return Data;
		}
	}
}