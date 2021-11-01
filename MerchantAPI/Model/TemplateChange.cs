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
	[JsonConverter(typeof(TemplateChangeConverter))]
	public class TemplateChange : Model
	{
		/// <value>Property TemplateId - int</value>
		[JsonPropertyName("Template_ID")]
		public int? TemplateId { get; set; }

		/// <value>Property TemplateFilename - String</value>
		[JsonPropertyName("Template_Filename")]
		public String TemplateFilename { get; set; }

		/// <value>Property Source - String</value>
		[JsonPropertyName("Source")]
		public String Source { get; set; }

		/// <value>Property Settings - TemplateVersionSettings</value>
		[JsonPropertyName("Settings")]
		public TemplateVersionSettings Settings { get; set; }

		/// <value>Property Notes - String</value>
		[JsonPropertyName("Notes")]
		public String Notes { get; set; }

		/// <summary>
		/// Getter for Template_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetTemplateId()
		{
			return TemplateId;
		}

		/// <summary>
		/// Getter for Template_Filename.
		/// <returns>String</returns>
		/// </summary>
		public String GetTemplateFilename()
		{
			return TemplateFilename;
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
		/// Getter for Settings.
		/// <returns>TemplateVersionSettings</returns>
		/// </summary>
		public TemplateVersionSettings GetSettings()
		{
			return Settings;
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
		/// Setter for Template_ID.
		/// <param name="value">int</param>
		/// <returns>TemplateChange</returns>
		/// </summary>
		public TemplateChange SetTemplateId(int value)
		{
			TemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for Template_Filename.
		/// <param name="value">String</param>
		/// <returns>TemplateChange</returns>
		/// </summary>
		public TemplateChange SetTemplateFilename(String value)
		{
			TemplateFilename = value;
			return this;
		}

		/// <summary>
		/// Setter for Source.
		/// <param name="value">String</param>
		/// <returns>TemplateChange</returns>
		/// </summary>
		public TemplateChange SetSource(String value)
		{
			Source = value;
			return this;
		}

		/// <summary>
		/// Setter for Notes.
		/// <param name="value">String</param>
		/// <returns>TemplateChange</returns>
		/// </summary>
		public TemplateChange SetNotes(String value)
		{
			Notes = value;
			return this;
		}
	}

	/// <summary>
	/// Converter for model TemplateChange
	/// </summary>
	public class TemplateChangeConverter : BaseJsonConverter<TemplateChange>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(TemplateChange) || typeToConvert.IsSubclassOf(typeof(TemplateChange));
		}

		public override TemplateChange Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			TemplateChange value = new TemplateChange();

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

				if (String.Equals(property, "Template_ID", StringComparison.OrdinalIgnoreCase))
				{
					value.TemplateId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "Template_Filename", StringComparison.OrdinalIgnoreCase))
				{
					value.TemplateFilename = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Source", StringComparison.OrdinalIgnoreCase))
				{
					value.Source = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "Settings", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
					{
						throw new MerchantAPIException(String.Format("Expected start of object but encountered {0}", reader.TokenType));
					}

					value.Settings = JsonSerializer.Deserialize<TemplateVersionSettings>(ref reader, options);
				}
				else if (String.Equals(property, "Notes", StringComparison.OrdinalIgnoreCase))
				{
					value.Notes = ReadNextString(ref reader, options);
				}
				else
				{
					throw new MerchantAPIException(String.Format("Unexpected property {0} for TemplateChange", property));
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, TemplateChange value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.TemplateId.HasValue)
			{
				writer.WriteNumber("Template_ID", value.TemplateId.Value);
			}

			if (value.TemplateFilename != null && value.TemplateFilename.Length > 0)
			{
				writer.WriteString("Template_Filename", value.TemplateFilename);
			}

			if (value.Source != null && value.Source.Length > 0)
			{
				writer.WriteString("Source", value.Source);
			}

			writer.WritePropertyName("Settings");
			JsonSerializer.Serialize(writer, value.Settings, options);

			if (value.Notes != null && value.Notes.Length > 0)
			{
				writer.WriteString("Notes", value.Notes);
			}

			writer.WriteEndObject();
		}
	}
}
