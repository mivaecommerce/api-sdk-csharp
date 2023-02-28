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
	/// Handles API Request InventoryProductSettings_Update.
	/// <see>https://docs.miva.com/json-api/functions/inventoryproductsettings_update</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class InventoryProductSettingsUpdateRequest : Request
	{
		/// Enumeration InventoryChoice
		public enum InventoryChoice
		{
			Default,
			Yes,
			No,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String InventoryChoiceToString(InventoryChoice value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static InventoryChoice? InventoryChoiceFromString(String value)
		{
			switch(value)
			{
				case "Default": return InventoryChoice.Default;
				case "Yes": return InventoryChoice.Yes;
				case "No": return InventoryChoice.No;
				default: return null;
			}
		}

		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field TrackLowStockLevel.
		[JsonPropertyName("TrackLowStockLevel")]
		public String TrackLowStockLevel { get; set; }

		/// Request field TrackOutOfStockLevel.
		[JsonPropertyName("TrackOutOfStockLevel")]
		public String TrackOutOfStockLevel { get; set; }

		/// Request field HideOutOfStockProducts.
		[JsonPropertyName("HideOutOfStockProducts")]
		public String HideOutOfStockProducts { get; set; }

		/// Request field LowStockLevel.
		[JsonPropertyName("LowStockLevel")]
		public int? LowStockLevel { get; set; }

		/// Request field OutOfStockLevel.
		[JsonPropertyName("OutOfStockLevel")]
		public int? OutOfStockLevel { get; set; }

		/// Request field TrackProduct.
		[JsonPropertyName("TrackProduct")]
		public bool? TrackProduct { get; set; }

		/// Request field InStockMessageShort.
		[JsonPropertyName("InStockMessageShort")]
		public String InStockMessageShort { get; set; }

		/// Request field InStockMessageLong.
		[JsonPropertyName("InStockMessageLong")]
		public String InStockMessageLong { get; set; }

		/// Request field LowStockMessageShort.
		[JsonPropertyName("LowStockMessageShort")]
		public String LowStockMessageShort { get; set; }

		/// Request field LowStockMessageLong.
		[JsonPropertyName("LowStockMessageLong")]
		public String LowStockMessageLong { get; set; }

		/// Request field OutOfStockMessageShort.
		[JsonPropertyName("OutOfStockMessageShort")]
		public String OutOfStockMessageShort { get; set; }

		/// Request field OutOfStockMessageLong.
		[JsonPropertyName("OutOfStockMessageLong")]
		public String OutOfStockMessageLong { get; set; }

		/// Request field LimitedStockMessage.
		[JsonPropertyName("LimitedStockMessage")]
		public String LimitedStockMessage { get; set; }

		/// Request field AdjustStockBy.
		[JsonPropertyName("AdjustStockBy")]
		public int? AdjustStockBy { get; set; }

		/// Request field CurrentStock.
		[JsonPropertyName("CurrentStock")]
		public int? CurrentStock { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public InventoryProductSettingsUpdateRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "InventoryProductSettings_Update";
			if (product != null) {
				if (product.Id > 0)
				{
					ProductId = product.Id;
				}
				else if (product.Code.Length > 0)
				{
					EditProduct = product.Code;
				}
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
		/// Getter for TrackLowStockLevel.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackLowStockLevel()
		{
			return TrackLowStockLevel;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>InventoryChoice?</returns>
		/// </summary>
		public InventoryChoice? GetTrackLowStockLevelConst()
		{
			return InventoryChoiceFromString(TrackLowStockLevel);
		}

		/// <summary>
		/// Getter for TrackOutOfStockLevel.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackOutOfStockLevel()
		{
			return TrackOutOfStockLevel;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>InventoryChoice?</returns>
		/// </summary>
		public InventoryChoice? GetTrackOutOfStockLevelConst()
		{
			return InventoryChoiceFromString(TrackOutOfStockLevel);
		}

		/// <summary>
		/// Getter for HideOutOfStockProducts.
		/// <returns>String</returns>
		/// </summary>
		public String GetHideOutOfStockProducts()
		{
			return HideOutOfStockProducts;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>InventoryChoice?</returns>
		/// </summary>
		public InventoryChoice? GetHideOutOfStockProductsConst()
		{
			return InventoryChoiceFromString(HideOutOfStockProducts);
		}

		/// <summary>
		/// Getter for LowStockLevel.
		/// <returns>int</returns>
		/// </summary>
		public int? GetLowStockLevel()
		{
			return LowStockLevel;
		}

		/// <summary>
		/// Getter for OutOfStockLevel.
		/// <returns>int</returns>
		/// </summary>
		public int? GetOutOfStockLevel()
		{
			return OutOfStockLevel;
		}

		/// <summary>
		/// Getter for TrackProduct.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTrackProduct()
		{
			return TrackProduct;
		}

		/// <summary>
		/// Getter for InStockMessageShort.
		/// <returns>String</returns>
		/// </summary>
		public String GetInStockMessageShort()
		{
			return InStockMessageShort;
		}

		/// <summary>
		/// Getter for InStockMessageLong.
		/// <returns>String</returns>
		/// </summary>
		public String GetInStockMessageLong()
		{
			return InStockMessageLong;
		}

		/// <summary>
		/// Getter for LowStockMessageShort.
		/// <returns>String</returns>
		/// </summary>
		public String GetLowStockMessageShort()
		{
			return LowStockMessageShort;
		}

		/// <summary>
		/// Getter for LowStockMessageLong.
		/// <returns>String</returns>
		/// </summary>
		public String GetLowStockMessageLong()
		{
			return LowStockMessageLong;
		}

		/// <summary>
		/// Getter for OutOfStockMessageShort.
		/// <returns>String</returns>
		/// </summary>
		public String GetOutOfStockMessageShort()
		{
			return OutOfStockMessageShort;
		}

		/// <summary>
		/// Getter for OutOfStockMessageLong.
		/// <returns>String</returns>
		/// </summary>
		public String GetOutOfStockMessageLong()
		{
			return OutOfStockMessageLong;
		}

		/// <summary>
		/// Getter for LimitedStockMessage.
		/// <returns>String</returns>
		/// </summary>
		public String GetLimitedStockMessage()
		{
			return LimitedStockMessage;
		}

		/// <summary>
		/// Getter for AdjustStockBy.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAdjustStockBy()
		{
			return AdjustStockBy;
		}

		/// <summary>
		/// Getter for CurrentStock.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCurrentStock()
		{
			return CurrentStock;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for TrackLowStockLevel.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetTrackLowStockLevel(String value)
		{
			TrackLowStockLevel = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">InventoryChoice</param>
		/// <returns></returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetTrackLowStockLevel(InventoryChoice value)
		{
			TrackLowStockLevel = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for TrackOutOfStockLevel.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetTrackOutOfStockLevel(String value)
		{
			TrackOutOfStockLevel = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">InventoryChoice</param>
		/// <returns></returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetTrackOutOfStockLevel(InventoryChoice value)
		{
			TrackOutOfStockLevel = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for HideOutOfStockProducts.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetHideOutOfStockProducts(String value)
		{
			HideOutOfStockProducts = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">InventoryChoice</param>
		/// <returns></returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetHideOutOfStockProducts(InventoryChoice value)
		{
			HideOutOfStockProducts = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for LowStockLevel.
		/// <param name="value">int</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetLowStockLevel(int? value)
		{
			LowStockLevel = value;
			return this;
		}

		/// <summary>
		/// Setter for OutOfStockLevel.
		/// <param name="value">int</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetOutOfStockLevel(int? value)
		{
			OutOfStockLevel = value;
			return this;
		}

		/// <summary>
		/// Setter for TrackProduct.
		/// <param name="value">bool</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetTrackProduct(bool? value)
		{
			TrackProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for InStockMessageShort.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetInStockMessageShort(String value)
		{
			InStockMessageShort = value;
			return this;
		}

		/// <summary>
		/// Setter for InStockMessageLong.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetInStockMessageLong(String value)
		{
			InStockMessageLong = value;
			return this;
		}

		/// <summary>
		/// Setter for LowStockMessageShort.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetLowStockMessageShort(String value)
		{
			LowStockMessageShort = value;
			return this;
		}

		/// <summary>
		/// Setter for LowStockMessageLong.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetLowStockMessageLong(String value)
		{
			LowStockMessageLong = value;
			return this;
		}

		/// <summary>
		/// Setter for OutOfStockMessageShort.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetOutOfStockMessageShort(String value)
		{
			OutOfStockMessageShort = value;
			return this;
		}

		/// <summary>
		/// Setter for OutOfStockMessageLong.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetOutOfStockMessageLong(String value)
		{
			OutOfStockMessageLong = value;
			return this;
		}

		/// <summary>
		/// Setter for LimitedStockMessage.
		/// <param name="value">String</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetLimitedStockMessage(String value)
		{
			LimitedStockMessage = value;
			return this;
		}

		/// <summary>
		/// Setter for AdjustStockBy.
		/// <param name="value">int</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetAdjustStockBy(int? value)
		{
			AdjustStockBy = value;
			return this;
		}

		/// <summary>
		/// Setter for CurrentStock.
		/// <param name="value">int</param>
		/// <returns>InventoryProductSettingsUpdateRequest</returns>
		/// </summary>
		public InventoryProductSettingsUpdateRequest SetCurrentStock(int? value)
		{
			CurrentStock = value;
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
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}

			if (TrackLowStockLevel != null && TrackLowStockLevel.Length > 0)
			{
				writer.WriteString("TrackLowStockLevel", TrackLowStockLevel);
			}

			if (TrackOutOfStockLevel != null && TrackOutOfStockLevel.Length > 0)
			{
				writer.WriteString("TrackOutOfStockLevel", TrackOutOfStockLevel);
			}

			if (HideOutOfStockProducts != null && HideOutOfStockProducts.Length > 0)
			{
				writer.WriteString("HideOutOfStockProducts", HideOutOfStockProducts);
			}

			if (LowStockLevel.HasValue)
			{
				writer.WriteNumber("LowStockLevel", LowStockLevel.Value);
			}

			if (OutOfStockLevel.HasValue)
			{
				writer.WriteNumber("OutOfStockLevel", OutOfStockLevel.Value);
			}

			if (TrackProduct.HasValue)
			{
				writer.WriteBoolean("TrackProduct", TrackProduct.Value);
			}

			if (InStockMessageShort != null && InStockMessageShort.Length > 0)
			{
				writer.WriteString("InStockMessageShort", InStockMessageShort);
			}

			if (InStockMessageLong != null && InStockMessageLong.Length > 0)
			{
				writer.WriteString("InStockMessageLong", InStockMessageLong);
			}

			if (LowStockMessageShort != null && LowStockMessageShort.Length > 0)
			{
				writer.WriteString("LowStockMessageShort", LowStockMessageShort);
			}

			if (LowStockMessageLong != null && LowStockMessageLong.Length > 0)
			{
				writer.WriteString("LowStockMessageLong", LowStockMessageLong);
			}

			if (OutOfStockMessageShort != null && OutOfStockMessageShort.Length > 0)
			{
				writer.WriteString("OutOfStockMessageShort", OutOfStockMessageShort);
			}

			if (OutOfStockMessageLong != null && OutOfStockMessageLong.Length > 0)
			{
				writer.WriteString("OutOfStockMessageLong", OutOfStockMessageLong);
			}

			if (LimitedStockMessage != null && LimitedStockMessage.Length > 0)
			{
				writer.WriteString("LimitedStockMessage", LimitedStockMessage);
			}

			if (AdjustStockBy.HasValue)
			{
				writer.WriteNumber("AdjustStockBy", AdjustStockBy.Value);
			}

			if (CurrentStock.HasValue)
			{
				writer.WriteNumber("CurrentStock", CurrentStock.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<InventoryProductSettingsUpdateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>InventoryProductSettingsUpdateResponse</returns>
		/// </summary>
		public new InventoryProductSettingsUpdateResponse Send()
		{
			return Client.SendRequestAsync<InventoryProductSettingsUpdateRequest, InventoryProductSettingsUpdateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<InventoryProductSettingsUpdateResponse></returns>
		/// </summary>
		public new async Task<InventoryProductSettingsUpdateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<InventoryProductSettingsUpdateRequest, InventoryProductSettingsUpdateResponse>(this);
		}
	}

	/// Enum Extensions
	public static class InventoryProductSettingsUpdateRequestExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this InventoryProductSettingsUpdateRequest.InventoryChoice e)
	    {
			switch(e)
			{
				case InventoryProductSettingsUpdateRequest.InventoryChoice.Default: return "Default";
				case InventoryProductSettingsUpdateRequest.InventoryChoice.Yes: return "Yes";
				case InventoryProductSettingsUpdateRequest.InventoryChoice.No: return "No";
			}
			return "";
	    
		}
	}
}
