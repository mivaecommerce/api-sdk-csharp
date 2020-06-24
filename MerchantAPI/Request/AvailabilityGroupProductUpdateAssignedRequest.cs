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
	/// Handles API Request AvailabilityGroupProduct_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroupproduct_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AvailabilityGroupProductUpdateAssignedRequest : Request
	{
		/// Request field AvailabilityGroup_ID.
		[JsonPropertyName("AvailabilityGroup_ID")]
		public int? AvailabilityGroupId { get; set; }

		/// Request field Edit_AvailabilityGroup.
		[JsonPropertyName("Edit_AvailabilityGroup")]
		public String EditAvailabilityGroup { get; set; }

		/// Request field AvailabilityGroup_Name.
		[JsonPropertyName("AvailabilityGroup_Name")]
		public String AvailabilityGroupName { get; set; }

		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="availabilityGroup">AvailabilityGroup</param>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest(Client client = null, AvailabilityGroup availabilityGroup = null) :
			base(client)
		{
			Function = "AvailabilityGroupProduct_Update_Assigned";
			if (availabilityGroup != null) {
				if (availabilityGroup.Id > 0)
				{
					AvailabilityGroupId = availabilityGroup.Id;
				}
				else if (availabilityGroup.Name.Length > 0)
				{
					EditAvailabilityGroup = availabilityGroup.Name;
				}
			}
		}

		/// <summary>
		/// Getter for AvailabilityGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAvailabilityGroupId()
		{
			return AvailabilityGroupId;
		}

		/// <summary>
		/// Getter for Edit_AvailabilityGroup.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAvailabilityGroup()
		{
			return EditAvailabilityGroup;
		}

		/// <summary>
		/// Getter for AvailabilityGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetAvailabilityGroupName()
		{
			return AvailabilityGroupName;
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
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetAvailabilityGroupId(int? value)
		{
			AvailabilityGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AvailabilityGroup.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetEditAvailabilityGroup(String value)
		{
			EditAvailabilityGroup = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroup_Name.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetAvailabilityGroupName(String value)
		{
			AvailabilityGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>AvailabilityGroupProductUpdateAssignedRequest</returns>
		/// </summary>
		public AvailabilityGroupProductUpdateAssignedRequest SetAssigned(bool value)
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

			if (AvailabilityGroupId.HasValue)
			{
				writer.WriteNumber("AvailabilityGroup_ID", AvailabilityGroupId.Value);
			}
			else if (EditAvailabilityGroup != null && EditAvailabilityGroup.Length > 0)
			{
				writer.WriteString("Edit_AvailabilityGroup", EditAvailabilityGroup);
			}
			else if (AvailabilityGroupName != null && AvailabilityGroupName.Length > 0)
			{
				writer.WriteString("AvailabilityGroup_Name", AvailabilityGroupName);
			}

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

			writer.WriteBoolean("Assigned", Assigned);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AvailabilityGroupProductUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AvailabilityGroupProductUpdateAssignedResponse</returns>
		/// </summary>
		public new AvailabilityGroupProductUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<AvailabilityGroupProductUpdateAssignedRequest, AvailabilityGroupProductUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AvailabilityGroupProductUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<AvailabilityGroupProductUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AvailabilityGroupProductUpdateAssignedRequest, AvailabilityGroupProductUpdateAssignedResponse>(this);
		}
	}
}
