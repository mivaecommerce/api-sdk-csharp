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
	/// API Response for Category_Insert.
	/// <see>https://docs.miva.com/json-api/functions/category_insert</see>
	/// </summary>
	public class CategoryInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Category Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public CategoryInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for category.
		/// <returns>Category</returns>
		/// </summary>
		public Category GetCategory()
		{
			return Data;
		}
	}
}