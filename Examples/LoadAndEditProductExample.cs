/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using MerchantAPI;

namespace MerchantAPILoadAndEditProductExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			var loadProductRequest = new ProductListLoadQueryRequest(client);

			 /// apply filtering to match a specific product
			 /// @see ListQueryExample.cs
			loadProductRequest.GetFilter().Equal("code", "MY_PRODUCT");

			/// include all custom fields
			loadProductRequest.AddOnDemandColumn("CustomField_Values:*");

			ProductListLoadQueryResponse loadProductResponse = loadProductRequest.Send();

			if (!loadProductResponse.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", loadProductResponse.GetErrorCode(), loadProductResponse.GetErrorMessage());
				return;
			}
			else
			{
				Console.WriteLine("Successfully loaded product");
			}

			if (loadProductResponse.GetProducts().Count == 0 )
			{
				Console.WriteLine("No Products Found");
				return;
			}

			var product = loadProductResponse.GetProducts()[0];

			Console.WriteLine("Loaded Product {0} Code {1} Name {2}", product.GetId(), product.GetCode(), product.GetName());

			/// You can access the custom fields of the product from the CustomFieldValues model
			VariableValue myCustomFieldValue = product.GetCustomFieldValues().GetValue("MyField");

			// Field values can be inspected of their type. Supported types are any IConvertible, and Array's of IConvertible (multitext)
			if (myCustomFieldValue.ValueType == VariableValue.ValueDataType.ConvertibleType)
			{
				String myCustomFieldValueString = myCustomFieldValue.ToString();
			}
			else if (myCustomFieldValue.ValueType == VariableValue.ValueDataType.ArrayType)
			{
				foreach(var v in myCustomFieldValue.GetValueArray())
				{
					String myCustomFieldValueMultitextString = v.ToString();
				}
			}

			/// to get a specific module field, specify the optional 2rd argument with the module code.
			VariableValue myModuleCustomFieldValue = product.GetCustomFieldValues().GetValue("MyField", "MyModule");

			/// Some requests accept a Model object in their constructor
			/// which will allow the Request object to inherit data from.
			/// ProductUpdate accepts a Product model.
			var request = new ProductUpdateRequest(client, product);

			request.SetProductName("The New Product Name")
				.SetProductDescription("New Product Description")
				.SetProductPrice(39.99)
				.SetProductCost(29.99)
				.SetProductWeight(2.5);

			/// You can update custom field values using the CustomFieldValues model.
			request.GetCustomFieldValues().SetValue("MyField", "MyValue");

			/// to update a specific module field, specify the optional 3rd argument with the module code.
			request.GetCustomFieldValues().SetValue("MyField", "MyValue", "MyModule");

			ProductUpdateResponse response = request.Send();

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
				return;
			}
			else
			{
				Console.WriteLine("Successfully updated product");
			}
		}
	}
}
