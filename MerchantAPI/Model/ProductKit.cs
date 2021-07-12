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
	public class ProductKit : Model
	{
		/// <value>Property AttrId - int</value>
		[JsonPropertyName("attr_id")]
		public int AttrId { get; set; }

		/// <value>Property AttrType - String</value>
		[JsonPropertyName("attr_type")]
		public String AttrType { get; set; }

		/// <value>Property AttrCode - String</value>
		[JsonPropertyName("attr_code")]
		public String AttrCode { get; set; }

		/// <value>Property AttrPrompt - String</value>
		[JsonPropertyName("attr_prompt")]
		public String AttrPrompt { get; set; }

		/// <value>Property AttmpatId - int</value>
		[JsonPropertyName("attmpat_id")]
		public int AttmpatId { get; set; }

		/// <value>Property OptionId - int</value>
		[JsonPropertyName("option_id")]
		public int OptionId { get; set; }

		/// <value>Property OptionCode - String</value>
		[JsonPropertyName("option_code")]
		public String OptionCode { get; set; }

		/// <value>Property OptionPrompt - String</value>
		[JsonPropertyName("option_prompt")]
		public String OptionPrompt { get; set; }

		/// <value>Property Parts - List<ProductKitPart></value>
		[JsonPropertyName("parts")]
		public List<ProductKitPart> Parts { get; set; } = new List<ProductKitPart>();

		/// <summary>
		/// Getter for attr_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttrId()
		{
			return AttrId;
		}

		/// <summary>
		/// Getter for attr_type.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttrType()
		{
			return AttrType;
		}

		/// <summary>
		/// Getter for attr_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttrCode()
		{
			return AttrCode;
		}

		/// <summary>
		/// Getter for attr_prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttrPrompt()
		{
			return AttrPrompt;
		}

		/// <summary>
		/// Getter for attmpat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAttmpatId()
		{
			return AttmpatId;
		}

		/// <summary>
		/// Getter for option_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOptionId()
		{
			return OptionId;
		}

		/// <summary>
		/// Getter for option_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionCode()
		{
			return OptionCode;
		}

		/// <summary>
		/// Getter for option_prompt.
		/// <returns>String</returns>
		/// </summary>
		public String GetOptionPrompt()
		{
			return OptionPrompt;
		}

		/// <summary>
		/// Getter for parts.
		/// <returns>List<ProductKitPart></returns>
		/// </summary>
		public List<ProductKitPart> GetParts()
		{
			return Parts;
		}
	}
}
