using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MerchantAPI
{
	/// <summary>
	/// SSHPrivateKeyAuthenticator - Authenticates requests via SSH Private Key Signing using a specified private key.
	/// </summary>
	public class SSHPrivateKeyAuthenticator : Authenticator
	{
		// Sign digest types
		public enum DigestType
		{
			SSH_RSA_SHA256,
			SSH_RSA_SHA512
		};

		// Private key import types
		public enum KeyType
		{
			PKCS1,
			PKCS8,
			PKCS12
		};

		// Store username
		public String Username;

		// RSA instance
		public RSA PrivateKey;

		// Sign digest type
		public DigestType SignDigestType;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="username"></param>
		/// <param name="privateKeyPath"></param>
		/// <param name="password"></param>
		/// <param name="keyType"></param>
		/// <param name="digestType"></param>
		public SSHPrivateKeyAuthenticator(String username, String privateKeyPath, String password, KeyType keyType = KeyType.PKCS1, DigestType digestType = DigestType.SSH_RSA_SHA256)
		{
			Username = username;
			SignDigestType = digestType;

			if (privateKeyPath.Length > 0)
			{
				SetPrivateKey(privateKeyPath, password, keyType);
			}
		}

		/// <summary>
		/// Constructor with pre loaded x509
		/// </summary>
		/// <param name="username"></param>
		/// <param name="X509"></param>
		/// <param name="digestType"></param>
		public SSHPrivateKeyAuthenticator(String username, X509Certificate2 X509, DigestType digestType = DigestType.SSH_RSA_SHA256)
		{
			Username = username;
			PrivateKey = X509.GetRSAPrivateKey();
			SignDigestType = digestType;
		}

		/// <summary>
		/// Constructor with pre loaded private key
		/// </summary>
		/// <param name="username"></param>
		/// <param name="privateKey"></param>
		/// <param name="digestType"></param>
		public SSHPrivateKeyAuthenticator(String username, RSA privateKey, DigestType digestType = DigestType.SSH_RSA_SHA256)
		{
			Username = username;
			PrivateKey = privateKey;
			SignDigestType = digestType;
		}

		/// <summary>
		/// Set the private key by file
		/// </summary>
		/// <param name="x509Path"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public SSHPrivateKeyAuthenticator SetPrivateKey(String filePath, String password, KeyType keyType)
		{
			if (keyType == KeyType.PKCS12)
			{
				SetPrivateKey_PKCS12(filePath, password);
			}
			else if (keyType == KeyType.PKCS8)
			{
				SetPrivateKey_PKCS8(filePath, password);
			}
			else if (keyType == KeyType.PKCS1)
			{
				SetPrivateKey_PKCS1(filePath);
			}
			else
			{
				throw new Exception("Invalid Key Type");
			}

			return this;
		}

		/// <summary>
		/// Set the private key from a pkcs12 file
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public SSHPrivateKeyAuthenticator SetPrivateKey_PKCS12(String filePath, String password)
		{
			X509Certificate2 cert = new X509Certificate2(filePath, password, X509KeyStorageFlags.DefaultKeySet);
			PrivateKey = cert.GetRSAPrivateKey();
			return this;
		}

		/// <summary>
		/// Sethte private key from a pkcs1 file
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		public SSHPrivateKeyAuthenticator SetPrivateKey_PKCS1(String filePath)
		{
#if NET472
			throw new Exception("PKCS1 SSH Private Key authentication is not supported in .NET 472");
#else
			String[] fileLines = File.ReadAllLines(filePath);
			String keyBase64 = "";
			int keyBytesRead = 0;

			if (fileLines.Length <= 0)
			{
				throw new Exception("Invalid PCKS1 Format. File is empty");
			}
			else if (fileLines[0] != "-----BEGIN RSA PRIVATE KEY-----")
			{
				throw new Exception("Invalid PCKS1 Format. Expected header: BEGIN RSA PRIVATE KEY");
			}
			else if (fileLines[fileLines.Length - 1] != "-----END RSA PRIVATE KEY-----")
			{
				throw new Exception("Invalid PCKS1 Format. Expected footer: END RSA PRIVATE KEY");
			}

			for (var i = 1; i < fileLines.Length - 1; i++)
			{
				keyBase64 = keyBase64 + fileLines[i];
			}

			ReadOnlySpan<byte> keyBytes = new ReadOnlySpan<byte>(System.Convert.FromBase64String(keyBase64));

			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

			RSA.ImportRSAPrivateKey(keyBytes, out keyBytesRead);

			PrivateKey = RSA;
#endif
			return this;
		}

		/// <summary>
		/// Set the private key from a pkcs8 file
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public SSHPrivateKeyAuthenticator SetPrivateKey_PKCS8(String filePath, String password)
		{
#if NET472
			throw new Exception("PKCS8 SSH Private Key authentication is not supported in .NET 472");
#else
			String[] fileLines = File.ReadAllLines(filePath);
			String keyBase64 = "";
			int keyBytesRead = 0;
			bool encrypted = false;

			if (fileLines.Length <= 0)
			{
				throw new Exception("Invalid PCKS8 Format. File is empty");
			}
			else if (fileLines[0] != "-----BEGIN ENCRYPTED PRIVATE KEY-----" && fileLines[0] != "-----BEGIN PRIVATE KEY-----")
			{
				throw new Exception("Invalid PCKS8 Format. Expected header: BEGIN ENCRYPTED PRIVATE KEY or BEGIN PRIVATE KEY");
			}
			else if (fileLines[fileLines.Length - 1] != "-----END ENCRYPTED PRIVATE KEY-----" && fileLines[fileLines.Length - 1] != "-----END PRIVATE KEY-----")
			{
				throw new Exception("Invalid PCKS8 Format. Expected footer: END ENCRYPTED PRIVATE KEY or END PRIVATE KEY");
			}

			encrypted = fileLines[0] == "-----BEGIN ENCRYPTED PRIVATE KEY-----";

			for (var i = 1; i < fileLines.Length - 1; i++)
			{
				keyBase64 = keyBase64 + fileLines[i];
			}

			ReadOnlySpan<byte> keyBytes = new ReadOnlySpan<byte>(System.Convert.FromBase64String(keyBase64));
			ReadOnlySpan<byte> passwordBytes = new ReadOnlySpan<byte>(Encoding.ASCII.GetBytes(password));

			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

			if (encrypted)
			{
				RSA.ImportEncryptedPkcs8PrivateKey(passwordBytes, keyBytes, out keyBytesRead);
			}
			else
			{
				RSA.ImportPkcs8PrivateKey(keyBytes, out keyBytesRead);				
			}

			PrivateKey = RSA;
#endif
			return this;
		}

		/// <summary>
		/// Set the username
		/// </summary>
		/// <param name="newUsername"></param>
		/// <returns></returns>
		public SSHPrivateKeyAuthenticator SetUsername(String newUsername)
		{
			Username = newUsername;
			return this;
		}

		/// <summary>
		/// Get the username
		/// </summary>
		/// <returns></returns>
		public String GetUsername()
		{
			return Username;
		}

		/// <summary>
		/// Set the digest type
		/// </summary>
		/// <param name="newDigestType"></param>
		/// <returns></returns>
		public SSHPrivateKeyAuthenticator SetDigestType(DigestType newDigestType)
		{
			SignDigestType = newDigestType;
			return this;
		}

		/// <summary>
		/// Get the digest type
		/// </summary>
		/// <returns></returns>
		public DigestType GetDigestType()
		{
			return SignDigestType;
		}

		/// <summary>
		/// Generates an authentication header value
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public override string GenerateAuthenticationHeader(string data)
		{
			if (SignDigestType == DigestType.SSH_RSA_SHA256)
			{
				return String.Format("SSH-RSA-SHA2-256 {0}:{1}", System.Convert.ToBase64String(Encoding.ASCII.GetBytes(Username)), SignData(data));
			}
			else if(SignDigestType == DigestType.SSH_RSA_SHA512)
			{
				return String.Format("SSH-RSA-SHA2-512 {0}:{1}", System.Convert.ToBase64String(Encoding.ASCII.GetBytes(Username)), SignData(data));
			}

			throw new Exception("Invalid Digest Type");
		}

		/// <summary>
		/// Signs the given data
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public override string SignData(string data)
		{
			HashAlgorithmName HashAlgo = HashAlgorithmName.SHA256;

			if (SignDigestType == DigestType.SSH_RSA_SHA512)
			{
				HashAlgo = HashAlgorithmName.SHA512;
			}

			byte[] bytes = Encoding.ASCII.GetBytes(data);

			return System.Convert.ToBase64String(PrivateKey.SignData(bytes, 0, bytes.Length, HashAlgo, RSASignaturePadding.Pkcs1));
		}
	}
}

