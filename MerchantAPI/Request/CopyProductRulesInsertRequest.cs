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
	/// Handles API Request CopyProductRules_Insert.
	/// <see>https://docs.miva.com/json-api/functions/copyproductrules_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CopyProductRulesInsertRequest : Request
	{
		/// Request field Name.
		[JsonPropertyName("Name")]
		public String Name { get; set; }

		/// Request field CoreProductData.
		[JsonPropertyName("CoreProductData")]
		public bool? CoreProductData { get; set; }

		/// Request field Attributes.
		[JsonPropertyName("Attributes")]
		public bool? Attributes { get; set; }

		/// Request field CategoryAssignments.
		[JsonPropertyName("CategoryAssignments")]
		public bool? CategoryAssignments { get; set; }

		/// Request field InventorySettings.
		[JsonPropertyName("InventorySettings")]
		public bool? InventorySettings { get; set; }

		/// Request field InventoryLevel.
		[JsonPropertyName("InventoryLevel")]
		public bool? InventoryLevel { get; set; }

		/// Request field Images.
		[JsonPropertyName("Images")]
		public bool? Images { get; set; }

		/// Request field RelatedProducts.
		[JsonPropertyName("RelatedProducts")]
		public bool? RelatedProducts { get; set; }

		/// Request field Upsale.
		[JsonPropertyName("Upsale")]
		public bool? Upsale { get; set; }

		/// Request field AvailabilityGroupAssignments.
		[JsonPropertyName("AvailabilityGroupAssignments")]
		public bool? AvailabilityGroupAssignments { get; set; }

		/// Request field PriceGroupAssignments.
		[JsonPropertyName("PriceGroupAssignments")]
		public bool? PriceGroupAssignments { get; set; }

		/// Request field DigitalDownloadSettings.
		[JsonPropertyName("DigitalDownloadSettings")]
		public bool? DigitalDownloadSettings { get; set; }

		/// Request field GiftCertificateSales.
		[JsonPropertyName("GiftCertificateSales")]
		public bool? GiftCertificateSales { get; set; }

		/// Request field SubscriptionSettings.
		[JsonPropertyName("SubscriptionSettings")]
		public bool? SubscriptionSettings { get; set; }

		/// Request field PaymentRules.
		[JsonPropertyName("PaymentRules")]
		public bool? PaymentRules { get; set; }

		/// Request field ShippingRules.
		[JsonPropertyName("ShippingRules")]
		public bool? ShippingRules { get; set; }

		/// Request field ProductKits.
		[JsonPropertyName("ProductKits")]
		public bool? ProductKits { get; set; }

		/// Request field ProductVariants.
		[JsonPropertyName("ProductVariants")]
		public bool? ProductVariants { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public CopyProductRulesInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "CopyProductRules_Insert";
		}

		/// <summary>
		/// Getter for Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for CoreProductData.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCoreProductData()
		{
			return CoreProductData;
		}

		/// <summary>
		/// Getter for Attributes.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Getter for CategoryAssignments.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCategoryAssignments()
		{
			return CategoryAssignments;
		}

		/// <summary>
		/// Getter for InventorySettings.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetInventorySettings()
		{
			return InventorySettings;
		}

		/// <summary>
		/// Getter for InventoryLevel.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetInventoryLevel()
		{
			return InventoryLevel;
		}

		/// <summary>
		/// Getter for Images.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetImages()
		{
			return Images;
		}

		/// <summary>
		/// Getter for RelatedProducts.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetRelatedProducts()
		{
			return RelatedProducts;
		}

		/// <summary>
		/// Getter for Upsale.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUpsale()
		{
			return Upsale;
		}

		/// <summary>
		/// Getter for AvailabilityGroupAssignments.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAvailabilityGroupAssignments()
		{
			return AvailabilityGroupAssignments;
		}

		/// <summary>
		/// Getter for PriceGroupAssignments.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetPriceGroupAssignments()
		{
			return PriceGroupAssignments;
		}

		/// <summary>
		/// Getter for DigitalDownloadSettings.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDigitalDownloadSettings()
		{
			return DigitalDownloadSettings;
		}

		/// <summary>
		/// Getter for GiftCertificateSales.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetGiftCertificateSales()
		{
			return GiftCertificateSales;
		}

		/// <summary>
		/// Getter for SubscriptionSettings.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetSubscriptionSettings()
		{
			return SubscriptionSettings;
		}

		/// <summary>
		/// Getter for PaymentRules.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetPaymentRules()
		{
			return PaymentRules;
		}

		/// <summary>
		/// Getter for ShippingRules.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetShippingRules()
		{
			return ShippingRules;
		}

		/// <summary>
		/// Getter for ProductKits.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetProductKits()
		{
			return ProductKits;
		}

		/// <summary>
		/// Getter for ProductVariants.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetProductVariants()
		{
			return ProductVariants;
		}

		/// <summary>
		/// Setter for Name.
		/// <param name="value">String</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for CoreProductData.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetCoreProductData(bool? value)
		{
			CoreProductData = value;
			return this;
		}

		/// <summary>
		/// Setter for Attributes.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetAttributes(bool? value)
		{
			Attributes = value;
			return this;
		}

		/// <summary>
		/// Setter for CategoryAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetCategoryAssignments(bool? value)
		{
			CategoryAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for InventorySettings.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetInventorySettings(bool? value)
		{
			InventorySettings = value;
			return this;
		}

		/// <summary>
		/// Setter for InventoryLevel.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetInventoryLevel(bool? value)
		{
			InventoryLevel = value;
			return this;
		}

		/// <summary>
		/// Setter for Images.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetImages(bool? value)
		{
			Images = value;
			return this;
		}

		/// <summary>
		/// Setter for RelatedProducts.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetRelatedProducts(bool? value)
		{
			RelatedProducts = value;
			return this;
		}

		/// <summary>
		/// Setter for Upsale.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetUpsale(bool? value)
		{
			Upsale = value;
			return this;
		}

		/// <summary>
		/// Setter for AvailabilityGroupAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetAvailabilityGroupAssignments(bool? value)
		{
			AvailabilityGroupAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroupAssignments.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetPriceGroupAssignments(bool? value)
		{
			PriceGroupAssignments = value;
			return this;
		}

		/// <summary>
		/// Setter for DigitalDownloadSettings.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetDigitalDownloadSettings(bool? value)
		{
			DigitalDownloadSettings = value;
			return this;
		}

		/// <summary>
		/// Setter for GiftCertificateSales.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetGiftCertificateSales(bool? value)
		{
			GiftCertificateSales = value;
			return this;
		}

		/// <summary>
		/// Setter for SubscriptionSettings.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetSubscriptionSettings(bool? value)
		{
			SubscriptionSettings = value;
			return this;
		}

		/// <summary>
		/// Setter for PaymentRules.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetPaymentRules(bool? value)
		{
			PaymentRules = value;
			return this;
		}

		/// <summary>
		/// Setter for ShippingRules.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetShippingRules(bool? value)
		{
			ShippingRules = value;
			return this;
		}

		/// <summary>
		/// Setter for ProductKits.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetProductKits(bool? value)
		{
			ProductKits = value;
			return this;
		}

		/// <summary>
		/// Setter for ProductVariants.
		/// <param name="value">bool</param>
		/// <returns>CopyProductRulesInsertRequest</returns>
		/// </summary>
		public CopyProductRulesInsertRequest SetProductVariants(bool? value)
		{
			ProductVariants = value;
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

			writer.WriteString("Name", Name);

			if (CoreProductData.HasValue)
			{
				writer.WriteBoolean("CoreProductData", CoreProductData.Value);
			}

			if (Attributes.HasValue)
			{
				writer.WriteBoolean("Attributes", Attributes.Value);
			}

			if (CategoryAssignments.HasValue)
			{
				writer.WriteBoolean("CategoryAssignments", CategoryAssignments.Value);
			}

			if (InventorySettings.HasValue)
			{
				writer.WriteBoolean("InventorySettings", InventorySettings.Value);
			}

			if (InventoryLevel.HasValue)
			{
				writer.WriteBoolean("InventoryLevel", InventoryLevel.Value);
			}

			if (Images.HasValue)
			{
				writer.WriteBoolean("Images", Images.Value);
			}

			if (RelatedProducts.HasValue)
			{
				writer.WriteBoolean("RelatedProducts", RelatedProducts.Value);
			}

			if (Upsale.HasValue)
			{
				writer.WriteBoolean("Upsale", Upsale.Value);
			}

			if (AvailabilityGroupAssignments.HasValue)
			{
				writer.WriteBoolean("AvailabilityGroupAssignments", AvailabilityGroupAssignments.Value);
			}

			if (PriceGroupAssignments.HasValue)
			{
				writer.WriteBoolean("PriceGroupAssignments", PriceGroupAssignments.Value);
			}

			if (DigitalDownloadSettings.HasValue)
			{
				writer.WriteBoolean("DigitalDownloadSettings", DigitalDownloadSettings.Value);
			}

			if (GiftCertificateSales.HasValue)
			{
				writer.WriteBoolean("GiftCertificateSales", GiftCertificateSales.Value);
			}

			if (SubscriptionSettings.HasValue)
			{
				writer.WriteBoolean("SubscriptionSettings", SubscriptionSettings.Value);
			}

			if (PaymentRules.HasValue)
			{
				writer.WriteBoolean("PaymentRules", PaymentRules.Value);
			}

			if (ShippingRules.HasValue)
			{
				writer.WriteBoolean("ShippingRules", ShippingRules.Value);
			}

			if (ProductKits.HasValue)
			{
				writer.WriteBoolean("ProductKits", ProductKits.Value);
			}

			if (ProductVariants.HasValue)
			{
				writer.WriteBoolean("ProductVariants", ProductVariants.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CopyProductRulesInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CopyProductRulesInsertResponse</returns>
		/// </summary>
		public new CopyProductRulesInsertResponse Send()
		{
			return Client.SendRequestAsync<CopyProductRulesInsertRequest, CopyProductRulesInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CopyProductRulesInsertResponse></returns>
		/// </summary>
		public new async Task<CopyProductRulesInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CopyProductRulesInsertRequest, CopyProductRulesInsertResponse>(this);
		}
	}
}
