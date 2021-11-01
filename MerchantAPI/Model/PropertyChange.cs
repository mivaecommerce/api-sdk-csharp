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
	[JsonConverter(typeof(PropertyChangeConverter))]
	public class PropertyChange : Model
	{
		/// <value>Property PropertyId - int</value>
		[JsonPropertyName("Property_ID")]
		public int? PropertyId { get; set; }

		/// <value>Property PropertyType - String</value>
		[JsonPropertyName("Property_Type")]
		public String PropertyType { get; set; }

		/// <value>Property PropertyCode - String</value>
		[JsonPropertyName("Property_Code")]
		public String PropertyCode { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// <value>Property ProductCode - String</value>
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// <value>Property EditProduct - String</value>
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// <value>Property CategoryId - int</value>
		[JsonPropertyName("Category_ID")]
		public int? CategoryId { get; set; }

		/// <value>Property CategoryCode - String</value>
		[JsonPropertyName("Category_Code")]
		public String CategoryCode { get; set; }

		/// <value>Property EditCategory - String</value>
		[JsonPropertyName("Edit_Category")]
		public String EditCategory { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("Source")]
		public String Source { get; set; }

		/// <value>Property Settings - TemplateVersionSettings</value>
		[JsonPropertyName("Settings")]
		public TemplateVersionSettings Settings { get; set; }

		/// <value>Property Notes - String</value>
		[JsonPropertyName("Notes")]
		public String Notes { get; set; }

		/// <summary>
		/// Getter for Property_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPropertyId()
		{
			return PropertyId;
		}

		/// <summary>
		/// Getter for Property_Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetPropertyType()
		{
			return PropertyType;
		}

		/// <summary>
		/// Getter for Property_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetPropertyCode()
		{
			return PropertyCode;
		}

		/// <summary>
		/// Getter for Product_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for Product_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
		}

		/// <summary>
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
		}

		/// <summary>
		/// Getter for Category_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCategoryId()
		{
			return CategoryId;
		}

		/// <summary>
		/// Getter for Category_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCategoryCode()
		{
			return CategoryCode;
		}

		/// <summary>
		/// Getter for Edit_Category.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCategory()
		{
			return EditCategory;
		}

		/// <summary>
		/// Getter for Source.
		/// <returns>String</returns>
		/// </summary>
		public String GetSource()
		{
			return Source;
		}

		/// <summary>
		/// Getter for Settings.
		/// <returns>TemplateVersionSettings</returns>
		/// </summary>
		public TemplateVersionSettings GetSettings()
		{
			return Settings;
		}

		/// <summary>
		/// Getter for Notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetNotes()
		{
			return Notes;
		}

		/// <summary>
		/// Setter for Property_ID.
		/// <param name="value">int</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetPropertyId(int value)
		{
			PropertyId = value;
			return this;
		}

		/// <summary>
		/// Setter for Property_Type.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetPropertyType(String value)
		{
			PropertyType = value;
			return this;
		}

		/// <summary>
		/// Setter for Property_Code.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetPropertyCode(String value)
		{
			PropertyCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_ID.
		/// <param name="value">int</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetCategoryId(int value)
		{
			CategoryId = value;
			return this;
		}

		/// <summary>
		/// Setter for Category_Code.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetCategoryCode(String value)
		{
			CategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Category.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetEditCategory(String value)
		{
			EditCategory = value;
			return this;
		}

		/// <summary>
		/// Setter for Source.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetSource(String value)
		{
			Source = value;
			return this;
		}

		/// <summary>
		/// Setter for Notes.
		/// <param name="value">String</param>
		/// <returns>PropertyChange</returns>
		/// </summary>
		public PropertyChange SetNotes(String value)
		{
			Notes = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model PropertyChange
	/// </summary>
	public class PropertyChangeConverter : BaseJsonConverter<PropertyChange>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(PropertyChange) || typeToConvert.IsSubclassOf(typeof(PropertyChange));
		}

		public override PropertyChange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			PropertyChange value = new PropertyChange();

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

				if (String.Equals(property, "Property_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.PropertyId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "Property_Type", StringComparison.OrdinalIgnoreCase))
				{
					value.PropertyType = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Property_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.PropertyCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Product_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "Product_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Edit_Product", StringComparison.OrdinalIgnoreCase))
				{
					value.EditProduct = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Category_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.CategoryId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "Category_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.CategoryCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Edit_Category", StringComparison.OrdinalIgnoreCase))
				{
					value.EditCategory = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Source", StringComparison.OrdinalIgnoreCase))
				{
					value.Source = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Settings", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.Settings = JsonSerializer.Deserialize<TemplateVersionSettings>(ref reader, options);
				}
				else if (String.Equals(property, "Notes", StringComparison.OrdinalIgnoreCase))
				{
					value.Notes = ReadNextString(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for PropertyChange", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, PropertyChange value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.PropertyId.HasValue)
			{
				writer.WriteNumber("Property_ID", value.PropertyId.Value);
			}

			if (value.PropertyType != null && value.PropertyType.Length > 0)
			{
				writer.WriteString("Property_Type", value.PropertyType);
			}

			if (value.PropertyCode != null && value.PropertyCode.Length > 0)
			{
				writer.WriteString("Property_Code", value.PropertyCode);
			}

			if (value.ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", value.ProductId.Value);
			}

			if (value.ProductCode != null && value.ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", value.ProductCode);
			}

			if (value.EditProduct != null && value.EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", value.EditProduct);
			}

			if (value.CategoryId.HasValue)
			{
				writer.WriteNumber("Category_ID", value.CategoryId.Value);
			}

			if (value.CategoryCode != null && value.CategoryCode.Length > 0)
			{
				writer.WriteString("Category_Code", value.CategoryCode);
			}

			if (value.EditCategory != null && value.EditCategory.Length > 0)
			{
				writer.WriteString("Edit_Category", value.EditCategory);
			}

			if (value.Source != null && value.Source.Length > 0)
			{
				writer.WriteString("Source", value.Source);
			}

			writer.WritePropertyName("Settings");
			JsonSerializer.Serialize(writer, value.Settings, options);

			if (value.Notes != null && value.Notes.Length > 0)
			{
				writer.WriteString("Notes", value.Notes);
			}

			writer.WriteEndObject();
		}
	}
}
