/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

namespace MerchantAPILoadOrdersExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			/// Create a OrderListLoadQuery request instance, passing client to the constructor
			var request = new OrderListLoadQueryRequest(client);

			/// include additional order information by including ondemandcolumns
			request.SetOnDemandColumns(new String[] {
				"ship_method",				// include the shipping method
				"cust_login",				// include the customers login
				"cust_pw_email",			// include the customers email address
				"business_title",			// include the customers business account title
				"payment_module",			// include the payment module information
				"customer",					// include the customer information
				"items",					// include the orders items
				"charges",					// include the orders charges
				"coupons",					// include the orders coupons
				"discounts",				// include the orders discounts
				"payments"					// include the orders payments
			});

			request.AddOnDemandColumn("notes"); // include the orders notes

			/// Include all custom fields
			request.AddOnDemandColumn("CustomField_Values:*");

			/// Set the list sorting
			request.SetSort("id", OrderListLoadQueryRequest.SortDirection.ASC);

			/// If you wish to decrypt payment data, you must provide the passphrase used by your encryption key
			request.SetPassphrase("MY_ENCRYPTION_KEYS_PASSPHRASE");

			// Send the request

			OrderListLoadQueryResponse response = request.Send();

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
			}
			else
			{
				foreach (Order order in response.GetOrders()) {
					Console.WriteLine("Order ID {0} With {1} Items, {2} Charges Total {3}",
						 order.GetId(),
						 order.GetItems().Count,
						 order.GetCharges().Count,
						 order.GetFormattedTotal());
				}
			}
		}
	}
}
