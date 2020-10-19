using System;
using System.IO;

namespace MerchantAPI
{
	/// <summary>
	/// SSHAgentAuthenticator - Authenticates requests via SSH Private Key Signing via your local SSH Agent unix socket.
	/// </summary>
	public class SSHAgentAuthenticator : Authenticator
	{
		public enum DigestType
		{
			SSH_RSA_SHA256,
			SSH_RSA_SHA512
		};

		public String Username;

		public String PublicKey;

		public DigestType SignDigestType;

		public SSHAgentSignClient AgentClient;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="username">Your store username</param>
		/// <param name="publicKeyFilePath">The path to your public key file associated with your store user</param>
		/// <param name="agentSocketPath">Optional path to the SSH Agent socket. Defaults to environment variable value SSH_AUTH_SOCK </param>
		/// <param name="digestType">A DigestType constant</param>
		public SSHAgentAuthenticator(String username, String publicKeyFilePath, String agentSocketPath = "", DigestType digestType = DigestType.SSH_RSA_SHA256)
		{
			Username = username;			
			SignDigestType = digestType;
			AgentClient = new SSHAgentSignClient(agentSocketPath);

			if (publicKeyFilePath.Length > 0)
			{
				if (File.Exists(publicKeyFilePath))
				{
					SetPublicKeyFromFile(publicKeyFilePath);
				}
			}
		}

		/// <summary>
		/// Set the public key from a local file
		/// </summary>
		/// <param name="publicKeyFilePath"></param>
		public SSHAgentAuthenticator SetPublicKeyFromFile(String publicKeyFilePath)
		{
			String fileContents = File.ReadAllText(publicKeyFilePath);

			if (fileContents.Length > 0)
			{
				SetPublicKey(fileContents);
			}

			return this;
		}

		/// <summary>
		/// Set the public key from a string. This can be the contents of a public key file, or the base64 encoded blob.
		/// </summary>
		/// <param name="publicKey"></param>
		public SSHAgentAuthenticator SetPublicKey(String publicKey)
		{
			if (publicKey.Contains(" "))
			{
				String[] split = publicKey.Split(" ");

				if (split.Length >= 2)
				{
					PublicKey = split[1];
				}
			}
			else
			{
				PublicKey = publicKey;
			}

			return this;
		}

		/// <summary>
		/// Set the username
		/// </summary>
		/// <param name="newUsername"></param>
		/// <returns></returns>
		public SSHAgentAuthenticator SetUsername(String newUsername)
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
		public SSHAgentAuthenticator SetDigestType(DigestType newDigestType)
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
		public override string GenerateAuthenticationHeader(String data)
		{
			if (SignDigestType == DigestType.SSH_RSA_SHA256)
			{
				return String.Format("SSH-RSA-SHA2-256 {0}:{1}", System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Username)), SignData(data));
			}
			else if (SignDigestType == DigestType.SSH_RSA_SHA512)
			{
				return String.Format("SSH-RSA-SHA2-512 {0}:{1}", System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Username)), SignData(data));
			}

			throw new Exception("Invalid Digest Type");
		}

		/// <summary>
		/// Signs the given data
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public override String SignData(String data)
		{
			AgentClient.Connect();

			SSHAgentSignRequest signRequest = new SSHAgentSignRequest();

			signRequest.SetPublicKey(PublicKey);
			signRequest.SetSignData(data);

			if (SignDigestType == DigestType.SSH_RSA_SHA512)
			{
				signRequest.SetSignFlags((int)AgentSignFlags.SSH_AGENT_RSA_SHA2_512);
			}
			else
			{
				signRequest.SetSignFlags((int)AgentSignFlags.SSH_AGENT_RSA_SHA2_256);
			}

			SSHAgentSignResponse signResponse = AgentClient.Send<SSHAgentSignResponse>(signRequest);

			AgentClient.Disconnect();

			if (signResponse.Signature.Length > 0)
			{
				return System.Convert.ToBase64String(signResponse.Signature);
			}

			throw new Exception("Invalid Signature");
		}
	}
}
