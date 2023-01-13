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
	[JsonConverter(typeof(ResourceGroupChangeConverter))]
	public class ResourceGroupChange : Model
	{
		/// <value>Property ResourceGroupId - int</value>
		[JsonPropertyName("ResourceGroup_ID")]
		public int? ResourceGroupId { get; set; }

		/// <value>Property ResourceGroupCode - String</value>
		[JsonPropertyName("ResourceGroup_Code")]
		public String ResourceGroupCode { get; set; }

		/// <value>Property LinkedCSSResources - List<String></value>
		[JsonPropertyName("LinkedCSSResources")]
		public List<String> LinkedCSSResources { get; set; } = new List<String>();

		/// <value>Property LinkedJavaScriptResources - List<String></value>
		[JsonPropertyName("LinkedJavaScriptResources")]
		public List<String> LinkedJavaScriptResources { get; set; } = new List<String>();

		/// <summary>
		/// Getter for ResourceGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetResourceGroupId()
		{
			return ResourceGroupId;
		}

		/// <summary>
		/// Getter for ResourceGroup_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetResourceGroupCode()
		{
			return ResourceGroupCode;
		}

		/// <summary>
		/// Getter for LinkedCSSResources.
		/// <returns>List<String></returns>
		/// </summary>
		public List<String> GetLinkedCSSResources()
		{
			return LinkedCSSResources;
		}

		/// <summary>
		/// Getter for LinkedJavaScriptResources.
		/// <returns>List<String></returns>
		/// </summary>
		public List<String> GetLinkedJavaScriptResources()
		{
			return LinkedJavaScriptResources;
		}

		/// <summary>
		/// Setter for ResourceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>ResourceGroupChange</returns>
		/// </summary>
		public ResourceGroupChange SetResourceGroupId(int value)
		{
			ResourceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for ResourceGroup_Code.
		/// <param name="value">String</param>
		/// <returns>ResourceGroupChange</returns>
		/// </summary>
		public ResourceGroupChange SetResourceGroupCode(String value)
		{
			ResourceGroupCode = value;
			return this;
		}

		/// <summary>
		/// Setter for LinkedCSSResources.
		/// <param name="value">ist<String></param>
		/// <returns>ResourceGroupChange</returns>
		/// </summary>
		public ResourceGroupChange SetLinkedCSSResources(List<String> value)
		{
			LinkedCSSResources = value;
			return this;
		}

		/// <summary>
		/// Setter for LinkedJavaScriptResources.
		/// <param name="value">ist<String></param>
		/// <returns>ResourceGroupChange</returns>
		/// </summary>
		public ResourceGroupChange SetLinkedJavaScriptResources(List<String> value)
		{
			LinkedJavaScriptResources = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model ResourceGroupChange
	/// </summary>
	public class ResourceGroupChangeConverter : BaseJsonConverter<ResourceGroupChange>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(ResourceGroupChange) || typeToConvert.IsSubclassOf(typeof(ResourceGroupChange));
		}

		public override ResourceGroupChange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ResourceGroupChange value = new ResourceGroupChange();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while(reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return value;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "ResourceGroup_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.ResourceGroupId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "ResourceGroup_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.ResourceGroupCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "LinkedCSSResources", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}
					value.LinkedCSSResources = JsonSerializer.Deserialize<List<String>>(ref reader, options);
				}
				else if (String.Equals(property, "LinkedJavaScriptResources", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}
					value.LinkedJavaScriptResources = JsonSerializer.Deserialize<List<String>>(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, ResourceGroupChange value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.ResourceGroupId.HasValue)
			{
				writer.WriteNumber("ResourceGroup_ID", value.ResourceGroupId.Value);
			}

			if (value.ResourceGroupCode != null && value.ResourceGroupCode.Length > 0)
			{
				writer.WriteString("ResourceGroup_Code", value.ResourceGroupCode);
			}

			writer.WritePropertyName("LinkedCSSResources");
			JsonSerializer.Serialize(writer, value.LinkedCSSResources, options);

			writer.WritePropertyName("LinkedJavaScriptResources");
			JsonSerializer.Serialize(writer, value.LinkedJavaScriptResources, options);

			writer.WriteEndObject();
		}
	}
}
