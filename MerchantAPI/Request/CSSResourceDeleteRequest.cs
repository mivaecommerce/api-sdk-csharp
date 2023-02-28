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
	/// Handles API Request CSSResource_Delete.
	/// <see>https://docs.miva.com/json-api/functions/cssresource_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CSSResourceDeleteRequest : Request
	{
		/// Request field CSSResource_ID.
		[JsonPropertyName("CSSResource_ID")]
		public int? CSSResourceId { get; set; }

		/// Request field Edit_CSSResource.
		[JsonPropertyName("Edit_CSSResource")]
		public String EditCSSResource { get; set; }

		/// Request field CSSResource_Code.
		[JsonPropertyName("CSSResource_Code")]
		public String CSSResourceCode { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="CSSResource">CSSResource</param>
		/// </summary>
		public CSSResourceDeleteRequest(BaseClient client = null, CSSResource CSSResource = null) :
			base(client)
		{
			Function = "CSSResource_Delete";
			if (CSSResource != null) {
				if (CSSResource.Id > 0)
				{
					CSSResourceId = CSSResource.Id;
				}
				else if (CSSResource.Code.Length > 0)
				{
					EditCSSResource = CSSResource.Code;
				}
				else if (CSSResource.Code.Length > 0)
				{
					CSSResourceCode = CSSResource.Code;
				}

				CSSResourceCode = CSSResource.Code;
			}
		}

		/// <summary>
		/// Getter for CSSResource_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCSSResourceId()
		{
			return CSSResourceId;
		}

		/// <summary>
		/// Getter for Edit_CSSResource.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCSSResource()
		{
			return EditCSSResource;
		}

		/// <summary>
		/// Getter for CSSResource_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCSSResourceCode()
		{
			return CSSResourceCode;
		}

		/// <summary>
		/// Setter for CSSResource_ID.
		/// <param name="value">int</param>
		/// <returns>CSSResourceDeleteRequest</returns>
		/// </summary>
		public CSSResourceDeleteRequest SetCSSResourceId(int? value)
		{
			CSSResourceId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_CSSResource.
		/// <param name="value">String</param>
		/// <returns>CSSResourceDeleteRequest</returns>
		/// </summary>
		public CSSResourceDeleteRequest SetEditCSSResource(String value)
		{
			EditCSSResource = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Code.
		/// <param name="value">String</param>
		/// <returns>CSSResourceDeleteRequest</returns>
		/// </summary>
		public CSSResourceDeleteRequest SetCSSResourceCode(String value)
		{
			CSSResourceCode = value;
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

			if (CSSResourceId.HasValue)
			{
				writer.WriteNumber("CSSResource_ID", CSSResourceId.Value);
			}
			else if (EditCSSResource != null && EditCSSResource.Length > 0)
			{
				writer.WriteString("Edit_CSSResource", EditCSSResource);
			}
			else if (CSSResourceCode != null && CSSResourceCode.Length > 0)
			{
				writer.WriteString("CSSResource_Code", CSSResourceCode);
			}

			if (CSSResourceCode != null && CSSResourceCode.Length > 0)
			{
				writer.WriteString("CSSResource_Code", CSSResourceCode);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CSSResourceDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CSSResourceDeleteResponse</returns>
		/// </summary>
		public new CSSResourceDeleteResponse Send()
		{
			return Client.SendRequestAsync<CSSResourceDeleteRequest, CSSResourceDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CSSResourceDeleteResponse></returns>
		/// </summary>
		public new async Task<CSSResourceDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CSSResourceDeleteRequest, CSSResourceDeleteResponse>(this);
		}
	}
}
