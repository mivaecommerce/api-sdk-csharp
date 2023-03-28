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
	/// Handles API Request Product_Copy.
	/// <see>https://docs.miva.com/json-api/functions/product_copy</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductCopyRequest : Request
	{
		/// Request field Product_Copy_Session_ID.
		[JsonPropertyName("Product_Copy_Session_ID")]
		public String ProductCopySessionId { get; set; }

		/// Request field CopyProductRules_ID.
		[JsonPropertyName("CopyProductRules_ID")]
		public int? CopyProductRulesId { get; set; }

		/// Request field CopyProductRules_Name.
		[JsonPropertyName("CopyProductRules_Name")]
		public String CopyProductRulesName { get; set; }

		/// Request field Source_Product_ID.
		[JsonPropertyName("Source_Product_ID")]
		public int? SourceProductId { get; set; }

		/// Request field Source_Product_Code.
		[JsonPropertyName("Source_Product_Code")]
		public String SourceProductCode { get; set; }

		/// Request field Dest_Product_Code.
		[JsonPropertyName("Dest_Product_Code")]
		public String DestinationProductCode { get; set; }

		/// Request field Dest_Product_Name.
		[JsonPropertyName("Dest_Product_Name")]
		public String DestinationProductName { get; set; }

		/// Request field Dest_Product_SKU.
		[JsonPropertyName("Dest_Product_SKU")]
		public String DestinationProductSku { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductCopyRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "Product_Copy";
			if (product != null) {
				if (product.Id > 0)
				{
					SourceProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					SourceProductCode = product.Code;
				}
			}
		}

		/// <summary>
		/// Getter for Product_Copy_Session_ID.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCopySessionId()
		{
			return ProductCopySessionId;
		}

		/// <summary>
		/// Getter for CopyProductRules_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCopyProductRulesId()
		{
			return CopyProductRulesId;
		}

		/// <summary>
		/// Getter for CopyProductRules_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCopyProductRulesName()
		{
			return CopyProductRulesName;
		}

		/// <summary>
		/// Getter for Source_Product_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetSourceProductId()
		{
			return SourceProductId;
		}

		/// <summary>
		/// Getter for Source_Product_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceProductCode()
		{
			return SourceProductCode;
		}

		/// <summary>
		/// Getter for Dest_Product_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationProductCode()
		{
			return DestinationProductCode;
		}

		/// <summary>
		/// Getter for Dest_Product_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationProductName()
		{
			return DestinationProductName;
		}

		/// <summary>
		/// Getter for Dest_Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationProductSku()
		{
			return DestinationProductSku;
		}

		/// <summary>
		/// Setter for Product_Copy_Session_ID.
		/// <param name="value">String</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetProductCopySessionId(String value)
		{
			ProductCopySessionId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyProductRules_ID.
		/// <param name="value">int</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetCopyProductRulesId(int? value)
		{
			CopyProductRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyProductRules_Name.
		/// <param name="value">String</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetCopyProductRulesName(String value)
		{
			CopyProductRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Source_Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetSourceProductId(int? value)
		{
			SourceProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Source_Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetSourceProductCode(String value)
		{
			SourceProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetDestinationProductCode(String value)
		{
			DestinationProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Product_Name.
		/// <param name="value">String</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetDestinationProductName(String value)
		{
			DestinationProductName = value;
			return this;
		}

		/// <summary>
		/// Setter for Dest_Product_SKU.
		/// <param name="value">String</param>
		/// <returns>ProductCopyRequest</returns>
		/// </summary>
		public ProductCopyRequest SetDestinationProductSku(String value)
		{
			DestinationProductSku = value;
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

			if (SourceProductId.HasValue)
			{
				writer.WriteNumber("Source_Product_ID", SourceProductId.Value);
			}
			else if (SourceProductCode != null && SourceProductCode.Length > 0)
			{
				writer.WriteString("Source_Product_Code", SourceProductCode);
			}

			if (DestinationProductCode != null && DestinationProductCode.Length > 0)
			{
				writer.WriteString("Dest_Product_Code", DestinationProductCode);
			}

			if (CopyProductRulesId.HasValue)
			{
				writer.WriteNumber("CopyProductRules_ID", CopyProductRulesId.Value);
			}
			else if (CopyProductRulesName != null && CopyProductRulesName.Length > 0)
			{
				writer.WriteString("CopyProductRules_Name", CopyProductRulesName);
			}

			writer.WriteString("Product_Copy_Session_ID", ProductCopySessionId);

			if (CopyProductRulesId.HasValue)
			{
				writer.WriteNumber("CopyProductRules_ID", CopyProductRulesId.Value);
			}

			if (CopyProductRulesName != null && CopyProductRulesName.Length > 0)
			{
				writer.WriteString("CopyProductRules_Name", CopyProductRulesName);
			}

			if (DestinationProductCode != null && DestinationProductCode.Length > 0)
			{
				writer.WriteString("Dest_Product_Code", DestinationProductCode);
			}

			if (DestinationProductName != null && DestinationProductName.Length > 0)
			{
				writer.WriteString("Dest_Product_Name", DestinationProductName);
			}

			if (DestinationProductSku != null && DestinationProductSku.Length > 0)
			{
				writer.WriteString("Dest_Product_SKU", DestinationProductSku);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductCopyResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductCopyResponse</returns>
		/// </summary>
		public new ProductCopyResponse Send()
		{
			return Client.SendRequestAsync<ProductCopyRequest, ProductCopyResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductCopyResponse></returns>
		/// </summary>
		public new async Task<ProductCopyResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductCopyRequest, ProductCopyResponse>(this);
		}
	}
}
