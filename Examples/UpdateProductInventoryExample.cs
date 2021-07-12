/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

namespace MerchantAPIUpdateProductInventoryExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			/// Create a ProductListAdjustInventory request instance, passing client to the constructor
			var request = new ProductListAdjustInventoryRequest();

			/// Create instances of ProductInventoryAdjustment for each adjustment we want to make

			/// Add 100 to inventory count by product code 
			var adjustment1 = new ProductInventoryAdjustment();
			var adjustment2 = new ProductInventoryAdjustment();
			var adjustment3 = new ProductInventoryAdjustment();
			var adjustment4 = new ProductInventoryAdjustment();

			adjustment1.SetProductCode("PRODUCT_1")
				.SetAdjustment(100);

			/// Subtract 25 from inventory count by product code
			adjustment2.SetProductCode("PRODUCT_2")
				.SetAdjustment(-25);

			/// Add 10 to inventory count by product id
			adjustment3.SetProductId(10248)
				.SetAdjustment(10);

			/// Add 30 to inventory count by product sku
			adjustment4.SetProductSku("ProductSku1")
				.SetAdjustment(30);

			/// Add the ProductInventoryAdjustment object to the Request
			request.AddInventoryAdjustment(adjustment1);

			/// You can also add an array of ProductInventoryAdjustment
			request.AddInventoryAdjustments(new List<ProductInventoryAdjustment> {
				adjustment2,
				adjustment3,
				adjustment4
			});

			try
			{
				ProductListAdjustInventoryResponse response = request.Send();
			}
			catch(ClientException e)
			{
				// Handle Exception;
				return;
			}            

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
			}
			else
			{
				Console.WriteLine("Successfully Updated Product Inventory");
			}
		}
	}
}
