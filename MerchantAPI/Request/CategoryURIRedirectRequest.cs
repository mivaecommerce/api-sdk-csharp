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
	/// Handles API Request CategoryURI_Redirect.
	/// <see>https://docs.miva.com/json-api/functions/categoryuri_redirect</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CategoryURIRedirectRequest : ListQueryRequest
	{
		/// Request field Destination_Store_Code.
		[JsonPropertyName("Destination_Store_Code")]
		public String DestinationStoreCode { get; set; }

		/// Request field Destination_Type.
		[JsonPropertyName("Destination_Type")]
		public String DestinationType { get; set; }

		/// Request field Destination.
		[JsonPropertyName("Destination")]
		public String Destination { get; set; }

		/// Request field Status.
		[JsonPropertyName("Status")]
		public int? Status { get; set; }

		/// Request field URI_IDs.
		public List<int> UriIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CategoryURIRedirectRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CategoryURI_Redirect";
		}

		/// <summary>
		/// Getter for Destination_Store_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationStoreCode()
		{
			return DestinationStoreCode;
		}

		/// <summary>
		/// Getter for Destination_Type.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestinationType()
		{
			return DestinationType;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>Uri.DestinationType?</returns>
		/// </summary>
		public Uri.DestinationType? GetDestinationTypeConst()
		{
			return Uri.DestinationTypeFromString(DestinationType);
		}

		/// <summary>
		/// Getter for Destination.
		/// <returns>String</returns>
		/// </summary>
		public String GetDestination()
		{
			return Destination;
		}

		/// <summary>
		/// Getter for Status.
		/// <returns>int</returns>
		/// </summary>
		public int? GetStatus()
		{
			return Status;
		}

		/// <summary>
		/// Setter for Destination_Store_Code.
		/// <param name="value">String</param>
		/// <returns>CategoryURIRedirectRequest</returns>
		/// </summary>
		public CategoryURIRedirectRequest SetDestinationStoreCode(String value)
		{
			DestinationStoreCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Destination_Type.
		/// <param name="value">String</param>
		/// <returns>CategoryURIRedirectRequest</returns>
		/// </summary>
		public CategoryURIRedirectRequest SetDestinationType(String value)
		{
			DestinationType = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">Uri.DestinationType</param>
		/// <returns></returns>
		/// </summary>
		public CategoryURIRedirectRequest SetDestinationType(Uri.DestinationType value)
		{
			DestinationType = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Destination.
		/// <param name="value">String</param>
		/// <returns>CategoryURIRedirectRequest</returns>
		/// </summary>
		public CategoryURIRedirectRequest SetDestination(String value)
		{
			Destination = value;
			return this;
		}

		/// <summary>
		/// Setter for Status.
		/// <param name="value">int</param>
		/// <returns>CategoryURIRedirectRequest</returns>
		/// </summary>
		public CategoryURIRedirectRequest SetStatus(int? value)
		{
			Status = value;
			return this;
		}

		/// <summary>
		/// Add URI_IDs.
		///	- uriId: Int
		/// - Returns: Self
		/// </summary>
		public CategoryURIRedirectRequest AddUriID(int uriId)
		{
			UriIds.Add(uriId);
			return this;
		}

		/// <summary>
		/// Add Uri model.
		/// <param name="uri">Uri></param>
		/// <returns>CategoryURIRedirectRequest</returns>
		/// </summary>
		public CategoryURIRedirectRequest AddUri(Uri uri)
		{
			if (uri.Id > 0)
			{
				UriIds.Add(uri.Id);
			}

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

			if (DestinationStoreCode != null && DestinationStoreCode.Length > 0)
			{
				writer.WriteString("Destination_Store_Code", DestinationStoreCode);
			}

			if (DestinationType != null && DestinationType.Length > 0)
			{
				writer.WriteString("Destination_Type", DestinationType);
			}

			if (Destination != null && Destination.Length > 0)
			{
				writer.WriteString("Destination", Destination);
			}

			if (Status.HasValue)
			{
				writer.WriteNumber("Status", Status.Value);
			}

			writer.WritePropertyName("URI_IDs");
			JsonSerializer.Serialize(writer, this.UriIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CategoryURIRedirectResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CategoryURIRedirectResponse</returns>
		/// </summary>
		public new CategoryURIRedirectResponse Send()
		{
			return Client.SendRequestAsync<CategoryURIRedirectRequest, CategoryURIRedirectResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CategoryURIRedirectResponse></returns>
		/// </summary>
		public new async Task<CategoryURIRedirectResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CategoryURIRedirectRequest, CategoryURIRedirectResponse>(this);
		}
	}
}
