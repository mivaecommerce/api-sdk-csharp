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

namespace MerchantAPI
{
	[JsonConverter(typeof(ProductConverter))]
	public class Product : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Sku - String</value>
		[JsonPropertyName("sku")]
		public String Sku { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Thumbnail - String</value>
		[JsonPropertyName("thumbnail")]
		public String Thumbnail { get; set; }

		/// <value>Property Image - String</value>
		[JsonPropertyName("image")]
		public String Image { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float Price { get; set; }

		/// <value>Property FormattedPrice - String</value>
		[JsonPropertyName("formatted_price")]
		public String FormattedPrice { get; set; }

		/// <value>Property Cost - float</value>
		[JsonPropertyName("cost")]
		public float Cost { get; set; }

		/// <value>Property FormattedCost - String</value>
		[JsonPropertyName("formatted_cost")]
		public String FormattedCost { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property CategoryCount - int</value>
		[JsonPropertyName("catcount")]
		public int CategoryCount { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float Weight { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property PageTitle - String</value>
		[JsonPropertyName("page_title")]
		public String PageTitle { get; set; }

		/// <value>Property Taxable - bool</value>
		[JsonPropertyName("taxable")]
		public bool Taxable { get; set; }

		/// <value>Property DateTimeCreated - int</value>
		[JsonPropertyName("dt_created")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeCreated { get; set; }

		/// <value>Property DateTimeUpdate - int</value>
		[JsonPropertyName("dt_updated")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeUpdate { get; set; }

		/// <value>Property ProductInventorySettings - ProductInventorySettings</value>
		[JsonPropertyName("productinventorysettings")]
		public ProductInventorySettings ProductInventorySettings { get; set; }

		/// <value>Property ProductInventoryActive - bool</value>
		[JsonPropertyName("product_inventory_active")]
		public bool ProductInventoryActive { get; set; }

		/// <value>Property ProductInventory - int</value>
		[JsonPropertyName("product_inventory")]
		public int ProductInventory { get; set; }

		/// <value>Property CanonicalCategoryCode - String</value>
		[JsonPropertyName("cancat_code")]
		public String CanonicalCategoryCode { get; set; }

		/// <value>Property PageCode - String</value>
		[JsonPropertyName("page_code")]
		public String PageCode { get; set; }

		/// <value>Property CustomFieldValues - CustomFieldValues</value>
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <value>Property Uris - List<Uri></value>
		[JsonPropertyName("uris")]
		public List<Uri> Uris { get; set; } = new List<Uri>();

		/// <value>Property RelatedProducts - List<RelatedProduct></value>
		[JsonPropertyName("relatedproducts")]
		public List<RelatedProduct> RelatedProducts { get; set; } = new List<RelatedProduct>();

		/// <value>Property Categories - List<Category></value>
		[JsonPropertyName("categories")]
		public List<Category> Categories { get; set; } = new List<Category>();

		/// <value>Property ProductShippingRules - ProductShippingRules</value>
		[JsonPropertyName("productshippingrules")]
		public ProductShippingRules ProductShippingRules { get; set; }

		/// <value>Property ProductImageData - List<ProductImageData></value>
		[JsonPropertyName("productimagedata")]
		public List<ProductImageData> ProductImageData { get; set; } = new List<ProductImageData>();

		/// <value>Property Attributes - List<ProductAttribute></value>
		[JsonPropertyName("attributes")]
		public List<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();

		/// <value>Property Url - String</value>
		[JsonPropertyName("url")]
		public String Url { get; set; }

		/// <value>Property ImageTypes - List<KeyValuePair<String, Int>></value>
		public List<KeyValuePair<String, Int32>> ImageTypes { get; set; } = new List<KeyValuePair<String, Int32>>();

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

		/// <value>Property SubscriptionSettings - ProductSubscriptionSettings</value>
		[JsonPropertyName("subscriptionsettings")]
		public ProductSubscriptionSettings SubscriptionSettings { get; set; }

		/// <value>Property SubscriptionTerms - List<ProductSubscriptionTerm></value>
		[JsonPropertyName("subscriptionterms")]
		public List<ProductSubscriptionTerm> SubscriptionTerms { get; set; } = new List<ProductSubscriptionTerm>();

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for thumbnail.
		/// <returns>String</returns>
		/// </summary>
		public String GetThumbnail()
		{
			return Thumbnail;
		}

		/// <summary>
		/// Getter for image.
		/// <returns>String</returns>
		/// </summary>
		public String GetImage()
		{
			return Image;
		}

		/// <summary>
		/// Getter for price.
		/// <returns>float</returns>
		/// </summary>
		public float GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for formatted_price.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedPrice()
		{
			return FormattedPrice;
		}

		/// <summary>
		/// Getter for cost.
		/// <returns>float</returns>
		/// </summary>
		public float GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Getter for formatted_cost.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedCost()
		{
			return FormattedCost;
		}

		/// <summary>
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for catcount.
		/// <returns>int</returns>
		/// </summary>
		public int GetCategoryCount()
		{
			return CategoryCount;
		}

		/// <summary>
		/// Getter for weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetWeight()
		{
			return Weight;
		}

		/// <summary>
		/// Getter for active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetActive()
		{
			return Active;
		}

		/// <summary>
		/// Getter for page_title.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageTitle()
		{
			return PageTitle;
		}

		/// <summary>
		/// Getter for taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTaxable()
		{
			return Taxable;
		}

		/// <summary>
		/// Getter for dt_created.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeCreated()
		{
			return DateTimeCreated;
		}

		/// <summary>
		/// Getter for dt_updated.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeUpdate()
		{
			return DateTimeUpdate;
		}

		/// <summary>
		/// Getter for productinventorysettings.
		/// <returns>ProductInventorySettings</returns>
		/// </summary>
		public ProductInventorySettings GetProductInventorySettings()
		{
			return ProductInventorySettings;
		}

		/// <summary>
		/// Getter for product_inventory_active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetProductInventoryActive()
		{
			return ProductInventoryActive;
		}

		/// <summary>
		/// Getter for product_inventory.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductInventory()
		{
			return ProductInventory;
		}

		/// <summary>
		/// Getter for cancat_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCanonicalCategoryCode()
		{
			return CanonicalCategoryCode;
		}

		/// <summary>
		/// Getter for page_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageCode()
		{
			return PageCode;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Getter for uris.
		/// <returns>List<Uri></returns>
		/// </summary>
		public List<Uri> GetUris()
		{
			return Uris;
		}

		/// <summary>
		/// Getter for relatedproducts.
		/// <returns>List<RelatedProduct></returns>
		/// </summary>
		public List<RelatedProduct> GetRelatedProducts()
		{
			return RelatedProducts;
		}

		/// <summary>
		/// Getter for categories.
		/// <returns>List<Category></returns>
		/// </summary>
		public List<Category> GetCategories()
		{
			return Categories;
		}

		/// <summary>
		/// Getter for productshippingrules.
		/// <returns>ProductShippingRules</returns>
		/// </summary>
		public ProductShippingRules GetProductShippingRules()
		{
			return ProductShippingRules;
		}

		/// <summary>
		/// Getter for productimagedata.
		/// <returns>List<ProductImageData></returns>
		/// </summary>
		public List<ProductImageData> GetProductImageData()
		{
			return ProductImageData;
		}

		/// <summary>
		/// Getter for attributes.
		/// <returns>List<ProductAttribute></returns>
		/// </summary>
		public List<ProductAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for url.
		/// <returns>String</returns>
		/// </summary>
		public String GetUrl()
		{
			return Url;
		}

		/// <summary>
		/// Getter for disp_order.
		/// <returns>int</returns>
		/// </summary>
		public int GetDisplayOrder()
		{
			return DisplayOrder;
		}

		/// <summary>
		/// Getter for subscriptionsettings.
		/// <returns>ProductSubscriptionSettings</returns>
		/// </summary>
		public ProductSubscriptionSettings GetSubscriptionSettings()
		{
			return SubscriptionSettings;
		}

		/// <summary>
		/// Getter for subscriptionterms.
		/// <returns>List<ProductSubscriptionTerm></returns>
		/// </summary>
		public List<ProductSubscriptionTerm> GetSubscriptionTerms()
		{
			return SubscriptionTerms;
		}
	}

	/// <summary>
	/// Converter for model Product
	/// </summary>
	public class ProductConverter : BaseJsonConverter<Product>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(Product) || typeToConvert.IsSubclassOf(typeof(Product));
		}

		public override Product Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			Product value = new Product();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while(reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return value;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "id", StringComparison.OrdinalIgnoreCase))
				{
					value.Id = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "code", StringComparison.OrdinalIgnoreCase))
				{
					value.Code = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "sku", StringComparison.OrdinalIgnoreCase))
				{
					value.Sku = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "name", StringComparison.OrdinalIgnoreCase))
				{
					value.Name = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "thumbnail", StringComparison.OrdinalIgnoreCase))
				{
					value.Thumbnail = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "image", StringComparison.OrdinalIgnoreCase))
				{
					value.Image = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "price", StringComparison.OrdinalIgnoreCase))
				{
					value.Price = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_price", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedPrice = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "cost", StringComparison.OrdinalIgnoreCase))
				{
					value.Cost = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_cost", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedCost = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "descrip", StringComparison.OrdinalIgnoreCase))
				{
					value.Description = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "catcount", StringComparison.OrdinalIgnoreCase))
				{
					value.CategoryCount = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "weight", StringComparison.OrdinalIgnoreCase))
				{
					value.Weight = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "active", StringComparison.OrdinalIgnoreCase))
				{
					value.Active = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "page_title", StringComparison.OrdinalIgnoreCase))
				{
					value.PageTitle = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "taxable", StringComparison.OrdinalIgnoreCase))
				{
					value.Taxable = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "dt_created", StringComparison.OrdinalIgnoreCase))
				{
					value.DateTimeCreated = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "dt_updated", StringComparison.OrdinalIgnoreCase))
				{
					value.DateTimeUpdate = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "productinventorysettings", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.ProductInventorySettings = JsonSerializer.Deserialize<ProductInventorySettings>(ref reader, options);
				}
				else if (String.Equals(property, "product_inventory_active", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductInventoryActive = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "product_inventory", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductInventory = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "cancat_code", StringComparison.OrdinalIgnoreCase))
				{
					value.CanonicalCategoryCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "page_code", StringComparison.OrdinalIgnoreCase))
				{
					value.PageCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "CustomField_Values", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.CustomFieldValues = JsonSerializer.Deserialize<CustomFieldValues>(ref reader, options);
				}
				else if (String.Equals(property, "uris", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Uris = JsonSerializer.Deserialize<List<Uri>>(ref reader, options);
				}
				else if (String.Equals(property, "relatedproducts", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.RelatedProducts = JsonSerializer.Deserialize<List<RelatedProduct>>(ref reader, options);
				}
				else if (String.Equals(property, "categories", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Categories = JsonSerializer.Deserialize<List<Category>>(ref reader, options);
				}
				else if (String.Equals(property, "productshippingrules", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.ProductShippingRules = JsonSerializer.Deserialize<ProductShippingRules>(ref reader, options);
				}
				else if (String.Equals(property, "productimagedata", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.ProductImageData = JsonSerializer.Deserialize<List<ProductImageData>>(ref reader, options);
				}
				else if (String.Equals(property, "attributes", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Attributes = JsonSerializer.Deserialize<List<ProductAttribute>>(ref reader, options);
				}
				else if (String.Equals(property, "url", StringComparison.OrdinalIgnoreCase))
				{
					value.Url = ReadNextString(ref reader, options);
				}
				else if (property.StartsWith("imagetype:", StringComparison.OrdinalIgnoreCase))
				{
					KeyValuePair<String, Int32> entry = new KeyValuePair<String, Int32>(property.Substring(property.IndexOf(":") + 1), ReadNextInteger(ref reader, options));
					value.ImageTypes.Add(entry);
				}
				else if (String.Equals(property, "disp_order", StringComparison.OrdinalIgnoreCase))
				{
					value.DisplayOrder = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "subscriptionsettings", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.SubscriptionSettings = JsonSerializer.Deserialize<ProductSubscriptionSettings>(ref reader, options);
				}
				else if (String.Equals(property, "subscriptionterms", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.SubscriptionTerms = JsonSerializer.Deserialize<List<ProductSubscriptionTerm>>(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, Product value, JsonSerializerOptions options)
		{
			throw new MerchantAPIException("ProductConverter only supports deserialization");
		}
	}
}
