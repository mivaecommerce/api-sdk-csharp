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
	/// Handles API Request Product_Update.
	/// <see>https://docs.miva.com/json-api/functions/product_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class ProductUpdateRequest : Request
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_SKU.
		[JsonPropertyName("Product_SKU")]
		public String ProductSku { get; set; }

		/// Request field Product_Name.
		[JsonPropertyName("Product_Name")]
		public String ProductName { get; set; }

		/// Request field Product_Description.
		[JsonPropertyName("Product_Description")]
		public String ProductDescription { get; set; }

		/// Request field Product_Canonical_Category_Code.
		[JsonPropertyName("Product_Canonical_Category_Code")]
		public String ProductCanonicalCategoryCode { get; set; }

		/// Request field Product_Alternate_Display_Page.
		[JsonPropertyName("Product_Alternate_Display_Page")]
		public String ProductAlternateDisplayPage { get; set; }

		/// Request field Product_Page_Title.
		[JsonPropertyName("Product_Page_Title")]
		public String ProductPageTitle { get; set; }

		/// Request field Product_Thumbnail.
		[JsonPropertyName("Product_Thumbnail")]
		public String ProductThumbnail { get; set; }

		/// Request field Product_Image.
		[JsonPropertyName("Product_Image")]
		public String ProductImage { get; set; }

		/// Request field Product_Price.
		[JsonPropertyName("Product_Price")]
		public float? ProductPrice { get; set; }

		/// Request field Product_Cost.
		[JsonPropertyName("Product_Cost")]
		public float? ProductCost { get; set; }

		/// Request field Product_Weight.
		[JsonPropertyName("Product_Weight")]
		public float? ProductWeight { get; set; }

		/// Request field Product_Inventory.
		[JsonPropertyName("Product_Inventory")]
		public int? ProductInventory { get; set; }

		/// Request field Product_Taxable.
		[JsonPropertyName("Product_Taxable")]
		public bool? ProductTaxable { get; set; }

		/// Request field Product_Active.
		[JsonPropertyName("Product_Active")]
		public bool? ProductActive { get; set; }

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public ProductUpdateRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "Product_Update";
			CustomFieldValues = new CustomFieldValues();
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
				}

				ProductCode = product.Code;
				ProductSku = product.Sku;
				ProductName = product.Name;
				ProductDescription = product.Description;
				ProductCanonicalCategoryCode = product.CanonicalCategoryCode;
				ProductAlternateDisplayPage = product.PageCode;
				ProductPageTitle = product.PageTitle;
				ProductThumbnail = product.Thumbnail;
				ProductImage = product.Image;
				ProductPrice = product.Price;
				ProductCost = product.Cost;
				ProductWeight = product.Weight;
				ProductInventory = product.ProductInventory;
				ProductTaxable = product.Taxable;
				ProductActive = product.Active;
				CustomFieldValues = product.CustomFieldValues;
			}
		}

		/// <summary>
		/// Getter for Product_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetProductId()
		{
			return ProductId;
		}

		/// <summary>
		/// Getter for Product_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
		}

		/// <summary>
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
		}

		/// <summary>
		/// Getter for Product_SKU.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for Product_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductName()
		{
			return ProductName;
		}

		/// <summary>
		/// Getter for Product_Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductDescription()
		{
			return ProductDescription;
		}

		/// <summary>
		/// Getter for Product_Canonical_Category_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCanonicalCategoryCode()
		{
			return ProductCanonicalCategoryCode;
		}

		/// <summary>
		/// Getter for Product_Alternate_Display_Page.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductAlternateDisplayPage()
		{
			return ProductAlternateDisplayPage;
		}

		/// <summary>
		/// Getter for Product_Page_Title.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductPageTitle()
		{
			return ProductPageTitle;
		}

		/// <summary>
		/// Getter for Product_Thumbnail.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductThumbnail()
		{
			return ProductThumbnail;
		}

		/// <summary>
		/// Getter for Product_Image.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductImage()
		{
			return ProductImage;
		}

		/// <summary>
		/// Getter for Product_Price.
		/// <returns>float</returns>
		/// </summary>
		public float? GetProductPrice()
		{
			return ProductPrice;
		}

		/// <summary>
		/// Getter for Product_Cost.
		/// <returns>float</returns>
		/// </summary>
		public float? GetProductCost()
		{
			return ProductCost;
		}

		/// <summary>
		/// Getter for Product_Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetProductWeight()
		{
			return ProductWeight;
		}

		/// <summary>
		/// Getter for Product_Inventory.
		/// <returns>int</returns>
		/// </summary>
		public int? GetProductInventory()
		{
			return ProductInventory;
		}

		/// <summary>
		/// Getter for Product_Taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetProductTaxable()
		{
			return ProductTaxable;
		}

		/// <summary>
		/// Getter for Product_Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetProductActive()
		{
			return ProductActive;
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
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_SKU.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductSku(String value)
		{
			ProductSku = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Name.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductName(String value)
		{
			ProductName = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Description.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductDescription(String value)
		{
			ProductDescription = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Canonical_Category_Code.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductCanonicalCategoryCode(String value)
		{
			ProductCanonicalCategoryCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Alternate_Display_Page.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductAlternateDisplayPage(String value)
		{
			ProductAlternateDisplayPage = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Page_Title.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductPageTitle(String value)
		{
			ProductPageTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Thumbnail.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductThumbnail(String value)
		{
			ProductThumbnail = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Image.
		/// <param name="value">String</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductImage(String value)
		{
			ProductImage = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Price.
		/// <param name="value">float</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
	   public ProductUpdateRequest SetProductPrice(float? value)
	   {
			ProductPrice = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Price.
		/// <param name="value">double</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
	   public ProductUpdateRequest SetProductPrice(double? value)
	   {
			ProductPrice = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Cost.
		/// <param name="value">float</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
	   public ProductUpdateRequest SetProductCost(float? value)
	   {
			ProductCost = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Cost.
		/// <param name="value">double</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
	   public ProductUpdateRequest SetProductCost(double? value)
	   {
			ProductCost = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Weight.
		/// <param name="value">float</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
	   public ProductUpdateRequest SetProductWeight(float? value)
	   {
			ProductWeight = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Weight.
		/// <param name="value">double</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
	   public ProductUpdateRequest SetProductWeight(double? value)
	   {
			ProductWeight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Inventory.
		/// <param name="value">int</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductInventory(int? value)
		{
			ProductInventory = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Taxable.
		/// <param name="value">bool</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductTaxable(bool? value)
		{
			ProductTaxable = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Active.
		/// <param name="value">bool</param>
		/// <returns>ProductUpdateRequest</returns>
		/// </summary>
		public ProductUpdateRequest SetProductActive(bool? value)
		{
			ProductActive = value;
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

			if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}

			if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}

			if (ProductSku != null && ProductSku.Length > 0)
			{
				writer.WriteString("Product_SKU", ProductSku);
			}

			if (ProductName != null && ProductName.Length > 0)
			{
				writer.WriteString("Product_Name", ProductName);
			}

			if (ProductDescription != null && ProductDescription.Length > 0)
			{
				writer.WriteString("Product_Description", ProductDescription);
			}

			if (ProductCanonicalCategoryCode != null && ProductCanonicalCategoryCode.Length > 0)
			{
				writer.WriteString("Product_Canonical_Category_Code", ProductCanonicalCategoryCode);
			}

			if (ProductAlternateDisplayPage != null && ProductAlternateDisplayPage.Length > 0)
			{
				writer.WriteString("Product_Alternate_Display_Page", ProductAlternateDisplayPage);
			}

			if (ProductPageTitle != null && ProductPageTitle.Length > 0)
			{
				writer.WriteString("Product_Page_Title", ProductPageTitle);
			}

			if (ProductThumbnail != null && ProductThumbnail.Length > 0)
			{
				writer.WriteString("Product_Thumbnail", ProductThumbnail);
			}

			if (ProductImage != null && ProductImage.Length > 0)
			{
				writer.WriteString("Product_Image", ProductImage);
			}

			if (ProductPrice.HasValue)
			{
				writer.WriteNumber("Product_Price", ProductPrice.Value);
			}

			if (ProductCost.HasValue)
			{
				writer.WriteNumber("Product_Cost", ProductCost.Value);
			}

			if (ProductWeight.HasValue)
			{
				writer.WriteNumber("Product_Weight", ProductWeight.Value);
			}

			if (ProductInventory.HasValue)
			{
				writer.WriteNumber("Product_Inventory", ProductInventory.Value);
			}

			if (ProductTaxable.HasValue)
			{
				writer.WriteBoolean("Product_Taxable", ProductTaxable.Value);
			}

			if (ProductActive.HasValue)
			{
				writer.WriteBoolean("Product_Active", ProductActive.Value);
			}

			if (CustomFieldValues != null)
			{
				writer.WritePropertyName("CustomField_Values");
				JsonSerializer.Serialize(writer, this.CustomFieldValues, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<ProductUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>ProductUpdateResponse</returns>
		/// </summary>
		public new ProductUpdateResponse Send()
		{
			return Client.SendRequestAsync<ProductUpdateRequest, ProductUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<ProductUpdateResponse></returns>
		/// </summary>
		public new async Task<ProductUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<ProductUpdateRequest, ProductUpdateResponse>(this);
		}
	}
}
