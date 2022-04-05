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
	/// Handles API Request CustomerSubscriptionList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/customersubscriptionlist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CustomerSubscriptionListLoadQueryRequest : ListQueryRequest
	{
		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int CustomerId { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field CustomField_Values.
		[JsonPropertyName("CustomField_Values")]
		public CustomFieldValues CustomFieldValues { get; set; }

		/// The available search fields applicable to the request.
		override public String[] AvailableSearchFields { get; } =
		{
			"id",
			"order_id",
			"quantity",
			"termrem",
			"termproc",
			"firstdate",
			"lastdate",
			"nextdate",
			"status",
			"message",
			"cncldate",
			"tax",
			"shipping",
			"subtotal",
			"total",
			"authfails",
			"lastafail",
			"frequency",
			"term",
			"descrip",
			"n",
			"fixed_dow",
			"fixed_dom",
			"sub_count",
			"customer_login",
			"customer_pw_email",
			"customer_business_title",
			"product_code",
			"product_name",
			"product_sku",
			"product_price",
			"product_cost",
			"product_weight",
			"product_descrip",
			"product_taxable",
			"product_thumbnail",
			"product_image",
			"product_active",
			"product_page_title",
			"product_cancat_code",
			"product_page_code",
			"address_descrip",
			"address_fname",
			"address_lname",
			"address_email",
			"address_phone",
			"address_fax",
			"address_comp",
			"address_addr1",
			"address_addr2",
			"address_city",
			"address_state",
			"address_zip",
			"address_cntry",
			"product_inventory",
			"product_inventory_active",
			"product_inventory"
		};

		/// The available sort fields applicable to the request.
		override public String[] AvailableSortFields { get; } =
		{
			"id",
			"order_id",
			"custpc_id",
			"quantity",
			"termrem",
			"termproc",
			"firstdate",
			"lastdate",
			"nextdate",
			"status",
			"message",
			"cncldate",
			"tax",
			"shipping",
			"subtotal",
			"total",
			"authfails",
			"lastafail",
			"frequency",
			"term",
			"descrip",
			"n",
			"fixed_dow",
			"fixed_dom",
			"sub_count",
			"customer_login",
			"customer_pw_email",
			"customer_business_title",
			"product_code",
			"product_name",
			"product_sku",
			"product_cancat_code",
			"product_page_code",
			"product_price",
			"product_cost",
			"product_weight",
			"product_descrip",
			"product_taxable",
			"product_thumbnail",
			"product_image",
			"product_active",
			"product_page_title",
			"address_descrip",
			"address_fname",
			"address_lname",
			"address_email",
			"address_phone",
			"address_fax",
			"address_comp",
			"address_addr1",
			"address_addr2",
			"address_city",
			"address_state",
			"address_zip",
			"address_cntry",
			"product_inventory"
		};

		/// The available on demand columns applicable to the request.
		override public String[] AvailableOnDemandColumns { get; } =
		{
			"imagetypes",
			"imagetype_count",
			"product_descrip"
		};

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="customer">Customer</param>
		/// </summary>
		public CustomerSubscriptionListLoadQueryRequest(BaseClient client = null, Customer customer = null) :
			base(client)
		{
			Function = "CustomerSubscriptionList_Load_Query";
			CustomFieldValues = new CustomFieldValues();
			if (customer != null) {
				if (customer.Id > 0)
				{
					CustomerId = customer.Id;
				}
				else if (customer.Login.Length > 0)
				{
					EditCustomer = customer.Login;
				}

				CustomFieldValues = customer.CustomFieldValues;
			}
		}

		/// <summary>
		/// Getter for Customer_ID.
		/// <returns>int</returns>
		/// </summary>
		public int GetCustomerId()
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
		/// Getter for CustomField_Values.
		/// <returns>CustomFieldValues</returns>
		/// </summary>
		public CustomFieldValues GetCustomFieldValues()
		{
			return CustomFieldValues;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CustomerSubscriptionListLoadQueryRequest</returns>
		/// </summary>
		public CustomerSubscriptionListLoadQueryRequest SetCustomerId(int value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CustomerSubscriptionListLoadQueryRequest</returns>
		/// </summary>
		public CustomerSubscriptionListLoadQueryRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CustomerSubscriptionListLoadQueryRequest</returns>
		/// </summary>
		public CustomerSubscriptionListLoadQueryRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
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

			if (CustomerId > 0)
			{
				writer.WriteNumber("Customer_ID", CustomerId);
			}
			else if (EditCustomer != null && EditCustomer.Length > 0)
			{
				writer.WriteString("Edit_Customer", EditCustomer);
			}
			else if (CustomerLogin != null && CustomerLogin.Length > 0)
			{
				writer.WriteString("Customer_Login", CustomerLogin);
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
			return JsonSerializer.Deserialize<CustomerSubscriptionListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CustomerSubscriptionListLoadQueryResponse</returns>
		/// </summary>
		public new CustomerSubscriptionListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CustomerSubscriptionListLoadQueryRequest, CustomerSubscriptionListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CustomerSubscriptionListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CustomerSubscriptionListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CustomerSubscriptionListLoadQueryRequest, CustomerSubscriptionListLoadQueryResponse>(this);
		}
	}
}
