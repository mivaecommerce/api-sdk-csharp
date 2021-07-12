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
	public class CustomerAddressList : Model
	{
		/// <value>Property ShipId - int</value>
		[JsonPropertyName("ship_id")]
		public int ShipId { get; set; }

		/// <value>Property BillId - int</value>
		[JsonPropertyName("bill_id")]
		public int BillId { get; set; }

		/// <value>Property Addresses - List<CustomerAddress></value>
		[JsonPropertyName("addresses")]
		public List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();

		/// <summary>
		/// Getter for ship_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetShipId()
		{
			return ShipId;
		}

		/// <summary>
		/// Getter for bill_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetBillId()
		{
			return BillId;
		}

		/// <summary>
		/// Getter for addresses.
		/// <returns>List<CustomerAddress></returns>
		/// </summary>
		public List<CustomerAddress> GetAddresses()
		{
			return Addresses;
		}
	}
}
