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
	/// Handles API Request CouponPriceGroupList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/couponpricegrouplist_load_query</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponPriceGroupListLoadQueryRequest : PriceGroupListLoadQueryRequest
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

		/// Request field Assigned.
		[JsonPropertyName("Assigned")]
		public bool? Assigned { get; set; }

		/// Request field Unassigned.
		[JsonPropertyName("Unassigned")]
		public bool? Unassigned { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// <param name="coupon">Coupon</param>
		/// </summary>
		public CouponPriceGroupListLoadQueryRequest(Client client = null, Coupon coupon = null) :
			base(client)
		{
			Function = "CouponPriceGroupList_Load_Query";
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
		/// Getter for Assigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetAssigned()
		{
			return Assigned;
		}

		/// <summary>
		/// Getter for Unassigned.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetUnassigned()
		{
			return Unassigned;
		}

		/// <summary>
		/// Setter for Coupon_ID.
		/// <param name="value">int</param>
		/// <returns>CouponPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CouponPriceGroupListLoadQueryRequest SetCouponId(int? value)
		{
			CouponId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Coupon.
		/// <param name="value">String</param>
		/// <returns>CouponPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CouponPriceGroupListLoadQueryRequest SetEditCoupon(String value)
		{
			EditCoupon = value;
			return this;
		}

		/// <summary>
		/// Setter for Coupon_Code.
		/// <param name="value">String</param>
		/// <returns>CouponPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CouponPriceGroupListLoadQueryRequest SetCouponCode(String value)
		{
			CouponCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Assigned.
		/// <param name="value">bool</param>
		/// <returns>CouponPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CouponPriceGroupListLoadQueryRequest SetAssigned(bool? value)
		{
			Assigned = value;
			return this;
		}

		/// <summary>
		/// Setter for Unassigned.
		/// <param name="value">bool</param>
		/// <returns>CouponPriceGroupListLoadQueryRequest</returns>
		/// </summary>
		public CouponPriceGroupListLoadQueryRequest SetUnassigned(bool? value)
		{
			Unassigned = value;
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

			if (Assigned.HasValue)
			{
				writer.WriteBoolean("Assigned", Assigned.Value);
			}

			if (Unassigned.HasValue)
			{
				writer.WriteBoolean("Unassigned", Unassigned.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CouponPriceGroupListLoadQueryResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponPriceGroupListLoadQueryResponse</returns>
		/// </summary>
		public new CouponPriceGroupListLoadQueryResponse Send()
		{
			return Client.SendRequestAsync<CouponPriceGroupListLoadQueryRequest, CouponPriceGroupListLoadQueryResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponPriceGroupListLoadQueryResponse></returns>
		/// </summary>
		public new async Task<CouponPriceGroupListLoadQueryResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponPriceGroupListLoadQueryRequest, CouponPriceGroupListLoadQueryResponse>(this);
		}
	}
}
