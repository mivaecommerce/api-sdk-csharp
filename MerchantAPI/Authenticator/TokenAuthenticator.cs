using System;
using System.Security.Cryptography;
using System.Text;

namespace MerchantAPI
{
	/// <summary>
	/// TokenAuthenticator - Authenticates a request using an API token
	/// and optional (but default) HMAC signature
	/// </summary>
	public class TokenAuthenticator : Authenticator
	{
		public enum DigestType
		{
			None,
			SHA1,
			SHA256
		}

		// Property ApiToken - String
		public String ApiToken { get; set; }

		// Property SigningKey - byte[]
		public byte[] SigningKey { get; set; }

		public DigestType SignDigestType;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="apiToken">Your API Token</param>
		/// <param name="signingKey">Your signing key in base64 format</param>
		/// <param name="digestType">One of DigestType constants</param>
		public TokenAuthenticator(String apiToken, String signingKey, DigestType digestType)
		{
			ApiToken = apiToken;
			SignDigestType = digestType;
			SetSigningKey(signingKey);
		}

		/// <summary>
		/// Decodes the Base64 signing key and stores the resulting data as a
		/// byte array
		/// <param name="base64Key">The base64 encoded key as a string</param>
		/// <returns>Client</returns>
		/// </summary>
		/// <exception cref="MerchantAPIException"></exception>
		public TokenAuthenticator SetSigningKey(String base64Key)
		{
			if (base64Key.Length % 4 != 0)
			{
				base64Key = base64Key.PadRight(base64Key.Length + (4 - (base64Key.Length % 4)), '=');
			}

			try
			{
				SigningKey = System.Convert.FromBase64String(base64Key);
			}
			catch (Exception e)
			{
				throw new MerchantAPIException("Unable to decode signing key", e);
			}

			return this;
		}

		public byte[] GetSigningKey()
		{
			return SigningKey;
		}

		public TokenAuthenticator SetApiToken(String token)
		{
			ApiToken = token;
			return this;
		}

		public String GetApiToken()
		{
			return ApiToken;
		}

		public TokenAuthenticator SetDigestType(DigestType NewSigningDigestType)
		{
			SignDigestType = NewSigningDigestType;
			return this;
		}

		public DigestType GetDigestType()
		{
			return SignDigestType;
		}

		public override string GenerateAuthenticationHeader(string data)
		{
			if (SignDigestType == DigestType.SHA1)
			{
				return String.Format("MIVA-HMAC-SHA1 {0}:{1}", ApiToken, SignData(data));
			}
			else if (SignDigestType == DigestType.SHA256)
			{
				return String.Format("MIVA-HMAC-SHA256 {0}:{1}", ApiToken, SignData(data));
			}

			return String.Format("MIVA {0}", ApiToken);
		}

		public override string SignData(string data)
		{
			if (SignDigestType == DigestType.SHA256)
			{
				HMACSHA256 hmac = new HMACSHA256(SigningKey);
				return System.Convert.ToBase64String(hmac.ComputeHash(Encoding.ASCII.GetBytes(data)));
			}
			else if (SignDigestType == DigestType.SHA1)
			{
				HMACSHA1 hmac = new HMACSHA1(SigningKey);
				return System.Convert.ToBase64String(hmac.ComputeHash(Encoding.ASCII.GetBytes(data)));
			}

			throw new MerchantAPIException("Invalid Sign Type");
		}
	}
}
