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
	/// Handles API Request Module.
	/// <see>https://docs.miva.com/json-api/functions/module</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ModuleRequest : Request
	{
		/// Request field Module_Code.
		[JsonPropertyName("Module_Code")]
		public String ModuleCode { get; set; }

		/// Request field Module_Function.
		[JsonPropertyName("Module_Function")]
		public String ModuleFunction { get; set; }

		/// User set request fields
		public Dictionary<String, IConvertible> ModuleFields { get; set; } = new Dictionary<String, IConvertible>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public ModuleRequest(BaseClient client = null) :
			base(client)
		{
			Function = "Module";
		}

		/// <summary>
		/// Getter for Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for Module_Function.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleFunction()
		{
			return ModuleFunction;
		}

		/// <summary>
		///  Get user set request fields.
		/// <returns>Dictionary<String, IConvertible></returns>
		/// </summary>
		public Dictionary<String, IConvertible> GetModuleFields()
		{
			return ModuleFields;
		}

		/// <summary>
		/// Setter for Module_Code.
		/// <param name="value">String</param>
		/// <returns>ModuleRequest</returns>
		/// </summary>
		public ModuleRequest SetModuleCode(String value)
		{
			ModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_Function.
		/// <param name="value">String</param>
		/// <returns>ModuleRequest</returns>
		/// </summary>
		public ModuleRequest SetModuleFunction(String value)
		{
			ModuleFunction = value;
			return this;
		}
		/// <summary>
		/// Set user request data.
		/// <param name="name">String<String></param>
		/// <param name="value">IConvertible<String></param>
		/// <returns>ModuleRequest</returns>
		/// </summary>
		public ModuleRequest SetModuleField(String name, IConvertible value)
		{
			ModuleFields[name] = value;
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

			writer.WriteString("Module_Code", ModuleCode);

			writer.WriteString("Module_Function", ModuleFunction);

			if (ModuleFields.Count > 0)
			{
				foreach(KeyValuePair<String, IConvertible> entry in ModuleFields)
				{
					if (Util.IsDecimal(entry.Value))
					{
						if (Util.IsFloat(entry.Value))
						{
							writer.WriteNumber(entry.Key, (float)entry.Value);
						}
						else
						{
							writer.WriteNumber(entry.Key, (double)entry.Value);
						}
					}
					else if (Util.IsNumeric(entry.Value))
					{
						writer.WriteNumber(entry.Key, (int)entry.Value);
					}
					else if (Util.IsBoolean(entry.Value))
					{
						writer.WriteBoolean(entry.Key, (bool)entry.Value);
					}
					else
					{
						writer.WriteString(entry.Key, entry.Value.ToString());
					}
				}
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ModuleResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ModuleResponse</returns>
		/// </summary>
		public new ModuleResponse Send()
		{
			return Client.SendRequestAsync<ModuleRequest, ModuleResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ModuleResponse></returns>
		/// </summary>
		public new async Task<ModuleResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ModuleRequest, ModuleResponse>(this);
		}
	}
}
