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
	/// Handles API Request JavaScriptResource_Update.
	/// <see>https://docs.miva.com/json-api/functions/javascriptresource_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class JavaScriptResourceUpdateRequest : Request
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

		/// Request field JavaScriptResource_Type.
		[JsonPropertyName("JavaScriptResource_Type")]
		public String JavaScriptResourceType { get; set; }

		/// Request field JavaScriptResource_Global.
		[JsonPropertyName("JavaScriptResource_Global")]
		public bool? JavaScriptResourceGlobal { get; set; }

		/// Request field JavaScriptResource_Active.
		[JsonPropertyName("JavaScriptResource_Active")]
		public bool? JavaScriptResourceActive { get; set; }

		/// Request field JavaScriptResource_File_Path.
		[JsonPropertyName("JavaScriptResource_File_Path")]
		public String JavaScriptResourceFilePath { get; set; }

		/// Request field JavaScriptResource_Attributes.
		[JsonPropertyName("JavaScriptResource_Attributes")]
		public List<JavaScriptResourceAttribute> JavaScriptResourceAttributes { get; set; } = new List<JavaScriptResourceAttribute>();

		/// Request field JavaScriptResource_Module_Code.
		[JsonPropertyName("JavaScriptResource_Module_Code")]
		public String JavaScriptResourceModuleCode { get; set; }

		/// Request field JavaScriptResource_Module_Data.
		[JsonPropertyName("JavaScriptResource_Module_Data")]
		public String JavaScriptResourceModuleData { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="javaScriptResource">JavaScriptResource</param>
		/// </summary>
		public JavaScriptResourceUpdateRequest(BaseClient client = null, JavaScriptResource javaScriptResource = null) :
			base(client)
		{
			Function = "JavaScriptResource_Update";
			if (javaScriptResource != null) {
				if (javaScriptResource.Id > 0)
				{
					JavaScriptResourceId = javaScriptResource.Id;
				}
				else if (javaScriptResource.Code.Length > 0)
				{
					EditJavaScriptResource = javaScriptResource.Code;
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
		/// Getter for JavaScriptResource_Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetJavaScriptResourceType()
		{
			return JavaScriptResourceType;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>JavaScriptResource.JavaScriptResourceType?</returns>
		/// </summary>
		public JavaScriptResource.JavaScriptResourceType? GetJavaScriptResourceTypeConst()
		{
			return JavaScriptResource.JavaScriptResourceTypeFromString(JavaScriptResourceType);
		}

		/// <summary>
		/// Getter for JavaScriptResource_Global.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetJavaScriptResourceGlobal()
		{
			return JavaScriptResourceGlobal;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetJavaScriptResourceActive()
		{
			return JavaScriptResourceActive;
		}

		/// <summary>
		/// Getter for JavaScriptResource_File_Path.
		/// <returns>String</returns>
		/// </summary>
		public String GetJavaScriptResourceFilePath()
		{
			return JavaScriptResourceFilePath;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Attributes.
		/// <returns>List<JavaScriptResourceAttribute></returns>
		/// </summary>
		public List<JavaScriptResourceAttribute> GetJavaScriptResourceAttributes()
		{
			return JavaScriptResourceAttributes;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetJavaScriptResourceModuleCode()
		{
			return JavaScriptResourceModuleCode;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Module_Data.
		/// <returns>String</returns>
		/// </summary>
		public String GetJavaScriptResourceModuleData()
		{
			return JavaScriptResourceModuleData;
		}

		/// <summary>
		/// Setter for JavaScriptResource_ID.
		/// <param name="value">int</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceId(int? value)
		{
			JavaScriptResourceId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_JavaScriptResource.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetEditJavaScriptResource(String value)
		{
			EditJavaScriptResource = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Code.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceCode(String value)
		{
			JavaScriptResourceCode = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Type.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceType(String value)
		{
			JavaScriptResourceType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">JavaScriptResource.JavaScriptResourceType</param>
		/// <returns></returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceType(JavaScriptResource.JavaScriptResourceType value)
		{
			JavaScriptResourceType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Global.
		/// <param name="value">bool</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceGlobal(bool? value)
		{
			JavaScriptResourceGlobal = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Active.
		/// <param name="value">bool</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceActive(bool? value)
		{
			JavaScriptResourceActive = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_File_Path.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceFilePath(String value)
		{
			JavaScriptResourceFilePath = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Module_Code.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceModuleCode(String value)
		{
			JavaScriptResourceModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Module_Data.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest SetJavaScriptResourceModuleData(String value)
		{
			JavaScriptResourceModuleData = value;
			return this;
		}

		/// <summary>
		/// Add a JavaScriptResourceAttribute.
		/// - javaScriptResourceAttribute: JavaScriptResourceAttribute
		/// - Returns: Self
		/// </summary>
		public JavaScriptResourceUpdateRequest AddJavaScriptResourceAttribute(JavaScriptResourceAttribute javaScriptResourceAttribute)
		{
			JavaScriptResourceAttributes.Add(javaScriptResourceAttribute);
			return this;
		}

		/// <summary>
		/// Add an array of JavaScriptResourceAttribute.
		/// <param name="javaScriptResourceAttributes">List<JavaScriptResourceAttribute></param>
		/// <returns>JavaScriptResourceUpdateRequest</returns>
		/// </summary>
		public JavaScriptResourceUpdateRequest AddJavaScriptResourceAttributes(List<JavaScriptResourceAttribute> javaScriptResourceAttributes)
		{
			foreach(JavaScriptResourceAttribute e in javaScriptResourceAttributes)
			{
				JavaScriptResourceAttributes.Add(e);
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

			writer.WriteString("JavaScriptResource_Type", JavaScriptResourceType);

			if (JavaScriptResourceGlobal.HasValue)
			{
				writer.WriteBoolean("JavaScriptResource_Global", JavaScriptResourceGlobal.Value);
			}

			if (JavaScriptResourceActive.HasValue)
			{
				writer.WriteBoolean("JavaScriptResource_Active", JavaScriptResourceActive.Value);
			}

			writer.WriteString("JavaScriptResource_File_Path", JavaScriptResourceFilePath);

			if (JavaScriptResourceAttributes.Count > 0)
			{
				writer.WritePropertyName("JavaScriptResource_Attributes");
				JsonSerializer.Serialize(writer, this.JavaScriptResourceAttributes, options);
			}

			if (JavaScriptResourceModuleCode != null && JavaScriptResourceModuleCode.Length > 0)
			{
				writer.WriteString("JavaScriptResource_Module_Code", JavaScriptResourceModuleCode);
			}

			if (JavaScriptResourceModuleData != null && JavaScriptResourceModuleData.Length > 0)
			{
				writer.WriteString("JavaScriptResource_Module_Data", JavaScriptResourceModuleData);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<JavaScriptResourceUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>JavaScriptResourceUpdateResponse</returns>
		/// </summary>
		public new JavaScriptResourceUpdateResponse Send()
		{
			return Client.SendRequestAsync<JavaScriptResourceUpdateRequest, JavaScriptResourceUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<JavaScriptResourceUpdateResponse></returns>
		/// </summary>
		public new async Task<JavaScriptResourceUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<JavaScriptResourceUpdateRequest, JavaScriptResourceUpdateResponse>(this);
		}
	}
}
