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
	/// Handles API Request ProductShippingRules_Update.
	/// <see>https://docs.miva.com/json-api/functions/productshippingrules_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductShippingRulesUpdateRequest : Request
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field ShipsInOwnPackaging.
		[JsonPropertyName("ShipsInOwnPackaging")]
		public bool? ShipsInOwnPackaging { get; set; }

		/// Request field LimitShippingMethods.
		[JsonPropertyName("LimitShippingMethods")]
		public bool? LimitShippingMethods { get; set; }

		/// Request field Width.
		[JsonPropertyName("Width")]
		public float? Width { get; set; }

		/// Request field Length.
		[JsonPropertyName("Length")]
		public float? Length { get; set; }

		/// Request field Height.
		[JsonPropertyName("Height")]
		public float? Height { get; set; }

		/// Request field ShippingMethods.
		[JsonPropertyName("ShippingMethods")]
		public List<ShippingRuleMethod> ShippingMethods { get; set; } = new List<ShippingRuleMethod>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductShippingRulesUpdateRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductShippingRules_Update";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
				}
				else if (product.Sku.Length > 0)
				{
					ProductSku = product.Sku;
				}
			}
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
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
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
		/// Getter for Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for ShipsInOwnPackaging.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetShipsInOwnPackaging()
		{
			return ShipsInOwnPackaging;
		}

		/// <summary>
		/// Getter for LimitShippingMethods.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetLimitShippingMethods()
		{
			return LimitShippingMethods;
		}

		/// <summary>
		/// Getter for Width.
		/// <returns>float</returns>
		/// </summary>
		public float? GetWidth()
		{
			return Width;
		}

		/// <summary>
		/// Getter for Length.
		/// <returns>float</returns>
		/// </summary>
		public float? GetLength()
		{
			return Length;
		}

		/// <summary>
		/// Getter for Height.
		/// <returns>float</returns>
		/// </summary>
		public float? GetHeight()
		{
			return Height;
		}

		/// <summary>
		/// Getter for ShippingMethods.
		/// <returns>List<ShippingRuleMethod></returns>
		/// </summary>
		public List<ShippingRuleMethod> GetShippingMethods()
		{
			return ShippingMethods;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipsInOwnPackaging.
		/// <param name="value">bool</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetShipsInOwnPackaging(bool? value)
		{
			ShipsInOwnPackaging = value;
			return this;
		}

		/// <summary>
		/// Setter for LimitShippingMethods.
		/// <param name="value">bool</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetLimitShippingMethods(bool? value)
		{
			LimitShippingMethods = value;
			return this;
		}

		/// <summary>
		/// Setter for Width.
		/// <param name="value">float</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetWidth(float? value)
		{
			Width = value;
			return this;
		}

		/// <summary>
		/// Setter for Width.
		/// <param name="value">double</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetWidth(double? value)
		{
			Width = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Length.
		/// <param name="value">float</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetLength(float? value)
		{
			Length = value;
			return this;
		}

		/// <summary>
		/// Setter for Length.
		/// <param name="value">double</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetLength(double? value)
		{
			Length = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Height.
		/// <param name="value">float</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetHeight(float? value)
		{
			Height = value;
			return this;
		}

		/// <summary>
		/// Setter for Height.
		/// <param name="value">double</param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest SetHeight(double? value)
		{
			Height = (float?) value;
			return this;
		}

		/// <summary>
		/// Add a ShippingRuleMethod.
		/// - shippingMethod: ShippingRuleMethod
		/// - Returns: Self
		/// </summary>
		public ProductShippingRulesUpdateRequest AddShippingMethod(ShippingRuleMethod shippingMethod)
		{
			ShippingMethods.Add(shippingMethod);
			return this;
		}

		/// <summary>
		/// Add an array of ShippingRuleMethod.
		/// <param name="shippingMethods">List<ShippingRuleMethod></param>
		/// <returns>ProductShippingRulesUpdateRequest</returns>
		/// </summary>
		public ProductShippingRulesUpdateRequest AddShippingMethods(List<ShippingRuleMethod> shippingMethods)
		{
			foreach(ShippingRuleMethod e in shippingMethods)
			{
				ShippingMethods.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
			else if (ProductSku != null && ProductSku.Length > 0)
			{
				writer.WriteString("Product_SKU", ProductSku);
			}

			if (ShipsInOwnPackaging.HasValue)
			{
				writer.WriteBoolean("ShipsInOwnPackaging", ShipsInOwnPackaging.Value);
			}

			if (LimitShippingMethods.HasValue)
			{
				writer.WriteBoolean("LimitShippingMethods", LimitShippingMethods.Value);
			}

			if (Width.HasValue)
			{
				writer.WriteNumber("Width", Width.Value);
			}

			if (Length.HasValue)
			{
				writer.WriteNumber("Length", Length.Value);
			}

			if (Height.HasValue)
			{
				writer.WriteNumber("Height", Height.Value);
			}

			if (ShippingMethods.Count > 0)
			{
				writer.WritePropertyName("ShippingMethods");
				JsonSerializer.Serialize(writer, this.ShippingMethods, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductShippingRulesUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductShippingRulesUpdateResponse</returns>
		/// </summary>
		public new ProductShippingRulesUpdateResponse Send()
		{
			return Client.SendRequestAsync<ProductShippingRulesUpdateRequest, ProductShippingRulesUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductShippingRulesUpdateResponse></returns>
		/// </summary>
		public new async Task<ProductShippingRulesUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductShippingRulesUpdateRequest, ProductShippingRulesUpdateResponse>(this);
		}
	}
}
