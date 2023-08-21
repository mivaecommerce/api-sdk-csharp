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

namespace MerchantAPI
{
	public class CSSResource : Model
	{
		/// Enumeration CSSResourceType
		public enum CSSResourceType
		{
			ResourceTypeCombined,
			ResourceTypeInline,
			ResourceTypeExternal,
			ResourceTypeLocal,
			ResourceTypeModule,
			ResourceTypeModuleInline,
			ResourceTypeModuleManaged,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String CSSResourceTypeToString(CSSResourceType value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static CSSResourceType? CSSResourceTypeFromString(String value)
		{
			switch(value)
			{
				case "C": return CSSResourceType.ResourceTypeCombined;
				case "I": return CSSResourceType.ResourceTypeInline;
				case "E": return CSSResourceType.ResourceTypeExternal;
				case "L": return CSSResourceType.ResourceTypeLocal;
				case "M": return CSSResourceType.ResourceTypeModule;
				case "Y": return CSSResourceType.ResourceTypeModuleInline;
				case "Z": return CSSResourceType.ResourceTypeModuleManaged;
				default: return null;
			}
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property ResourceType - String</value>
		[JsonPropertyName("type")]
		public String ResourceType { get; set; }

		/// <value>Property IsGlobal - bool</value>
		[JsonPropertyName("is_global")]
		public bool IsGlobal { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property File - String</value>
		[JsonPropertyName("file")]
		public String File { get; set; }

		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplateId { get; set; }

		/// <value>Property Attributes - List<CSSResourceAttribute></value>
		[JsonPropertyName("attributes")]
		public List<CSSResourceAttribute> Attributes { get; set; } = new List<CSSResourceAttribute>();

		/// <value>Property ModuleCode - String</value>
		[JsonPropertyName("mod_code")]
		public String ModuleCode { get; set; }

		/// <value>Property ModuleData - String</value>
		[JsonPropertyName("mod_data")]
		public String ModuleData { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetResourceType()
		{
			return ResourceType;
		}

		/// <summary>
		/// Enum Getter for type.
		/// <returns>CSSResourceType?</returns>
		/// </summary>
		public CSSResourceType? GetResourceTypeConst()
		{
			return CSSResourceTypeFromString(ResourceType);
		}

		/// <summary>
		/// Getter for is_global.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetIsGlobal()
		{
			return IsGlobal;
		}

		/// <summary>
		/// Getter for active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetActive()
		{
			return Active;
		}

		/// <summary>
		/// Getter for file.
		/// <returns>String</returns>
		/// </summary>
		public String GetFile()
		{
			return File;
		}

		/// <summary>
		/// Getter for templ_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTemplateId()
		{
			return TemplateId;
		}

		/// <summary>
		/// Getter for attributes.
		/// <returns>List<CSSResourceAttribute></returns>
		/// </summary>
		public List<CSSResourceAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for mod_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for mod_data.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleData()
		{
			return ModuleData;
		}
	}

	/// Enum Extensions
	public static class CSSResourceExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this CSSResource.CSSResourceType e)
	    {
			switch(e)
			{
				case CSSResource.CSSResourceType.ResourceTypeCombined: return "C";
				case CSSResource.CSSResourceType.ResourceTypeInline: return "I";
				case CSSResource.CSSResourceType.ResourceTypeExternal: return "E";
				case CSSResource.CSSResourceType.ResourceTypeLocal: return "L";
				case CSSResource.CSSResourceType.ResourceTypeModule: return "M";
				case CSSResource.CSSResourceType.ResourceTypeModuleInline: return "Y";
				case CSSResource.CSSResourceType.ResourceTypeModuleManaged: return "Z";
			}
			return "";
		}
	}
}
