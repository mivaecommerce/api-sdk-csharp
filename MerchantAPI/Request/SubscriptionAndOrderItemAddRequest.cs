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
	/// Handles API Request SubscriptionAndOrderItem_Add.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionandorderitem_add</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class SubscriptionAndOrderItemAddRequest : Request
	{
		/// Request field Order_ID.
		[JsonPropertyName("Order_ID")]
		public int? OrderId { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Address_ID.
		[JsonPropertyName("Address_ID")]
		public int? AddressId { get; set; }

		/// Request field CustomerAddress_ID.
		[JsonPropertyName("CustomerAddress_ID")]
		public int? CustomerAddressId { get; set; }

		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int? ProductId { get; set; }

		/// Request field Edit_Product.
		[JsonPropertyName("Edit_Product")]
		public String EditProduct { get; set; }

		/// Request field Product_Code.
		[JsonPropertyName("Product_Code")]
		public String ProductCode { get; set; }

		/// Request field ProductSubscriptionTerm_ID.
		[JsonPropertyName("ProductSubscriptionTerm_ID")]
		public int? ProductSubscriptionTermId { get; set; }

		/// Request field ProductSubscriptionTerm_Description.
		[JsonPropertyName("ProductSubscriptionTerm_Description")]
		public String ProductSubscriptionTermDescription { get; set; }

		/// Request field Quantity.
		[JsonPropertyName("Quantity")]
		public int Quantity { get; set; }

		/// Request field NextDate.
		[JsonPropertyName("NextDate")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime NextDate { get; set; }

		/// Request field PaymentCard_ID.
		[JsonPropertyName("PaymentCard_ID")]
		public int? PaymentCardId { get; set; }

		/// Request field Ship_ID.
		[JsonPropertyName("Ship_ID")]
		public int? ShipId { get; set; }

		/// Request field Ship_Data.
		[JsonPropertyName("Ship_Data")]
		public String ShipData { get; set; }

		/// Request field Attributes.
		[JsonPropertyName("Attributes")]
		public List<SubscriptionAttribute> Attributes { get; set; } = new List<SubscriptionAttribute>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest(BaseClient client = null) :
			base(client)
		{
			Function = "SubscriptionAndOrderItem_Add";
		}

		/// <summary>
		/// Getter for Order_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Getter for Edit_Customer.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCustomer()
		{
			return EditCustomer;
		}

		/// <summary>
		/// Getter for Customer_Login.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerLogin()
		{
			return CustomerLogin;
		}

		/// <summary>
		/// Getter for Address_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetAddressId()
		{
			return AddressId;
		}

		/// <summary>
		/// Getter for CustomerAddress_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerAddressId()
		{
			return CustomerAddressId;
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
		/// Getter for Edit_Product.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditProduct()
		{
			return EditProduct;
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
		/// Getter for ProductSubscriptionTerm_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetProductSubscriptionTermId()
		{
			return ProductSubscriptionTermId;
		}

		/// <summary>
		/// Getter for ProductSubscriptionTerm_Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSubscriptionTermDescription()
		{
			return ProductSubscriptionTermDescription;
		}

		/// <summary>
		/// Getter for Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int GetQuantity()
		{
			return Quantity;
		}

		/// <summary>
		/// Getter for NextDate.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetNextDate()
		{
			return NextDate;
		}

		/// <summary>
		/// Getter for PaymentCard_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPaymentCardId()
		{
			return PaymentCardId;
		}

		/// <summary>
		/// Getter for Ship_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetShipId()
		{
			return ShipId;
		}

		/// <summary>
		/// Getter for Ship_Data.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipData()
		{
			return ShipData;
		}

		/// <summary>
		/// Getter for Attributes.
		/// <returns>List<SubscriptionAttribute></returns>
		/// </summary>
		public List<SubscriptionAttribute> GetAttributes()
		{
			return Attributes;
		}

		/// <summary>
		/// Setter for Order_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetOrderId(int? value)
		{
			OrderId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Address_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetAddressId(int? value)
		{
			AddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerAddress_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetCustomerAddressId(int? value)
		{
			CustomerAddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetProductId(int? value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for ProductSubscriptionTerm_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetProductSubscriptionTermId(int? value)
		{
			ProductSubscriptionTermId = value;
			return this;
		}

		/// <summary>
		/// Setter for ProductSubscriptionTerm_Description.
		/// <param name="value">String</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetProductSubscriptionTermDescription(String value)
		{
			ProductSubscriptionTermDescription = value;
			return this;
		}

		/// <summary>
		/// Setter for Quantity.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}

		/// <summary>
		/// Setter for NextDate.
		/// <param name="value">DateTime</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetNextDate(DateTime value)
		{
			NextDate = value;
			return this;
		}

		/// <summary>
		/// Setter for NextDate using a unix timestamp.
		/// <param name="value">long</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetNextDate(long value)
		{
			NextDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value));
			return this;
		}

		/// <summary>
		/// Setter for PaymentCard_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetPaymentCardId(int? value)
		{
			PaymentCardId = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetShipId(int? value)
		{
			ShipId = value;
			return this;
		}

		/// <summary>
		/// Setter for Ship_Data.
		/// <param name="value">String</param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest SetShipData(String value)
		{
			ShipData = value;
			return this;
		}

		/// <summary>
		/// Add a SubscriptionAttribute.
		/// - attribute: SubscriptionAttribute
		/// - Returns: Self
		/// </summary>
		public SubscriptionAndOrderItemAddRequest AddAttribute(SubscriptionAttribute attribute)
		{
			Attributes.Add(attribute);
			return this;
		}

		/// <summary>
		/// Add an array of SubscriptionAttribute.
		/// <param name="attributes">List<SubscriptionAttribute></param>
		/// <returns>SubscriptionAndOrderItemAddRequest</returns>
		/// </summary>
		public SubscriptionAndOrderItemAddRequest AddAttributes(List<SubscriptionAttribute> attributes)
		{
			foreach(SubscriptionAttribute e in attributes)
			{
				Attributes.Add(e);
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

			if (OrderId.HasValue)
			{
				writer.WriteNumber("Order_ID", OrderId.Value);
			}

			if (ProductId.HasValue)
			{
				writer.WriteNumber("Product_ID", ProductId.Value);
			}
			else if (EditProduct != null && EditProduct.Length > 0)
			{
				writer.WriteString("Edit_Product", EditProduct);
			}
			else if (ProductCode != null && ProductCode.Length > 0)
			{
				writer.WriteString("Product_Code", ProductCode);
			}

			if (ProductSubscriptionTermId.HasValue)
			{
				writer.WriteNumber("ProductSubscriptionTerm_ID", ProductSubscriptionTermId.Value);
			}
			else if (ProductSubscriptionTermDescription != null && ProductSubscriptionTermDescription.Length > 0)
			{
				writer.WriteString("ProductSubscriptionTerm_Description", ProductSubscriptionTermDescription);
			}

			if (CustomerId.HasValue)
			{
				writer.WriteNumber("Customer_ID", CustomerId.Value);
			}
			else if (EditCustomer != null && EditCustomer.Length > 0)
			{
				writer.WriteString("Edit_Customer", EditCustomer);
			}
			else if (CustomerLogin != null && CustomerLogin.Length > 0)
			{
				writer.WriteString("Customer_Login", CustomerLogin);
			}

			if (AddressId.HasValue)
			{
				writer.WriteNumber("Address_ID", AddressId.Value);
			}
			else if (CustomerAddressId.HasValue)
			{
				writer.WriteNumber("CustomerAddress_ID", CustomerAddressId.Value);
			}

			writer.WriteNumber("Quantity", Quantity);

			writer.WriteNumber("NextDate", new DateTimeOffset(NextDate).ToUnixTimeSeconds());

			if (PaymentCardId.HasValue)
			{
				writer.WriteNumber("PaymentCard_ID", PaymentCardId.Value);
			}

			if (ShipId.HasValue)
			{
				writer.WriteNumber("Ship_ID", ShipId.Value);
			}

			if (ShipData != null && ShipData.Length > 0)
			{
				writer.WriteString("Ship_Data", ShipData);
			}

			if (Attributes.Count > 0)
			{
				writer.WritePropertyName("Attributes");
				JsonSerializer.Serialize(writer, this.Attributes, options);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SubscriptionAndOrderItemAddResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>SubscriptionAndOrderItemAddResponse</returns>
		/// </summary>
		public new SubscriptionAndOrderItemAddResponse Send()
		{
			return Client.SendRequestAsync<SubscriptionAndOrderItemAddRequest, SubscriptionAndOrderItemAddResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<SubscriptionAndOrderItemAddResponse></returns>
		/// </summary>
		public new async Task<SubscriptionAndOrderItemAddResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<SubscriptionAndOrderItemAddRequest, SubscriptionAndOrderItemAddResponse>(this);
		}
	}
}
