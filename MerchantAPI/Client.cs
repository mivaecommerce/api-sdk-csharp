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
	/// <summary>
	/// Handles sending everything related to
	/// sending requests to the API
	/// </summary>
	public class Client : BaseClient
	{
		// Available signing types
		public enum ClientSignType
		{
			None,
			SHA1,
			SHA256
		};

		/// <summary>
		/// Constructor with defaults for request signing.
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// <param name="signingKey"></param>
		/// <param name="signType"></param>
		/// </summary>
		public Client(String endpoint, String apiToken, String signingKey, ClientSignType signType = ClientSignType.SHA256) :
			base(endpoint, new TokenAuthenticator(apiToken, signingKey, (TokenAuthenticator.DigestType)signType))
		{

		}

		/// <summary>
		/// Constructor with defaults for request signing with optional HttpClient when you already have an instance to use.
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// <param name="signingKey"></param>
		/// <param name="signType"></param>
		/// </summary>
		public Client(HttpClient httpClient, String endpoint, String apiToken, String signingKey, ClientSignType signType = ClientSignType.SHA256) :
			base(httpClient, endpoint, new TokenAuthenticator(apiToken, signingKey, (TokenAuthenticator.DigestType) signType))
		{

		}

		/// <summary>
		/// Constructor with defaults for no request signing.
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// </summary>
		public Client(String endpoint, String apiToken) :
			base(endpoint, new TokenAuthenticator(apiToken, "", TokenAuthenticator.DigestType.None))
		{

		}

		/// <summary>
		/// Constructor with defaults for no request signing with optional HttpClient when you already have an instance to use.
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// </summary>
		public Client(HttpClient httpClient, String endpoint, String apiToken) :
			base(httpClient, endpoint, new TokenAuthenticator(apiToken, "", TokenAuthenticator.DigestType.None))
		{

		}

		/// <summary>
		/// Constructor with a custom authenticator
		/// <param name="httpClient"></param>
		/// <param name="endpoint"></param>
		/// <param name="apiToken"></param>
		/// </summary>
		public Client(String endpoint, Authenticator authenticator) :
			base( endpoint, authenticator)
		{

		}

		public Client SetApiToken(String apiToken)
		{
			if (CurrentAuthenticator is TokenAuthenticator tokenauth)
			{
				tokenauth.SetApiToken(apiToken);
			}

			return this;
		}

		/// <summary>
		/// Decodes the Base64 signing key and stores the resulting data as a
		/// byte array
		/// <param name="base64Key">The base64 encoded key as a string</param>
		/// <returns>Client</returns>
		/// </summary>
		/// <exception cref="MerchantAPIException"></exception>
		public Client SetSigningKey(String base64Key)
		{
			if (CurrentAuthenticator is TokenAuthenticator tokenauth)
			{
				tokenauth.SetSigningKey(base64Key);
			}

			return this;
		}
	}
}
