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

namespace MerchantAPI
{
	public class Uri : Model
	{
		/// Enumeration DestinationType
		public enum DestinationType
		{
			Screen,
			Page,
			Category,
			Product,
			Feed,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String DestinationTypeToString(DestinationType value)
		{
			switch(value)
			{
				case DestinationType.Screen: return "screen";
				case DestinationType.Page: return "page";
				case DestinationType.Category: return "category";
				case DestinationType.Product: return "product";
				case DestinationType.Feed: return "feed";
			}
			return "";
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property LinkUri - String</value>
		[JsonPropertyName("uri")]
		public String LinkUri { get; set; }

		/// <value>Property StoreId - int</value>
		[JsonPropertyName("store_id")]
		public int StoreId { get; set; }

		/// <value>Property Screen - String</value>
		[JsonPropertyName("screen")]
		public String Screen { get; set; }

		/// <value>Property PageId - int</value>
		[JsonPropertyName("page_id")]
		public int PageId { get; set; }

		/// <value>Property CategoryId - int</value>
		[JsonPropertyName("cat_id")]
		public int CategoryId { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property FeedId - int</value>
		[JsonPropertyName("feed_id")]
		public int FeedId { get; set; }

		/// <value>Property Canonical - bool</value>
		[JsonPropertyName("canonical")]
		public bool Canonical { get; set; }

		/// <value>Property Status - int</value>
		[JsonPropertyName("status")]
		public int Status { get; set; }

		/// <value>Property Store - UriDetail</value>
		[JsonPropertyName("store")]
		public UriDetail Store { get; set; }

		/// <value>Property Product - UriDetail</value>
		[JsonPropertyName("product")]
		public UriDetail Product { get; set; }

		/// <value>Property Category - UriDetail</value>
		[JsonPropertyName("category")]
		public UriDetail Category { get; set; }

		/// <value>Property Page - UriDetail</value>
		[JsonPropertyName("page")]
		public UriDetail Page { get; set; }

		/// <value>Property Feed - UriDetail</value>
		[JsonPropertyName("feed")]
		public UriDetail Feed { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for uri.
		/// <returns>String</returns>
		/// </summary>
		public String GetLinkUri()
		{
			return LinkUri;
		}

		/// <summary>
		/// Getter for store_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetStoreId()
		{
			return StoreId;
		}

		/// <summary>
		/// Getter for screen.
		/// <returns>String</returns>
		/// </summary>
		public String GetScreen()
		{
			return Screen;
		}

		/// <summary>
		/// Getter for page_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPageId()
		{
			return PageId;
		}

		/// <summary>
		/// Getter for cat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCategoryId()
		{
			return CategoryId;
		}

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for feed_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetFeedId()
		{
			return FeedId;
		}

		/// <summary>
		/// Getter for canonical.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCanonical()
		{
			return Canonical;
		}

		/// <summary>
		/// Getter for status.
		/// <returns>int</returns>
		/// </summary>
		public int GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Getter for store.
		/// <returns>UriDetail</returns>
		/// </summary>
		public UriDetail GetStore()
		{
			return Store;
		}

		/// <summary>
		/// Getter for product.
		/// <returns>UriDetail</returns>
		/// </summary>
		public UriDetail GetProduct()
		{
			return Product;
		}

		/// <summary>
		/// Getter for category.
		/// <returns>UriDetail</returns>
		/// </summary>
		public UriDetail GetCategory()
		{
			return Category;
		}

		/// <summary>
		/// Getter for page.
		/// <returns>UriDetail</returns>
		/// </summary>
		public UriDetail GetPage()
		{
			return Page;
		}

		/// <summary>
		/// Getter for feed.
		/// <returns>UriDetail</returns>
		/// </summary>
		public UriDetail GetFeed()
		{
			return Feed;
		}
	}
}
