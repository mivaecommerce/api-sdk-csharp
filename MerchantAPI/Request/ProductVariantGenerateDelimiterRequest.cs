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
	/// Handles API Request ProductVariant_Generate_Delimiter.
	/// <see>https://docs.miva.com/json-api/functions/productvariant_generate_delimiter</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductVariantGenerateDelimiterRequest : ProductVariantGenerateRequest
	{
		/// Request field Delimiter.
		[JsonPropertyName("Delimiter")]
		public String Delimiter { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductVariantGenerateDelimiterRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "ProductVariant_Generate_Delimiter";
			if (product != null) {
			}
		}

		/// <summary>
		/// Getter for Delimiter.
		/// <returns>String</returns>
		/// </summary>
		public String GetDelimiter()
		{
			return Delimiter;
		}

		/// <summary>
		/// Setter for Delimiter.
		/// <param name="value">String</param>
		/// <returns>ProductVariantGenerateDelimiterRequest</returns>
		/// </summary>
		public ProductVariantGenerateDelimiterRequest SetDelimiter(String value)
		{
			Delimiter = value;
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

			if (Delimiter != null && Delimiter.Length > 0)
			{
				writer.WriteString("Delimiter", Delimiter);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductVariantGenerateDelimiterResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductVariantGenerateDelimiterResponse</returns>
		/// </summary>
		public new ProductVariantGenerateDelimiterResponse Send()
		{
			return Client.SendRequestAsync<ProductVariantGenerateDelimiterRequest, ProductVariantGenerateDelimiterResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductVariantGenerateDelimiterResponse></returns>
		/// </summary>
		public new async Task<ProductVariantGenerateDelimiterResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductVariantGenerateDelimiterRequest, ProductVariantGenerateDelimiterResponse>(this);
		}
	}
}
