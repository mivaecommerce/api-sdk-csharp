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
	/// Handles API Request CSSResource_Update.
	/// <see>https://docs.miva.com/json-api/functions/cssresource_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CSSResourceUpdateRequest : Request
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

		/// Request field CSSResource_Global.
		[JsonPropertyName("CSSResource_Global")]
		public bool? CSSResourceGlobal { get; set; }

		/// Request field CSSResource_Active.
		[JsonPropertyName("CSSResource_Active")]
		public bool? CSSResourceActive { get; set; }

		/// Request field CSSResource_File_Path.
		[JsonPropertyName("CSSResource_File_Path")]
		public String CSSResourceFilePath { get; set; }

		/// Request field CSSResource_Attributes.
		[JsonPropertyName("CSSResource_Attributes")]
		public List<CSSResourceAttribute> CSSResourceAttributes { get; set; } = new List<CSSResourceAttribute>();

		/// Request field CSSResource_Module_Code.
		[JsonPropertyName("CSSResource_Module_Code")]
		public String CSSResourceModuleCode { get; set; }

		/// Request field CSSResource_Module_Data.
		[JsonPropertyName("CSSResource_Module_Data")]
		public String CSSResourceModuleData { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="CSSResource">CSSResource</param>
		/// </summary>
		public CSSResourceUpdateRequest(BaseClient client = null, CSSResource CSSResource = null) :
			base(client)
		{
			Function = "CSSResource_Update";
			if (CSSResource != null) {
				if (CSSResource.Id > 0)
				{
					CSSResourceId = CSSResource.Id;
				}
				else if (CSSResource.Code.Length > 0)
				{
					EditCSSResource = CSSResource.Code;
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
		/// Getter for CSSResource_Global.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCSSResourceGlobal()
		{
			return CSSResourceGlobal;
		}

		/// <summary>
		/// Getter for CSSResource_Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCSSResourceActive()
		{
			return CSSResourceActive;
		}

		/// <summary>
		/// Getter for CSSResource_File_Path.
		/// <returns>String</returns>
		/// </summary>
		public String GetCSSResourceFilePath()
		{
			return CSSResourceFilePath;
		}

		/// <summary>
		/// Getter for CSSResource_Attributes.
		/// <returns>List<CSSResourceAttribute></returns>
		/// </summary>
		public List<CSSResourceAttribute> GetCSSResourceAttributes()
		{
			return CSSResourceAttributes;
		}

		/// <summary>
		/// Getter for CSSResource_Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCSSResourceModuleCode()
		{
			return CSSResourceModuleCode;
		}

		/// <summary>
		/// Getter for CSSResource_Module_Data.
		/// <returns>String</returns>
		/// </summary>
		public String GetCSSResourceModuleData()
		{
			return CSSResourceModuleData;
		}

		/// <summary>
		/// Setter for CSSResource_ID.
		/// <param name="value">int</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceId(int? value)
		{
			CSSResourceId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_CSSResource.
		/// <param name="value">String</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetEditCSSResource(String value)
		{
			EditCSSResource = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Code.
		/// <param name="value">String</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceCode(String value)
		{
			CSSResourceCode = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Global.
		/// <param name="value">bool</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceGlobal(bool? value)
		{
			CSSResourceGlobal = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Active.
		/// <param name="value">bool</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceActive(bool? value)
		{
			CSSResourceActive = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_File_Path.
		/// <param name="value">String</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceFilePath(String value)
		{
			CSSResourceFilePath = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Module_Code.
		/// <param name="value">String</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceModuleCode(String value)
		{
			CSSResourceModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Module_Data.
		/// <param name="value">String</param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest SetCSSResourceModuleData(String value)
		{
			CSSResourceModuleData = value;
			return this;
		}

		/// <summary>
		/// Add a CSSResourceAttribute.
		/// - CSSResourceAttribute: CSSResourceAttribute
		/// - Returns: Self
		/// </summary>
		public CSSResourceUpdateRequest AddCSSResourceAttribute(CSSResourceAttribute CSSResourceAttribute)
		{
			CSSResourceAttributes.Add(CSSResourceAttribute);
			return this;
		}

		/// <summary>
		/// Add an array of CSSResourceAttribute.
		/// <param name="CSSResourceAttributes">List<CSSResourceAttribute></param>
		/// <returns>CSSResourceUpdateRequest</returns>
		/// </summary>
		public CSSResourceUpdateRequest AddCSSResourceAttributes(List<CSSResourceAttribute> CSSResourceAttributes)
		{
			foreach(CSSResourceAttribute e in CSSResourceAttributes)
			{
				CSSResourceAttributes.Add(e);
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

			if (CSSResourceGlobal.HasValue)
			{
				writer.WriteBoolean("CSSResource_Global", CSSResourceGlobal.Value);
			}

			if (CSSResourceActive.HasValue)
			{
				writer.WriteBoolean("CSSResource_Active", CSSResourceActive.Value);
			}

			writer.WriteString("CSSResource_File_Path", CSSResourceFilePath);

			if (CSSResourceAttributes.Count > 0)
			{
				writer.WritePropertyName("CSSResource_Attributes");
				JsonSerializer.Serialize(writer, this.CSSResourceAttributes, options);
			}

			if (CSSResourceModuleCode != null && CSSResourceModuleCode.Length > 0)
			{
				writer.WriteString("CSSResource_Module_Code", CSSResourceModuleCode);
			}

			if (CSSResourceModuleData != null && CSSResourceModuleData.Length > 0)
			{
				writer.WriteString("CSSResource_Module_Data", CSSResourceModuleData);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CSSResourceUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CSSResourceUpdateResponse</returns>
		/// </summary>
		public new CSSResourceUpdateResponse Send()
		{
			return Client.SendRequestAsync<CSSResourceUpdateRequest, CSSResourceUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CSSResourceUpdateResponse></returns>
		/// </summary>
		public new async Task<CSSResourceUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CSSResourceUpdateRequest, CSSResourceUpdateResponse>(this);
		}
	}
}
