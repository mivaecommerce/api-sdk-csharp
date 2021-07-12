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
	/// API Response for OptionList_Load_Attribute.
	/// <see>https://docs.miva.com/json-api/functions/optionlist_load_attribute</see>
	/// </summary>
	public class OptionListLoadAttributeResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<ProductOption> Data { get; set; } = new List<ProductOption>();

		/// <summary>
		///  Constructor
		/// </summary>
		public OptionListLoadAttributeResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for productOptions.
		/// <returns>ProductOption[]</returns>
		/// </summary>
		public List<ProductOption> GetProductOptions()
		{
			return Data;
		}
	}
}