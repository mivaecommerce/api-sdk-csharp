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
	/// Handles API Request ProductImage_Update_Type.
	/// <see>https://docs.miva.com/json-api/functions/productimage_update_type</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductImageUpdateTypeRequest : Request
	{
		/// Request field ProductImage_ID.
		[JsonPropertyName("ProductImage_ID")]
		public int ProductImageId { get; set; }

		/// Request field ImageType_ID.
		[JsonPropertyName("ImageType_ID")]
		public int? ImageTypeId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ProductImageUpdateTypeRequest(BaseClient client = null) :
			base(client)
		{
			Function = "ProductImage_Update_Type";
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
		/// Getter for ImageType_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetImageTypeId()
		{
			return ImageTypeId;
		}

		/// <summary>
		/// Setter for ProductImage_ID.
		/// <param name="value">int</param>
		/// <returns>ProductImageUpdateTypeRequest</returns>
		/// </summary>
		public ProductImageUpdateTypeRequest SetProductImageId(int value)
		{
			ProductImageId = value;
			return this;
		}

		/// <summary>
		/// Setter for ImageType_ID.
		/// <param name="value">int</param>
		/// <returns>ProductImageUpdateTypeRequest</returns>
		/// </summary>
		public ProductImageUpdateTypeRequest SetImageTypeId(int? value)
		{
			ImageTypeId = value;
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

			if (ImageTypeId.HasValue)
			{
				writer.WriteNumber("ImageType_ID", ImageTypeId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductImageUpdateTypeResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductImageUpdateTypeResponse</returns>
		/// </summary>
		public new ProductImageUpdateTypeResponse Send()
		{
			return Client.SendRequestAsync<ProductImageUpdateTypeRequest, ProductImageUpdateTypeResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductImageUpdateTypeResponse></returns>
		/// </summary>
		public new async Task<ProductImageUpdateTypeResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductImageUpdateTypeRequest, ProductImageUpdateTypeResponse>(this);
		}
	}
}
