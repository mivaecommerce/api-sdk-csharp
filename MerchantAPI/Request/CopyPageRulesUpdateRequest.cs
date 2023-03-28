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
	/// Handles API Request CopyPageRules_Update.
	/// <see>https://docs.miva.com/json-api/functions/copypagerules_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyPageRulesUpdateRequest : Request
	{
		/// Request field CopyPageRules_ID.
		[JsonPropertyName("CopyPageRules_ID")]
		public int? CopyPageRulesId { get; set; }

		/// Request field CopyPageRules_Name.
		[JsonPropertyName("CopyPageRules_Name")]
		public String CopyPageRulesName { get; set; }

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
		/// <param name="copyPageRule">CopyPageRule</param>
		/// </summary>
		public CopyPageRulesUpdateRequest(BaseClient client = null, CopyPageRule copyPageRule = null) :
			base(client)
		{
			Function = "CopyPageRules_Update";
			if (copyPageRule != null) {
				if (copyPageRule.Id > 0)
				{
					CopyPageRulesId = copyPageRule.Id;
				}
				else if (copyPageRule.Name.Length > 0)
				{
					CopyPageRulesName = copyPageRule.Name;
				}
			}
		}

		/// <summary>
		/// Getter for CopyPageRules_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCopyPageRulesId()
		{
			return CopyPageRulesId;
		}

		/// <summary>
		/// Getter for CopyPageRules_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetCopyPageRulesName()
		{
			return CopyPageRulesName;
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
		/// Setter for CopyPageRules_ID.
		/// <param name="value">int</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetCopyPageRulesId(int? value)
		{
			CopyPageRulesId = value;
			return this;
		}

		/// <summary>
		/// Setter for CopyPageRules_Name.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetCopyPageRulesName(String value)
		{
			CopyPageRulesName = value;
			return this;
		}

		/// <summary>
		/// Setter for Name.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for Secure.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetSecure(bool? value)
		{
			Secure = value;
			return this;
		}

		/// <summary>
		/// Setter for Title.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetTitle(bool? value)
		{
			Title = value;
			return this;
		}

		/// <summary>
		/// Setter for Template.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetTemplate(bool? value)
		{
			Template = value;
			return this;
		}

		/// <summary>
		/// Setter for Items.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetItems(bool? value)
		{
			Items = value;
			return this;
		}

		/// <summary>
		/// Setter for Settings.
		/// <param name="value">String</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetSettings(String value)
		{
			Settings = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">CopyPageRule.PageRuleSettings</param>
		/// <returns></returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetSettings(CopyPageRule.PageRuleSettings value)
		{
			Settings = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResourceAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetJavaScriptResourceAssignments(bool? value)
		{
			JavaScriptResourceAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResourceAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetCSSResourceAssignments(bool? value)
		{
			CSSResourceAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for CacheSettings.
		/// <param name="value">bool</param>
		/// <returns>CopyPageRulesUpdateRequest</returns>
		/// </summary>
		public CopyPageRulesUpdateRequest SetCacheSettings(bool? value)
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

			if (CopyPageRulesId.HasValue)
			{
				writer.WriteNumber("CopyPageRules_ID", CopyPageRulesId.Value);
			}
			else if (CopyPageRulesName != null && CopyPageRulesName.Length > 0)
			{
				writer.WriteString("CopyPageRules_Name", CopyPageRulesName);
			}

			if (Name != null && Name.Length > 0)
			{
				writer.WriteString("Name", Name);
			}

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
			return JsonSerializer.Deserialize<CopyPageRulesUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyPageRulesUpdateResponse</returns>
		/// </summary>
		public new CopyPageRulesUpdateResponse Send()
		{
			return Client.SendRequestAsync<CopyPageRulesUpdateRequest, CopyPageRulesUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyPageRulesUpdateResponse></returns>
		/// </summary>
		public new async Task<CopyPageRulesUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyPageRulesUpdateRequest, CopyPageRulesUpdateResponse>(this);
		}
	}
}
