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
	/// Handles API Request OptionList_Load_Attribute.
	/// <see>https://docs.miva.com/json-api/functions/optionlist_load_attribute</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OptionListLoadAttributeRequest : Request
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
		public int? AttributeId { get; set; }

		/// Request field Edit_Attribute.
		[JsonPropertyName("Edit_Attribute")]
		public String EditAttribute { get; set; }

		/// Request field Attribute_Code.
		[JsonPropertyName("Attribute_Code")]
		public String AttributeCode { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="productAttribute">ProductAttribute</param>
		/// </summary>
		public OptionListLoadAttributeRequest(BaseClient client = null, ProductAttribute productAttribute = null) :
			base(client)
		{
			Function = "OptionList_Load_Attribute";
			if (productAttribute != null) {
				if (productAttribute.ProductId > 0)
				{
					ProductId = productAttribute.ProductId;
				}

				if (productAttribute.Id > 0)
				{
					AttributeId = productAttribute.Id;
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
		public int? GetAttributeId()
		{
			return AttributeId;
		}

		/// <summary>
		/// Getter for Edit_Attribute.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAttribute()
		{
			return EditAttribute;
		}

		/// <summary>
		/// Getter for Attribute_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeCode()
		{
			return AttributeCode;
		}

		/// <summary>
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_ID.
		/// <param name="value">int</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetAttributeId(int? value)
		{
			AttributeId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Attribute.
		/// <param name="value">String</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetEditAttribute(String value)
		{
			EditAttribute = value;
			return this;
		}

		/// <summary>
		/// Setter for Attribute_Code.
		/// <param name="value">String</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetAttributeCode(String value)
		{
			AttributeCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>OptionListLoadAttributeRequest</returns>
		/// </summary>
		public OptionListLoadAttributeRequest SetCustomerId(int? value)
		{
			CustomerId = value;
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

			if (AttributeId.HasValue)
			{
				writer.WriteNumber("Attribute_ID", AttributeId.Value);
			}
			else if (EditAttribute != null && EditAttribute.Length > 0)
			{
				writer.WriteString("Edit_Attribute", EditAttribute);
			}
			else if (AttributeCode != null && AttributeCode.Length > 0)
			{
				writer.WriteString("Attribute_Code", AttributeCode);
			}

			if (CustomerId.HasValue)
			{
				writer.WriteNumber("Customer_ID", CustomerId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OptionListLoadAttributeResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OptionListLoadAttributeResponse</returns>
		/// </summary>
		public new OptionListLoadAttributeResponse Send()
		{
			return Client.SendRequestAsync<OptionListLoadAttributeRequest, OptionListLoadAttributeResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OptionListLoadAttributeResponse></returns>
		/// </summary>
		public new async Task<OptionListLoadAttributeResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OptionListLoadAttributeRequest, OptionListLoadAttributeResponse>(this);
		}
	}
}
