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
	/// Handles API Request CSSResource_Insert.
	/// <see>https://docs.miva.com/json-api/functions/cssresource_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CSSResourceInsertRequest : Request
	{
		/// Request field CSSResource_Code.
		[JsonPropertyName("CSSResource_Code")]
		public String CSSResourceCode { get; set; }

		/// Request field CSSResource_Type.
		[JsonPropertyName("CSSResource_Type")]
		public String CSSResourceType { get; set; }

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

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CSSResourceInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CSSResource_Insert";
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
		/// Getter for CSSResource_Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetCSSResourceType()
		{
			return CSSResourceType;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>CSSResource.CSSResourceType?</returns>
		/// </summary>
		public CSSResource.CSSResourceType? GetCSSResourceTypeConst()
		{
			return CSSResource.CSSResourceTypeFromString(CSSResourceType);
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
		/// Setter for CSSResource_Code.
		/// <param name="value">String</param>
		/// <returns>CSSResourceInsertRequest</returns>
		/// </summary>
		public CSSResourceInsertRequest SetCSSResourceCode(String value)
		{
			CSSResourceCode = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Type.
		/// <param name="value">String</param>
		/// <returns>CSSResourceInsertRequest</returns>
		/// </summary>
		public CSSResourceInsertRequest SetCSSResourceType(String value)
		{
			CSSResourceType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">CSSResource.CSSResourceType</param>
		/// <returns></returns>
		/// </summary>
		public CSSResourceInsertRequest SetCSSResourceType(CSSResource.CSSResourceType value)
		{
			CSSResourceType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Global.
		/// <param name="value">bool</param>
		/// <returns>CSSResourceInsertRequest</returns>
		/// </summary>
		public CSSResourceInsertRequest SetCSSResourceGlobal(bool? value)
		{
			CSSResourceGlobal = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Active.
		/// <param name="value">bool</param>
		/// <returns>CSSResourceInsertRequest</returns>
		/// </summary>
		public CSSResourceInsertRequest SetCSSResourceActive(bool? value)
		{
			CSSResourceActive = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_File_Path.
		/// <param name="value">String</param>
		/// <returns>CSSResourceInsertRequest</returns>
		/// </summary>
		public CSSResourceInsertRequest SetCSSResourceFilePath(String value)
		{
			CSSResourceFilePath = value;
			return this;
		}

		/// <summary>
		/// Add a CSSResourceAttribute.
		/// - CSSResourceAttribute: CSSResourceAttribute
		/// - Returns: Self
		/// </summary>
		public CSSResourceInsertRequest AddCSSResourceAttribute(CSSResourceAttribute CSSResourceAttribute)
		{
			CSSResourceAttributes.Add(CSSResourceAttribute);
			return this;
		}

		/// <summary>
		/// Add an array of CSSResourceAttribute.
		/// <param name="CSSResourceAttributes">List<CSSResourceAttribute></param>
		/// <returns>CSSResourceInsertRequest</returns>
		/// </summary>
		public CSSResourceInsertRequest AddCSSResourceAttributes(List<CSSResourceAttribute> CSSResourceAttributes)
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

			writer.WriteString("CSSResource_Code", CSSResourceCode);

			writer.WriteString("CSSResource_Type", CSSResourceType);

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
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CSSResourceInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CSSResourceInsertResponse</returns>
		/// </summary>
		public new CSSResourceInsertResponse Send()
		{
			return Client.SendRequestAsync<CSSResourceInsertRequest, CSSResourceInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CSSResourceInsertResponse></returns>
		/// </summary>
		public new async Task<CSSResourceInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CSSResourceInsertRequest, CSSResourceInsertResponse>(this);
		}
	}
}
