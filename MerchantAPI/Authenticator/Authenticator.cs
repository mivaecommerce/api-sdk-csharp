using System;
namespace MerchantAPI
{
	abstract public class Authenticator
	{
		abstract public String GenerateAuthenticationHeader(String data);

		abstract public String SignData(String data);
	}
}
