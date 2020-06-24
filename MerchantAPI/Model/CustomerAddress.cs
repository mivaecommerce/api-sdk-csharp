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
	public class CustomerAddress : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property CustomerId - int</value>
		[JsonPropertyName("cust_id")]
		public int CustomerId { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property FirstName - String</value>
		[JsonPropertyName("fname")]
		public String FirstName { get; set; }

		/// <value>Property LastName - String</value>
		[JsonPropertyName("lname")]
		public String LastName { get; set; }

		/// <value>Property Email - String</value>
		[JsonPropertyName("email")]
		public String Email { get; set; }

		/// <value>Property Company - String</value>
		[JsonPropertyName("comp")]
		public String Company { get; set; }

		/// <value>Property Phone - String</value>
		[JsonPropertyName("phone")]
		public String Phone { get; set; }

		/// <value>Property Fax - String</value>
		[JsonPropertyName("fax")]
		public String Fax { get; set; }

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

		/// <value>Property Residential - bool</value>
		[JsonPropertyName("resdntl")]
		public bool Residential { get; set; }

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
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
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
		/// Getter for email.
		/// <returns>String</returns>
		/// </summary>
		public String GetEmail()
		{
			return Email;
		}

		/// <summary>
		/// Getter for comp.
		/// <returns>String</returns>
		/// </summary>
		public String GetCompany()
		{
			return Company;
		}

		/// <summary>
		/// Getter for phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetPhone()
		{
			return Phone;
		}

		/// <summary>
		/// Getter for fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetFax()
		{
			return Fax;
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
		/// Getter for resdntl.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetResidential()
		{
			return Residential;
		}
	}
}
