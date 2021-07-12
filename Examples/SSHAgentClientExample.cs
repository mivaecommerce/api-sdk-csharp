/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

namespace MerchantAPISSHAgentClientExample
{
	class Program
	{
		static void Main(string[] args)
		{
			SSHAgentClient client;

			// Create a client from a specified public key file on disk, using the environment defined ssh agent socket location (SSH_AUTH_SOCK)
			// See the readme file for the format your public key must be in
			client = new SSHAgentClient("https://www.mystore.com/mm5/json.mvc", "MY_USERNAME", "/path/to/public/key.pub");

			// If you need to manually specify the socket location, you can do so in the constructor
			client = new SSHAgentClient("https://www.mystore.com/mm5/json.mvc", "MY_USERNAME", "/path/to/public/key.pub", "/path/to/agent.socket", SSHAgentAuthenticator.DigestType.SSH_RSA_SHA256);

			/// Setting the default store code, optionally you can set this on a Request level
			/// but requests without it will try to assign the default set here
			client.DefaultStoreCode = "STORE_CODE";

			/// Disabling Timestamp requirements by settings the RequiredTimestamp boolean property
			/// It is not recommended to disable this security feature
			client.RequireTimestamps = false;

			/// For MultiCall operations only, set the timeout in 
			/// seconds. Defaults to 60 seconds.
			client.OperationTimeout = 60;
		}
	}
}
