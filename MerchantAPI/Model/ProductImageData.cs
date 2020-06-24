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
	public class ProductImageData : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ProductId - int</value>
		[JsonPropertyName("product_id")]
		public int ProductId { get; set; }

		/// <value>Property ImageId - int</value>
		[JsonPropertyName("image_id")]
		public int ImageId { get; set; }

		/// <value>Property TypeId - int</value>
		[JsonPropertyName("type_id")]
		public int TypeId { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property TypeDescription - String</value>
		[JsonPropertyName("type_desc")]
		public String TypeDescription { get; set; }

		/// <value>Property Image - String</value>
		[JsonPropertyName("image")]
		public String Image { get; set; }

		/// <value>Property Width - int</value>
		[JsonPropertyName("width")]
		public int Width { get; set; }

		/// <value>Property Height - int</value>
		[JsonPropertyName("height")]
		public int Height { get; set; }

		/// <value>Property DisplayOrder - int</value>
		[JsonPropertyName("disp_order")]
		public int DisplayOrder { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for product_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for image_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetImageId()
		{
			return ImageId;
		}

		/// <summary>
		/// Getter for type_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTypeId()
		{
			return TypeId;
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
		/// Getter for type_desc.
		/// <returns>String</returns>
		/// </summary>
		public String GetTypeDescription()
		{
			return TypeDescription;
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
		/// Getter for width.
		/// <returns>int</returns>
		/// </summary>
		public int GetWidth()
		{
			return Width;
		}

		/// <summary>
		/// Getter for height.
		/// <returns>int</returns>
		/// </summary>
		public int GetHeight()
		{
			return Height;
		}

		/// <summary>
		/// Getter for disp_order.
		/// <returns>int</returns>
		/// </summary>
		public int GetDisplayOrder()
		{
			return DisplayOrder;
		}
	}
}
