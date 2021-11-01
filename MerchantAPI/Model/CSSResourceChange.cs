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
	[JsonConverter(typeof(CSSResourceChangeConverter))]
	public class CSSResourceChange : Model
	{
		/// <value>Property CSSResourceId - int</value>
		[JsonPropertyName("CSSResource_ID")]
		public int? CSSResourceId { get; set; }

		/// <value>Property CSSResourceCode - String</value>
		[JsonPropertyName("CSSResource_Code")]
		public String CSSResourceCode { get; set; }

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

		/// <value>Property Attributes - List<CSSResourceVersionAttribute></value>
		[JsonPropertyName("Attributes")]
		public List<CSSResourceVersionAttribute> Attributes { get; set; } = new List<CSSResourceVersionAttribute>();

		/// <value>Property Notes - String</value>
		[JsonPropertyName("Notes")]
		public String Notes { get; set; }

		/// <summary>
		/// Getter for CSSResource_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCSSResourceId()
		{
			return CSSResourceId;
		}

		/// <summary>
		/// Getter for CSSResource_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCSSResourceCode()
		{
			return CSSResourceCode;
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
		/// <returns>List<CSSResourceVersionAttribute></returns>
		/// </summary>
		public List<CSSResourceVersionAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for Notes.
		/// <returns>String</returns>
		/// </summary>
		public String GetNotes()
		{
			return Notes;
		}

		/// <summary>
		/// Setter for CSSResource_ID.
		/// <param name="value">int</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetCSSResourceId(int value)
		{
			CSSResourceId = value;
			return this;
		}

		/// <summary>
		/// Setter for CSSResource_Code.
		/// <param name="value">String</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetCSSResourceCode(String value)
		{
			CSSResourceCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Type.
		/// <param name="value">String</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetResourceType(String value)
		{
			ResourceType = value;
			return this;
		}

		/// <summary>
		/// Setter for Global.
		/// <param name="value">bool</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetGlobal(bool value)
		{
			Global = value;
			return this;
		}

		/// <summary>
		/// Setter for Active.
		/// <param name="value">bool</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetActive(bool value)
		{
			Active = value;
			return this;
		}

		/// <summary>
		/// Setter for File_Path.
		/// <param name="value">String</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetFilePath(String value)
		{
			FilePath = value;
			return this;
		}

		/// <summary>
		/// Setter for Branchless_File_Path.
		/// <param name="value">String</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetBranchlessFilePath(String value)
		{
			BranchlessFilePath = value;
			return this;
		}

		/// <summary>
		/// Setter for Source.
		/// <param name="value">String</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetSource(String value)
		{
			Source = value;
			return this;
		}

		/// <summary>
		/// Setter for LinkedPages.
		/// <param name="value">ist<String></param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetLinkedPages(List<String> value)
		{
			LinkedPages = value;
			return this;
		}

		/// <summary>
		/// Setter for LinkedResources.
		/// <param name="value">ist<String></param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetLinkedResources(List<String> value)
		{
			LinkedResources = value;
			return this;
		}

		/// <summary>
		/// Setter for Notes.
		/// <param name="value">String</param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange SetNotes(String value)
		{
			Notes = value;
			return this;
		}

		/// <summary>
		/// Add a CSSResourceVersionAttribute.
		/// <param name="CSSResourceVersionAttribute"></param>
		/// <returns>CSSResourceChange</returns>
		/// </summary>
		public CSSResourceChange AddAttribute(CSSResourceVersionAttribute model)
		{
			Attributes.Add(model);
			return this;
		}
	}

	/// <summary>
	/// Converter for model CSSResourceChange
	/// </summary>
	public class CSSResourceChangeConverter : BaseJsonConverter<CSSResourceChange>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(CSSResourceChange) || typeToConvert.IsSubclassOf(typeof(CSSResourceChange));
		}

		public override CSSResourceChange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			CSSResourceChange value = new CSSResourceChange();

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

				if (String.Equals(property, "CSSResource_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.CSSResourceId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "CSSResource_Code", StringComparison.OrdinalIgnoreCase))
				{
					value.CSSResourceCode = ReadNextString(ref reader, options);
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

					value.Attributes = JsonSerializer.Deserialize<List<CSSResourceVersionAttribute>>(ref reader, options);
				}
				else if (String.Equals(property, "Notes", StringComparison.OrdinalIgnoreCase))
				{
					value.Notes = ReadNextString(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for CSSResourceChange", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, CSSResourceChange value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.CSSResourceId.HasValue)
			{
				writer.WriteNumber("CSSResource_ID", value.CSSResourceId.Value);
			}

			if (value.CSSResourceCode != null && value.CSSResourceCode.Length > 0)
			{
				writer.WriteString("CSSResource_Code", value.CSSResourceCode);
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

			if (value.Notes != null && value.Notes.Length > 0)
			{
				writer.WriteString("Notes", value.Notes);
			}

			writer.WriteEndObject();
		}
	}
}
