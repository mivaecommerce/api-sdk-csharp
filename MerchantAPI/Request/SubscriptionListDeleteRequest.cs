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
using System.Text.Json;
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request SubscriptionList_Delete.
	/// <see>https://docs.miva.com/json-api/functions/subscriptionlist_delete</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class SubscriptionListDeleteRequest : Request
	{
		/// Request field Subscription_IDs.
		public List<int> SubscriptionIds { get; set; } = new List<int>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public SubscriptionListDeleteRequest(BaseClient client = null) :
			base(client)
		{
			Function = "SubscriptionList_Delete";
		}

		/// <summary>
		/// Add Subscription_IDs.
		///	- subscriptionId: Int
		/// - Returns: Self
		/// </summary>
		public SubscriptionListDeleteRequest AddSubscriptionId(int subscriptionId)
		{
			SubscriptionIds.Add(subscriptionId);
			return this;
		}

		/// <summary>
		/// Add Subscription model.
		/// <param name="subscription">Subscription></param>
		/// <returns>SubscriptionListDeleteRequest</returns>
		/// </summary>
		public SubscriptionListDeleteRequest AddSubscription(Subscription subscription)
		{
			if (subscription.Id > 0)
			{
				SubscriptionIds.Add(subscription.Id);
			}

			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			writer.WritePropertyName("Subscription_IDs");
			JsonSerializer.Serialize(writer, this.SubscriptionIds, options);
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SubscriptionListDeleteResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>SubscriptionListDeleteResponse</returns>
		/// </summary>
		public new SubscriptionListDeleteResponse Send()
		{
			return Client.SendRequestAsync<SubscriptionListDeleteRequest, SubscriptionListDeleteResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<SubscriptionListDeleteResponse></returns>
		/// </summary>
		public new async Task<SubscriptionListDeleteResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<SubscriptionListDeleteRequest, SubscriptionListDeleteResponse>(this);
		}
	}
}
