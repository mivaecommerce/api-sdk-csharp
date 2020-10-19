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
	/// API Response for Changeset_Create.
	/// <see>https://docs.miva.com/json-api/functions/changeset_create</see>
	/// </summary>
	public class ChangesetCreateResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Changeset Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public ChangesetCreateResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for changeset.
		/// <returns>Changeset</returns>
		/// </summary>
		public Changeset GetChangeset()
		{
			return Data;
		}
	}
}