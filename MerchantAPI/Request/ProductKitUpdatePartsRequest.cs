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
	/// Handles API Request ProductKit_Update_Parts.
	/// <see>https://docs.miva.com/json-api/functions/productkit_update_parts</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductKitUpdatePartsRequest : Request
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Attribute_ID.
		[JsonPropertyName("Attribute_ID")]
		public int AttributeId { get; set; }

		/// Request field AttributeTemplateAttribute_ID.
		[JsonPropertyName("AttributeTemplateAttribute_ID")]
		public int? AttributeTemplateAttributeId { get; set; }

		/// Request field Option_ID.
		[JsonPropertyName("Option_ID")]
		public int OptionId { get; set; }

		/// Request field Parts.
		[JsonPropertyName("Parts")]
		public List<KitPart> Parts { get; set; } = new List<KitPart>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductKitUpdatePartsRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductKit_Update_Parts";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
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
		/// Getter for Attribute_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for AttributeTemplateAttribute_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeTemplateAttributeId()
		{
			return AttributeTemplateAttributeId;
		}

		/// <summary>
		/// Getter for Option_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetOptionId()
		{
			return OptionId;
		}

		/// <summary>
		/// Getter for Parts.
		/// <returns>List<KitPart></returns>
		/// </summary>
		public List<KitPart> GetParts()
		{
			return Parts;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest SetAttributeId(int value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplateAttribute_ID.
		/// <param name="value">int</param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest SetAttributeTemplateAttributeId(int? value)
		{
			AttributeTemplateAttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Option_ID.
		/// <param name="value">int</param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest SetOptionId(int value)
		{
			OptionId = value;
			return this;
		}

		/// <summary>
		/// Add a KitPart.
		/// - kitPart: KitPart
		/// - Returns: Self
		/// </summary>
		public ProductKitUpdatePartsRequest AddKitPart(KitPart kitPart)
		{
			Parts.Add(kitPart);
			return this;
		}

		/// <summary>
		/// Add an array of KitPart.
		/// <param name="parts">List<KitPart></param>
		/// <returns>ProductKitUpdatePartsRequest</returns>
		/// </summary>
		public ProductKitUpdatePartsRequest AddParts(List<KitPart> parts)
		{
			foreach(KitPart e in parts)
			{
				Parts.Add(e);
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
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}

			if (AttributeId > 0)
			{
				writer.WriteNumber("Attribute_ID", AttributeId);
			}

			if (AttributeTemplateAttributeId.HasValue)
			{
				writer.WriteNumber("AttributeTemplateAttribute_ID", AttributeTemplateAttributeId.Value);
			}

			if (OptionId > 0)
			{
				writer.WriteNumber("Option_ID", OptionId);
			}

			writer.WritePropertyName("Parts");
			JsonSerializer.Serialize(writer, this.Parts, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductKitUpdatePartsResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductKitUpdatePartsResponse</returns>
		/// </summary>
		public new ProductKitUpdatePartsResponse Send()
		{
			return Client.SendRequestAsync<ProductKitUpdatePartsRequest, ProductKitUpdatePartsResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductKitUpdatePartsResponse></returns>
		/// </summary>
		public new async Task<ProductKitUpdatePartsResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductKitUpdatePartsRequest, ProductKitUpdatePartsResponse>(this);
		}
	}
}
