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
	/// <summary>
	/// Holds the current version of this release
	/// </summary>
	public static class Version
	{
		public const int VERSION_MAJOR = 2;

		public const int VERSION_MINOR = 0;

		public const int VERSION_PATCH = 1;

		new public static String ToString()
		{
			return String.Format( "v%d.%d.%d",
				Version.VERSION_MAJOR,
				Version.VERSION_MINOR,
				Version.VERSION_PATCH
			 );
		}
	}
}
