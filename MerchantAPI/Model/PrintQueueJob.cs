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
	public class PrintQueueJob : Model
	{
		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property QueueId - int</value>
		[JsonPropertyName("queue_id")]
		public int QueueId { get; set; }

		/// <value>Property StoreId - int</value>
		[JsonPropertyName("store_id")]
		public int StoreId { get; set; }

		/// <value>Property UserId - int</value>
		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property JobFormat - String</value>
		[JsonPropertyName("job_fmt")]
		public String JobFormat { get; set; }

		/// <value>Property JobData - String</value>
		[JsonPropertyName("job_data")]
		public String JobData { get; set; }

		/// <value>Property DateTimeCreated - int</value>
		[JsonPropertyName("dt_created")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime DateTimeCreated { get; set; }

		/// <value>Property UserName - String</value>
		[JsonPropertyName("user_name")]
		public String UserName { get; set; }

		/// <value>Property StoreCode - String</value>
		[JsonPropertyName("store_code")]
		public String StoreCode { get; set; }

		/// <value>Property StoreName - String</value>
		[JsonPropertyName("store_name")]
		public String StoreName { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for queue_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetQueueId()
		{
			return QueueId;
		}

		/// <summary>
		/// Getter for store_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetStoreId()
		{
			return StoreId;
		}

		/// <summary>
		/// Getter for user_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUserId()
		{
			return UserId;
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
		/// Getter for job_fmt.
		/// <returns>String</returns>
		/// </summary>
		public String GetJobFormat()
		{
			return JobFormat;
		}

		/// <summary>
		/// Getter for job_data.
		/// <returns>String</returns>
		/// </summary>
		public String GetJobData()
		{
			return JobData;
		}

		/// <summary>
		/// Getter for dt_created.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime GetDateTimeCreated()
		{
			return DateTimeCreated;
		}

		/// <summary>
		/// Getter for user_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetUserName()
		{
			return UserName;
		}

		/// <summary>
		/// Getter for store_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetStoreCode()
		{
			return StoreCode;
		}

		/// <summary>
		/// Getter for store_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetStoreName()
		{
			return StoreName;
		}
	}
}
