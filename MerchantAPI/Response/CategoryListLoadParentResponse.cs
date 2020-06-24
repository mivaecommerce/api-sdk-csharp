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
	/// API Response for CategoryList_Load_Parent.
	/// <see>https://docs.miva.com/json-api/functions/categorylist_load_parent</see>
	/// </summary>
	public class CategoryListLoadParentResponse : Response
	{
		/// The response model collection
		[JsonPropertyName("data")]
		public List<Category> Data { get; set; } = new List<Category>();

		/// <summary>
		///  Constructor
		/// </summary>
		public CategoryListLoadParentResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for categories.
		/// <returns>Category[]</returns>
		/// </summary>
		public List<Category> GetCategories()
		{
			return Data;
		}
	}
}