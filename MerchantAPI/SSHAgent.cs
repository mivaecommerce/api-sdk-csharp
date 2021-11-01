using System;
using System.Net.Sockets;
using System.Buffers.Binary;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Net;

namespace MerchantAPI
{
	public enum AgentCommand : byte
	{
		SSH_AGENTC_REQUEST_IDENTITIES = 11,
		SSH_AGENTC_SIGN_REQUEST = 13
	};

	public enum AgentResponse : byte
	{
		SSH_AGENT_FAILURE = 5,
		SSH_AGENT_SUCCESS = 6,
		SSH_AGENT_IDENTITIES_ANSWER = 12,
		SSH_AGENT_SIGN_RESPONSE = 14
	};

	public enum AgentSignFlags
	{
		SSH_AGENT_RSA_SHA2_256 = 2,
		SSH_AGENT_RSA_SHA2_512 = 4
	};

	/// <summary>
	/// Handles connecting and signing data with the local agent socket.
	/// </summary>
	public class SSHAgentSignClient
	{
		public String SocketPath;

		public UnixEndPoint Endpoint;

		public Socket Connection;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="socketPath">Defaults to SSH_AUTH_SOCK environment variable</param>
		public SSHAgentSignClient(String socketPath = null)
		{
			if (socketPath != null && socketPath.Length > 0)
			{
				SocketPath = socketPath;
			}
			else
			{
				SocketPath = Environment.GetEnvironmentVariable("SSH_AUTH_SOCK");
			}

			Endpoint = new UnixEndPoint(SocketPath);
			Connection = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
		}

		/// <summary>
		/// Connects the socket to the endpoint
		/// </summary>
		public void Connect()
		{
			Connection.Connect(Endpoint);
		}

		/// <summary>
		/// Disconnects the socket
		/// </summary>
		public void Disconnect()
		{
			Connection.Disconnect(true);
		}

		/// <summary>
		/// Sends the SSHAgentRequest for a SSHAgentResponse
		/// </summary>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="request"></param>
		/// <returns></returns>
		public TResponse Send<TResponse>(SSHAgentRequest request)
			where TResponse : SSHAgentResponse
		{
			int received;
			byte[] data = request.Pack();
			byte[] merged = new byte[data.Length + sizeof(UInt32)];

			MemoryStream stream = new MemoryStream(merged, 0, data.Length + sizeof(UInt32), true, true);
			BinaryWriter writer = new BinaryWriter(stream);

			Span<byte> sendDataSize = new Span<byte>(new byte[sizeof(UInt32)]);

			BinaryPrimitives.WriteUInt32BigEndian(sendDataSize, (UInt32)data.Length);

			writer.Write(sendDataSize.ToArray());
			writer.Write(data);

			byte[] buf = stream.GetBuffer();

			int sent = Connection.Send(buf, SocketFlags.None);

			byte[] receiveDataSizeBuffer = new byte[sizeof(UInt32)];

			received = Connection.Receive(receiveDataSizeBuffer, sizeof(UInt32), SocketFlags.None);

			UInt32 receiveDataSize = BinaryPrimitives.ReadUInt32BigEndian(new ReadOnlySpan<byte>(receiveDataSizeBuffer));

			if (receiveDataSize <= 0)
			{
				throw new Exception("Received no data");
			}

			byte[] indata = new byte[receiveDataSize];

			received = Connection.Receive(indata, (int)receiveDataSize, SocketFlags.None);

			MemoryStream Stream = new MemoryStream(indata);
			BinaryReader Reader = new BinaryReader(Stream);

			return request.Unpack(Reader) as TResponse;
		}
	}

	/// <summary>
	/// Abstract agent request
	/// </summary>
	abstract public class SSHAgentRequest
	{
		abstract public byte[] Pack();

		abstract public SSHAgentResponse Unpack(BinaryReader Reader);
	}

	/// <summary>
	/// Abstract agent response
	/// </summary>
	abstract public class SSHAgentResponse
	{
		abstract public void Unpack(BinaryReader Reader);
	}

	/// <summary>
	/// Agent sign request
	/// </summary>
	public class SSHAgentSignRequest : SSHAgentRequest
	{
		public byte[] PublicKeyBlob;

		public byte[] SignData;

		public UInt32 AgentSignFlags = 0;

		public void SetSignFlags(UInt32 Flags)
		{
			AgentSignFlags = Flags;
		}

		public void SetPublicKey(String key)
		{
			SetPublicKey(System.Convert.FromBase64String(key));
		}

		public void SetPublicKey(byte[] key)
		{
			PublicKeyBlob = key;
		}

		public void SetSignData(String data)
		{
			SetSignData(Encoding.ASCII.GetBytes(data));
		}

		public void SetSignData(byte[] data)
		{
			SignData = data;
		}

