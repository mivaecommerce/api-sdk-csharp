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
		/// Response field completed.
		[JsonPropertyName("completed")]
		public bool Completed { get; set; }

		/// Response field branch_create_session_id.
		[JsonPropertyName("branch_create_session_id")]
		public String BranchCreateSessionId { get; set; }

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
		/// Getter for completed.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetCompleted()
		{
			return Completed;
		}

		/// <summary>
		/// Getter for branch_create_session_id.
		/// <returns>string</returns>
		/// </summary>
		public String GetBranchCreateSessionId()
		{
			return BranchCreateSessionId;
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