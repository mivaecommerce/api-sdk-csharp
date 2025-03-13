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

namespace MerchantAPI
{
	public class CustomerPaymentCard : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property CustomerId - int</value>
		[JsonPropertyName("cust_id")]
		public int CustomerId { get; set; }

		/// <value>Property FirstName - String</value>
		[JsonPropertyName("fname")]
		public String FirstName { get; set; }

		/// <value>Property LastName - String</value>
		[JsonPropertyName("lname")]
		public String LastName { get; set; }

		/// <value>Property ExpirationMonth - int</value>
		[JsonPropertyName("exp_month")]
		public int ExpirationMonth { get; set; }

		/// <value>Property ExpirationYear - int</value>
		[JsonPropertyName("exp_year")]
		public int ExpirationYear { get; set; }

		/// <value>Property LastFour - String</value>
		[JsonPropertyName("lastfour")]
		public String LastFour { get; set; }

		/// <value>Property Address1 - String</value>
		[JsonPropertyName("addr1")]
		public String Address1 { get; set; }

		/// <value>Property Address2 - String</value>
		[JsonPropertyName("addr2")]
		public String Address2 { get; set; }

		/// <value>Property City - String</value>
		[JsonPropertyName("city")]
		public String City { get; set; }

		/// <value>Property State - String</value>
		[JsonPropertyName("state")]
		public String State { get; set; }

		/// <value>Property Zip - String</value>
		[JsonPropertyName("zip")]
		public String Zip { get; set; }

		/// <value>Property Country - String</value>
		[JsonPropertyName("cntry")]
		public String Country { get; set; }

		/// <value>Property LastUsed - int</value>
		[JsonPropertyName("lastused")]
		public int LastUsed { get; set; }

		/// <value>Property Token - String</value>
		[JsonPropertyName("token")]
		public String Token { get; set; }

		/// <value>Property TypeId - int</value>
		[JsonPropertyName("type_id")]
		public int TypeId { get; set; }

		/// <value>Property ReferenceCount - int</value>
		[JsonPropertyName("refcount")]
		public int ReferenceCount { get; set; }

		/// <value>Property CardType - String</value>
		[JsonPropertyName("type")]
		public String CardType { get; set; }

		/// <value>Property ModuleCode - String</value>
		[JsonPropertyName("mod_code")]
		public String ModuleCode { get; set; }

		/// <value>Property MethodCode - String</value>
		[JsonPropertyName("meth_code")]
		public String MethodCode { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for cust_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCustomerId()
		{
			return CustomerId;
		}

		/// <summary>
		/// Getter for fname.
		/// <returns>String</returns>
		/// </summary>
		public String GetFirstName()
		{
			return FirstName;
		}

		/// <summary>
		/// Getter for lname.
		/// <returns>String</returns>
		/// </summary>
		public String GetLastName()
		{
			return LastName;
		}

		/// <summary>
		/// Getter for exp_month.
		/// <returns>int</returns>
		/// </summary>
		public int GetExpirationMonth()
		{
			return ExpirationMonth;
		}

		/// <summary>
		/// Getter for exp_year.
		/// <returns>int</returns>
		/// </summary>
		public int GetExpirationYear()
		{
			return ExpirationYear;
		}

		/// <summary>
		/// Getter for lastfour.
		/// <returns>String</returns>
		/// </summary>
		public String GetLastFour()
		{
			return LastFour;
		}

		/// <summary>
		/// Getter for addr1.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddress1()
		{
			return Address1;
		}

		/// <summary>
		/// Getter for addr2.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddress2()
		{
			return Address2;
		}

		/// <summary>
		/// Getter for city.
		/// <returns>String</returns>
		/// </summary>
		public String GetCity()
		{
			return City;
		}

		/// <summary>
		/// Getter for state.
		/// <returns>String</returns>
		/// </summary>
		public String GetState()
		{
			return State;
		}

		/// <summary>
		/// Getter for zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetZip()
		{
			return Zip;
		}

		/// <summary>
		/// Getter for cntry.
		/// <returns>String</returns>
		/// </summary>
		public String GetCountry()
		{
			return Country;
		}

		/// <summary>
		/// Getter for lastused.
		/// <returns>int</returns>
		/// </summary>
		public int GetLastUsed()
		{
			return LastUsed;
		}

		/// <summary>
		/// Getter for token.
		/// <returns>String</returns>
		/// </summary>
		public String GetToken()
		{
			return Token;
		}

		/// <summary>
		/// Getter for type_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTypeId()
		{
			return TypeId;
		}

		/// <summary>
		/// Getter for refcount.
		/// <returns>int</returns>
		/// </summary>
		public int GetReferenceCount()
		{
			return ReferenceCount;
		}

		/// <summary>
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetCardType()
		{
			return CardType;
		}

		/// <summary>
		/// Getter for mod_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for meth_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodCode()
		{
			return MethodCode;
		}
	}
}
