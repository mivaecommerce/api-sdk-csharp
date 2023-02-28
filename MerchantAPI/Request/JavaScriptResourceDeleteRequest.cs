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
	/// Handles API Request JavaScriptResource_Delete.
	/// <see>https://docs.miva.com/json-api/functions/javascriptresource_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class JavaScriptResourceDeleteRequest : Request
	{
		/// Request field JavaScriptResource_ID.
		[JsonPropertyName("JavaScriptResource_ID")]
		public int? JavaScriptResourceId { get; set; }

		/// Request field Edit_JavaScriptResource.
		[JsonPropertyName("Edit_JavaScriptResource")]
		public String EditJavaScriptResource { get; set; }

		/// Request field JavaScriptResource_Code.
		[JsonPropertyName("JavaScriptResource_Code")]
		public String JavaScriptResourceCode { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="javaScriptResource">JavaScriptResource</param>
		/// </summary>
		public JavaScriptResourceDeleteRequest(BaseClient client = null, JavaScriptResource javaScriptResource = null) :
			base(client)
		{
			Function = "JavaScriptResource_Delete";
			if (javaScriptResource != null) {
				if (javaScriptResource.Id > 0)
				{
					JavaScriptResourceId = javaScriptResource.Id;
				}
				else if (javaScriptResource.Code.Length > 0)
				{
					EditJavaScriptResource = javaScriptResource.Code;
				}
				else if (javaScriptResource.Code.Length > 0)
				{
					JavaScriptResourceCode = javaScriptResource.Code;
				}

				JavaScriptResourceCode = javaScriptResource.Code;
			}
		}

		/// <summary>
		/// Getter for JavaScriptResource_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetJavaScriptResourceId()
		{
			return JavaScriptResourceId;
		}

		/// <summary>
		/// Getter for Edit_JavaScriptResource.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditJavaScriptResource()
		{
			return EditJavaScriptResource;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetJavaScriptResourceCode()
		{
			return JavaScriptResourceCode;
		}

		/// <summary>
		/// Setter for JavaScriptResource_ID.
		/// <param name="value">int</param>
		/// <returns>JavaScriptResourceDeleteRequest</returns>
		/// </summary>
		public JavaScriptResourceDeleteRequest SetJavaScriptResourceId(int? value)
		{
			JavaScriptResourceId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_JavaScriptResource.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceDeleteRequest</returns>
		/// </summary>
		public JavaScriptResourceDeleteRequest SetEditJavaScriptResource(String value)
		{
			EditJavaScriptResource = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Code.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceDeleteRequest</returns>
		/// </summary>
		public JavaScriptResourceDeleteRequest SetJavaScriptResourceCode(String value)
		{
			JavaScriptResourceCode = value;
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

			if (JavaScriptResourceId.HasValue)
			{
				writer.WriteNumber("JavaScriptResource_ID", JavaScriptResourceId.Value);
			}
			else if (EditJavaScriptResource != null && EditJavaScriptResource.Length > 0)
			{
				writer.WriteString("Edit_JavaScriptResource", EditJavaScriptResource);
			}
			else if (JavaScriptResourceCode != null && JavaScriptResourceCode.Length > 0)
			{
				writer.WriteString("JavaScriptResource_Code", JavaScriptResourceCode);
			}

			if (JavaScriptResourceCode != null && JavaScriptResourceCode.Length > 0)
			{
				writer.WriteString("JavaScriptResource_Code", JavaScriptResourceCode);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<JavaScriptResourceDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>JavaScriptResourceDeleteResponse</returns>
		/// </summary>
		public new JavaScriptResourceDeleteResponse Send()
		{
			return Client.SendRequestAsync<JavaScriptResourceDeleteRequest, JavaScriptResourceDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<JavaScriptResourceDeleteResponse></returns>
		/// </summary>
		public new async Task<JavaScriptResourceDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<JavaScriptResourceDeleteRequest, JavaScriptResourceDeleteResponse>(this);
		}
	}
}
