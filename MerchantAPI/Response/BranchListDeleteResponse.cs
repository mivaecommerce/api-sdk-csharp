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
	/// API Response for BranchList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/branchlist_delete</see>
	/// </summary>
	public class BranchListDeleteResponse : Response
	{
		/// Response field processed.
		[JsonPropertyName("processed")]
		public int Processed { get; set; }

		/// <summary>
		///  Constructor
		/// </summary>
		public BranchListDeleteResponse() :
			base()
		{
		}

		/// <summary>
		/// Getter for processed.
		/// <returns>int</returns>
		/// </summary>
		public int GetProcessed()
		{
			return Processed;
		}
	}
}