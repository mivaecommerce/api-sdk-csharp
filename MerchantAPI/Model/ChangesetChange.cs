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
	public class ChangesetChange : Model
	{
		/// <value>Property ItemType - String</value>
		[JsonPropertyName("item_type")]
		public String ItemType { get; set; }

		/// <value>Property ItemId - int</value>
		[JsonPropertyName("item_id")]
		public int ItemId { get; set; }

		/// <value>Property ItemVersionId - int</value>
		[JsonPropertyName("item_version_id")]
		public int ItemVersionId { get; set; }

		/// <value>Property ItemIdentifier - String</value>
		[JsonPropertyName("item_identifier")]
		public String ItemIdentifier { get; set; }

		/// <summary>
		/// Getter for item_type.
		/// <returns>String</returns>
		/// </summary>
		public String GetItemType()
		{
			return ItemType;
		}

		/// <summary>
		/// Getter for item_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetItemId()
		{
			return ItemId;
		}

		/// <summary>
		/// Getter for item_version_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetItemVersionId()
		{
			return ItemVersionId;
		}

		/// <summary>
		/// Getter for item_identifier.
		/// <returns>String</returns>
		/// </summary>
		public String GetItemIdentifier()
		{
			return ItemIdentifier;
		}
	}
}
