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
	/// Handles API Request SubscriptionShippingMethodList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionshippingmethodlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class SubscriptionShippingMethodListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Product_ID.
		[JsonPropertyName("Product_ID")]
		public int ProductId { get; set; }

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

		/// Request field CustomerAddress_ID.
		[JsonPropertyName("CustomerAddress_ID")]
		public int? CustomerAddressId { get; set; }

		/// Request field Address_ID.
		[JsonPropertyName("Address_ID")]
		public int? AddressId { get; set; }

		/// Request field PaymentCard_ID.
		[JsonPropertyName("PaymentCard_ID")]
		public int? PaymentCardId { get; set; }

		/// Request field CustomerPaymentCard_ID.
		[JsonPropertyName("CustomerPaymentCard_ID")]
		public int? CustomerPaymentCardId { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Attributes.
		[JsonPropertyName("Attributes")]
		public List<SubscriptionAttribute> Attributes { get; set; } = new List<SubscriptionAttribute>();

		/// Request field Quantity.
		[JsonPropertyName("Quantity")]
		public int Quantity { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"method",
			"price"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"method",
			"price"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="product">Product</param>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest(BaseClient client = null, Product product = null) :
			base(client)
		{
			Function = "SubscriptionShippingMethodList_Load_Query";
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
		public int GetProductId()
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
		/// Getter for CustomerAddress_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerAddressId()
		{
			return CustomerAddressId;
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
		/// Getter for PaymentCard_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPaymentCardId()
		{
			return PaymentCardId;
		}

		/// <summary>
		/// Getter for CustomerPaymentCard_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerPaymentCardId()
		{
			return CustomerPaymentCardId;
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
		/// Getter for Attributes.
		/// <returns>List<SubscriptionAttribute></returns>
		/// </summary>
		public List<SubscriptionAttribute> GetAttributes()
		{
			return Attributes;
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
		/// Setter for Product_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetProductId(int value)
		{
			ProductId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Product.
		/// <param name="value">String</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetEditProduct(String value)
		{
			EditProduct = value;
			return this;
		}

		/// <summary>
		/// Setter for Product_Code.
		/// <param name="value">String</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetProductCode(String value)
		{
			ProductCode = value;
			return this;
		}

		/// <summary>
		/// Setter for ProductSubscriptionTerm_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetProductSubscriptionTermId(int? value)
		{
			ProductSubscriptionTermId = value;
			return this;
		}

		/// <summary>
		/// Setter for ProductSubscriptionTerm_Description.
		/// <param name="value">String</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetProductSubscriptionTermDescription(String value)
		{
			ProductSubscriptionTermDescription = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerAddress_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetCustomerAddressId(int? value)
		{
			CustomerAddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for Address_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetAddressId(int? value)
		{
			AddressId = value;
			return this;
		}

		/// <summary>
		/// Setter for PaymentCard_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetPaymentCardId(int? value)
		{
			PaymentCardId = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerPaymentCard_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetCustomerPaymentCardId(int? value)
		{
			CustomerPaymentCardId = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Quantity.
		/// <param name="value">int</param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest SetQuantity(int value)
		{
			Quantity = value;
			return this;
		}

		/// <summary>
		/// Add a SubscriptionAttribute.
		/// - subscriptionAttribute: SubscriptionAttribute
		/// - Returns: Self
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest AddSubscriptionAttribute(SubscriptionAttribute subscriptionAttribute)
		{
			Attributes.Add(subscriptionAttribute);
			return this;
		}

		/// <summary>
		/// Add an array of SubscriptionAttribute.
		/// <param name="attributes">List<SubscriptionAttribute></param>
		/// <returns>SubscriptionShippingMethodListLoadQueryRequest</returns>
		/// </summary>
		public SubscriptionShippingMethodListLoadQueryRequest AddAttributes(List<SubscriptionAttribute> attributes)
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

			if (ProductId > 0)
			{
				writer.WriteNumber("Product_ID", ProductId);
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

			if (CustomerAddressId.HasValue)
			{
				writer.WriteNumber("CustomerAddress_ID", CustomerAddressId.Value);
			}
			else if (AddressId.HasValue)
			{
				writer.WriteNumber("Address_ID", AddressId.Value);
			}

			if (PaymentCardId.HasValue)
			{
				writer.WriteNumber("PaymentCard_ID", PaymentCardId.Value);
			}
			else if (CustomerPaymentCardId.HasValue)
			{
				writer.WriteNumber("CustomerPaymentCard_ID", CustomerPaymentCardId.Value);
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

			if (Attributes.Count > 0)
			{
				writer.WritePropertyName("Attributes");
				JsonSerializer.Serialize(writer, this.Attributes, options);
			}

			writer.WriteNumber("Quantity", Quantity);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SubscriptionShippingMethodListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>SubscriptionShippingMethodListLoadQueryResponse</returns>
		/// </summary>
		public new SubscriptionShippingMethodListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<SubscriptionShippingMethodListLoadQueryRequest, SubscriptionShippingMethodListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<SubscriptionShippingMethodListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<SubscriptionShippingMethodListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<SubscriptionShippingMethodListLoadQueryRequest, SubscriptionShippingMethodListLoadQueryResponse>(this);
		}
	}
}
