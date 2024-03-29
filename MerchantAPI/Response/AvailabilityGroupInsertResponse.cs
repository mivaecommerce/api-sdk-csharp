/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// API Response for AvailabilityGroup_Insert.
	/// <see>https://docs.miva.com/json-api/functions/availabilitygroup_insert</see>
	/// </summary>
	public class AvailabilityGroupInsertResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public AvailabilityGroup Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public AvailabilityGroupInsertResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for availabilityGroup.
		/// <returns>AvailabilityGroup</returns>
		/// </summary>
		public AvailabilityGroup GetAvailabilityGroup()
		{
			return Data;
		}
	}
}