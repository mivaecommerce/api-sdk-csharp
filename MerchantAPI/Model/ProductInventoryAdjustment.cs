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
	[JsonConverter(typeof(ProductInventoryAdjustmentConverter))]
	public class ProductInventoryAdjustment : Model
	{
		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int? ProductId { get; set; }

		/// <value>Property ProductCode - String</value>
		[JsonPropertyName("product_code")]
		public String ProductCode { get; set; }

		/// <value>Property ProductSku - String</value>
		[JsonPropertyName("product_sku")]
		public String ProductSku { get; set; }

		/// <value>Property Adjustment - float</value>
		[JsonPropertyName("adjustment")]
		public float Adjustment { get; set; }

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int? GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for product_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
		}

		/// <summary>
		/// Getter for product_sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for adjustment.
		/// <returns>float</returns>
		/// </summary>
		public float GetAdjustment()
		{
			return Adjustment;
		}

		/// <summary>
		/// Setter for product_id.
		/// <param name="value">int</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
		public ProductInventoryAdjustment SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for product_code.
		/// <param name="value">String</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
		public ProductInventoryAdjustment SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for product_sku.
		/// <param name="value">String</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
		public ProductInventoryAdjustment SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for adjustment.
		/// <param name="value">float</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
	   public ProductInventoryAdjustment SetAdjustment(float value)
	   {
			Adjustment = value;
			return this;
		}

		/// <summary>
		/// Setter for adjustment.
		/// <param name="value">double</param>
		/// <returns>ProductInventoryAdjustment</returns>
		/// </summary>
	   public ProductInventoryAdjustment SetAdjustment(double value)
	   {
			Adjustment = (float) value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ProductInventoryAdjustment
	/// </summary>
	public class ProductInventoryAdjustmentConverter : BaseJsonConverter<ProductInventoryAdjustment>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ProductInventoryAdjustment) || typeToConvert.IsSubclassOf(typeof(ProductInventoryAdjustment));
		}

		public override ProductInventoryAdjustment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ProductInventoryAdjustment value = new ProductInventoryAdjustment();

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

				if (String.Equals(property, "product_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "product_code", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_sku", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductSku = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "adjustment", StringComparison.OrdinalIgnoreCase))
				{
					value.Adjustment = ReadNextFloat(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for ProductInventoryAdjustment", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ProductInventoryAdjustment value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.ProductId.HasValue)
			{
				writer.WriteNumber("product_id", value.ProductId.Value);
			}

			if (value.ProductCode != null && value.ProductCode.Length > 0)
			{
				writer.WriteString("product_code", value.ProductCode);
			}

			if (value.ProductSku != null && value.ProductSku.Length > 0)
			{
				writer.WriteString("product_sku", value.ProductSku);
			}

			writer.WriteNumber("adjustment", value.Adjustment);

			writer.WriteEndObject();
		}
	}
}
