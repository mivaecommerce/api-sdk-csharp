/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using MerchantAPI;

namespace MerchantAPIClientExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Client client;

			// Create a client using HMAC-SHA256 signing
			client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");

			// Create a client using HMAC-SHA1 signing
			client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY", Client.ClientSignType.SHA1);

			// Create a client using no Siging
			client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN");

			/// or
			client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "", Client.ClientSignType.None);

			/// Setting the default store code, optionally you can set this on a Request level
			/// but requests without it will try to assign the default set here
			client.DefaultStoreCode = "STORE_CODE";

			/// Disabling Timestamp requirements by settings the RequiredTimestamp boolean property
			/// It is not recommended to disable this security feature
			client.RequireTimestamps = false;
		}
	}
}
