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
	/// Handles API Request CategoryList_Load_Parent.
	/// <see>https://docs.miva.com/json-api/functions/categorylist_load_parent</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryListLoadParentRequest : Request
	{
		/// Request field Parent_ID.
		[JsonPropertyName("Parent_ID")]
		public int ParentId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="category">Category</param>
		/// </summary>
		public CategoryListLoadParentRequest(Client client = null, Category category = null) :
			base(client)
		{
			Function = "CategoryList_Load_Parent";
			if (category != null) {
				ParentId = category.Id;
			}
		}

		/// <summary>
		/// Getter for Parent_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetParentId()
		{
			return ParentId;
		}

		/// <summary>
		/// Setter for Parent_ID.
		/// <param name="value">int</param>
		/// <returns>CategoryListLoadParentRequest</returns>
		/// </summary>
		public CategoryListLoadParentRequest SetParentId(int value)
		{
			ParentId = value;
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

			writer.WriteNumber("Parent_ID", ParentId);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryListLoadParentResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryListLoadParentResponse</returns>
		/// </summary>
		public new CategoryListLoadParentResponse Send()
		{
			return Client.SendRequestAsync<CategoryListLoadParentRequest, CategoryListLoadParentResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryListLoadParentResponse></returns>
		/// </summary>
		public new async Task<CategoryListLoadParentResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryListLoadParentRequest, CategoryListLoadParentResponse>(this);
		}
	}
}
