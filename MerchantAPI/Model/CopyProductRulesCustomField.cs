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
	public class CopyProductRulesCustomField : Model
	{
		/// <value>Property RulesId - int</value>
		[JsonPropertyName("rules_id")]
		public int RulesId { get; set; }

		/// <value>Property Assigned - bool</value>
		[JsonPropertyName("assigned")]
		public bool Assigned { get; set; }

		/// <value>Property FieldCode - String</value>
		[JsonPropertyName("field_code")]
		public String FieldCode { get; set; }

		/// <value>Property FieldName - String</value>
		[JsonPropertyName("field_name")]
		public String FieldName { get; set; }

		/// <value>Property Module - Module</value>
		[JsonPropertyName("module")]
		public Module Module { get; set; }

		/// <summary>
		/// Getter for rules_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetRulesId()
		{
			return RulesId;
		}

		/// <summary>
		/// Getter for assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Getter for field_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetFieldCode()
		{
			return FieldCode;
		}

		/// <summary>
		/// Getter for field_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetFieldName()
		{
			return FieldName;
		}

		/// <summary>
		/// Getter for module.
		/// <returns>Module</returns>
		/// </summary>
		public Module GetModule()
		{
			return Module;
		}
	}
}
