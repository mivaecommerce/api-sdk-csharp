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
	public class RelatedProduct : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property Sku - String</value>
		[JsonPropertyName("sku")]
		public String Sku { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Thumbnail - String</value>
		[JsonPropertyName("thumbnail")]
		public String Thumbnail { get; set; }

		/// <value>Property Image - String</value>
		[JsonPropertyName("image")]
		public String Image { get; set; }

		/// <value>Property Price - float</value>
		[JsonPropertyName("price")]
		public float Price { get; set; }

		/// <value>Property FormattedPrice - String</value>
		[JsonPropertyName("formatted_price")]
		public String FormattedPrice { get; set; }

		/// <value>Property Cost - float</value>
		[JsonPropertyName("cost")]
		public float Cost { get; set; }

		/// <value>Property FormattedCost - String</value>
		[JsonPropertyName("formatted_cost")]
		public String FormattedCost { get; set; }

		/// <value>Property Weight - float</value>
		[JsonPropertyName("weight")]
		public float Weight { get; set; }

		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property PageTitle - String</value>
		[JsonPropertyName("page_title")]
		public String PageTitle { get; set; }

		/// <value>Property Taxable - bool</value>
		[JsonPropertyName("taxable")]
		public bool Taxable { get; set; }

		/// <value>Property DateTimeCreated - int</value>
		[JsonPropertyName("dt_created")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeCreated { get; set; }

		/// <value>Property DateTimeUpdated - int</value>
		[JsonPropertyName("dt_updated")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeUpdated { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetSku()
		{
			return Sku;
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
		/// Getter for thumbnail.
		/// <returns>String</returns>
		/// </summary>
		public String GetThumbnail()
		{
			return Thumbnail;
		}

		/// <summary>
		/// Getter for image.
		/// <returns>String</returns>
		/// </summary>
		public String GetImage()
		{
			return Image;
		}

		/// <summary>
		/// Getter for price.
		/// <returns>float</returns>
		/// </summary>
		public float GetPrice()
		{
			return Price;
		}

		/// <summary>
		/// Getter for formatted_price.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedPrice()
		{
			return FormattedPrice;
		}

		/// <summary>
		/// Getter for cost.
		/// <returns>float</returns>
		/// </summary>
		public float GetCost()
		{
			return Cost;
		}

		/// <summary>
		/// Getter for formatted_cost.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedCost()
		{
			return FormattedCost;
		}

		/// <summary>
		/// Getter for weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetWeight()
		{
			return Weight;
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
		/// Getter for page_title.
		/// <returns>String</returns>
		/// </summary>
		public String GetPageTitle()
		{
			return PageTitle;
		}

		/// <summary>
		/// Getter for taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTaxable()
		{
			return Taxable;
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
		/// Setter for code.
		/// <param name="value">String</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for sku.
		/// <param name="value">String</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetSku(String value)
		{
			Sku = value;
			return this;
		}

		/// <summary>
		/// Setter for name.
		/// <param name="value">String</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for thumbnail.
		/// <param name="value">String</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetThumbnail(String value)
		{
			Thumbnail = value;
			return this;
		}

		/// <summary>
		/// Setter for image.
		/// <param name="value">String</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetImage(String value)
		{
			Image = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">float</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
	   public RelatedProduct SetPrice(float value)
	   {
			Price = value;
			return this;
		}

		/// <summary>
		/// Setter for price.
		/// <param name="value">double</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
	   public RelatedProduct SetPrice(double value)
	   {
			Price = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">float</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
	   public RelatedProduct SetCost(float value)
	   {
			Cost = value;
			return this;
		}

		/// <summary>
		/// Setter for cost.
		/// <param name="value">double</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
	   public RelatedProduct SetCost(double value)
	   {
			Cost = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">float</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
	   public RelatedProduct SetWeight(float value)
	   {
			Weight = value;
			return this;
		}

		/// <summary>
		/// Setter for weight.
		/// <param name="value">double</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
	   public RelatedProduct SetWeight(double value)
	   {
			Weight = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for active.
		/// <param name="value">bool</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetActive(bool value)
		{
			Active = value;
			return this;
		}

		/// <summary>
		/// Setter for page_title.
		/// <param name="value">String</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetPageTitle(String value)
		{
			PageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for taxable.
		/// <param name="value">bool</param>
		/// <returns>RelatedProduct</returns>
		/// </summary>
		public RelatedProduct SetTaxable(bool value)
		{
			Taxable = value;
			return this;
		}
	}
}
