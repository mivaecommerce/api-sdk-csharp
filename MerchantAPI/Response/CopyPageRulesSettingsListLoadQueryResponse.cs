/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// API Response for CopyPageRulesSettingsList_Load_Query.
	/// <see>https://docs.miva.com/json-api/functions/copypagerulessettingslist_load_query</see>
	/// </summary>
	public class CopyPageRulesSettingsListLoadQueryResponse : ListQueryResponse<CopyPageRulesSettings>
	{
		/// <summary>
		///  Constructor
		/// </summary>
		public CopyPageRulesSettingsListLoadQueryResponse() :
			base()
		{
		}
		/// <summary>
		///  Getter for copyPageRulesSettings.
		/// <returns>CopyPageRulesSettings[]</returns>
		/// </summary>
		public List<CopyPageRulesSettings> GetCopyPageRulesSettings()
		{
			return Data.Data;
		}
	}
}