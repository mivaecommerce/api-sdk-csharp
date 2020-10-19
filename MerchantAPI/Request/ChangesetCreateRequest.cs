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
	/// Handles API Request Changeset_Create.
	/// <see>https://docs.miva.com/json-api/functions/changeset_create</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ChangesetCreateRequest : Request
	{
		/// Request field Branch_ID.
		[JsonPropertyName("Branch_ID")]
		public int? BranchId { get; set; }

		/// Request field Branch_Name.
		[JsonPropertyName("Branch_Name")]
		public String BranchName { get; set; }

		/// Request field Edit_Branch.
		[JsonPropertyName("Edit_Branch")]
		public String EditBranch { get; set; }

		/// Request field Notes.
		[JsonPropertyName("Notes")]
		public String Notes { get; set; }

		/// Request field Tags.
		[JsonPropertyName("Tags")]
		public String Tags { get; set; }

		/// Request field Template_Changes.
		[JsonPropertyName("Template_Changes")]
		public List<TemplateChange> TemplateChanges { get; set; } = new List<TemplateChange>();

		/// Request field ResourceGroup_Changes.
		[JsonPropertyName("ResourceGroup_Changes")]
		public List<ResourceGroupChange> ResourceGroupChanges { get; set; } = new List<ResourceGroupChange>();

		/// Request field CSSResource_Changes.
		[JsonPropertyName("CSSResource_Changes")]
		public List<CSSResourceChange> CSSResourceChanges { get; set; } = new List<CSSResourceChange>();

		/// Request field JavaScriptResource_Changes.
		[JsonPropertyName("JavaScriptResource_Changes")]
		public List<JavaScriptResourceChange> JavaScriptResourceChanges { get; set; } = new List<JavaScriptResourceChange>();

		/// Request field Property_Changes.
		[JsonPropertyName("Property_Changes")]
		public List<PropertyChange> PropertyChanges { get; set; } = new List<PropertyChange>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="branch">Branch</param>
		/// </summary>
		public ChangesetCreateRequest(BaseClient client = null, Branch branch = null) :
			base(client)
		{
			Function = "Changeset_Create";
			if (branch != null) {
				if (branch.Id > 0)
				{
					BranchId = branch.Id;
				}

				BranchName = branch.Name;
			}
		}

		/// <summary>
		/// Getter for Branch_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBranchId()
		{
			return BranchId;
		}

		/// <summary>
		/// Getter for Branch_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetBranchName()
		{
			return BranchName;
		}

		/// <summary>
		/// Getter for Edit_Branch.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditBranch()
		{
			return EditBranch;
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
		/// Getter for Tags.
		/// <returns>String</returns>
		/// </summary>
		public String GetTags()
		{
			return Tags;
		}

		/// <summary>
		/// Getter for Template_Changes.
		/// <returns>List<TemplateChange></returns>
		/// </summary>
		public List<TemplateChange> GetTemplateChanges()
		{
			return TemplateChanges;
		}

		/// <summary>
		/// Getter for ResourceGroup_Changes.
		/// <returns>List<ResourceGroupChange></returns>
		/// </summary>
		public List<ResourceGroupChange> GetResourceGroupChanges()
		{
			return ResourceGroupChanges;
		}

		/// <summary>
		/// Getter for CSSResource_Changes.
		/// <returns>List<CSSResourceChange></returns>
		/// </summary>
		public List<CSSResourceChange> GetCSSResourceChanges()
		{
			return CSSResourceChanges;
		}

		/// <summary>
		/// Getter for JavaScriptResource_Changes.
		/// <returns>List<JavaScriptResourceChange></returns>
		/// </summary>
		public List<JavaScriptResourceChange> GetJavaScriptResourceChanges()
		{
			return JavaScriptResourceChanges;
		}

		/// <summary>
		/// Getter for Property_Changes.
		/// <returns>List<PropertyChange></returns>
		/// </summary>
		public List<PropertyChange> GetPropertyChanges()
		{
			return PropertyChanges;
		}

		/// <summary>
		/// Setter for Branch_ID.
		/// <param name="value">int</param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest SetBranchId(int? value)
		{
			BranchId = value;
			return this;
		}

		/// <summary>
		/// Setter for Branch_Name.
		/// <param name="value">String</param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest SetBranchName(String value)
		{
			BranchName = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Branch.
		/// <param name="value">String</param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest SetEditBranch(String value)
		{
			EditBranch = value;
			return this;
		}

		/// <summary>
		/// Setter for Notes.
		/// <param name="value">String</param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest SetNotes(String value)
		{
			Notes = value;
			return this;
		}

		/// <summary>
		/// Setter for Tags.
		/// <param name="value">String</param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest SetTags(String value)
		{
			Tags = value;
			return this;
		}

		/// <summary>
		/// Add a TemplateChange.
		/// - templateChange: TemplateChange
		/// - Returns: Self
		/// </summary>
		public ChangesetCreateRequest AddTemplateChange(TemplateChange templateChange)
		{
			TemplateChanges.Add(templateChange);
			return this;
		}

		/// <summary>
		/// Add an array of TemplateChange.
		/// <param name="templateChanges">List<TemplateChange></param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest AddTemplateChanges(List<TemplateChange> templateChanges)
		{
			foreach(TemplateChange e in templateChanges)
			{
				TemplateChanges.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a ResourceGroupChange.
		/// - resourceGroupChange: ResourceGroupChange
		/// - Returns: Self
		/// </summary>
		public ChangesetCreateRequest AddResourceGroupChange(ResourceGroupChange resourceGroupChange)
		{
			ResourceGroupChanges.Add(resourceGroupChange);
			return this;
		}

		/// <summary>
		/// Add an array of ResourceGroupChange.
		/// <param name="resourceGroupChanges">List<ResourceGroupChange></param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest AddResourceGroupChanges(List<ResourceGroupChange> resourceGroupChanges)
		{
			foreach(ResourceGroupChange e in resourceGroupChanges)
			{
				ResourceGroupChanges.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a CSSResourceChange.
		/// - CSSResourceChange: CSSResourceChange
		/// - Returns: Self
		/// </summary>
		public ChangesetCreateRequest AddCSSResourceChange(CSSResourceChange CSSResourceChange)
		{
			CSSResourceChanges.Add(CSSResourceChange);
			return this;
		}

		/// <summary>
		/// Add an array of CSSResourceChange.
		/// <param name="CSSResourceChanges">List<CSSResourceChange></param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest AddCSSResourceChanges(List<CSSResourceChange> CSSResourceChanges)
		{
			foreach(CSSResourceChange e in CSSResourceChanges)
			{
				CSSResourceChanges.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a JavaScriptResourceChange.
		/// - javaScriptResourceChange: JavaScriptResourceChange
		/// - Returns: Self
		/// </summary>
		public ChangesetCreateRequest AddJavaScriptResourceChange(JavaScriptResourceChange javaScriptResourceChange)
		{
			JavaScriptResourceChanges.Add(javaScriptResourceChange);
			return this;
		}

		/// <summary>
		/// Add an array of JavaScriptResourceChange.
		/// <param name="javaScriptResourceChanges">List<JavaScriptResourceChange></param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest AddJavaScriptResourceChanges(List<JavaScriptResourceChange> javaScriptResourceChanges)
		{
			foreach(JavaScriptResourceChange e in javaScriptResourceChanges)
			{
				JavaScriptResourceChanges.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a PropertyChange.
		/// - propertyChange: PropertyChange
		/// - Returns: Self
		/// </summary>
		public ChangesetCreateRequest AddPropertyChange(PropertyChange propertyChange)
		{
			PropertyChanges.Add(propertyChange);
			return this;
		}

		/// <summary>
		/// Add an array of PropertyChange.
		/// <param name="propertyChanges">List<PropertyChange></param>
		/// <returns>ChangesetCreateRequest</returns>
		/// </summary>
		public ChangesetCreateRequest AddPropertyChanges(List<PropertyChange> propertyChanges)
		{
			foreach(PropertyChange e in propertyChanges)
			{
				PropertyChanges.Add(e);
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

			if (BranchId.HasValue)
			{
				writer.WriteNumber("Branch_ID", BranchId.Value);
			}
			else if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}
			else if (EditBranch != null && EditBranch.Length > 0)
			{
				writer.WriteString("Edit_Branch", EditBranch);
			}

			if (BranchName != null && BranchName.Length > 0)
			{
				writer.WriteString("Branch_Name", BranchName);
			}

			if (Notes != null && Notes.Length > 0)
			{
				writer.WriteString("Notes", Notes);
			}

			if (Tags != null && Tags.Length > 0)
			{
				writer.WriteString("Tags", Tags);
			}

			if (TemplateChanges.Count > 0)
			{
				writer.WritePropertyName("Template_Changes");
				JsonSerializer.Serialize(writer, this.TemplateChanges, options);
			}

			if (ResourceGroupChanges.Count > 0)
			{
				writer.WritePropertyName("ResourceGroup_Changes");
				JsonSerializer.Serialize(writer, this.ResourceGroupChanges, options);
			}

			if (CSSResourceChanges.Count > 0)
			{
				writer.WritePropertyName("CSSResource_Changes");
				JsonSerializer.Serialize(writer, this.CSSResourceChanges, options);
			}

			if (JavaScriptResourceChanges.Count > 0)
			{
				writer.WritePropertyName("JavaScriptResource_Changes");
				JsonSerializer.Serialize(writer, this.JavaScriptResourceChanges, options);
			}

			if (PropertyChanges.Count > 0)
			{
				writer.WritePropertyName("Property_Changes");
				JsonSerializer.Serialize(writer, this.PropertyChanges, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ChangesetCreateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ChangesetCreateResponse</returns>
		/// </summary>
		public new ChangesetCreateResponse Send()
		{
			return Client.SendRequestAsync<ChangesetCreateRequest, ChangesetCreateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ChangesetCreateResponse></returns>
		/// </summary>
		public new async Task<ChangesetCreateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ChangesetCreateRequest, ChangesetCreateResponse>(this);
		}
	}
}
