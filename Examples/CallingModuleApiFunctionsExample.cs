/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

namespace MerchantAPICallingModuleApiFunctionsExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			/// If you create a custom module or want to hook into an existing modules API functionality it exposes you can
			/// use the Module request class to call into the module.

			var request = new ModuleRequest(client);

			// Set the module you wish to call into
			request.SetModuleCode("mymodule");

			// Set the function name you wish to call (defined by your modules json_api feature)
			request.SetModuleFunction("MyModuleFunction");

			/// Add custom parameters to the request using the setModuleField method
			request.SetModuleField("MyModuleField", "Foo")
				.SetModuleField("MyModuleField_Int", 1)
				.SetModuleField("MyModuleField_Decimal", 2.99);

			// Send the request

			ModuleResponse response = request.Send();

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
			}
			else
			{
				Console.WriteLine("Success");
			}
		}
	}
}
