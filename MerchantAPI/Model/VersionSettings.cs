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

namespace MerchantAPI
{
	[JsonConverter(typeof(VersionSettingsConverter))]
	public class VersionSettings : Model
	{
		public VariableValue Settings { get; set; }

		/// <summary>
		/// Check if a specific item settings is defined.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool HasItem(String item)
		{
			if (Settings == null) return false;

			if (Settings.IsDictionary())
			{
				return Settings.GetValueDictionary().ContainsKey(item);
			}

			return false;
		}

		/// <summary>
		/// Get a specific item settings values, or null if it does not exist.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public VariableValue GetItem(String item)
		{
			if (Settings == null) return null;

			if (HasItem(item))
			{
				VariableValue value;

				if (Settings.GetValueDictionary().TryGetValue(item, out value))
				{
					return value;
				}
			}

			return null;
		}

		/// <summary>
		/// Check if an item contains a property
		/// </summary>
		/// <param name="item"></param>
		/// <param name="property"></param>
		/// <returns></returns>
		public bool ItemHasProperty(String item, String property)
		{
			if (Settings == null) return false;

			if (!HasItem(item))
			{
				return false;
			}

			VariableValue itemvalue;

			if (Settings.GetValueDictionary().TryGetValue(item, out itemvalue))
			{
				if (itemvalue.IsDictionary())
				{
					return itemvalue.GetValueDictionary().ContainsKey(property);
				}
			}

			return false;
		}

		/// <summary>
		/// Get the value for a given property of an item, or null if it does not eixst
		/// </summary>
		/// <param name="item"></param>
		/// <param name="property"></param>
		/// <returns></returns>
		public VariableValue GetItemProperty(String item, String property)
		{
			if (ItemHasProperty(item, property))
			{
				VariableValue itemvalue;
				VariableValue ret;

				if (Settings.GetValueDictionary().TryGetValue(item, out itemvalue))
				{
					if (itemvalue.IsDictionary())
					{
						if (itemvalue.GetValueDictionary().TryGetValue(property, out ret))
						{
							return ret;
						}
					}
				}
			}

			return null;
		}

		/// <summary>
		/// Sets an item with the given dictionary
		/// </summary>
		/// <param name="item"></param>
		/// <param name="itemValues"></param>
		/// <returns></returns>
		public VersionSettings SetItem(String item, VariableValue itemValue)
		{
			if (Settings == null)
			{
				Settings = new VariableValue(new Dictionary<String, VariableValue>());
			}

			if (Settings.IsDictionary())
			{
				Settings.AddToDictionary(item, itemValue);
			}

			return this;
		}

		/// <summary>
		/// Sets a specific propert in a specific item
		/// </summary>
		/// <param name="item"></param>
		/// <param name="property"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public VersionSettings SetItemProperty(String item, String property, VariableValue value)
		{
			if (Settings == null)
			{
				Settings = new VariableValue(new Dictionary<String, VariableValue>());
			}
			if (Settings.IsDictionary())
			{
				Settings.AddToDictionary(property, value);
			}

			return this;
		}
	}

	/// <summary>
	/// Handles converting the version settings values model
	/// </summary>
	public class  VersionSettingsConverter : BaseJsonConverter<VersionSettings>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(VersionSettings) || typeToConvert.IsSubclassOf(typeof(VersionSettings));
		}

		public override VersionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			VersionSettings value = new VersionSettings();

			value.Settings = JsonSerializer.Deserialize<VariableValue>(ref reader, options);

			return value;
		}

		public override void Write(Utf8JsonWriter writer, VersionSettings model, JsonSerializerOptions options)
		{
			if (model.Settings == null || model.Settings.IsNull())
			{
				writer.WritePropertyName("");
				return;
			}

			if (model.Settings.IsDictionary())
			{
				writer.WriteStartObject();

				foreach (KeyValuePair<String, VariableValue> itemEntry in model.Settings.GetValueDictionary())
				{
					writer.WritePropertyName(itemEntry.Key);

					JsonSerializer.Serialize<VariableValue>(writer, itemEntry.Value, options);

					writer.WriteEndObject();
				}

				writer.WriteEndObject();
			}
			else if (model.Settings.IsArray())
			{
				writer.WriteStartArray();

				foreach (VariableValue itemEntry in model.Settings.GetValueArray())
				{
					JsonSerializer.Serialize<VariableValue>(writer, itemEntry, options);
				}

				writer.WriteEndArray();
			}
			else if (model.Settings.IsConvertible())
			{
				JsonSerializer.Serialize<VariableValue>(writer, model.Settings, options);
			}
			else
			{
				throw new MerchantAPIException("Unexpected VariableValue type");
			}
		}
	}
}
