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
	public class CopyProductRule : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property CoreProductData - bool</value>
		[JsonPropertyName("product")]
		public bool CoreProductData { get; set; }

		/// <value>Property Attributes - bool</value>
		[JsonPropertyName("attributes")]
		public bool Attributes { get; set; }

		/// <value>Property CategoryAssignments - bool</value>
		[JsonPropertyName("categories")]
		public bool CategoryAssignments { get; set; }

		/// <value>Property InventorySettings - bool</value>
		[JsonPropertyName("invset")]
		public bool InventorySettings { get; set; }

		/// <value>Property InventoryLevel - bool</value>
		[JsonPropertyName("invlevel")]
		public bool InventoryLevel { get; set; }

		/// <value>Property Images - bool</value>
		[JsonPropertyName("images")]
		public bool Images { get; set; }

		/// <value>Property RelatedProducts - bool</value>
		[JsonPropertyName("relprod")]
		public bool RelatedProducts { get; set; }

		/// <value>Property Upsale - bool</value>
		[JsonPropertyName("upsale")]
		public bool Upsale { get; set; }

		/// <value>Property AvailabilityGroupAssignments - bool</value>
		[JsonPropertyName("availgroup")]
		public bool AvailabilityGroupAssignments { get; set; }

		/// <value>Property PriceGroupAssignments - bool</value>
		[JsonPropertyName("pricegroup")]
		public bool PriceGroupAssignments { get; set; }

		/// <value>Property DigitalDownloadSettings - bool</value>
		[JsonPropertyName("ddownload")]
		public bool DigitalDownloadSettings { get; set; }

		/// <value>Property GiftCertificateSales - bool</value>
		[JsonPropertyName("giftcert")]
		public bool GiftCertificateSales { get; set; }

		/// <value>Property SubscriptionSettings - bool</value>
		[JsonPropertyName("subscrip")]
		public bool SubscriptionSettings { get; set; }

		/// <value>Property PaymentRules - bool</value>
		[JsonPropertyName("payment")]
		public bool PaymentRules { get; set; }

		/// <value>Property ShippingRules - bool</value>
		[JsonPropertyName("shipping")]
		public bool ShippingRules { get; set; }

		/// <value>Property ProductKits - bool</value>
		[JsonPropertyName("kit")]
		public bool ProductKits { get; set; }

		/// <value>Property ProductVariants - bool</value>
		[JsonPropertyName("variants")]
		public bool ProductVariants { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
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
		/// Getter for product.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCoreProductData()
		{
			return CoreProductData;
		}

		/// <summary>
		/// Getter for attributes.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for categories.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCategoryAssignments()
		{
			return CategoryAssignments;
		}

		/// <summary>
		/// Getter for invset.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetInventorySettings()
		{
			return InventorySettings;
		}

		/// <summary>
		/// Getter for invlevel.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetInventoryLevel()
		{
			return InventoryLevel;
		}

		/// <summary>
		/// Getter for images.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetImages()
		{
			return Images;
		}

		/// <summary>
		/// Getter for relprod.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetRelatedProducts()
		{
			return RelatedProducts;
		}

		/// <summary>
		/// Getter for upsale.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetUpsale()
		{
			return Upsale;
		}

		/// <summary>
		/// Getter for availgroup.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAvailabilityGroupAssignments()
		{
			return AvailabilityGroupAssignments;
		}

		/// <summary>
		/// Getter for pricegroup.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetPriceGroupAssignments()
		{
			return PriceGroupAssignments;
		}

		/// <summary>
		/// Getter for ddownload.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetDigitalDownloadSettings()
		{
			return DigitalDownloadSettings;
		}

		/// <summary>
		/// Getter for giftcert.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetGiftCertificateSales()
		{
			return GiftCertificateSales;
		}

		/// <summary>
		/// Getter for subscrip.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetSubscriptionSettings()
		{
			return SubscriptionSettings;
		}

		/// <summary>
		/// Getter for payment.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetPaymentRules()
		{
			return PaymentRules;
		}

		/// <summary>
		/// Getter for shipping.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetShippingRules()
		{
			return ShippingRules;
		}

		/// <summary>
		/// Getter for kit.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetProductKits()
		{
			return ProductKits;
		}

		/// <summary>
		/// Getter for variants.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetProductVariants()
		{
			return ProductVariants;
		}
	}
}
