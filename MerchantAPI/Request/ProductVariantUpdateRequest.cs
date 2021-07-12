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
	/// Handles API Request ProductVariant_Update.
	/// <see>https://docs.miva.com/json-api/functions/productvariant_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductVariantUpdateRequest : Request
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

		/// Request field Variant_ID.
		[JsonPropertyName("Variant_ID")]
		public int VariantId { get; set; }

		/// Request field Attributes.
		[JsonPropertyName("Attributes")]
		public List<VariantAttribute> Attributes { get; set; } = new List<VariantAttribute>();

		/// Request field Parts.
		[JsonPropertyName("Parts")]
		public List<VariantPart> Parts { get; set; } = new List<VariantPart>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="productVariant">ProductVariant</param>
		/// </summary>
		public ProductVariantUpdateRequest(BaseClient client = null, ProductVariant productVariant = null) :
			base(client)
		{
			Function = "ProductVariant_Update";
			if (productVariant != null) {
				if (productVariant.ProductId > 0)
				{
					ProductId = productVariant.ProductId;
				}

				if (productVariant.VariantId > 0)
				{
					VariantId = productVariant.VariantId;
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
		/// Getter for Variant_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetVariantId()
		{
			return VariantId;
		}

		/// <summary>
		/// Getter for Attributes.
		/// <returns>List<VariantAttribute></returns>
		/// </summary>
		public List<VariantAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for Parts.
		/// <returns>List<VariantPart></returns>
		/// </summary>
		public List<VariantPart> GetParts()
		{
			return Parts;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductVariantUpdateRequest</returns>
		/// </summary>
		public ProductVariantUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductVariantUpdateRequest</returns>
		/// </summary>
		public ProductVariantUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductVariantUpdateRequest</returns>
		/// </summary>
		public ProductVariantUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Variant_ID.
		/// <param name="value">int</param>
		/// <returns>ProductVariantUpdateRequest</returns>
		/// </summary>
		public ProductVariantUpdateRequest SetVariantId(int value)
		{
			VariantId = value;
			return this;
		}

		/// <summary>
		/// Add a VariantAttribute.
		/// - variantAttribute: VariantAttribute
		/// - Returns: Self
		/// </summary>
		public ProductVariantUpdateRequest AddVariantAttribute(VariantAttribute variantAttribute)
		{
			Attributes.Add(variantAttribute);
			return this;
		}

		/// <summary>
		/// Add an array of VariantAttribute.
		/// <param name="attributes">List<VariantAttribute></param>
		/// <returns>ProductVariantUpdateRequest</returns>
		/// </summary>
		public ProductVariantUpdateRequest AddAttributes(List<VariantAttribute> attributes)
		{
			foreach(VariantAttribute e in attributes)
			{
				Attributes.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a VariantPart.
		/// - variantPart: VariantPart
		/// - Returns: Self
		/// </summary>
		public ProductVariantUpdateRequest AddVariantPart(VariantPart variantPart)
		{
			Parts.Add(variantPart);
			return this;
		}

		/// <summary>
		/// Add an array of VariantPart.
		/// <param name="parts">List<VariantPart></param>
		/// <returns>ProductVariantUpdateRequest</returns>
		/// </summary>
		public ProductVariantUpdateRequest AddParts(List<VariantPart> parts)
		{
			foreach(VariantPart e in parts)
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

			if (VariantId > 0)
			{
				writer.WriteNumber("Variant_ID", VariantId);
			}

			if (Attributes.Count > 0)
			{
				writer.WritePropertyName("Attributes");
				JsonSerializer.Serialize(writer, this.Attributes, options);
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
			return JsonSerializer.Deserialize<ProductVariantUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductVariantUpdateResponse</returns>
		/// </summary>
		public new ProductVariantUpdateResponse Send()
		{
			return Client.SendRequestAsync<ProductVariantUpdateRequest, ProductVariantUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductVariantUpdateResponse></returns>
		/// </summary>
		public new async Task<ProductVariantUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductVariantUpdateRequest, ProductVariantUpdateResponse>(this);
		}
	}
}
