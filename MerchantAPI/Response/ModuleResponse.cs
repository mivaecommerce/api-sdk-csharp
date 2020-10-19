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
	/// API Response for Module.
	/// <see>https://docs.miva.com/json-api/functions/module</see>
	/// </summary>
	public class ModuleResponse : Response
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public ModuleResponse() :
			base()
		{
		}

		[JsonPropertyName("data")]
		public VariableValue Data { get; set; } = new VariableValue();

		/// <summary>
		/// Get the underlying data result
		/// </summary>
		/// <returns></returns>
		public VariableValue GetData()
		{
			return Data;
		}
	}
}