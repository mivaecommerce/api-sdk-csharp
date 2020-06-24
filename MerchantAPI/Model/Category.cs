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

namespace MerchantAPI
{
	public class Category : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ParentId - int</value>
		[JsonPropertyName("parent_id")]
		public int ParentId { get; set; }

		/// <value>Property AvailabilityGroupCount - int</value>
		[JsonPropertyName("agrpcount")]
		public int AvailabilityGroupCount { get; set; }

		/// <value>Property Depth - int</value>
		[JsonPropertyName("depth")]
		public int Depth { get; set; }

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

		/// <value>Property PageId - int</value>
		[JsonPropertyName("page_id")]
		public int PageId { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property PageTitle - String</value>
		[JsonPropertyName("page_title")]
		public String PageTitle { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property DateTimeCreated - int</value>
		[JsonPropertyName("dt_created")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeCreated { get; set; }

		/// <value>Property DateTimeUpdated - int</value>
		[JsonPropertyName("dt_updated")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeUpdated { get; set; }

		/// <value>Property PageCode - String</value>
		[JsonPropertyName("page_code")]
		public String PageCode { get; set; }

		/// <value>Property ParentCategory - String</value>
		[JsonPropertyName("parent_category")]
		public String ParentCategory { get; set; }

		/// <value>Property CustomFieldValues - CustomFieldValues</value>
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for parent_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetParentId()
		{
			return ParentId;
		}

		/// <summary>
		/// Getter for agrpcount.
		/// <returns>int</returns>
		/// </summary>
		public int GetAvailabilityGroupCount()
		{
			return AvailabilityGroupCount;
		}

		/// <summary>
		/// Getter for depth.
		/// <returns>int</returns>
		/// </summary>
		public int GetDepth()
		{
			return Depth;
		}

		/// <summary>
		/// Getter for disp_order.
		/// <returns>int</returns>
		/// </summary>
		public int GetDisplayOrder()
		{
			return DisplayOrder;
		}

		/// <summary>
		/// Getter for page_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetPageId()
		{
			return PageId;
		}

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for page_title.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageTitle()
		{
			return PageTitle;
		}

		/// <summary>
		/// Getter for active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetActive()
		{
			return Active;
		}

		/// <summary>
		/// Getter for dt_created.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeCreated()
		{
			return DateTimeCreated;
		}

		/// <summary>
		/// Getter for dt_updated.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeUpdated()
		{
			return DateTimeUpdated;
		}

		/// <summary>
		/// Getter for page_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageCode()
		{
			return PageCode;
		}

		/// <summary>
		/// Getter for parent_category.
		/// <returns>String</returns>
		/// </summary>
		public String GetParentCategory()
		{
			return ParentCategory;
		}

		/// <summary>
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>Category</returns>
		/// </summary>
		public Category SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for name.
		/// <param name="value">String</param>
		/// <returns>Category</returns>
		/// </summary>
		public Category SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for page_title.
		/// <param name="value">String</param>
		/// <returns>Category</returns>
		/// </summary>
		public Category SetPageTitle(String value)
		{
			PageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for active.
		/// <param name="value">bool</param>
		/// <returns>Category</returns>
		/// </summary>
		public Category SetActive(bool value)
		{
			Active = value;
			return this;
		}

		/// <summary>
		/// Setter for page_code.
		/// <param name="value">String</param>
		/// <returns>Category</returns>
		/// </summary>
		public Category SetPageCode(String value)
		{
			PageCode = value;
			return this;
		}

		/// <summary>
		/// Setter for parent_category.
		/// <param name="value">String</param>
		/// <returns>Category</returns>
		/// </summary>
		public Category SetParentCategory(String value)
		{
			ParentCategory = value;
			return this;
		}
	}
}
