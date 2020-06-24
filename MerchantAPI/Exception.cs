/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;

namespace MerchantAPI
{
	public class MerchantAPIException : Exception
	{
		public MerchantAPIException() : base()
		{
		}

		public MerchantAPIException(string message) : base(message)
		{

		}

		public MerchantAPIException(String message, Exception innerException) :
			base(message, innerException)
		{
		}
	}
}
