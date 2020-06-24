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
	}
}
