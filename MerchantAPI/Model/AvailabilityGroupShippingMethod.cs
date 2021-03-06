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
	public class AvailabilityGroupShippingMethod : Model
	{
		/// <value>Property ModuleCode - String</value>
		[JsonPropertyName("mod_code")]
		public String ModuleCode { get; set; }

		/// <value>Property MethodCode - String</value>
		[JsonPropertyName("meth_code")]
		public String MethodCode { get; set; }

		/// <value>Property MethodName - String</value>
		[JsonPropertyName("method_name")]
		public String MethodName { get; set; }

		/// <value>Property Assigned - bool</value>
		[JsonPropertyName("assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Getter for mod_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for meth_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodCode()
		{
			return MethodCode;
		}

		/// <summary>
		/// Getter for method_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodName()
		{
			return MethodName;
		}

		/// <summary>
		/// Getter for assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}
	}
}
