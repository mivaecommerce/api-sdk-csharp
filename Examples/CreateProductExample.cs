/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using MerchantAPI;

namespace MerchantAPICreateProductExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			var request = new ProductInsertRequest(client);

			request.SetProductCode("NEW_PRODUCT")
				.SetProductName("My New Product")
				.SetProductPrice(29.99)
				.SetProductWeight(1.50);

			ProductInsertResponse response = request.Send();

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
			}
			else
			{
				Console.WriteLine("Successfully inserted product");
			}
		}
	}
}