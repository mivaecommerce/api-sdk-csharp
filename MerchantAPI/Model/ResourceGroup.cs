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
	public class ResourceGroup : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property LinkedCSSResources - List<CSSResource></value>
		[JsonPropertyName("linkedcssresources")]
		public List<CSSResource> LinkedCSSResources { get; set; } = new List<CSSResource>();

		/// <value>Property LinkedJavaScriptResources - List<JavaScriptResource></value>
		[JsonPropertyName("linkedjavascriptresources")]
		public List<JavaScriptResource> LinkedJavaScriptResources { get; set; } = new List<JavaScriptResource>();

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
		/// Getter for linkedcssresources.
		/// <returns>List<CSSResource></returns>
		/// </summary>
		public List<CSSResource> GetLinkedCSSResources()
		{
			return LinkedCSSResources;
		}

		/// <summary>
		/// Getter for linkedjavascriptresources.
		/// <returns>List<JavaScriptResource></returns>
		/// </summary>
		public List<JavaScriptResource> GetLinkedJavaScriptResources()
		{
			return LinkedJavaScriptResources;
		}
	}
}
