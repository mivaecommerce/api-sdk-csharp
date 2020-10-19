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
	/// API Response for Branch_Create.
	/// <see>https://docs.miva.com/json-api/functions/branch_create</see>
	/// </summary>
	public class BranchCreateResponse : Response
	{
		/// The response model
		[JsonPropertyName("data")]
		public Branch Data { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public BranchCreateResponse() :
			base()
		{
		}

		/// <summary>
		///  Getter for branch.
		/// <returns>Branch</returns>
		/// </summary>
		public Branch GetBranch()
		{
			return Data;
		}
	}
}