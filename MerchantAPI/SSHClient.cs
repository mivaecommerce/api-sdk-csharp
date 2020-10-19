/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace MerchantAPI
{
	public class SSHClient : BaseClient
	{
		/// <summary>
		/// Construct a client with a path to a local private key file
		/// </summary>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="X509Path"></param>
		/// <param name="password"></param>
		/// <param name="digestType"></param>
		public SSHClient(String endpoint, String username, String X509Path, String password = null, SSHPrivateKeyAuthenticator.KeyType keyType = SSHPrivateKeyAuthenticator.KeyType.PKCS8, SSHPrivateKeyAuthenticator.DigestType digestType = SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(endpoint, new SSHPrivateKeyAuthenticator(username, X509Path, password, keyType, digestType))
		{

		}

		/// <summary>
		/// Construct a client with a certificate you already loaded
		/// </summary>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="x509"></param>
		/// <param name="digestType"></param>
		public SSHClient(String endpoint, String username, X509Certificate2 x509, SSHPrivateKeyAuthenticator.DigestType digestType = SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(endpoint, new SSHPrivateKeyAuthenticator(username, x509, digestType))
		{

		}

		/// <summary>
		/// Construct a client with a certificate you already loaded
		/// </summary>
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="x509"></param>
		/// <param name="digestType"></param>
		public SSHClient(HttpClient httpClient, String endpoint, String username, X509Certificate2 x509, SSHPrivateKeyAuthenticator.DigestType digestType = SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(httpClient, endpoint, new SSHPrivateKeyAuthenticator(username, x509, digestType))
		{

		}

		/// <summary>
		/// Construct a client with a key you already loaded
		/// </summary>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="privateKey"></param>
		/// <param name="digestType"></param>
		public SSHClient(String endpoint, String username, RSA privateKey, SSHPrivateKeyAuthenticator.DigestType digestType = SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(endpoint, new SSHPrivateKeyAuthenticator(username, privateKey, digestType))
		{

		}

		/// <summary>
		/// Construct a client with a key you already loaded
		/// </summary>
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="privateKey"></param>
		/// <param name="digestType"></param>
		public SSHClient(HttpClient httpClient, String endpoint, String username, RSA privateKey, SSHPrivateKeyAuthenticator.DigestType digestType = SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(httpClient, endpoint, new SSHPrivateKeyAuthenticator(username, privateKey, digestType))
		{

		}

		/// <summary>
		/// Set the private key by file
		/// </summary>
		/// <param name="x509Path"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public SSHClient SetPrivateKey(String filePath, String password, SSHPrivateKeyAuthenticator.KeyType keyType)
		{
			if (CurrentAuthenticator is SSHPrivateKeyAuthenticator auth)
			{
				auth.SetPrivateKey(filePath, password, keyType);
			}

			return this;
		}

		/// <summary>
		/// Set the digest type
		/// </summary>
		/// <param name="digestType"></param>
		/// <returns></returns>
		public SSHClient SetDigestType(SSHPrivateKeyAuthenticator.DigestType digestType)
		{
			if (CurrentAuthenticator is SSHPrivateKeyAuthenticator auth )
			{
				auth.SetDigestType(digestType);
			}

			return this;
		}

		/// <summary>
		/// Get the digest type
		/// </summary>
		/// <returns>DigestType</returns>
		public SSHPrivateKeyAuthenticator.DigestType GetDigestType()
		{
			if (CurrentAuthenticator is SSHPrivateKeyAuthenticator auth)
			{
				return auth.GetDigestType();
			}

			return SSHPrivateKeyAuthenticator.DigestType.SSH_RSA_SHA256;
		}



		/// <summary>
		/// Set the username
		/// </summary>
		/// <param name="username"></param>
		/// <returns>SSHClient</returns>
		public SSHClient SetUsername(String username)
		{
			if (CurrentAuthenticator is SSHPrivateKeyAuthenticator auth)
			{
				auth.SetUsername(username);
			}

			return this;
		}

		/// <summary>
		/// Get the username
		/// </summary>
		/// <returns>String</returns>
		public String GetUsername()
		{
			if (CurrentAuthenticator is SSHPrivateKeyAuthenticator auth)
			{
				return auth.GetUsername();
			}

			return "";
		}
	}
}
