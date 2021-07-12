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
	public class JavaScriptResourceVersion : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ResourceId - int</value>
		[JsonPropertyName("res_id")]
		public int ResourceId { get; set; }

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

		/// <value>Property BranchlessFile - String</value>
		[JsonPropertyName("branchless_file")]
		public String BranchlessFile { get; set; }

		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplateId { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property UserName - String</value>
		[JsonPropertyName("user_name")]
		public String UserName { get; set; }

		/// <value>Property UserIcon - String</value>
		[JsonPropertyName("user_icon")]
		public String UserIcon { get; set; }

		/// <value>Property SourceUserId - int</value>
		[JsonPropertyName("source_user_id")]
		public int SourceUserId { get; set; }

		/// <value>Property SourceUserName - String</value>
		[JsonPropertyName("source_user_name")]
		public String SourceUserName { get; set; }

		/// <value>Property SourceUserIcon - String</value>
		[JsonPropertyName("source_user_icon")]
		public String SourceUserIcon { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("source")]
		public String Source { get; set; }

		/// <value>Property Attributes - List<JavaScriptResourceVersionAttribute></value>
		[JsonPropertyName("attributes")]
		public List<JavaScriptResourceVersionAttribute> Attributes { get; set; } = new List<JavaScriptResourceVersionAttribute>();

		/// <value>Property LinkedPages - List<Page></value>
		[JsonPropertyName("linkedpages")]
		public List<Page> LinkedPages { get; set; } = new List<Page>();

		/// <value>Property LinkedResources - List<JavaScriptResource></value>
		[JsonPropertyName("linkedresources")]
		public List<JavaScriptResource> LinkedResources { get; set; } = new List<JavaScriptResource>();

		/// <value>Property SourceNotes - String</value>
		[JsonPropertyName("source_notes")]
		public String SourceNotes { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for res_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetResourceId()
		{
			return ResourceId;
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
		/// Getter for branchless_file.
		/// <returns>String</returns>
		/// </summary>
		public String GetBranchlessFile()
		{
			return BranchlessFile;
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
		/// Getter for user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUserId()
		{
			return UserId;
		}

		/// <summary>
		/// Getter for user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetUserName()
		{
			return UserName;
		}

		/// <summary>
		/// Getter for user_icon.
		/// <returns>String</returns>
		/// </summary>
		public String GetUserIcon()
		{
			return UserIcon;
		}

		/// <summary>
		/// Getter for source_user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetSourceUserId()
		{
			return SourceUserId;
		}

		/// <summary>
		/// Getter for source_user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceUserName()
		{
			return SourceUserName;
		}

		/// <summary>
		/// Getter for source_user_icon.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceUserIcon()
		{
			return SourceUserIcon;
		}

		/// <summary>
		/// Getter for source.
		/// <returns>String</returns>
		/// </summary>
		public String GetSource()
		{
			return Source;
		}

		/// <summary>
		/// Getter for attributes.
		/// <returns>List<JavaScriptResourceVersionAttribute></returns>
		/// </summary>
		public List<JavaScriptResourceVersionAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for linkedpages.
		/// <returns>List<Page></returns>
		/// </summary>
		public List<Page> GetLinkedPages()
		{
			return LinkedPages;
		}

		/// <summary>
		/// Getter for linkedresources.
		/// <returns>List<JavaScriptResource></returns>
		/// </summary>
		public List<JavaScriptResource> GetLinkedResources()
		{
			return LinkedResources;
		}

		/// <summary>
		/// Getter for source_notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetSourceNotes()
		{
			return SourceNotes;
		}
	}
}
