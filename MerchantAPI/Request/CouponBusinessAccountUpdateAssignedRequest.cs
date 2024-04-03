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
	/// Handles API Request CouponBusinessAccount_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/couponbusinessaccount_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponBusinessAccountUpdateAssignedRequest : Request
	{
		/// Request field Coupon_ID.
		[JsonPropertyName("Coupon_ID")]
		public int? CouponId { get; set; }

		/// Request field Edit_Coupon.
		[JsonPropertyName("Edit_Coupon")]
		public String EditCoupon { get; set; }

		/// Request field Coupon_Code.
		[JsonPropertyName("Coupon_Code")]
		public String CouponCode { get; set; }

		/// Request field BusinessAccount_ID.
		[JsonPropertyName("BusinessAccount_ID")]
		public int? BusinessAccountId { get; set; }

		/// Request field Edit_BusinessAccount.
		[JsonPropertyName("Edit_BusinessAccount")]
		public String EditBusinessAccount { get; set; }

		/// Request field BusinessAccount_Title.
		[JsonPropertyName("BusinessAccount_Title")]
		public String BusinessAccountTitle { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="coupon">Coupon</param>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest(BaseClient client = null, Coupon coupon = null) :
			base(client)
		{
			Function = "CouponBusinessAccount_Update_Assigned";
			if (coupon != null) {
				if (coupon.Id > 0)
				{
					CouponId = coupon.Id;
				}
				else if (coupon.Code.Length > 0)
				{
					EditCoupon = coupon.Code;
				}
			}
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
		/// Getter for BusinessAccount_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBusinessAccountId()
		{
			return BusinessAccountId;
		}

		/// <summary>
		/// Getter for Edit_BusinessAccount.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditBusinessAccount()
		{
			return EditBusinessAccount;
		}

		/// <summary>
		/// Getter for BusinessAccount_Title.
		/// <returns>String</returns>
		/// </summary>
		public String GetBusinessAccountTitle()
		{
			return BusinessAccountTitle;
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
		/// Setter for Coupon_ID.
		/// <param name="value">int</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetCouponId(int? value)
		{
			CouponId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Coupon.
		/// <param name="value">String</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetEditCoupon(String value)
		{
			EditCoupon = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_Code.
		/// <param name="value">String</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetCouponCode(String value)
		{
			CouponCode = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_ID.
		/// <param name="value">int</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetBusinessAccountId(int? value)
		{
			BusinessAccountId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_BusinessAccount.
		/// <param name="value">String</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetEditBusinessAccount(String value)
		{
			EditBusinessAccount = value;
			return this;
		}

		/// <summary>
		/// Setter for BusinessAccount_Title.
		/// <param name="value">String</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetBusinessAccountTitle(String value)
		{
			BusinessAccountTitle = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CouponBusinessAccountUpdateAssignedRequest</returns>
		/// </summary>
		public CouponBusinessAccountUpdateAssignedRequest SetAssigned(bool? value)
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

			if (BusinessAccountId.HasValue)
			{
				writer.WriteNumber("BusinessAccount_ID", BusinessAccountId.Value);
			}
			else if (EditBusinessAccount != null && EditBusinessAccount.Length > 0)
			{
				writer.WriteString("Edit_BusinessAccount", EditBusinessAccount);
			}
			else if (BusinessAccountTitle != null && BusinessAccountTitle.Length > 0)
			{
				writer.WriteString("BusinessAccount_Title", BusinessAccountTitle);
			}

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
			return JsonSerializer.Deserialize<CouponBusinessAccountUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponBusinessAccountUpdateAssignedResponse</returns>
		/// </summary>
		public new CouponBusinessAccountUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<CouponBusinessAccountUpdateAssignedRequest, CouponBusinessAccountUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponBusinessAccountUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<CouponBusinessAccountUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponBusinessAccountUpdateAssignedRequest, CouponBusinessAccountUpdateAssignedResponse>(this);
		}
	}
}
