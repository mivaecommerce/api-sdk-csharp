/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request CategoryList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/categorylist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryListLoadQueryRequest : ListQueryRequest
	{
		/// Enumeration CategoryShow
		public enum CategoryShow
		{
			All,
			Active,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String CategoryShowToString(CategoryShow value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static CategoryShow? CategoryShowFromString(String value)
		{
			switch(value)
			{
				case "All": return CategoryShow.All;
				case "Active": return CategoryShow.Active;
				default: return null;
			}
		}

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"code",
			"name",
			"page_title",
			"parent_category",
			"page_code",
			"dt_created",
			"dt_updated",
			"depth"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"code",
			"name",
			"page_title",
			"active",
			"page_code",
			"parent_category",
			"disp_order",
			"dt_created",
			"dt_updated",
			"depth"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"uris",
			"url"
		};

		/// The available custom fileters applicable to the request.
		override public String[] AvailableCustomFilters { get; } =
		{
			"Category_Show"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CategoryListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CategoryList_Load_Query";
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryListLoadQueryResponse</returns>
		/// </summary>
		public new CategoryListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CategoryListLoadQueryRequest, CategoryListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CategoryListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryListLoadQueryRequest, CategoryListLoadQueryResponse>(this);
		}
	}

	/// Enum Extensions
	public static class CategoryListLoadQueryRequestExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this CategoryListLoadQueryRequest.CategoryShow e)
	    {
			switch(e)
			{
				case CategoryListLoadQueryRequest.CategoryShow.All: return "All";
				case CategoryListLoadQueryRequest.CategoryShow.Active: return "Active";
			}
			return "";
	    
		}
	}
}
