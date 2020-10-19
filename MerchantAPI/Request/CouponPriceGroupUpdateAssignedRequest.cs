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
	/// Handles API Request CouponPriceGroup_Update_Assigned.
	/// <see>https://docs.miva.com/json-api/functions/couponpricegroup_update_assigned</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponPriceGroupUpdateAssignedRequest : Request
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

		/// Request field PriceGroup_ID.
		[JsonPropertyName("PriceGroup_ID")]
		public int? PriceGroupId { get; set; }

		/// Request field PriceGroup_Name.
		[JsonPropertyName("PriceGroup_Name")]
		public String PriceGroupName { get; set; }

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool Assigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="coupon">Coupon</param>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest(BaseClient client = null, Coupon coupon = null) :
			base(client)
		{
			Function = "CouponPriceGroup_Update_Assigned";
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
		/// Getter for PriceGroup_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPriceGroupId()
		{
			return PriceGroupId;
		}

		/// <summary>
		/// Getter for PriceGroup_Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetPriceGroupName()
		{
			return PriceGroupName;
		}

		/// <summary>
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Setter for Coupon_ID.
		/// <param name="value">int</param>
		/// <returns>CouponPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest SetCouponId(int? value)
		{
			CouponId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Coupon.
		/// <param name="value">String</param>
		/// <returns>CouponPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest SetEditCoupon(String value)
		{
			EditCoupon = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_Code.
		/// <param name="value">String</param>
		/// <returns>CouponPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest SetCouponCode(String value)
		{
			CouponCode = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>CouponPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_Name.
		/// <param name="value">String</param>
		/// <returns>CouponPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest SetPriceGroupName(String value)
		{
			PriceGroupName = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CouponPriceGroupUpdateAssignedRequest</returns>
		/// </summary>
		public CouponPriceGroupUpdateAssignedRequest SetAssigned(bool value)
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

			if (PriceGroupId.HasValue)
			{
				writer.WriteNumber("PriceGroup_ID", PriceGroupId.Value);
			}
			else if (PriceGroupName != null && PriceGroupName.Length > 0)
			{
				writer.WriteString("PriceGroup_Name", PriceGroupName);
			}

			writer.WriteBoolean("Assigned", Assigned);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CouponPriceGroupUpdateAssignedResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponPriceGroupUpdateAssignedResponse</returns>
		/// </summary>
		public new CouponPriceGroupUpdateAssignedResponse Send()
		{
			return Client.SendRequestAsync<CouponPriceGroupUpdateAssignedRequest, CouponPriceGroupUpdateAssignedResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponPriceGroupUpdateAssignedResponse></returns>
		/// </summary>
		public new async Task<CouponPriceGroupUpdateAssignedResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponPriceGroupUpdateAssignedRequest, CouponPriceGroupUpdateAssignedResponse>(this);
		}
	}
}
