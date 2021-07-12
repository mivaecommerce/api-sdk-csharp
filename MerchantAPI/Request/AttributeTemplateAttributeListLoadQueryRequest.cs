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
	/// Handles API Request AttributeTemplateAttributeList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/attributetemplateattributelist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class AttributeTemplateAttributeListLoadQueryRequest : ListQueryRequest
	{
		/// Request field AttributeTemplate_ID.
		[JsonPropertyName("AttributeTemplate_ID")]
		public int? AttributeTemplateId { get; set; }

		/// Request field AttributeTemplate_Code.
		[JsonPropertyName("AttributeTemplate_Code")]
		public String AttributeTemplateCode { get; set; }

		/// Request field Edit_AttributeTemplate.
		[JsonPropertyName("Edit_AttributeTemplate")]
		public String EditAttributeTemplate { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"attr_code",
			"attr_prompt",
			"attr_price",
			"attr_cost",
			"attr_weight",
			"attr_image",
			"opt_code",
			"opt_prompt",
			"opt_price",
			"opt_cost",
			"opt_weight",
			"opt_image",
			"code",
			"prompt",
			"price",
			"cost",
			"weight",
			"image",
			"required",
			"inventory"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"code",
			"type",
			"prompt",
			"price",
			"cost",
			"weight",
			"image",
			"required",
			"inventory",
			"attr_code",
			"attr_prompt",
			"attr_price",
			"attr_cost",
			"attr_weight",
			"attr_image",
			"opt_code",
			"opt_prompt",
			"opt_price",
			"opt_cost",
			"opt_weight",
			"opt_image"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="attributeTemplate">AttributeTemplate</param>
		/// </summary>
		public AttributeTemplateAttributeListLoadQueryRequest(BaseClient client = null, AttributeTemplate attributeTemplate = null) :
			base(client)
		{
			Function = "AttributeTemplateAttributeList_Load_Query";
			if (attributeTemplate != null) {
				if (attributeTemplate.Id > 0)
				{
					AttributeTemplateId = attributeTemplate.Id;
				}
				else if (attributeTemplate.Code.Length > 0)
				{
					AttributeTemplateCode = attributeTemplate.Code;
				}
				else if (attributeTemplate.Code.Length > 0)
				{
					EditAttributeTemplate = attributeTemplate.Code;
				}
			}
		}

		/// <summary>
		/// Getter for AttributeTemplate_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAttributeTemplateId()
		{
			return AttributeTemplateId;
		}

		/// <summary>
		/// Getter for AttributeTemplate_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetAttributeTemplateCode()
		{
			return AttributeTemplateCode;
		}

		/// <summary>
		/// Getter for Edit_AttributeTemplate.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditAttributeTemplate()
		{
			return EditAttributeTemplate;
		}

		/// <summary>
		/// Setter for AttributeTemplate_ID.
		/// <param name="value">int</param>
		/// <returns>AttributeTemplateAttributeListLoadQueryRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeListLoadQueryRequest SetAttributeTemplateId(int? value)
		{
			AttributeTemplateId = value;
			return this;
		}

		/// <summary>
		/// Setter for AttributeTemplate_Code.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeListLoadQueryRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeListLoadQueryRequest SetAttributeTemplateCode(String value)
		{
			AttributeTemplateCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_AttributeTemplate.
		/// <param name="value">String</param>
		/// <returns>AttributeTemplateAttributeListLoadQueryRequest</returns>
		/// </summary>
		public AttributeTemplateAttributeListLoadQueryRequest SetEditAttributeTemplate(String value)
		{
			EditAttributeTemplate = value;
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

			if (AttributeTemplateId.HasValue)
			{
				writer.WriteNumber("AttributeTemplate_ID", AttributeTemplateId.Value);
			}
			else if (AttributeTemplateCode != null && AttributeTemplateCode.Length > 0)
			{
				writer.WriteString("AttributeTemplate_Code", AttributeTemplateCode);
			}
			else if (EditAttributeTemplate != null && EditAttributeTemplate.Length > 0)
			{
				writer.WriteString("Edit_AttributeTemplate", EditAttributeTemplate);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<AttributeTemplateAttributeListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>AttributeTemplateAttributeListLoadQueryResponse</returns>
		/// </summary>
		public new AttributeTemplateAttributeListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<AttributeTemplateAttributeListLoadQueryRequest, AttributeTemplateAttributeListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<AttributeTemplateAttributeListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<AttributeTemplateAttributeListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<AttributeTemplateAttributeListLoadQueryRequest, AttributeTemplateAttributeListLoadQueryResponse>(this);
		}
	}
}
