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
	public class JavaScriptResource : Model
	{
		/// Enumeration JavaScriptResourceType
		public enum JavaScriptResourceType
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
		public static String JavaScriptResourceTypeToString(JavaScriptResourceType value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static JavaScriptResourceType? JavaScriptResourceTypeFromString(String value)
		{
			switch(value)
			{
				case "C": return JavaScriptResourceType.ResourceTypeCombined;
				case "I": return JavaScriptResourceType.ResourceTypeInline;
				case "E": return JavaScriptResourceType.ResourceTypeExternal;
				case "L": return JavaScriptResourceType.ResourceTypeLocal;
				case "M": return JavaScriptResourceType.ResourceTypeModule;
				case "Y": return JavaScriptResourceType.ResourceTypeModuleInline;
				case "Z": return JavaScriptResourceType.ResourceTypeModuleManaged;
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

		/// <value>Property Attributes - List<JavaScriptResourceAttribute></value>
		[JsonPropertyName("attributes")]
		public List<JavaScriptResourceAttribute> Attributes { get; set; } = new List<JavaScriptResourceAttribute>();

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
		/// <returns>JavaScriptResourceType?</returns>
		/// </summary>
		public JavaScriptResourceType? GetResourceTypeConst()
		{
			return JavaScriptResourceTypeFromString(ResourceType);
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
		/// <returns>List<JavaScriptResourceAttribute></returns>
		/// </summary>
		public List<JavaScriptResourceAttribute> GetAttributes()
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
	public static class JavaScriptResourceExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this JavaScriptResource.JavaScriptResourceType e)
	    {
			switch(e)
			{
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeCombined: return "C";
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeInline: return "I";
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeExternal: return "E";
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeLocal: return "L";
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeModule: return "M";
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeModuleInline: return "Y";
				case JavaScriptResource.JavaScriptResourceType.ResourceTypeModuleManaged: return "Z";
			}
			return "";
		}
	}
}
