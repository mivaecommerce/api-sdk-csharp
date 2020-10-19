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

		/// <value>Property File - int</value>
		[JsonPropertyName("file")]
		public int File { get; set; }

		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("templ_id")]
		public int TemplateId { get; set; }

		/// <value>Property Attributes - List<CSSResourceAttribute></value>
		[JsonPropertyName("attributes")]
		public List<CSSResourceAttribute> Attributes { get; set; } = new List<CSSResourceAttribute>();

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
		/// <returns>int</returns>
		/// </summary>
		public int GetFile()
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
	}
}
