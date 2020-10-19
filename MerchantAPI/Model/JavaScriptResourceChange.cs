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
	[JsonConverter(typeof(JavaScriptResourceChangeConverter))]
	public class JavaScriptResourceChange : Model
	{
		/// <value>Property JavaScriptResourceId - int</value>
		[JsonPropertyName("JavaScriptResource_ID")]
		public int? JavaScriptResourceId { get; set; }

		/// <value>Property JavaScriptResourceCode - String</value>
		[JsonPropertyName("JavaScriptResource_Code")]
		public String JavaScriptResourceCode { get; set; }

		/// <value>Property ResourceType - String</value>
		[JsonPropertyName("Type")]
		public String ResourceType { get; set; }

		/// <value>Property Global - bool</value>
		[JsonPropertyName("Global")]
		public bool? Global { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("Active")]
		public bool? Active { get; set; }

		/// <value>Property FilePath - String</value>
		[JsonPropertyName("File_Path")]
		public String FilePath { get; set; }

		/// <value>Property BranchlessFilePath - String</value>
		[JsonPropertyName("Branchless_File_Path")]
		public String BranchlessFilePath { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("Source")]
		public String Source { get; set; }

		/// <value>Property LinkedPages - List<String></value>
		[JsonPropertyName("LinkedPages")]
		public List<String> LinkedPages { get; set; } = new List<String>();

		/// <value>Property LinkedResources - List<String></value>
		[JsonPropertyName("LinkedResources")]
		public List<String> LinkedResources { get; set; } = new List<String>();

		/// <value>Property Attributes - List<JavaScriptResourceVersionAttribute></value>
		[JsonPropertyName("Attributes")]
		public List<JavaScriptResourceVersionAttribute> Attributes { get; set; } = new List<JavaScriptResourceVersionAttribute>();

		/// <summary>
		/// Getter for JavaScriptResource_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetJavaScriptResourceId()
		{
			return JavaScriptResourceId;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetJavaScriptResourceCode()
		{
			return JavaScriptResourceCode;
		}

		/// <summary>
		/// Getter for Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetResourceType()
		{
			return ResourceType;
		}

		/// <summary>
		/// Getter for Global.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetGlobal()
		{
			return Global;
		}

		/// <summary>
		/// Getter for Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetActive()
		{
			return Active;
		}

		/// <summary>
		/// Getter for File_Path.
		/// <returns>String</returns>
		/// </summary>
		public String GetFilePath()
		{
			return FilePath;
		}

		/// <summary>
		/// Getter for Branchless_File_Path.
		/// <returns>String</returns>
		/// </summary>
		public String GetBranchlessFilePath()
		{
			return BranchlessFilePath;
		}

		/// <summary>
		/// Getter for Source.
		/// <returns>String</returns>
		/// </summary>
		public String GetSource()
		{
			return Source;
		}

		/// <summary>
		/// Getter for LinkedPages.
		/// <returns>List<String></returns>
		/// </summary>
		public List<String> GetLinkedPages()
		{
			return LinkedPages;
		}

		/// <summary>
		/// Getter for LinkedResources.
		/// <returns>List<String></returns>
		/// </summary>
		public List<String> GetLinkedResources()
		{
			return LinkedResources;
		}

		/// <summary>
		/// Getter for Attributes.
		/// <returns>List<JavaScriptResourceVersionAttribute></returns>
		/// </summary>
		public List<JavaScriptResourceVersionAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Setter for JavaScriptResource_ID.
		/// <param name="value">int</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetJavaScriptResourceId(int value)
		{
			JavaScriptResourceId = value;
			return this;
		}

		/// <summary>
		/// Setter for JavaScriptResource_Code.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetJavaScriptResourceCode(String value)
		{
			JavaScriptResourceCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Type.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetResourceType(String value)
		{
			ResourceType = value;
			return this;
		}

		/// <summary>
		/// Setter for Global.
		/// <param name="value">bool</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetGlobal(bool value)
		{
			Global = value;
			return this;
		}

		/// <summary>
		/// Setter for Active.
		/// <param name="value">bool</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetActive(bool value)
		{
			Active = value;
			return this;
		}

		/// <summary>
		/// Setter for File_Path.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetFilePath(String value)
		{
			FilePath = value;
			return this;
		}

		/// <summary>
		/// Setter for Branchless_File_Path.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetBranchlessFilePath(String value)
		{
			BranchlessFilePath = value;
			return this;
		}

		/// <summary>
		/// Setter for Source.
		/// <param name="value">String</param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetSource(String value)
		{
			Source = value;
			return this;
		}

		/// <summary>
		/// Setter for LinkedPages.
		/// <param name="value">ist<String></param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetLinkedPages(List<String> value)
		{
			LinkedPages = value;
			return this;
		}

		/// <summary>
		/// Setter for LinkedResources.
		/// <param name="value">ist<String></param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange SetLinkedResources(List<String> value)
		{
			LinkedResources = value;
			return this;
		}

		/// <summary>
		/// Add a JavaScriptResourceVersionAttribute.
		/// <param name="JavaScriptResourceVersionAttribute"></param>
		/// <returns>JavaScriptResourceChange</returns>
		/// </summary>
		public JavaScriptResourceChange AddAttribute(JavaScriptResourceVersionAttribute model)
		{
			Attributes.Add(model);
			return this;
		}
	}

	/// <summary>
	/// Converter for model JavaScriptResourceChange
	/// </summary>
	public class JavaScriptResourceChangeConverter : BaseJsonConverter<JavaScriptResourceChange>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(JavaScriptResourceChange) || typeToConvert.IsSubclassOf(typeof(JavaScriptResourceChange));
		}

		public override JavaScriptResourceChange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			JavaScriptResourceChange value = new JavaScriptResourceChange();

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

				if (String.Equals(property, "JavaScriptResource_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.JavaScriptResourceId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "JavaScriptResource_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.JavaScriptResourceCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Type", StringComparison.OrdinalIgnoreCase))
				{
					value.ResourceType = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Global", StringComparison.OrdinalIgnoreCase))
				{
					value.Global = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "Active", StringComparison.OrdinalIgnoreCase))
				{
					value.Active = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "File_Path", StringComparison.OrdinalIgnoreCase))
				{
					value.FilePath = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Branchless_File_Path", StringComparison.OrdinalIgnoreCase))
				{
					value.BranchlessFilePath = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Source", StringComparison.OrdinalIgnoreCase))
				{
					value.Source = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "LinkedPages", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}
					value.LinkedPages = JsonSerializer.Deserialize<List<String>>(ref reader, options);
				}
				else if (String.Equals(property, "LinkedResources", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}
					value.LinkedResources = JsonSerializer.Deserialize<List<String>>(ref reader, options);
				}
				else if (String.Equals(property, "Attributes", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Attributes = JsonSerializer.Deserialize<List<JavaScriptResourceVersionAttribute>>(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for JavaScriptResourceChange", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, JavaScriptResourceChange value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.JavaScriptResourceId.HasValue)
			{
				writer.WriteNumber("JavaScriptResource_ID", value.JavaScriptResourceId.Value);
			}

			if (value.JavaScriptResourceCode != null && value.JavaScriptResourceCode.Length > 0)
			{
				writer.WriteString("JavaScriptResource_Code", value.JavaScriptResourceCode);
			}

			if (value.ResourceType != null && value.ResourceType.Length > 0)
			{
				writer.WriteString("Type", value.ResourceType);
			}

			if (value.Global.HasValue)
			{
				writer.WriteBoolean("Global", value.Global.Value);
			}

			if (value.Active.HasValue)
			{
				writer.WriteBoolean("Active", value.Active.Value);
			}

			if (value.FilePath != null && value.FilePath.Length > 0)
			{
				writer.WriteString("File_Path", value.FilePath);
			}

			if (value.BranchlessFilePath != null && value.BranchlessFilePath.Length > 0)
			{
				writer.WriteString("Branchless_File_Path", value.BranchlessFilePath);
			}

			if (value.Source != null && value.Source.Length > 0)
			{
				writer.WriteString("Source", value.Source);
			}

			writer.WritePropertyName("LinkedPages");
			JsonSerializer.Serialize(writer, value.LinkedPages, options);

			writer.WritePropertyName("LinkedResources");
			JsonSerializer.Serialize(writer, value.LinkedResources, options);

			writer.WritePropertyName("Attributes");
			JsonSerializer.Serialize(writer, value.Attributes, options);

			writer.WriteEndObject();
		}
	}
}
