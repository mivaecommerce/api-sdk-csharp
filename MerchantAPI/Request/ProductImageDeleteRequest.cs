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
	/// Handles API Request ProductImage_Delete.
	/// <see>https://docs.miva.com/json-api/functions/productimage_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductImageDeleteRequest : Request
	{
		/// Request field ProductImage_ID.
		[JsonPropertyName("ProductImage_ID")]
		public int ProductImageId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="productImageData">ProductImageData</param>
		/// </summary>
		public ProductImageDeleteRequest(BaseClient client = null, ProductImageData productImageData = null) :
			base(client)
		{
			Function = "ProductImage_Delete";
			if (productImageData != null) {
				ProductImageId = productImageData.Id;
			}
		}

		/// <summary>
		/// Getter for ProductImage_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductImageId()
		{
			return ProductImageId;
		}

		/// <summary>
		/// Setter for ProductImage_ID.
		/// <param name="value">int</param>
		/// <returns>ProductImageDeleteRequest</returns>
		/// </summary>
		public ProductImageDeleteRequest SetProductImageId(int value)
		{
			ProductImageId = value;
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

			writer.WriteNumber("ProductImage_ID", ProductImageId);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductImageDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductImageDeleteResponse</returns>
		/// </summary>
		public new ProductImageDeleteResponse Send()
		{
			return Client.SendRequestAsync<ProductImageDeleteRequest, ProductImageDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductImageDeleteResponse></returns>
		/// </summary>
		public new async Task<ProductImageDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductImageDeleteRequest, ProductImageDeleteResponse>(this);
		}
	}
}
