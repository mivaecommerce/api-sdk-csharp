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
	public class OrderCustomField : Model
	{
		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property FieldType - String</value>
		[JsonPropertyName("type")]
		public String FieldType { get; set; }

		/// <value>Property Searchable - bool</value>
		[JsonPropertyName("searchable")]
		public bool Searchable { get; set; }

		/// <value>Property Sortable - bool</value>
		[JsonPropertyName("sortable")]
		public bool Sortable { get; set; }

		/// <value>Property Module - Module</value>
		[JsonPropertyName("module")]
		public Module Module { get; set; }

		/// <value>Property Choices - List<String></value>
		[JsonPropertyName("choices")]
		public List<String> Choices { get; set; } = new List<String>();

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetFieldType()
		{
			return FieldType;
		}

		/// <summary>
		/// Getter for searchable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetSearchable()
		{
			return Searchable;
		}

		/// <summary>
		/// Getter for sortable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetSortable()
		{
			return Sortable;
		}

		/// <summary>
		/// Getter for module.
		/// <returns>Module</returns>
		/// </summary>
		public Module GetModule()
		{
			return Module;
		}

		/// <summary>
		/// Getter for choices.
		/// <returns>List<String></returns>
		/// </summary>
		public List<String> GetChoices()
		{
			return Choices;
		}
	}
}
