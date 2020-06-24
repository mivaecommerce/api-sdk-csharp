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
	public class ProductInventorySettings : Model
	{
		/// <value>Property Active - bool</value>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <value>Property InStockMessageShort - String</value>
		[JsonPropertyName("in_short")]
		public String InStockMessageShort { get; set; }

		/// <value>Property InStockMessageLong - String</value>
		[JsonPropertyName("in_long")]
		public String InStockMessageLong { get; set; }

		/// <value>Property TrackLowStockLevel - String</value>
		[JsonPropertyName("low_track")]
		public String TrackLowStockLevel { get; set; }

		/// <value>Property LowStockLevel - int</value>
		[JsonPropertyName("low_level")]
		public int LowStockLevel { get; set; }

		/// <value>Property LowStockLevelDefault - bool</value>
		[JsonPropertyName("low_lvl_d")]
		public bool LowStockLevelDefault { get; set; }

		/// <value>Property LowStockMessageShort - String</value>
		[JsonPropertyName("low_short")]
		public String LowStockMessageShort { get; set; }

		/// <value>Property LowStockMessageLong - String</value>
		[JsonPropertyName("low_long")]
		public String LowStockMessageLong { get; set; }

		/// <value>Property TrackOutOfStockLevel - String</value>
		[JsonPropertyName("out_track")]
		public String TrackOutOfStockLevel { get; set; }

		/// <value>Property HideOutOfStock - String</value>
		[JsonPropertyName("out_hide")]
		public String HideOutOfStock { get; set; }

		/// <value>Property OutOfStockLevel - int</value>
		[JsonPropertyName("out_level")]
		public int OutOfStockLevel { get; set; }

		/// <value>Property OutOfStockLevelDefault - bool</value>
		[JsonPropertyName("out_lvl_d")]
		public bool OutOfStockLevelDefault { get; set; }

		/// <value>Property OutOfStockMessageShort - String</value>
		[JsonPropertyName("out_short")]
		public String OutOfStockMessageShort { get; set; }

		/// <value>Property OutOfStockMessageLong - String</value>
		[JsonPropertyName("out_long")]
		public String OutOfStockMessageLong { get; set; }

		/// <value>Property LimitedStockMessage - String</value>
		[JsonPropertyName("ltd_long")]
		public String LimitedStockMessage { get; set; }

		/// <summary>
		/// Getter for active.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetActive()
		{
			return Active;
		}

		/// <summary>
		/// Getter for in_short.
		/// <returns>String</returns>
		/// </summary>
		public String GetInStockMessageShort()
		{
			return InStockMessageShort;
		}

		/// <summary>
		/// Getter for in_long.
		/// <returns>String</returns>
		/// </summary>
		public String GetInStockMessageLong()
		{
			return InStockMessageLong;
		}

		/// <summary>
		/// Getter for low_track.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackLowStockLevel()
		{
			return TrackLowStockLevel;
		}

		/// <summary>
		/// Getter for low_level.
		/// <returns>int</returns>
		/// </summary>
		public int GetLowStockLevel()
		{
			return LowStockLevel;
		}

		/// <summary>
		/// Getter for low_lvl_d.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetLowStockLevelDefault()
		{
			return LowStockLevelDefault;
		}

		/// <summary>
		/// Getter for low_short.
		/// <returns>String</returns>
		/// </summary>
		public String GetLowStockMessageShort()
		{
			return LowStockMessageShort;
		}

		/// <summary>
		/// Getter for low_long.
		/// <returns>String</returns>
		/// </summary>
		public String GetLowStockMessageLong()
		{
			return LowStockMessageLong;
		}

		/// <summary>
		/// Getter for out_track.
		/// <returns>String</returns>
		/// </summary>
		public String GetTrackOutOfStockLevel()
		{
			return TrackOutOfStockLevel;
		}

		/// <summary>
		/// Getter for out_hide.
		/// <returns>String</returns>
		/// </summary>
		public String GetHideOutOfStock()
		{
			return HideOutOfStock;
		}

		/// <summary>
		/// Getter for out_level.
		/// <returns>int</returns>
		/// </summary>
		public int GetOutOfStockLevel()
		{
			return OutOfStockLevel;
		}

		/// <summary>
		/// Getter for out_lvl_d.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetOutOfStockLevelDefault()
		{
			return OutOfStockLevelDefault;
		}

		/// <summary>
		/// Getter for out_short.
		/// <returns>String</returns>
		/// </summary>
		public String GetOutOfStockMessageShort()
		{
			return OutOfStockMessageShort;
		}

		/// <summary>
		/// Getter for out_long.
		/// <returns>String</returns>
		/// </summary>
		public String GetOutOfStockMessageLong()
		{
			return OutOfStockMessageLong;
		}

		/// <summary>
		/// Getter for ltd_long.
		/// <returns>String</returns>
		/// </summary>
		public String GetLimitedStockMessage()
		{
			return LimitedStockMessage;
		}
	}
}
