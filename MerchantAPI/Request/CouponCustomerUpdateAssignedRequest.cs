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
	/// Handles API Request CouponCustomer_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/couponcustomer_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponCustomerUpdateAssignedRequest : Request
	{
		/// Request field Customer_ID.
		[JsonPropertyName("Customer_ID")]
		public int? CustomerId { get; set; }

		/// Request field Edit_Customer.
		[JsonPropertyName("Edit_Customer")]
		public String EditCustomer { get; set; }

		/// Request field Customer_Login.
		[JsonPropertyName("Customer_Login")]
		public String CustomerLogin { get; set; }

		/// Request field Coupon_ID.
		[JsonPropertyName("Coupon_ID")]
		public int? CouponId { get; set; }

		/// Request field Edit_Coupon.
		[JsonPropertyName("Edit_Coupon")]
		public String EditCoupon { get; set; }

		/// Request field Coupon_Code.
		[JsonPropertyName("Coupon_Code")]
		public String CouponCode { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="coupon">Coupon</param>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest(BaseClient client = null, Coupon coupon = null) :
			base(client)
		{
			Function = "CouponCustomer_Update_Assigned";
			if (coupon != null) {
				if (coupon.Id > 0)
				{
					CouponId = coupon.Id;
				}

				CouponCode = coupon.Code;
			}
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
		/// Getter for Coupon_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetCouponId()
		{
			return CouponId;
		}

		/// <summary>
		/// Getter for Edit_Coupon.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditCoupon()
		{
			return EditCoupon;
		}

		/// <summary>
		/// Getter for Coupon_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCouponCode()
		{
			return CouponCode;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for Customer_ID.
		/// <param name="value">int</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetCustomerId(int? value)
		{
			CustomerId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Customer.
		/// <param name="value">String</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetEditCustomer(String value)
		{
			EditCustomer = value;
			return this;
		}

		/// <summary>
		/// Setter for Customer_Login.
		/// <param name="value">String</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetCustomerLogin(String value)
		{
			CustomerLogin = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_ID.
		/// <param name="value">int</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetCouponId(int? value)
		{
			CouponId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Coupon.
		/// <param name="value">String</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetEditCoupon(String value)
		{
			EditCoupon = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_Code.
		/// <param name="value">String</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetCouponCode(String value)
		{
			CouponCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CouponCustomerUpdateAssignedRequest</returns>
		/// </summary>
		public CouponCustomerUpdateAssignedRequest SetAssigned(bool? value)
		{
			Assigned = value;
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

			if (CouponId.HasValue)
			{
				writer.WriteNumber("Coupon_ID", CouponId.Value);
			}
			else if (EditCoupon != null && EditCoupon.Length > 0)
			{
				writer.WriteString("Edit_Coupon", EditCoupon);
			}
			else if (CouponCode != null && CouponCode.Length > 0)
			{
				writer.WriteString("Coupon_Code", CouponCode);
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

			writer.WriteString("Customer_Login", CustomerLogin);

			writer.WriteString("Coupon_Code", CouponCode);

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CouponCustomerUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponCustomerUpdateAssignedResponse</returns>
		/// </summary>
		public new CouponCustomerUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<CouponCustomerUpdateAssignedRequest, CouponCustomerUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponCustomerUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<CouponCustomerUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponCustomerUpdateAssignedRequest, CouponCustomerUpdateAssignedResponse>(this);
		}
	}
}
