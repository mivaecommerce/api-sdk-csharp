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
	/// Handles API Request PriceGroupProduct_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/pricegroupproduct_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupProductUpdateAssignedRequest : Request
	{
		/// Request field PriceGroup_ID.
		[JsonPropertyName("PriceGroup_ID")]
		public int? PriceGroupId { get; set; }

		/// Request field PriceGroup_Name.
		[JsonPropertyName("PriceGroup_Name")]
		public String PriceGroupName { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="priceGroup">PriceGroup</param>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest(Client client = null, PriceGroup priceGroup = null) :
			base(client)
		{
			Function = "PriceGroupProduct_Update_Assigned";
			if (priceGroup != null) {
				if (priceGroup.Id > 0)
				{
					PriceGroupId = priceGroup.Id;
				}
				else if (priceGroup.Name.Length > 0)
				{
					PriceGroupName = priceGroup.Name;
				}

				PriceGroupName = priceGroup.Name;
			}
		}

		/// <summary>
		/// Getter for PriceGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPriceGroupId()
		{
			return PriceGroupId;
		}

		/// <summary>
		/// Getter for PriceGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetPriceGroupName()
		{
			return PriceGroupName;
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
		/// Getter for Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public PriceGroupProductUpdateAssignedRequest SetAssigned(bool? value)
		{
			Assigned = value;
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

			if (PriceGroupId.HasValue)
			{
				writer.WriteNumber("PriceGroup_ID", PriceGroupId.Value);
			}
			else if (PriceGroupName != null && PriceGroupName.Length > 0)
			{
				writer.WriteString("PriceGroup_Name", PriceGroupName);
			}

			if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}
			else if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
			else if (ProductSku != null && ProductSku.Length > 0)
			{
				writer.WriteString("Product_SKU", ProductSku);
			}

			if (PriceGroupName != null && PriceGroupName.Length > 0)
			{
				writer.WriteString("PriceGroup_Name", PriceGroupName);
			}

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PriceGroupProductUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupProductUpdateAssignedResponse</returns>
		/// </summary>
		public new PriceGroupProductUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupProductUpdateAssignedRequest, PriceGroupProductUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupProductUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<PriceGroupProductUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupProductUpdateAssignedRequest, PriceGroupProductUpdateAssignedResponse>(this);
		}
	}
}
