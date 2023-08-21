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
	public class VersionSettings : VariableValue
	{
		/// <summary>
		/// Default constructor, creates a null value of convertible type
		/// </summary>
		/// <param name="value"></param>
		public VersionSettings() : base()
		{
			
		}

		/// <summary>
		/// Constructor for dynamic types
		/// </summary>
		/// <param name="values"></param>
		public VersionSettings(dynamic value)
		{
			SetValue(value);
		}

		/// <summary>
		/// Check if a specific item settings is defined.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool HasItem(String item)
		{
			if (IsDictionary())
			{
				return GetValue().ContainsKey(item);
			}

			return false;
		}

		/// <summary>
		/// Get a specific item settings values, or null if it does not exist.
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public dynamic GetItem(String item)
		{
			if (HasItem(item))
			{
				dynamic value;

				if (GetValue().TryGetValue(item, out value))
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
			if (!HasItem(item))		return false;

			dynamic itemvalue;

			if (GetValue().TryGetValue(item, out itemvalue))
			{
				if (Util.IsDictionaryType(itemvalue.GetType()))
				{
					return itemvalue.ContainsKey(property);
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
		public dynamic GetItemProperty(String item, String property)
		{
			if (ItemHasProperty(item, property))
			{
				dynamic itemvalue;
				dynamic ret;

				if (GetValue().TryGetValue(item, out itemvalue))
				{
					if (Util.IsDictionaryType(itemvalue.GetType()))
					{
						if (itemvalue.TryGetValue(property, out ret))
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
		public VersionSettings SetItem(String item, dynamic itemValue)
		{
			if (IsDictionary())
			{
				GetValue()[item] = itemValue;
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
		public VersionSettings SetItemProperty(String item, String property, dynamic value)
		{
			if (IsDictionary())
			{
				if (!GetValue().ContainsKey(item))
				{
					GetValue()[item] = new Dictionary<String, dynamic>() { { property, value } };
				} else
				{
					if (Util.IsDictionaryType(GetValue()[item].getType()))
					{
						GetValue()[item][property] = value;
					}					
				}
			}

			return this;
		}
	}

	/// <summary>
	/// Handles converting the version settings values model
	/// </summary>
	public class  VersionSettingsConverter : VariableValueConverter
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(VersionSettings) || typeToConvert.IsSubclassOf(typeof(VersionSettings));
		}

		public override VariableValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return new VersionSettings(Read(ref reader, options));
		}

		public override void Write(Utf8JsonWriter writer, VariableValue value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<dynamic>(writer, value.GetValue(), options);
		}
	}
}
