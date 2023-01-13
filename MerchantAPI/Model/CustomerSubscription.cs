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

namespace MerchantAPI
{
	[JsonConverter(typeof(CustomerSubscriptionConverter))]
	public class CustomerSubscription : Subscription
	{
		/// <value>Property Frequency - String</value>
		[JsonPropertyName("frequency")]
		public String Frequency { get; set; }

		/// <value>Property Term - int</value>
		[JsonPropertyName("term")]
		public int Term { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property N - int</value>
		[JsonPropertyName("n")]
		public int N { get; set; }

		/// <value>Property FixedDayOfWeek - int</value>
		[JsonPropertyName("fixed_dow")]
		public int FixedDayOfWeek { get; set; }

		/// <value>Property FixedDayOfMonth - int</value>
		[JsonPropertyName("fixed_dom")]
		public int FixedDayOfMonth { get; set; }

		/// <value>Property SubscriptionCount - int</value>
		[JsonPropertyName("sub_count")]
		public int SubscriptionCount { get; set; }

		/// <value>Property Method - String</value>
		[JsonPropertyName("method")]
		public String Method { get; set; }

		/// <value>Property ProductCode - String</value>
		[JsonPropertyName("product_code")]
		public String ProductCode { get; set; }

		/// <value>Property ProductName - String</value>
		[JsonPropertyName("product_name")]
		public String ProductName { get; set; }

		/// <value>Property ProductSku - String</value>
		[JsonPropertyName("product_sku")]
		public String ProductSku { get; set; }

		/// <value>Property ProductPrice - float</value>
		[JsonPropertyName("product_price")]
		public float ProductPrice { get; set; }

		/// <value>Property ProductFormattedPrice - String</value>
		[JsonPropertyName("product_formatted_price")]
		public String ProductFormattedPrice { get; set; }

		/// <value>Property ProductCost - float</value>
		[JsonPropertyName("product_cost")]
		public float ProductCost { get; set; }

		/// <value>Property ProductFormattedCost - String</value>
		[JsonPropertyName("product_formatted_cost")]
		public String ProductFormattedCost { get; set; }

		/// <value>Property ProductWeight - float</value>
		[JsonPropertyName("product_weight")]
		public float ProductWeight { get; set; }

		/// <value>Property ProductTaxable - bool</value>
		[JsonPropertyName("product_taxable")]
		public bool ProductTaxable { get; set; }

		/// <value>Property ProductThumbnail - String</value>
		[JsonPropertyName("product_thumbnail")]
		public String ProductThumbnail { get; set; }

		/// <value>Property ProductImage - String</value>
		[JsonPropertyName("product_image")]
		public String ProductImage { get; set; }

		/// <value>Property ProductActive - bool</value>
		[JsonPropertyName("product_active")]
		public bool ProductActive { get; set; }

		/// <value>Property ProductDateTimeCreated - int</value>
		[JsonPropertyName("product_dt_created")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime ProductDateTimeCreated { get; set; }

		/// <value>Property ProductDateTimeUpdated - int</value>
		[JsonPropertyName("product_dt_updated")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime ProductDateTimeUpdated { get; set; }

		/// <value>Property ProductPageTitle - String</value>
		[JsonPropertyName("product_page_title")]
		public String ProductPageTitle { get; set; }

		/// <value>Property ProductPageId - int</value>
		[JsonPropertyName("product_page_id")]
		public int ProductPageId { get; set; }

		/// <value>Property ProductPageCode - String</value>
		[JsonPropertyName("product_page_code")]
		public String ProductPageCode { get; set; }

		/// <value>Property ProductCanonicalCategoryId - int</value>
		[JsonPropertyName("product_cancat_id")]
		public int ProductCanonicalCategoryId { get; set; }

		/// <value>Property ProductCanonicalCategoryCode - String</value>
		[JsonPropertyName("product_cancat_code")]
		public String ProductCanonicalCategoryCode { get; set; }

		/// <value>Property ProductInventoryActive - bool</value>
		[JsonPropertyName("product_inventory_active")]
		public bool ProductInventoryActive { get; set; }

		/// <value>Property ProductInventory - int</value>
		[JsonPropertyName("product_inventory")]
		public int ProductInventory { get; set; }

		/// <value>Property ImageTypes - List<KeyValuePair<String, Int>></value>
		public List<KeyValuePair<String, Int32>> ImageTypes { get; set; } = new List<KeyValuePair<String, Int32>>();

		/// <value>Property PaymentCardLastFour - String</value>
		[JsonPropertyName("paymentcard_lastfour")]
		public String PaymentCardLastFour { get; set; }

		/// <value>Property PaymentCardType - String</value>
		[JsonPropertyName("paymentcard_type")]
		public String PaymentCardType { get; set; }

		/// <value>Property AddressDescription - String</value>
		[JsonPropertyName("address_descrip")]
		public String AddressDescription { get; set; }

		/// <value>Property AddressFirstName - String</value>
		[JsonPropertyName("address_fname")]
		public String AddressFirstName { get; set; }

		/// <value>Property AddressLastName - String</value>
		[JsonPropertyName("address_lname")]
		public String AddressLastName { get; set; }

		/// <value>Property AddressEmail - String</value>
		[JsonPropertyName("address_email")]
		public String AddressEmail { get; set; }

		/// <value>Property AddressCompany - String</value>
		[JsonPropertyName("address_comp")]
		public String AddressCompany { get; set; }

		/// <value>Property AddressPhone - String</value>
		[JsonPropertyName("address_phone")]
		public String AddressPhone { get; set; }

		/// <value>Property AddressFax - String</value>
		[JsonPropertyName("address_fax")]
		public String AddressFax { get; set; }

		/// <value>Property AddressAddress - String</value>
		[JsonPropertyName("address_addr")]
		public String AddressAddress { get; set; }

		/// <value>Property AddressAddress1 - String</value>
		[JsonPropertyName("address_addr1")]
		public String AddressAddress1 { get; set; }

		/// <value>Property AddressAddress2 - String</value>
		[JsonPropertyName("address_addr2")]
		public String AddressAddress2 { get; set; }

		/// <value>Property AddressCity - String</value>
		[JsonPropertyName("address_city")]
		public String AddressCity { get; set; }

		/// <value>Property AddressState - String</value>
		[JsonPropertyName("address_state")]
		public String AddressState { get; set; }

		/// <value>Property AddressZip - String</value>
		[JsonPropertyName("address_zip")]
		public String AddressZip { get; set; }

		/// <value>Property AddressCountry - String</value>
		[JsonPropertyName("address_cntry")]
		public String AddressCountry { get; set; }

		/// <value>Property AddressResidential - bool</value>
		[JsonPropertyName("address_resdntl")]
		public bool AddressResidential { get; set; }

		/// <value>Property CustomerLogin - String</value>
		[JsonPropertyName("customer_login")]
		public String CustomerLogin { get; set; }

		/// <value>Property CustomerPasswordEmail - String</value>
		[JsonPropertyName("customer_pw_email")]
		public String CustomerPasswordEmail { get; set; }

		/// <value>Property CustomerBusinessTitle - String</value>
		[JsonPropertyName("customer_business_title")]
		public String CustomerBusinessTitle { get; set; }

		/// <summary>
		/// Getter for frequency.
		/// <returns>String</returns>
		/// </summary>
		public String GetFrequency()
		{
			return Frequency;
		}

		/// <summary>
		/// Getter for term.
		/// <returns>int</returns>
		/// </summary>
		public int GetTerm()
		{
			return Term;
		}

		/// <summary>
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for n.
		/// <returns>int</returns>
		/// </summary>
		public int GetN()
		{
			return N;
		}

		/// <summary>
		/// Getter for fixed_dow.
		/// <returns>int</returns>
		/// </summary>
		public int GetFixedDayOfWeek()
		{
			return FixedDayOfWeek;
		}

		/// <summary>
		/// Getter for fixed_dom.
		/// <returns>int</returns>
		/// </summary>
		public int GetFixedDayOfMonth()
		{
			return FixedDayOfMonth;
		}

		/// <summary>
		/// Getter for sub_count.
		/// <returns>int</returns>
		/// </summary>
		public int GetSubscriptionCount()
		{
			return SubscriptionCount;
		}

		/// <summary>
		/// Getter for method.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethod()
		{
			return Method;
		}

		/// <summary>
		/// Getter for product_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCode()
		{
			return ProductCode;
		}

		/// <summary>
		/// Getter for product_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductName()
		{
			return ProductName;
		}

		/// <summary>
		/// Getter for product_sku.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductSku()
		{
			return ProductSku;
		}

		/// <summary>
		/// Getter for product_price.
		/// <returns>float</returns>
		/// </summary>
		public float GetProductPrice()
		{
			return ProductPrice;
		}

		/// <summary>
		/// Getter for product_formatted_price.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductFormattedPrice()
		{
			return ProductFormattedPrice;
		}

		/// <summary>
		/// Getter for product_cost.
		/// <returns>float</returns>
		/// </summary>
		public float GetProductCost()
		{
			return ProductCost;
		}

		/// <summary>
		/// Getter for product_formatted_cost.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductFormattedCost()
		{
			return ProductFormattedCost;
		}

		/// <summary>
		/// Getter for product_weight.
		/// <returns>float</returns>
		/// </summary>
		public float GetProductWeight()
		{
			return ProductWeight;
		}

		/// <summary>
		/// Getter for product_taxable.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetProductTaxable()
		{
			return ProductTaxable;
		}

		/// <summary>
		/// Getter for product_thumbnail.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductThumbnail()
		{
			return ProductThumbnail;
		}

		/// <summary>
		/// Getter for product_image.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductImage()
		{
			return ProductImage;
		}

		/// <summary>
		/// Getter for product_active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetProductActive()
		{
			return ProductActive;
		}

		/// <summary>
		/// Getter for product_dt_created.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetProductDateTimeCreated()
		{
			return ProductDateTimeCreated;
		}

		/// <summary>
		/// Getter for product_dt_updated.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetProductDateTimeUpdated()
		{
			return ProductDateTimeUpdated;
		}

		/// <summary>
		/// Getter for product_page_title.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductPageTitle()
		{
			return ProductPageTitle;
		}

		/// <summary>
		/// Getter for product_page_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductPageId()
		{
			return ProductPageId;
		}

		/// <summary>
		/// Getter for product_page_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductPageCode()
		{
			return ProductPageCode;
		}

		/// <summary>
		/// Getter for product_cancat_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductCanonicalCategoryId()
		{
			return ProductCanonicalCategoryId;
		}

		/// <summary>
		/// Getter for product_cancat_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetProductCanonicalCategoryCode()
		{
			return ProductCanonicalCategoryCode;
		}

		/// <summary>
		/// Getter for product_inventory_active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetProductInventoryActive()
		{
			return ProductInventoryActive;
		}

		/// <summary>
		/// Getter for product_inventory.
		/// <returns>int</returns>
		/// </summary>
		public int GetProductInventory()
		{
			return ProductInventory;
		}

		/// <summary>
		/// Getter for paymentcard_lastfour.
		/// <returns>String</returns>
		/// </summary>
		public String GetPaymentCardLastFour()
		{
			return PaymentCardLastFour;
		}

		/// <summary>
		/// Getter for paymentcard_type.
		/// <returns>String</returns>
		/// </summary>
		public String GetPaymentCardType()
		{
			return PaymentCardType;
		}

		/// <summary>
		/// Getter for address_descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressDescription()
		{
			return AddressDescription;
		}

		/// <summary>
		/// Getter for address_fname.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressFirstName()
		{
			return AddressFirstName;
		}

		/// <summary>
		/// Getter for address_lname.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressLastName()
		{
			return AddressLastName;
		}

		/// <summary>
		/// Getter for address_email.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressEmail()
		{
			return AddressEmail;
		}

		/// <summary>
		/// Getter for address_comp.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressCompany()
		{
			return AddressCompany;
		}

		/// <summary>
		/// Getter for address_phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressPhone()
		{
			return AddressPhone;
		}

		/// <summary>
		/// Getter for address_fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressFax()
		{
			return AddressFax;
		}

		/// <summary>
		/// Getter for address_addr.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressAddress()
		{
			return AddressAddress;
		}

		/// <summary>
		/// Getter for address_addr1.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressAddress1()
		{
			return AddressAddress1;
		}

		/// <summary>
		/// Getter for address_addr2.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressAddress2()
		{
			return AddressAddress2;
		}

		/// <summary>
		/// Getter for address_city.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressCity()
		{
			return AddressCity;
		}

		/// <summary>
		/// Getter for address_state.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressState()
		{
			return AddressState;
		}

		/// <summary>
		/// Getter for address_zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressZip()
		{
			return AddressZip;
		}

		/// <summary>
		/// Getter for address_cntry.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddressCountry()
		{
			return AddressCountry;
		}

		/// <summary>
		/// Getter for address_resdntl.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAddressResidential()
		{
			return AddressResidential;
		}

		/// <summary>
		/// Getter for customer_login.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerLogin()
		{
			return CustomerLogin;
		}

		/// <summary>
		/// Getter for customer_pw_email.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerPasswordEmail()
		{
			return CustomerPasswordEmail;
		}

		/// <summary>
		/// Getter for customer_business_title.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerBusinessTitle()
		{
			return CustomerBusinessTitle;
		}
	}

	/// <summary>
	/// Converter for model CustomerSubscription
	/// </summary>
	public class CustomerSubscriptionConverter : BaseJsonConverter<CustomerSubscription>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(CustomerSubscription) || typeToConvert.IsSubclassOf(typeof(CustomerSubscription));
		}

		public override CustomerSubscription Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			CustomerSubscription value = new CustomerSubscription();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while(reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return value;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "frequency", StringComparison.OrdinalIgnoreCase))
				{
					value.Frequency = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "term", StringComparison.OrdinalIgnoreCase))
				{
					value.Term = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "descrip", StringComparison.OrdinalIgnoreCase))
				{
					value.Description = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "n", StringComparison.OrdinalIgnoreCase))
				{
					value.N = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "fixed_dow", StringComparison.OrdinalIgnoreCase))
				{
					value.FixedDayOfWeek = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "fixed_dom", StringComparison.OrdinalIgnoreCase))
				{
					value.FixedDayOfMonth = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "sub_count", StringComparison.OrdinalIgnoreCase))
				{
					value.SubscriptionCount = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "method", StringComparison.OrdinalIgnoreCase))
				{
					value.Method = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_code", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_name", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductName = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_sku", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductSku = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_price", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductPrice = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "product_formatted_price", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductFormattedPrice = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_cost", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductCost = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "product_formatted_cost", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductFormattedCost = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_weight", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductWeight = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "product_taxable", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductTaxable = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "product_thumbnail", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductThumbnail = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_image", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductImage = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_active", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductActive = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "product_dt_created", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductDateTimeCreated = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "product_dt_updated", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductDateTimeUpdated = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "product_page_title", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductPageTitle = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_page_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductPageId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "product_page_code", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductPageCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_cancat_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductCanonicalCategoryId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "product_cancat_code", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductCanonicalCategoryCode = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "product_inventory_active", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductInventoryActive = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "product_inventory", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductInventory = ReadNextInteger(ref reader, options);
				}
				else if (property.StartsWith("imagetype:", StringComparison.OrdinalIgnoreCase))
				{
					KeyValuePair<String, Int32> entry = new KeyValuePair<String, Int32>(property.Substring(property.IndexOf(":")+1), ReadNextInteger(ref reader, options));
					value.ImageTypes.Add(entry);
				}
				else if (String.Equals(property, "paymentcard_lastfour", StringComparison.OrdinalIgnoreCase))
				{
					value.PaymentCardLastFour = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "paymentcard_type", StringComparison.OrdinalIgnoreCase))
				{
					value.PaymentCardType = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_descrip", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressDescription = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_fname", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressFirstName = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_lname", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressLastName = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_email", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressEmail = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_comp", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressCompany = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_phone", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressPhone = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_fax", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressFax = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_addr", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressAddress = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_addr1", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressAddress1 = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_addr2", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressAddress2 = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_city", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressCity = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_state", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressState = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_zip", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressZip = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_cntry", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressCountry = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "address_resdntl", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressResidential = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "customer_login", StringComparison.OrdinalIgnoreCase))
				{
					value.CustomerLogin = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "customer_pw_email", StringComparison.OrdinalIgnoreCase))
				{
					value.CustomerPasswordEmail = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "customer_business_title", StringComparison.OrdinalIgnoreCase))
				{
					value.CustomerBusinessTitle = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "id", StringComparison.OrdinalIgnoreCase))
				{
					value.Id = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "order_id", StringComparison.OrdinalIgnoreCase))
				{
					value.OrderId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "line_id", StringComparison.OrdinalIgnoreCase))
				{
					value.LineId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "cust_id", StringComparison.OrdinalIgnoreCase))
				{
					value.CustomerId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "custpc_id", StringComparison.OrdinalIgnoreCase))
				{
					value.CustomerPaymentCardId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "product_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ProductId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "subterm_id", StringComparison.OrdinalIgnoreCase))
				{
					value.SubscriptionTermId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "addr_id", StringComparison.OrdinalIgnoreCase))
				{
					value.AddressId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "ship_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ShipId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "ship_data", StringComparison.OrdinalIgnoreCase))
				{
					value.ShipData = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "quantity", StringComparison.OrdinalIgnoreCase))
				{
					value.Quantity = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "termrem", StringComparison.OrdinalIgnoreCase))
				{
					value.TermRemaining = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "termproc", StringComparison.OrdinalIgnoreCase))
				{
					value.TermProcessed = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "firstdate", StringComparison.OrdinalIgnoreCase))
				{
					value.FirstDate = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "lastdate", StringComparison.OrdinalIgnoreCase))
				{
					value.LastDate = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "nextdate", StringComparison.OrdinalIgnoreCase))
				{
					value.NextDate = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "status", StringComparison.OrdinalIgnoreCase))
				{
					value.Status = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "message", StringComparison.OrdinalIgnoreCase))
				{
					value.Message = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "cncldate", StringComparison.OrdinalIgnoreCase))
				{
					value.CancelDate = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "tax", StringComparison.OrdinalIgnoreCase))
				{
					value.Tax = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_tax", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedTax = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "shipping", StringComparison.OrdinalIgnoreCase))
				{
					value.Shipping = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_shipping", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedShipping = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "subtotal", StringComparison.OrdinalIgnoreCase))
				{
					value.Subtotal = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_subtotal", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedSubtotal = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "total", StringComparison.OrdinalIgnoreCase))
				{
					value.Total = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_total", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedTotal = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "authfails", StringComparison.OrdinalIgnoreCase))
				{
					value.AuthorizationFailureCount = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "lastafail", StringComparison.OrdinalIgnoreCase))
				{
					value.LastAuthorizationFailure = ReadNextTimestamp(ref reader, options);
				}
				else if (String.Equals(property, "options", StringComparison.OrdinalIgnoreCase))
				{
					if (!reader.Read() || reader.TokenType != JsonTokenType.StartArray)
					{
						throw new MerchantAPIException(String.Format("Expected start of array but encountered {0}", reader.TokenType));
					}

					value.Options = JsonSerializer.Deserialize<List<SubscriptionOption>>(ref reader, options);
				}
				else
				{
					reader.Skip();
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, CustomerSubscription value, JsonSerializerOptions options)
		{
			throw new MerchantAPIException("CustomerSubscriptionConverter only supports deserialization");
		}
	}
}
