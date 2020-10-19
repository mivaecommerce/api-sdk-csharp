/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using MerchantAPI;

namespace MerchantAPISSHClientExample
{
	class Program
	{
		static void Main(string[] args)
		{
			SSHClient client;

			// Create a client from a specified private key file on disk and the type of key
			// See the readme file for the format your private key must be in
			client = new SSHClient("https://www.mystore.com/mm5/json.mvc", "MY_USERNAME", "/path/to/private/key", "MY_KEY_PASSWORD", SSHPrivateKeyAuthenticator.KeyType.PKCS1, SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256);

			// Create a client from a pre-loaded X509
			System.Security.Cryptography;.X509Certificate2 x509;
			client = new SSHClient("https://www.mystore.com/mm5/json.mvc", "MY_USERNAME", x509, SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256);

			// Create a client from a pre-loaded RSA key
			System.Security.Cryptography;.RSA rsa;
			client = new SSHClient("https://www.mystore.com/mm5/json.mvc", "MY_USERNAME", rsa, SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256);		

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
