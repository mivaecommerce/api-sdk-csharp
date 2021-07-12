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
	public class PropertyVersion : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property PropertyId - int</value>
		[JsonPropertyName("prop_id")]
		public int PropertyId { get; set; }

		/// <value>Property VersionId - int</value>
		[JsonPropertyName("version_id")]
		public int VersionId { get; set; }

		/// <value>Property ResourceType - String</value>
		[JsonPropertyName("type")]
		public String ResourceType { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property CategoryId - int</value>
		[JsonPropertyName("cat_id")]
		public int CategoryId { get; set; }

		/// <value>Property VersionUserId - int</value>
		[JsonPropertyName("version_user_id")]
		public int VersionUserId { get; set; }

		/// <value>Property VersionUserName - String</value>
		[JsonPropertyName("version_user_name")]
		public String VersionUserName { get; set; }

		/// <value>Property VersionUserIcon - String</value>
		[JsonPropertyName("version_user_icon")]
		public String VersionUserIcon { get; set; }

		/// <value>Property SourceUserId - int</value>
		[JsonPropertyName("source_user_id")]
		public int SourceUserId { get; set; }

		/// <value>Property SourceUserName - String</value>
		[JsonPropertyName("source_user_name")]
		public String SourceUserName { get; set; }

		/// <value>Property SourceUserIcon - String</value>
		[JsonPropertyName("source_user_icon")]
		public String SourceUserIcon { get; set; }

		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplateId { get; set; }

		/// <value>Property Settings - TemplateVersionSettings</value>
		[JsonPropertyName("settings")]
		public TemplateVersionSettings Settings { get; set; }

		/// <value>Property Product - Product</value>
		[JsonPropertyName("product")]
		public Product Product { get; set; }

		/// <value>Property Category - Category</value>
		[JsonPropertyName("category")]
		public Category Category { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("source")]
		public String Source { get; set; }

		/// <value>Property Sync - bool</value>
		[JsonPropertyName("sync")]
		public bool Sync { get; set; }

		/// <value>Property SourceNotes - String</value>
		[JsonPropertyName("source_notes")]
		public String SourceNotes { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for prop_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPropertyId()
		{
			return PropertyId;
		}

		/// <summary>
		/// Getter for version_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetVersionId()
		{
			return VersionId;
		}

		/// <summary>
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetResourceType()
		{
			return ResourceType;
		}

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
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
		/// Getter for cat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCategoryId()
		{
			return CategoryId;
		}

		/// <summary>
		/// Getter for version_user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetVersionUserId()
		{
			return VersionUserId;
		}

		/// <summary>
		/// Getter for version_user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetVersionUserName()
		{
			return VersionUserName;
		}

		/// <summary>
		/// Getter for version_user_icon.
		/// <returns>String</returns>
		/// </summary>
		public String GetVersionUserIcon()
		{
			return VersionUserIcon;
		}

		/// <summary>
		/// Getter for source_user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSourceUserId()
		{
			return SourceUserId;
		}

		/// <summary>
		/// Getter for source_user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceUserName()
		{
			return SourceUserName;
		}

		/// <summary>
		/// Getter for source_user_icon.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceUserIcon()
		{
			return SourceUserIcon;
		}

		/// <summary>
		/// Getter for templ_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTemplateId()
		{
			return TemplateId;
		}

		/// <summary>
		/// Getter for settings.
		/// <returns>TemplateVersionSettings</returns>
		/// </summary>
		public TemplateVersionSettings GetSettings()
		{
			return Settings;
		}

		/// <summary>
		/// Getter for product.
		/// <returns>Product</returns>
		/// </summary>
		public Product GetProduct()
		{
			return Product;
		}

		/// <summary>
		/// Getter for category.
		/// <returns>Category</returns>
		/// </summary>
		public Category GetCategory()
		{
			return Category;
		}

		/// <summary>
		/// Getter for source.
		/// <returns>String</returns>
		/// </summary>
		public String GetSource()
		{
			return Source;
		}

		/// <summary>
		/// Getter for sync.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetSync()
		{
			return Sync;
		}

		/// <summary>
		/// Getter for source_notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceNotes()
		{
			return SourceNotes;
		}
	}
}
