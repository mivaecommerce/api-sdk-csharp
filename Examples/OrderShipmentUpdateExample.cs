/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

/**
 * This example will load an order by its ID from the first argument passed to it when run 
 * then proceed to create a shipment for all items in the order and then finally update the shipment
 * with tracking information and mark it as shipped.
 */

namespace MerchantAPIOrderShipmentUpdateExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			var ordersRequest = new OrderListLoadQueryRequest(client);

			ordersRequest.Filter.Equal("id", System.Convert.ToUInt32(args[1]));

			var ordersResponse = ordersRequest.Send();

			if (!ordersResponse.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", ordersResponse.GetErrorCode(), ordersResponse.GetErrorMessage());
				return;
			}
			else if (ordersResponse.GetOrders().Count == 0)
			{
				Console.WriteLine("Error: Order Not Found");
				return;
			}

			foreach (Order order in ordersResponse.GetOrders())
			{
				if (order.GetItems().Count == 0)
				{
					Console.WriteLine("Order Has No Items");
					continue;
				}

				// Create a shipment for all items in the order

				var createShipmentRequest = new OrderItemListCreateShipmentRequest(client);

				foreach (OrderItem item in order.GetItems())
				{
					if (item.GetShipmentId() > 0)
					{
						// item already has a shipment, skip it
						continue;
					}

					// add it the the shipment we are creating
					createShipmentRequest.AddOrderItem(item);
				}

				var orderShipmentResponse = createShipmentRequest.Send();

				if (!orderShipmentResponse.IsSuccess())
				{
					Console.WriteLine("Error: {0}: {1}", orderShipmentResponse.GetErrorCode(), orderShipmentResponse.GetErrorMessage());
					return;
				}

				var shipment = orderShipmentResponse.GetOrderShipment();

				// Now that we have created a shipment for the items in the order we can
				// assign a tracking number and mark it shipped

				var shipmentUpdateRequest = new OrderShipmentListUpdateRequest(client);

				var shipmentUpdate = new OrderShipmentUpdate();

				var trackingNumber = String.Format("Z{0}", DateTimeOffset.UtcNow.ToUnixTimeSeconds());

				shipmentUpdate.SetCost(1.00)
					.SetMarkShipped(true)
					.SetShipmentId(shipment.GetId())
					.SetTrackingNumber(trackingNumber)
					.SetTrackingType("UPS");

				shipmentUpdateRequest.AddShipmentUpdate(shipmentUpdate);

				var shipmentUpdateResponse = shipmentUpdateRequest.Send();

				if (!shipmentUpdateResponse.IsSuccess())
				{
					Console.WriteLine("Error: {0}: {1}", shipmentUpdateResponse.GetErrorCode(), shipmentUpdateResponse.GetErrorMessage());
					return;
				}
				else
				{
					Console.WriteLine("Order {0} Shipment {1} Created With Tracking {2}", order.GetId(), shipment.GetId(), trackingNumber);
				}
			}
		}
	}
}
