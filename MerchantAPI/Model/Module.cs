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
	public class Module : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Provider - String</value>
		[JsonPropertyName("provider")]
		public String Provider { get; set; }

		/// <value>Property ApiVersion - String</value>
		[JsonPropertyName("api_ver")]
		public String ApiVersion { get; set; }

		/// <value>Property Version - String</value>
		[JsonPropertyName("version")]
		public String Version { get; set; }

		/// <value>Property ModuleCode - String</value>
		[JsonPropertyName("module")]
		public String ModuleCode { get; set; }

		/// <value>Property ReferenceCount - int</value>
		[JsonPropertyName("refcount")]
		public int ReferenceCount { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property Priority - int</value>
		[JsonPropertyName("priority")]
		public int Priority { get; set; }

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
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for provider.
		/// <returns>String</returns>
		/// </summary>
		public String GetProvider()
		{
			return Provider;
		}

		/// <summary>
		/// Getter for api_ver.
		/// <returns>String</returns>
		/// </summary>
		public String GetApiVersion()
		{
			return ApiVersion;
		}

		/// <summary>
		/// Getter for version.
		/// <returns>String</returns>
		/// </summary>
		public String GetVersion()
		{
			return Version;
		}

		/// <summary>
		/// Getter for module.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for refcount.
		/// <returns>int</returns>
		/// </summary>
		public int GetReferenceCount()
		{
			return ReferenceCount;
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
		/// Getter for priority.
		/// <returns>int</returns>
		/// </summary>
		public int GetPriority()
		{
			return Priority;
		}
	}
}
