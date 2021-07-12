/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

namespace MerchantAPICallingMultiCallExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			/// MultiCall operations will timeout after a default of 60 seconds
			/// Control the timeout value from the client

			client.OperationTimeout = 10;

			/// Create a MultiCallRequest and add Request objects to it

			var request = new MultiCallRequest(client);

			request.AddRequest(new ProductListLoadQueryRequest())
				.AddRequest(new CategoryListLoadQueryRequest())
				.AddRequest(new PriceGroupListLoadQueryRequest());


			/// If you wish to automatically fetch the remaining data in the event of a timeout, you can specify
			/// the auto timeout completion flag within the request.  By default it is not enabled.

			request.autoTimeoutContinue = true;


			// Send the request

			MultiCallResponse response = request.Send();

			if (!response.IsSuccess())
			{
				if (response.IsTimeout())
				{
					Console.WriteLine("Operation Timed out");
				}
				else
				{
					Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
				}
			}
			else
			{
				foreach (Response resp in response.GetResponses())
				{
					if (resp.IsSuccess())
					{   
						// Do Something with the response
						// You will need to cast to the expected types
						if (resp is ProductListLoadQueryResponse castedProducts)
						{
							foreach(Product p in castedProducts.GetProducts())
							{
								// Do something with products
							}
						}
						else if(resp is CategoryListLoadQueryResponse castedCategories)
						{
							/// etc...
						}
					}
				}
			}

			/// Utilizing the Iterations feature allows you to compact request
			/// data by grouping multiple iterations to the same API function
			/// in sequence.
			/// @see MultiCallOperation

			request = new MultiCallRequest(client: client);

			/// Create a new MultiCallOperation and adds it to the Request.
			var operation = request.Operation();

			/// Alternately:
			/// var operation = new MultiCallOperation();
			/// request.AddOperation(operation)

			/// Set shared data between the iterations, for example we can set a shared
			/// value for Product_Price and update many products without specifying the same
			/// data for each of the iterations.

			operation.AddSharedData("Product_Price", 29.99);

			///We now add all the same request types to the operation to make use of iterations

			var update1 = new ProductUpdateRequest();

			update1.SetEditProduct("PROD_1");

			var update2 = new ProductUpdateRequest();

			update2.SetEditProduct("PROD_2");

			var update3 = new ProductUpdateRequest();

			update3.SetEditProduct("PROD_3");

			var update4 = new ProductUpdateRequest();

			update4.SetEditProduct("PROD_4")
				.SetProductName("Product 4");

			operation.AddRequest(update1);
			operation.AddRequest(update2);
			operation.AddRequest(update3);
			operation.AddRequest(update4);

			/// We can add more requests as well. Add a Product List Load to get the updated products at the end
			var checkProducts = new ProductListLoadQuery();

			checkProducts.GetFilter().IsIn("code", ["PROD_1", "PROD_2", "PROD_3", "PROD_4"]);

			request.AddRequest(checkProducts);

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
			}
			else
			{
				foreach (Response resp in response.GetResponses())
				{
					if (resp.IsSuccess())
					{
						/// Do something with this response
					}
				}
			}
		}
	}
}
