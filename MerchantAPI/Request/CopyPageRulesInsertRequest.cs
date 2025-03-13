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
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request CopyPageRules_Insert.
	/// <see>https://docs.miva.com/json-api/functions/copypagerules_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyPageRulesInsertRequest : Request
	{
		/// Request field Name.
		[JsonPropertyName("Name")]
		public String Name { get; set; }

		/// Request field Secure.
		[JsonPropertyName("Secure")]
		public bool? Secure { get; set; }

		/// Request field Title.
		[JsonPropertyName("Title")]
		public bool? Title { get; set; }

		/// Request field Template.
		[JsonPropertyName("Template")]
		public bool? Template { get; set; }

		/// Request field Items.
		[JsonPropertyName("Items")]
		public bool? Items { get; set; }

		/// Request field Public.
		[JsonPropertyName("Public")]
		public bool? Public { get; set; }

		/// Request field Settings.
		[JsonPropertyName("Settings")]
		public String Settings { get; set; }

		/// Request field JavaScriptResourceAssignments.
		[JsonPropertyName("JavaScriptResourceAssignments")]
		public bool? JavaScriptResourceAssignments { get; set; }

		/// Request field CSSResourceAssignments.
		[JsonPropertyName("CSSResourceAssignments")]
		public bool? CSSResourceAssignments { get; set; }

		/// Request field CacheSettings.
		[JsonPropertyName("CacheSettings")]
		public bool? CacheSettings { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CopyPageRulesInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CopyPageRules_Insert";
		}

		/// <summary>
		/// Getter for Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for Secure.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetSecure()
		{
			return Secure;
		}

		/// <summary>
		/// Getter for Title.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTitle()
		{
			return Title;
		}

		/// <summary>
		/// Getter for Template.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTemplate()
		{
			return Template;
		}

		/// <summary>
		/// Getter for Items.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetItems()
		{
			return Items;
		}

		/// <summary>
		/// Getter for Public.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetPublic()
		{
			return Public;
		}

		/// <summary>
		/// Getter for Settings.
		/// <returns>String</returns>
		/// </summary>
		public String GetSettings()
		{
			return Settings;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>CopyPageRule.PageRuleSettings?</returns>
		/// </summary>
		public CopyPageRule.PageRuleSettings? GetSettingsConst()
		{
			return CopyPageRule.PageRuleSettingsFromString(Settings);
		}

		/// <summary>
		/// Getter for JavaScriptResourceAssignments.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetJavaScriptResourceAssignments()
		{
			return JavaScriptResourceAssignments;
		}

		/// <summary>
		/// Getter for CSSResourceAssignments.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCSSResourceAssignments()
		{
			return CSSResourceAssignments;
		}

		/// <summary>
		/// Getter for CacheSettings.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCacheSettings()
		{
			return CacheSettings;
		}

		/// <summary>
		/// Setter for Name.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for Secure.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetSecure(bool? value)
		{
			Secure = value;
			return this;
		}

		/// <summary>
		/// Setter for Title.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetTitle(bool? value)
		{
			Title = value;
			return this;
		}

		/// <summary>
		/// Setter for Template.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetTemplate(bool? value)
		{
			Template = value;
			return this;
		}

		/// <summary>
		/// Setter for Items.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetItems(bool? value)
		{
			Items = value;
			return this;
		}

		/// <summary>
		/// Setter for Public.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetPublic(bool? value)
		{
			Public = value;
			return this;
		}

		/// <summary>
		/// Setter for Settings.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetSettings(String value)
		{
			Settings = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">CopyPageRule.PageRuleSettings</param>
		/// <returns></returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetSettings(CopyPageRule.PageRuleSettings value)
		{
			Settings = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResourceAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetJavaScriptResourceAssignments(bool? value)
		{
			JavaScriptResourceAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResourceAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetCSSResourceAssignments(bool? value)
		{
			CSSResourceAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for CacheSettings.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesInsertRequest</returns>
		/// </summary>
		public CopyPageRulesInsertRequest SetCacheSettings(bool? value)
		{
			CacheSettings = value;
			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			writer.WriteString("Name", Name);

			if (Secure.HasValue)
			{
				writer.WriteBoolean("Secure", Secure.Value);
			}

			if (Title.HasValue)
			{
				writer.WriteBoolean("Title", Title.Value);
			}

			if (Template.HasValue)
			{
				writer.WriteBoolean("Template", Template.Value);
			}

			if (Items.HasValue)
			{
				writer.WriteBoolean("Items", Items.Value);
			}

			if (Public.HasValue)
			{
				writer.WriteBoolean("Public", Public.Value);
			}

			if (Settings != null && Settings.Length > 0)
			{
				writer.WriteString("Settings", Settings);
			}

			if (JavaScriptResourceAssignments.HasValue)
			{
				writer.WriteBoolean("JavaScriptResourceAssignments", JavaScriptResourceAssignments.Value);
			}

			if (CSSResourceAssignments.HasValue)
			{
				writer.WriteBoolean("CSSResourceAssignments", CSSResourceAssignments.Value);
			}

			if (CacheSettings.HasValue)
			{
				writer.WriteBoolean("CacheSettings", CacheSettings.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyPageRulesInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyPageRulesInsertResponse</returns>
		/// </summary>
		public new CopyPageRulesInsertResponse Send()
		{
			return Client.SendRequestAsync<CopyPageRulesInsertRequest, CopyPageRulesInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyPageRulesInsertResponse></returns>
		/// </summary>
		public new async Task<CopyPageRulesInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyPageRulesInsertRequest, CopyPageRulesInsertResponse>(this);
		}
	}
}