		override public byte[] Pack()
		{
			int packetSize = (sizeof(UInt32) * 3) + sizeof(byte) + PublicKeyBlob.Length + SignData.Length;

			MemoryStream Stream = new MemoryStream(new byte[packetSize], 0, packetSize, true, true);
			BinaryWriter Writer = new BinaryWriter(Stream);

			Span<byte> PublicKeyBlobSize = new Span<byte>(new byte[4]);
			Span<byte> SignDataSize = new Span<byte>(new byte[sizeof(UInt32)]);
			Span<byte> Flags = new Span<byte>(new byte[sizeof(UInt32)]);

			BinaryPrimitives.WriteUInt32BigEndian(PublicKeyBlobSize, (UInt32)PublicKeyBlob.Length);
			BinaryPrimitives.WriteUInt32BigEndian(SignDataSize, (UInt32)SignData.Length);
			BinaryPrimitives.WriteUInt32BigEndian(Flags, AgentSignFlags);

			Writer.Write((byte)AgentCommand.SSH_AGENTC_SIGN_REQUEST);
			Writer.Write(PublicKeyBlobSize.ToArray());
			Writer.Write(PublicKeyBlob);
			Writer.Write(SignDataSize.ToArray());
			Writer.Write(SignData);
			Writer.Write(Flags.ToArray());

			return Stream.GetBuffer();
		}

		public override SSHAgentResponse Unpack(BinaryReader Reader)
		{
			var response = new SSHAgentSignResponse();

			response.Unpack(Reader);

			return response;
		}
	}

	/// <summary>
	/// Agent sign response
	/// </summary>
	public class SSHAgentSignResponse : SSHAgentResponse
	{
		public byte[] Signature;

		public String DigestType;

		public override void Unpack(BinaryReader reader)
		{
			byte response = reader.ReadByte();

			if (response != (byte)AgentResponse.SSH_AGENT_SIGN_RESPONSE)
			{
				throw new Exception("Invalid Response");
			}

			UInt32 totalSignatureSize = BitConverter.IsLittleEndian ?
				BinaryPrimitives.ReverseEndianness(reader.ReadUInt32()) : reader.ReadUInt32();

			UInt32 digestTypeLength = BitConverter.IsLittleEndian ?
				BinaryPrimitives.ReverseEndianness(reader.ReadUInt32()) : reader.ReadUInt32();

			DigestType = Encoding.ASCII.GetString(reader.ReadBytes((int)digestTypeLength));

			UInt32 signatureLength = BitConverter.IsLittleEndian ?
				BinaryPrimitives.ReverseEndianness(reader.ReadUInt32()) : reader.ReadUInt32();

			Signature = reader.ReadBytes((int)signatureLength);
		}
	}

	/// <summary>
	/// Requests available keys the agent has available for signing
	/// </summary>
	public class SSHAgentKeyListRequest : SSHAgentRequest
	{
		public override byte[] Pack()
		{
			byte[] packed = new byte[1];

			packed[0] = (byte)AgentCommand.SSH_AGENTC_REQUEST_IDENTITIES;

			return packed;
		}

		public override SSHAgentResponse Unpack(BinaryReader Reader)
		{
			var response = new SSHAgentKeyListResponse();

			response.Unpack(Reader);

			return response;
		}
	}

	/// <summary>
	/// Represents a key returned from the agent
	/// </summary>
	public class SSHAgentKey
	{
		public byte[] KeyBlob;

		public String Comment;

		public SSHAgentKey(byte[] keyBlob)
		{
			KeyBlob = keyBlob;
			Comment = "";
		}

		public SSHAgentKey(byte[] keyBlob, String comment)
		{
			KeyBlob = keyBlob;
			Comment = comment;
		}
	}

	/// <summary>
	/// Response of available keys the agent has available for signing
	/// </summary>
	public class SSHAgentKeyListResponse : SSHAgentResponse
	{
		public List<SSHAgentKey> Keys = new List<SSHAgentKey>();

		public override void Unpack(BinaryReader reader)
		{
			byte response = reader.ReadByte();

			if (response != (byte)AgentResponse.SSH_AGENT_IDENTITIES_ANSWER)
			{
				throw new Exception("Invalid Response");
			}

			UInt32 keyCount = BitConverter.IsLittleEndian ?
					BinaryPrimitives.ReverseEndianness(reader.ReadUInt32()) : reader.ReadUInt32();

			if (keyCount > 0)
			{
				for (int i = 0; i < keyCount; i++)
				{
					byte[] keyBlob;

					UInt32 keyBlobLength = BitConverter.IsLittleEndian ?
							BinaryPrimitives.ReverseEndianness(reader.ReadUInt32()) : reader.ReadUInt32();

					if (keyBlobLength <= 0) return;

					keyBlob = reader.ReadBytes((int)keyBlobLength);

					UInt32 commentLength = BitConverter.IsLittleEndian ?
							BinaryPrimitives.ReverseEndianness(reader.ReadUInt32()) : reader.ReadUInt32();

					if (commentLength > 0)
					{
						Keys.Add(new SSHAgentKey(keyBlob, Encoding.ASCII.GetString(reader.ReadBytes((int)commentLength))));
					}
					else
					{
						Keys.Add(new SSHAgentKey(keyBlob));
					}
				}
			}
		}
	}
}