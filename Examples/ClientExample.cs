/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
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

			/// For MultiCall operations only, set the timeout in 
			/// seconds. Defaults to 60 seconds.
			client.OperationTimeout = 60;

			/// Request Logging can be enabled by assigning a Logger instance to the client

			/// Currently, we provide two logger types:
			//		 FileLogger - logs to a local file
			//		 ConsoleLogger - logs to std out/err

			// Setting up a FileLogger
			client.SetLogger(new FileLogger("/path/to/my/logfile.log"));

			// Setting up a ConsoleLogger to log to stdout
			client.SetLogger(new ConsoleLogger(ConsleLogger.OutputDestination.StdOut));
			
			// Setting up a ConsoleLogger to log to stderr
			client.SetLogger(new ConsoleLogger(ConsleLogger.OutputDestination.StdErr));
		}
	}
}
