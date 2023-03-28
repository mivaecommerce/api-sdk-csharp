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
	/// Handles API Request ProductList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/productlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductListLoadQueryRequest : ListQueryRequest
	{
		/// Enumeration ProductShow
		public enum ProductShow
		{
			All,
			Uncategorized,
			Active,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String ProductShowToString(ProductShow value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static ProductShow? ProductShowFromString(String value)
		{
			switch(value)
			{
				case "All": return ProductShow.All;
				case "Uncategorized": return ProductShow.Uncategorized;
				case "Active": return ProductShow.Active;
				default: return null;
			}
		}

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"code",
			"sku",
			"cancat_code",
			"page_code",
			"name",
			"thumbnail",
			"image",
			"price",
			"cost",
			"descrip",
			"weight",
			"taxable",
			"active",
			"page_title",
			"dt_created",
			"dt_updated",
			"category",
			"product_inventory"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"code",
			"sku",
			"cancat_code",
			"page_code",
			"name",
			"thumbnail",
			"image",
			"price",
			"cost",
			"descrip",
			"weight",
			"taxable",
			"active",
			"page_title",
			"dt_created",
			"dt_updated"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"descrip",
			"catcount",
			"cancat_code",
			"page_code",
			"product_inventory",
			"productinventorysettings",
			"attributes",
			"productimagedata",
			"categories",
			"productshippingrules",
			"relatedproducts",
			"uris",
			"url",
			"subscriptionsettings",
			"subscriptionterms"
		};

		/// The available custom fileters applicable to the request.
		override public String[] AvailableCustomFilters { get; } =
		{
			"Product_Show"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ProductListLoadQueryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "ProductList_Load_Query";
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
			return JsonSerializer.Deserialize<ProductListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductListLoadQueryResponse</returns>
		/// </summary>
		public new ProductListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<ProductListLoadQueryRequest, ProductListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<ProductListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductListLoadQueryRequest, ProductListLoadQueryResponse>(this);
		}
	}

	/// Enum Extensions
	public static class ProductListLoadQueryRequestExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this ProductListLoadQueryRequest.ProductShow e)
	    {
			switch(e)
			{
				case ProductListLoadQueryRequest.ProductShow.All: return "All";
				case ProductListLoadQueryRequest.ProductShow.Uncategorized: return "Uncategorized";
				case ProductListLoadQueryRequest.ProductShow.Active: return "Active";
			}
			return "";
	    
		}
	}
}
