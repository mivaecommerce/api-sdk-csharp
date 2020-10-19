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
	/// Handles API Request Order_Create.
	/// <see>https://docs.miva.com/json-api/functions/order_create</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class OrderCreateRequest : Request
	{
		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field ShipFirstName.
		[JsonPropertyName("ShipFirstName")]
		public String ShipFirstName { get; set; }

		/// Request field ShipLastName.
		[JsonPropertyName("ShipLastName")]
		public String ShipLastName { get; set; }

		/// Request field ShipEmail.
		[JsonPropertyName("ShipEmail")]
		public String ShipEmail { get; set; }

		/// Request field ShipPhone.
		[JsonPropertyName("ShipPhone")]
		public String ShipPhone { get; set; }

		/// Request field ShipFax.
		[JsonPropertyName("ShipFax")]
		public String ShipFax { get; set; }

		/// Request field ShipCompany.
		[JsonPropertyName("ShipCompany")]
		public String ShipCompany { get; set; }

		/// Request field ShipAddress1.
		[JsonPropertyName("ShipAddress1")]
		public String ShipAddress1 { get; set; }

		/// Request field ShipAddress2.
		[JsonPropertyName("ShipAddress2")]
		public String ShipAddress2 { get; set; }

		/// Request field ShipCity.
		[JsonPropertyName("ShipCity")]
		public String ShipCity { get; set; }

		/// Request field ShipState.
		[JsonPropertyName("ShipState")]
		public String ShipState { get; set; }

		/// Request field ShipZip.
		[JsonPropertyName("ShipZip")]
		public String ShipZip { get; set; }

		/// Request field ShipCountry.
		[JsonPropertyName("ShipCountry")]
		public String ShipCountry { get; set; }

		/// Request field ShipResidential.
		[JsonPropertyName("ShipResidential")]
		public bool? ShipResidential { get; set; }

		/// Request field BillFirstName.
		[JsonPropertyName("BillFirstName")]
		public String BillFirstName { get; set; }

		/// Request field BillLastName.
		[JsonPropertyName("BillLastName")]
		public String BillLastName { get; set; }

		/// Request field BillEmail.
		[JsonPropertyName("BillEmail")]
		public String BillEmail { get; set; }

		/// Request field BillPhone.
		[JsonPropertyName("BillPhone")]
		public String BillPhone { get; set; }

		/// Request field BillFax.
		[JsonPropertyName("BillFax")]
		public String BillFax { get; set; }

		/// Request field BillCompany.
		[JsonPropertyName("BillCompany")]
		public String BillCompany { get; set; }

		/// Request field BillAddress1.
		[JsonPropertyName("BillAddress1")]
		public String BillAddress1 { get; set; }

		/// Request field BillAddress2.
		[JsonPropertyName("BillAddress2")]
		public String BillAddress2 { get; set; }

		/// Request field BillCity.
		[JsonPropertyName("BillCity")]
		public String BillCity { get; set; }

		/// Request field BillState.
		[JsonPropertyName("BillState")]
		public String BillState { get; set; }

		/// Request field BillZip.
		[JsonPropertyName("BillZip")]
		public String BillZip { get; set; }

		/// Request field BillCountry.
		[JsonPropertyName("BillCountry")]
		public String BillCountry { get; set; }

		/// Request field Items.
		[JsonPropertyName("Items")]
		public List<OrderItem> Items { get; set; } = new List<OrderItem>();

		/// Request field Products.
		[JsonPropertyName("Products")]
		public List<OrderProduct> Products { get; set; } = new List<OrderProduct>();

		/// Request field Charges.
		[JsonPropertyName("Charges")]
		public List<OrderCharge> Charges { get; set; } = new List<OrderCharge>();

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// Request field Shipping_Module_Code.
		[JsonPropertyName("Shipping_Module_Code")]
		public String ShippingModuleCode { get; set; }

		/// Request field Shipping_Module_Data.
		[JsonPropertyName("Shipping_Module_Data")]
		public String ShippingModuleData { get; set; }

		/// Request field CalculateCharges.
		[JsonPropertyName("CalculateCharges")]
		public bool? CalculateCharges { get; set; }

		/// Request field TriggerFulfillmentModules.
		[JsonPropertyName("TriggerFulfillmentModules")]
		public bool? TriggerFulfillmentModules { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public OrderCreateRequest(BaseClient client = null, Customer customer = null) :
			base(client)
		{
			Function = "Order_Create";
			CustomFieldValues = new CustomFieldValues();
			if (customer != null) {
				if (customer.Id > 0)
				{
					CustomerId = customer.Id;
				}
				else if (customer.Login.Length > 0)
				{
					CustomerLogin = customer.Login;
				}
			}
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
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Getter for ShipFirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipFirstName()
		{
			return ShipFirstName;
		}

		/// <summary>
		/// Getter for ShipLastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipLastName()
		{
			return ShipLastName;
		}

		/// <summary>
		/// Getter for ShipEmail.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipEmail()
		{
			return ShipEmail;
		}

		/// <summary>
		/// Getter for ShipPhone.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipPhone()
		{
			return ShipPhone;
		}

		/// <summary>
		/// Getter for ShipFax.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipFax()
		{
			return ShipFax;
		}

		/// <summary>
		/// Getter for ShipCompany.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCompany()
		{
			return ShipCompany;
		}

		/// <summary>
		/// Getter for ShipAddress1.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipAddress1()
		{
			return ShipAddress1;
		}

		/// <summary>
		/// Getter for ShipAddress2.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipAddress2()
		{
			return ShipAddress2;
		}

		/// <summary>
		/// Getter for ShipCity.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCity()
		{
			return ShipCity;
		}

		/// <summary>
		/// Getter for ShipState.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipState()
		{
			return ShipState;
		}

		/// <summary>
		/// Getter for ShipZip.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipZip()
		{
			return ShipZip;
		}

		/// <summary>
		/// Getter for ShipCountry.
		/// <returns>String</returns>
		/// </summary>
		public String GetShipCountry()
		{
			return ShipCountry;
		}

		/// <summary>
		/// Getter for ShipResidential.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetShipResidential()
		{
			return ShipResidential;
		}

		/// <summary>
		/// Getter for BillFirstName.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillFirstName()
		{
			return BillFirstName;
		}

		/// <summary>
		/// Getter for BillLastName.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillLastName()
		{
			return BillLastName;
		}

		/// <summary>
		/// Getter for BillEmail.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillEmail()
		{
			return BillEmail;
		}

		/// <summary>
		/// Getter for BillPhone.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillPhone()
		{
			return BillPhone;
		}

		/// <summary>
		/// Getter for BillFax.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillFax()
		{
			return BillFax;
		}

		/// <summary>
		/// Getter for BillCompany.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCompany()
		{
			return BillCompany;
		}

		/// <summary>
		/// Getter for BillAddress1.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillAddress1()
		{
			return BillAddress1;
		}

		/// <summary>
		/// Getter for BillAddress2.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillAddress2()
		{
			return BillAddress2;
		}

		/// <summary>
		/// Getter for BillCity.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCity()
		{
			return BillCity;
		}

		/// <summary>
		/// Getter for BillState.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillState()
		{
			return BillState;
		}

		/// <summary>
		/// Getter for BillZip.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillZip()
		{
			return BillZip;
		}

		/// <summary>
		/// Getter for BillCountry.
		/// <returns>String</returns>
		/// </summary>
		public String GetBillCountry()
		{
			return BillCountry;
		}

		/// <summary>
		/// Getter for Items.
		/// <returns>List<OrderItem></returns>
		/// </summary>
		public List<OrderItem> GetItems()
		{
			return Items;
		}

		/// <summary>
		/// Getter for Products.
		/// <returns>List<OrderProduct></returns>
		/// </summary>
		public List<OrderProduct> GetProducts()
		{
			return Products;
		}

		/// <summary>
		/// Getter for Charges.
		/// <returns>List<OrderCharge></returns>
		/// </summary>
		public List<OrderCharge> GetCharges()
		{
			return Charges;
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
		/// Getter for Shipping_Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetShippingModuleCode()
		{
			return ShippingModuleCode;
		}

		/// <summary>
		/// Getter for Shipping_Module_Data.
		/// <returns>String</returns>
		/// </summary>
		public String GetShippingModuleData()
		{
			return ShippingModuleData;
		}

		/// <summary>
		/// Getter for CalculateCharges.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetCalculateCharges()
		{
			return CalculateCharges;
		}

		/// <summary>
		/// Getter for TriggerFulfillmentModules.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTriggerFulfillmentModules()
		{
			return TriggerFulfillmentModules;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipFirstName.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipFirstName(String value)
		{
			ShipFirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipLastName.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipLastName(String value)
		{
			ShipLastName = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipEmail.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipEmail(String value)
		{
			ShipEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipPhone.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipPhone(String value)
		{
			ShipPhone = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipFax.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipFax(String value)
		{
			ShipFax = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipCompany.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipCompany(String value)
		{
			ShipCompany = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipAddress1.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipAddress1(String value)
		{
			ShipAddress1 = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipAddress2.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipAddress2(String value)
		{
			ShipAddress2 = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipCity.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipCity(String value)
		{
			ShipCity = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipState.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipState(String value)
		{
			ShipState = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipZip.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipZip(String value)
		{
			ShipZip = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipCountry.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipCountry(String value)
		{
			ShipCountry = value;
			return this;
		}

		/// <summary>
		/// Setter for ShipResidential.
		/// <param name="value">bool</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShipResidential(bool? value)
		{
			ShipResidential = value;
			return this;
		}

		/// <summary>
		/// Setter for BillFirstName.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillFirstName(String value)
		{
			BillFirstName = value;
			return this;
		}

		/// <summary>
		/// Setter for BillLastName.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillLastName(String value)
		{
			BillLastName = value;
			return this;
		}

		/// <summary>
		/// Setter for BillEmail.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillEmail(String value)
		{
			BillEmail = value;
			return this;
		}

		/// <summary>
		/// Setter for BillPhone.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillPhone(String value)
		{
			BillPhone = value;
			return this;
		}

		/// <summary>
		/// Setter for BillFax.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillFax(String value)
		{
			BillFax = value;
			return this;
		}

		/// <summary>
		/// Setter for BillCompany.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillCompany(String value)
		{
			BillCompany = value;
			return this;
		}

		/// <summary>
		/// Setter for BillAddress1.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillAddress1(String value)
		{
			BillAddress1 = value;
			return this;
		}

		/// <summary>
		/// Setter for BillAddress2.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillAddress2(String value)
		{
			BillAddress2 = value;
			return this;
		}

		/// <summary>
		/// Setter for BillCity.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillCity(String value)
		{
			BillCity = value;
			return this;
		}

		/// <summary>
		/// Setter for BillState.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillState(String value)
		{
			BillState = value;
			return this;
		}

		/// <summary>
		/// Setter for BillZip.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillZip(String value)
		{
			BillZip = value;
			return this;
		}

		/// <summary>
		/// Setter for BillCountry.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetBillCountry(String value)
		{
			BillCountry = value;
			return this;
		}

		/// <summary>
		/// Setter for Shipping_Module_Code.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShippingModuleCode(String value)
		{
			ShippingModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Shipping_Module_Data.
		/// <param name="value">String</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetShippingModuleData(String value)
		{
			ShippingModuleData = value;
			return this;
		}

		/// <summary>
		/// Setter for CalculateCharges.
		/// <param name="value">bool</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetCalculateCharges(bool? value)
		{
			CalculateCharges = value;
			return this;
		}

		/// <summary>
		/// Setter for TriggerFulfillmentModules.
		/// <param name="value">bool</param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest SetTriggerFulfillmentModules(bool? value)
		{
			TriggerFulfillmentModules = value;
			return this;
		}

		/// <summary>
		/// Add a OrderItem.
		/// - item: OrderItem
		/// - Returns: Self
		/// </summary>
		public OrderCreateRequest AddItem(OrderItem item)
		{
			Items.Add(item);
			return this;
		}

		/// <summary>
		/// Add an array of OrderItem.
		/// <param name="items">List<OrderItem></param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest AddItems(List<OrderItem> items)
		{
			foreach(OrderItem e in items)
			{
				Items.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a OrderProduct.
		/// - product: OrderProduct
		/// - Returns: Self
		/// </summary>
		public OrderCreateRequest AddProduct(OrderProduct product)
		{
			Products.Add(product);
			return this;
		}

		/// <summary>
		/// Add an array of OrderProduct.
		/// <param name="products">List<OrderProduct></param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest AddProducts(List<OrderProduct> products)
		{
			foreach(OrderProduct e in products)
			{
				Products.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Add a OrderCharge.
		/// - charge: OrderCharge
		/// - Returns: Self
		/// </summary>
		public OrderCreateRequest AddCharge(OrderCharge charge)
		{
			Charges.Add(charge);
			return this;
		}

		/// <summary>
		/// Add an array of OrderCharge.
		/// <param name="charges">List<OrderCharge></param>
		/// <returns>OrderCreateRequest</returns>
		/// </summary>
		public OrderCreateRequest AddCharges(List<OrderCharge> charges)
		{
			foreach(OrderCharge e in charges)
			{
				Charges.Add(e);
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

			if (CustomerId.HasValue)
			{
				writer.WriteNumber("Customer_ID", CustomerId.Value);
			}
			else if (CustomerLogin != null && CustomerLogin.Length > 0)
			{
				writer.WriteString("Customer_Login", CustomerLogin);
			}

			if (ShipFirstName != null && ShipFirstName.Length > 0)
			{
				writer.WriteString("ShipFirstName", ShipFirstName);
			}

			if (ShipLastName != null && ShipLastName.Length > 0)
			{
				writer.WriteString("ShipLastName", ShipLastName);
			}

			if (ShipEmail != null && ShipEmail.Length > 0)
			{
				writer.WriteString("ShipEmail", ShipEmail);
			}

			if (ShipPhone != null && ShipPhone.Length > 0)
			{
				writer.WriteString("ShipPhone", ShipPhone);
			}

			if (ShipFax != null && ShipFax.Length > 0)
			{
				writer.WriteString("ShipFax", ShipFax);
			}

			if (ShipCompany != null && ShipCompany.Length > 0)
			{
				writer.WriteString("ShipCompany", ShipCompany);
			}

			if (ShipAddress1 != null && ShipAddress1.Length > 0)
			{
				writer.WriteString("ShipAddress1", ShipAddress1);
			}

			if (ShipAddress2 != null && ShipAddress2.Length > 0)
			{
				writer.WriteString("ShipAddress2", ShipAddress2);
			}

			if (ShipCity != null && ShipCity.Length > 0)
			{
				writer.WriteString("ShipCity", ShipCity);
			}

			if (ShipState != null && ShipState.Length > 0)
			{
				writer.WriteString("ShipState", ShipState);
			}

			if (ShipZip != null && ShipZip.Length > 0)
			{
				writer.WriteString("ShipZip", ShipZip);
			}

			if (ShipCountry != null && ShipCountry.Length > 0)
			{
				writer.WriteString("ShipCountry", ShipCountry);
			}

			if (ShipResidential.HasValue)
			{
				writer.WriteBoolean("ShipResidential", ShipResidential.Value);
			}

			if (BillFirstName != null && BillFirstName.Length > 0)
			{
				writer.WriteString("BillFirstName", BillFirstName);
			}

			if (BillLastName != null && BillLastName.Length > 0)
			{
				writer.WriteString("BillLastName", BillLastName);
			}

			if (BillEmail != null && BillEmail.Length > 0)
			{
				writer.WriteString("BillEmail", BillEmail);
			}

			if (BillPhone != null && BillPhone.Length > 0)
			{
				writer.WriteString("BillPhone", BillPhone);
			}

			if (BillFax != null && BillFax.Length > 0)
			{
				writer.WriteString("BillFax", BillFax);
			}

			if (BillCompany != null && BillCompany.Length > 0)
			{
				writer.WriteString("BillCompany", BillCompany);
			}

			if (BillAddress1 != null && BillAddress1.Length > 0)
			{
				writer.WriteString("BillAddress1", BillAddress1);
			}

			if (BillAddress2 != null && BillAddress2.Length > 0)
			{
				writer.WriteString("BillAddress2", BillAddress2);
			}

			if (BillCity != null && BillCity.Length > 0)
			{
				writer.WriteString("BillCity", BillCity);
			}

			if (BillState != null && BillState.Length > 0)
			{
				writer.WriteString("BillState", BillState);
			}

			if (BillZip != null && BillZip.Length > 0)
			{
				writer.WriteString("BillZip", BillZip);
			}

			if (BillCountry != null && BillCountry.Length > 0)
			{
				writer.WriteString("BillCountry", BillCountry);
			}

			if (Items.Count > 0)
			{
				writer.WritePropertyName("Items");
				JsonSerializer.Serialize(writer, this.Items, options);
			}

			if (Products.Count > 0)
			{
				writer.WritePropertyName("Products");
				JsonSerializer.Serialize(writer, this.Products, options);
			}

			if (Charges.Count > 0)
			{
				writer.WritePropertyName("Charges");
				JsonSerializer.Serialize(writer, this.Charges, options);
			}

			if (CustomFieldValues != null)
			{
				writer.WritePropertyName("CustomField_Values");
				JsonSerializer.Serialize(writer, this.CustomFieldValues, options);
			}

			if (ShippingModuleCode != null && ShippingModuleCode.Length > 0)
			{
				writer.WriteString("Shipping_Module_Code", ShippingModuleCode);
			}

			if (ShippingModuleData != null && ShippingModuleData.Length > 0)
			{
				writer.WriteString("Shipping_Module_Data", ShippingModuleData);
			}

			if (CalculateCharges.HasValue)
			{
				writer.WriteBoolean("CalculateCharges", CalculateCharges.Value);
			}

			if (TriggerFulfillmentModules.HasValue)
			{
				writer.WriteBoolean("TriggerFulfillmentModules", TriggerFulfillmentModules.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<OrderCreateResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>OrderCreateResponse</returns>
		/// </summary>
		public new OrderCreateResponse Send()
		{
			return Client.SendRequestAsync<OrderCreateRequest, OrderCreateResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<OrderCreateResponse></returns>
		/// </summary>
		public new async Task<OrderCreateResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<OrderCreateRequest, OrderCreateResponse>(this);
		}
	}
}
