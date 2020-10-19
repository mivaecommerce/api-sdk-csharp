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

namespace MerchantAPI
{
	public class SSHAgentClient : BaseClient
	{
		/// <summary>
		/// Construct a client with a local public key file
		/// </summary>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="publicKeyPath"></param>
		/// <param name="agentSocketPath"></param>
		/// <param name="digestType"></param>
		public SSHAgentClient(String endpoint, String username, String publicKeyPath, String agentSocketPath = "", SSHAgentAuthenticator.DigestType digestType = SSHAgentAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(endpoint, new SSHAgentAuthenticator(username, publicKeyPath, agentSocketPath, digestType))
		{

		}
		/// <summary>
		/// Construct a client with a local public key file and existing HTTP Client
		/// </summary>
		/// <param name="endpoint"></param>
		/// <param name="username"></param>
		/// <param name="publicKeyPath"></param>
		/// <param name="agentSocketPath"></param>
		/// <param name="digestType"></param>
		public SSHAgentClient(HttpClient httpClient, String endpoint, String username, String publicKeyPath, String agentSocketPath = "", SSHAgentAuthenticator.DigestType digestType = SSHAgentAuthenticator.DigestType.SSH_RSA_SHA256) :
			base(httpClient, endpoint, new SSHAgentAuthenticator(username, publicKeyPath, agentSocketPath, digestType))
		{

		}

		/// <summary>
		/// Set the digest type
		/// </summary>
		/// <param name="digestType"></param>
		/// <returns></returns>
		public SSHAgentClient SetPublicKey(String publicKeyPath)
		{
			if (CurrentAuthenticator is SSHAgentAuthenticator auth)
			{
				auth.SetPublicKey(publicKeyPath);
			}

			return this;
		}

		/// <summary>
		/// Set the digest type
		/// </summary>
		/// <param name="digestType"></param>
		/// <returns></returns>
		public SSHAgentClient SetDigestType(SSHAgentAuthenticator.DigestType digestType)
		{
			if (CurrentAuthenticator is SSHAgentAuthenticator auth)
			{
				auth.SetDigestType(digestType);
			}

			return this;
		}

		/// <summary>
		/// Get the digest type
		/// </summary>
		/// <returns>DigestType</returns>
		public SSHAgentAuthenticator.DigestType GetDigestType()
		{
			if (CurrentAuthenticator is SSHAgentAuthenticator auth)
			{
				return auth.GetDigestType();
			}

			return SSHAgentAuthenticator.DigestType.SSH_RSA_SHA256;
		}



		/// <summary>
		/// Set the username
		/// </summary>
		/// <param name="username"></param>
		/// <returns>SSHAgentClient</returns>
		public SSHAgentClient SetUsername(String username)
		{
			if (CurrentAuthenticator is SSHAgentAuthenticator auth)
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
			if (CurrentAuthenticator is SSHAgentAuthenticator auth)
			{
				return auth.GetUsername();
			}

			return "";
		}
	}
}
