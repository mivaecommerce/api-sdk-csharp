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
	/// Handles API Request ProductList_Adjust_Inventory.
	/// <see>https://docs.miva.com/json-api/functions/productlist_adjust_inventory</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductListAdjustInventoryRequest : Request
	{
		/// Request field Inventory_Adjustments.
		[JsonPropertyName("Inventory_Adjustments")]
		public List<ProductInventoryAdjustment> InventoryAdjustments { get; set; } = new List<ProductInventoryAdjustment>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ProductListAdjustInventoryRequest(BaseClient client = null) :
			base(client)
		{
			Function = "ProductList_Adjust_Inventory";
		}

		/// <summary>
		/// Getter for Inventory_Adjustments.
		/// <returns>List<ProductInventoryAdjustment></returns>
		/// </summary>
		public List<ProductInventoryAdjustment> GetInventoryAdjustments()
		{
			return InventoryAdjustments;
		}

		/// <summary>
		/// Add a ProductInventoryAdjustment.
		/// - inventoryAdjustment: ProductInventoryAdjustment
		/// - Returns: Self
		/// </summary>
		public ProductListAdjustInventoryRequest AddInventoryAdjustment(ProductInventoryAdjustment inventoryAdjustment)
		{
			InventoryAdjustments.Add(inventoryAdjustment);
			return this;
		}

		/// <summary>
		/// Add an array of ProductInventoryAdjustment.
		/// <param name="inventoryAdjustments">List<ProductInventoryAdjustment></param>
		/// <returns>ProductListAdjustInventoryRequest</returns>
		/// </summary>
		public ProductListAdjustInventoryRequest AddInventoryAdjustments(List<ProductInventoryAdjustment> inventoryAdjustments)
		{
			foreach(ProductInventoryAdjustment e in inventoryAdjustments)
			{
				InventoryAdjustments.Add(e);
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

			writer.WritePropertyName("Inventory_Adjustments");
			JsonSerializer.Serialize(writer, this.InventoryAdjustments, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductListAdjustInventoryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductListAdjustInventoryResponse</returns>
		/// </summary>
		public new ProductListAdjustInventoryResponse Send()
		{
			return Client.SendRequestAsync<ProductListAdjustInventoryRequest, ProductListAdjustInventoryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductListAdjustInventoryResponse></returns>
		/// </summary>
		public new async Task<ProductListAdjustInventoryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductListAdjustInventoryRequest, ProductListAdjustInventoryResponse>(this);
		}
	}
}
