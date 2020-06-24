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
	/// Handles API Request CouponList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/couponlist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponListDeleteRequest : Request
	{
		/// Request field Coupon_IDs.
		public List<int> CouponIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">Client</param>
		/// </summary>
		public CouponListDeleteRequest(Client client = null) :
			base(client)
		{
			Function = "CouponList_Delete";
		}

		/// <summary>
		/// Add Coupon_IDs.
		///	- couponId: Int
		/// - Returns: Self
		/// </summary>
		public CouponListDeleteRequest AddCouponId(int couponId)
		{
			CouponIds.Add(couponId);
			return this;
		}

		/// <summary>
		/// Add Coupon model.
		/// <param name="coupon">Coupon></param>
		/// <returns>CouponListDeleteRequest</returns>
		/// </summary>
		public CouponListDeleteRequest AddCoupon(Coupon coupon)
		{
			if (coupon.Id > 0)
			{
				CouponIds.Add(coupon.Id);
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

			writer.WritePropertyName("Coupon_IDs");
			JsonSerializer.Serialize(writer, this.CouponIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CouponListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponListDeleteResponse</returns>
		/// </summary>
		public new CouponListDeleteResponse Send()
		{
			return Client.SendRequestAsync<CouponListDeleteRequest, CouponListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponListDeleteResponse></returns>
		/// </summary>
		public new async Task<CouponListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponListDeleteRequest, CouponListDeleteResponse>(this);
		}
	}
}
