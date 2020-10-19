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
	/// Handles API Request Coupon_Insert.
	/// <see>https://docs.miva.com/json-api/functions/coupon_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class CouponInsertRequest : Request
	{
		/// Request field Code.
		[JsonPropertyName("Code")]
		public String Code { get; set; }

		/// Request field Description.
		[JsonPropertyName("Description")]
		public String Description { get; set; }

		/// Request field CustomerScope.
		[JsonPropertyName("CustomerScope")]
		public String CustomerScope { get; set; }

		/// Request field DateTime_Start.
		[JsonPropertyName("DateTime_Start")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? DateTimeStart { get; set; }

		/// Request field DateTime_End.
		[JsonPropertyName("DateTime_End")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? DateTimeEnd { get; set; }

		/// Request field Max_Use.
		[JsonPropertyName("Max_Use")]
		public int? MaxUse { get; set; }

		/// Request field Max_Per.
		[JsonPropertyName("Max_Per")]
		public int? MaxPer { get; set; }

		/// Request field Active.
		[JsonPropertyName("Active")]
		public bool? Active { get; set; }

		/// Request field PriceGroup_ID.
		[JsonPropertyName("PriceGroup_ID")]
		public int? PriceGroupId { get; set; }

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// <param name="coupon">Coupon</param>
		/// </summary>
		public CouponInsertRequest(BaseClient client = null, Coupon coupon = null) :
			base(client)
		{
			Function = "Coupon_Insert";
			if (coupon != null) {
				Code = coupon.Code;
				Description = coupon.Description;
				CustomerScope = coupon.CustomerScope;
				DateTimeStart = coupon.DateTimeStart;
				DateTimeEnd = coupon.DateTimeEnd;
				MaxUse = coupon.MaxUse;
				MaxPer = coupon.MaxPer;
				Active = coupon.Active;
			}
		}

		/// <summary>
		/// Getter for Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for CustomerScope.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerScope()
		{
			return CustomerScope;
		}

		/// <summary>
		/// Getter for DateTime_Start.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime? GetDateTimeStart()
		{
			return DateTimeStart;
		}

		/// <summary>
		/// Getter for DateTime_End.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime? GetDateTimeEnd()
		{
			return DateTimeEnd;
		}

		/// <summary>
		/// Getter for Max_Use.
		/// <returns>int</returns>
		/// </summary>
		public int? GetMaxUse()
		{
			return MaxUse;
		}

		/// <summary>
		/// Getter for Max_Per.
		/// <returns>int</returns>
		/// </summary>
		public int? GetMaxPer()
		{
			return MaxPer;
		}

		/// <summary>
		/// Getter for Active.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetActive()
		{
			return Active;
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
		/// Setter for Code.
		/// <param name="value">String</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetCode(String value)
		{
			Code = value;
			return this;
		}

		/// <summary>
		/// Setter for Description.
		/// <param name="value">String</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetDescription(String value)
		{
			Description = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerScope.
		/// <param name="value">String</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetCustomerScope(String value)
		{
			CustomerScope = value;
			return this;
		}

		/// <summary>
		/// Setter for DateTime_Start.
		/// <param name="value">DateTime</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetDateTimeStart(DateTime? value)
		{
			DateTimeStart = value;
			return this;
		}

		/// <summary>
		/// Setter for DateTime_Start using a unix timestamp.
		/// <param name="value">long</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetDateTimeStart(long? value)
		{
			if (!value.HasValue)
			{
				DateTimeStart = null;
				return this;
			}

			DateTimeStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value.Value));
			return this;
		}

		/// <summary>
		/// Setter for DateTime_End.
		/// <param name="value">DateTime</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetDateTimeEnd(DateTime? value)
		{
			DateTimeEnd = value;
			return this;
		}

		/// <summary>
		/// Setter for DateTime_End using a unix timestamp.
		/// <param name="value">long</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetDateTimeEnd(long? value)
		{
			if (!value.HasValue)
			{
				DateTimeEnd = null;
				return this;
			}

			DateTimeEnd = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value.Value));
			return this;
		}

		/// <summary>
		/// Setter for Max_Use.
		/// <param name="value">int</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetMaxUse(int? value)
		{
			MaxUse = value;
			return this;
		}

		/// <summary>
		/// Setter for Max_Per.
		/// <param name="value">int</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetMaxPer(int? value)
		{
			MaxPer = value;
			return this;
		}

		/// <summary>
		/// Setter for Active.
		/// <param name="value">bool</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetActive(bool? value)
		{
			Active = value;
			return this;
		}

		/// <summary>
		/// Setter for PriceGroup_ID.
		/// <param name="value">int</param>
		/// <returns>CouponInsertRequest</returns>
		/// </summary>
		public CouponInsertRequest SetPriceGroupId(int? value)
		{
			PriceGroupId = value;
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

			writer.WriteString("Code", Code);

			if (Description != null && Description.Length > 0)
			{
				writer.WriteString("Description", Description);
			}

			if (CustomerScope != null && CustomerScope.Length > 0)
			{
				writer.WriteString("CustomerScope", CustomerScope);
			}

			if (DateTimeStart.HasValue)
			{
				writer.WriteNumber("DateTime_Start", new DateTimeOffset(DateTimeStart.Value).ToUnixTimeSeconds());
			}

			if (DateTimeEnd.HasValue)
			{
				writer.WriteNumber("DateTime_End", new DateTimeOffset(DateTimeEnd.Value).ToUnixTimeSeconds());
			}

			if (MaxUse.HasValue)
			{
				writer.WriteNumber("Max_Use", MaxUse.Value);
			}

			if (MaxPer.HasValue)
			{
				writer.WriteNumber("Max_Per", MaxPer.Value);
			}

			if (Active.HasValue)
			{
				writer.WriteBoolean("Active", Active.Value);
			}

			if (PriceGroupId.HasValue)
			{
				writer.WriteNumber("PriceGroup_ID", PriceGroupId.Value);
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<CouponInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>CouponInsertResponse</returns>
		/// </summary>
		public new CouponInsertResponse Send()
		{
			return Client.SendRequestAsync<CouponInsertRequest, CouponInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<CouponInsertResponse></returns>
		/// </summary>
		public new async Task<CouponInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<CouponInsertRequest, CouponInsertResponse>(this);
		}
	}
}
