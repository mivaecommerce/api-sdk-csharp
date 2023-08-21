/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MerchantAPI
{
	public class Store : Model
	{
		/// Enumeration CacheTypes
		public enum CacheTypes
		{
			CacheTypeNone,
			CacheTypeRedis,
		}

		/// <summary>
		/// Helper to convert enum to a valid string sent/received in from the API
		/// <returns>String</returns>
		/// </summary>
		public static String CacheTypesToString(CacheTypes value)
		{
			return value.ToConstString();
		}

		/// <summary>
		/// Helper to convert string to enum
		/// <returns>String</returns>
		/// </summary>
		public static CacheTypes? CacheTypesFromString(String value)
		{
			switch(value)
			{
				case "none": return CacheTypes.CacheTypeNone;
				case "redis": return CacheTypes.CacheTypeRedis;
				default: return null;
			}
		}

		/// <value>Property Id - int</value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <value>Property ManagerId - int</value>
		[JsonPropertyName("manager_id")]
		public int ManagerId { get; set; }

		/// <value>Property Code - String</value>
		[JsonPropertyName("code")]
		public String Code { get; set; }

		/// <value>Property License - String</value>
		[JsonPropertyName("license")]
		public String License { get; set; }

		/// <value>Property Name - String</value>
		[JsonPropertyName("name")]
		public String Name { get; set; }

		/// <value>Property Owner - String</value>
		[JsonPropertyName("owner")]
		public String Owner { get; set; }

		/// <value>Property Email - String</value>
		[JsonPropertyName("email")]
		public String Email { get; set; }

		/// <value>Property Company - String</value>
		[JsonPropertyName("company")]
		public String Company { get; set; }

		/// <value>Property Address - String</value>
		[JsonPropertyName("address")]
		public String Address { get; set; }

		/// <value>Property City - String</value>
		[JsonPropertyName("city")]
		public String City { get; set; }

		/// <value>Property State - String</value>
		[JsonPropertyName("state")]
		public String State { get; set; }

		/// <value>Property Zip - String</value>
		[JsonPropertyName("zip")]
		public String Zip { get; set; }

		/// <value>Property Phone - String</value>
		[JsonPropertyName("phone")]
		public String Phone { get; set; }

		/// <value>Property Fax - String</value>
		[JsonPropertyName("fax")]
		public String Fax { get; set; }

		/// <value>Property Country - String</value>
		[JsonPropertyName("country")]
		public String Country { get; set; }

		/// <value>Property WeightUnits - String</value>
		[JsonPropertyName("wtunits")]
		public String WeightUnits { get; set; }

		/// <value>Property WeightUnitCode - String</value>
		[JsonPropertyName("wtunitcode")]
		public String WeightUnitCode { get; set; }

		/// <value>Property DimensionUnits - String</value>
		[JsonPropertyName("dmunitcode")]
		public String DimensionUnits { get; set; }

		/// <value>Property BasketExpiration - int</value>
		[JsonPropertyName("baskexp")]
		public int BasketExpiration { get; set; }

		/// <value>Property PriceGroupOverlapResolution - String</value>
		[JsonPropertyName("pgrp_ovlp")]
		public String PriceGroupOverlapResolution { get; set; }

		/// <value>Property UserInterfaceId - int</value>
		[JsonPropertyName("ui_id")]
		public int UserInterfaceId { get; set; }

		/// <value>Property TaxId - int</value>
		[JsonPropertyName("tax_id")]
		public int TaxId { get; set; }

		/// <value>Property CurrencyId - int</value>
		[JsonPropertyName("currncy_id")]
		public int CurrencyId { get; set; }

		/// <value>Property MaintenanceWarningMessage - String</value>
		[JsonPropertyName("mnt_warn")]
		public String MaintenanceWarningMessage { get; set; }

		/// <value>Property MaintenanceClosedMessage - String</value>
		[JsonPropertyName("mnt_close")]
		public String MaintenanceClosedMessage { get; set; }

		/// <value>Property MaintenanceTime - int</value>
		[JsonPropertyName("mnt_time")]
		public int MaintenanceTime { get; set; }

		/// <value>Property MaintenanceNoNewCustomersBefore - int</value>
		[JsonPropertyName("mnt_no_new")]
		public int MaintenanceNoNewCustomersBefore { get; set; }

		/// <value>Property OrderMinimumQuantity - int</value>
		[JsonPropertyName("omin_quant")]
		public int OrderMinimumQuantity { get; set; }

		/// <value>Property OrderMinimumPrice - float</value>
		[JsonPropertyName("omin_price")]
		public float OrderMinimumPrice { get; set; }

		/// <value>Property OrderMinimumRequiredAll - bool</value>
		[JsonPropertyName("omin_all")]
		public bool OrderMinimumRequiredAll { get; set; }

		/// <value>Property OrderMinimumMessage - String</value>
		[JsonPropertyName("omin_msg")]
		public String OrderMinimumMessage { get; set; }

		/// <value>Property CryptId - int</value>
		[JsonPropertyName("crypt_id")]
		public int CryptId { get; set; }

		/// <value>Property RequireShipping - bool</value>
		[JsonPropertyName("req_ship")]
		public bool RequireShipping { get; set; }

		/// <value>Property RequireTax - bool</value>
		[JsonPropertyName("req_tax")]
		public bool RequireTax { get; set; }

		/// <value>Property RequireFreeOrderShipping - bool</value>
		[JsonPropertyName("req_frship")]
		public bool RequireFreeOrderShipping { get; set; }

		/// <value>Property ItemModuleUninstallable - bool</value>
		[JsonPropertyName("item_adel")]
		public bool ItemModuleUninstallable { get; set; }

		/// <value>Property CacheType - String</value>
		[JsonPropertyName("cache_type")]
		public String CacheType { get; set; }

		/// <value>Property RedisHost - String</value>
		[JsonPropertyName("redishost")]
		public String RedisHost { get; set; }

		/// <value>Property RedisPort - int</value>
		[JsonPropertyName("redisport")]
		public int RedisPort { get; set; }

		/// <value>Property RedisTimeout - int</value>
		[JsonPropertyName("redisto")]
		public int RedisTimeout { get; set; }

		/// <value>Property RedisExpiration - int</value>
		[JsonPropertyName("redisex")]
		public int RedisExpiration { get; set; }

		/// <value>Property BoxPackingId - int</value>
		[JsonPropertyName("boxpack_id")]
		public int BoxPackingId { get; set; }

		/// <value>Property AddressValidationId - int</value>
		[JsonPropertyName("addrval_id")]
		public int AddressValidationId { get; set; }

		/// <summary>
		/// Getter for id.
		/// <returns>int</returns>
		/// </summary>
		public int GetId()
		{
			return Id;
		}

		/// <summary>
		/// Getter for manager_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetManagerId()
		{
			return ManagerId;
		}

		/// <summary>
		/// Getter for code.
		/// <returns>String</returns>
		/// </summary>
		public String GetCode()
		{
			return Code;
		}

		/// <summary>
		/// Getter for license.
		/// <returns>String</returns>
		/// </summary>
		public String GetLicense()
		{
			return License;
		}

		/// <summary>
		/// Getter for name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for owner.
		/// <returns>String</returns>
		/// </summary>
		public String GetOwner()
		{
			return Owner;
		}

		/// <summary>
		/// Getter for email.
		/// <returns>String</returns>
		/// </summary>
		public String GetEmail()
		{
			return Email;
		}

		/// <summary>
		/// Getter for company.
		/// <returns>String</returns>
		/// </summary>
		public String GetCompany()
		{
			return Company;
		}

		/// <summary>
		/// Getter for address.
		/// <returns>String</returns>
		/// </summary>
		public String GetAddress()
		{
			return Address;
		}

		/// <summary>
		/// Getter for city.
		/// <returns>String</returns>
		/// </summary>
		public String GetCity()
		{
			return City;
		}

		/// <summary>
		/// Getter for state.
		/// <returns>String</returns>
		/// </summary>
		public String GetState()
		{
			return State;
		}

		/// <summary>
		/// Getter for zip.
		/// <returns>String</returns>
		/// </summary>
		public String GetZip()
		{
			return Zip;
		}

		/// <summary>
		/// Getter for phone.
		/// <returns>String</returns>
		/// </summary>
		public String GetPhone()
		{
			return Phone;
		}

		/// <summary>
		/// Getter for fax.
		/// <returns>String</returns>
		/// </summary>
		public String GetFax()
		{
			return Fax;
		}

		/// <summary>
		/// Getter for country.
		/// <returns>String</returns>
		/// </summary>
		public String GetCountry()
		{
			return Country;
		}

		/// <summary>
		/// Getter for wtunits.
		/// <returns>String</returns>
		/// </summary>
		public String GetWeightUnits()
		{
			return WeightUnits;
		}

		/// <summary>
		/// Getter for wtunitcode.
		/// <returns>String</returns>
		/// </summary>
		public String GetWeightUnitCode()
		{
			return WeightUnitCode;
		}

		/// <summary>
		/// Getter for dmunitcode.
		/// <returns>String</returns>
		/// </summary>
		public String GetDimensionUnits()
		{
			return DimensionUnits;
		}

		/// <summary>
		/// Getter for baskexp.
		/// <returns>int</returns>
		/// </summary>
		public int GetBasketExpiration()
		{
			return BasketExpiration;
		}

		/// <summary>
		/// Getter for pgrp_ovlp.
		/// <returns>String</returns>
		/// </summary>
		public String GetPriceGroupOverlapResolution()
		{
			return PriceGroupOverlapResolution;
		}

		/// <summary>
		/// Getter for ui_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetUserInterfaceId()
		{
			return UserInterfaceId;
		}

		/// <summary>
		/// Getter for tax_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetTaxId()
		{
			return TaxId;
		}

		/// <summary>
		/// Getter for currncy_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCurrencyId()
		{
			return CurrencyId;
		}

		/// <summary>
		/// Getter for mnt_warn.
		/// <returns>String</returns>
		/// </summary>
		public String GetMaintenanceWarningMessage()
		{
			return MaintenanceWarningMessage;
		}

		/// <summary>
		/// Getter for mnt_close.
		/// <returns>String</returns>
		/// </summary>
		public String GetMaintenanceClosedMessage()
		{
			return MaintenanceClosedMessage;
		}

		/// <summary>
		/// Getter for mnt_time.
		/// <returns>int</returns>
		/// </summary>
		public int GetMaintenanceTime()
		{
			return MaintenanceTime;
		}

		/// <summary>
		/// Getter for mnt_no_new.
		/// <returns>int</returns>
		/// </summary>
		public int GetMaintenanceNoNewCustomersBefore()
		{
			return MaintenanceNoNewCustomersBefore;
		}

		/// <summary>
		/// Getter for omin_quant.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderMinimumQuantity()
		{
			return OrderMinimumQuantity;
		}

		/// <summary>
		/// Getter for omin_price.
		/// <returns>float</returns>
		/// </summary>
		public float GetOrderMinimumPrice()
		{
			return OrderMinimumPrice;
		}

		/// <summary>
		/// Getter for omin_all.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetOrderMinimumRequiredAll()
		{
			return OrderMinimumRequiredAll;
		}

		/// <summary>
		/// Getter for omin_msg.
		/// <returns>String</returns>
		/// </summary>
		public String GetOrderMinimumMessage()
		{
			return OrderMinimumMessage;
		}

		/// <summary>
		/// Getter for crypt_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetCryptId()
		{
			return CryptId;
		}

		/// <summary>
		/// Getter for req_ship.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetRequireShipping()
		{
			return RequireShipping;
		}

		/// <summary>
		/// Getter for req_tax.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetRequireTax()
		{
			return RequireTax;
		}

		/// <summary>
		/// Getter for req_frship.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetRequireFreeOrderShipping()
		{
			return RequireFreeOrderShipping;
		}

		/// <summary>
		/// Getter for item_adel.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetItemModuleUninstallable()
		{
			return ItemModuleUninstallable;
		}

		/// <summary>
		/// Getter for cache_type.
		/// <returns>String</returns>
		/// </summary>
		public String GetCacheType()
		{
			return CacheType;
		}

		/// <summary>
		/// Enum Getter for cache_type.
		/// <returns>CacheTypes?</returns>
		/// </summary>
		public CacheTypes? GetCacheTypeConst()
		{
			return CacheTypesFromString(CacheType);
		}

		/// <summary>
		/// Getter for redishost.
		/// <returns>String</returns>
		/// </summary>
		public String GetRedisHost()
		{
			return RedisHost;
		}

		/// <summary>
		/// Getter for redisport.
		/// <returns>int</returns>
		/// </summary>
		public int GetRedisPort()
		{
			return RedisPort;
		}

		/// <summary>
		/// Getter for redisto.
		/// <returns>int</returns>
		/// </summary>
		public int GetRedisTimeout()
		{
			return RedisTimeout;
		}

		/// <summary>
		/// Getter for redisex.
		/// <returns>int</returns>
		/// </summary>
		public int GetRedisExpiration()
		{
			return RedisExpiration;
		}

		/// <summary>
		/// Getter for boxpack_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetBoxPackingId()
		{
			return BoxPackingId;
		}

		/// <summary>
		/// Getter for addrval_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetAddressValidationId()
		{
			return AddressValidationId;
		}
	}

	/// Enum Extensions
	public static class StoreExtensions
	{

		/// <summary>
		/// Extends enum to provide a ToConstString() method on a value
		/// <returns>String</returns>
		/// </summary>
	    public static String ToConstString(this Store.CacheTypes e)
	    {
			switch(e)
			{
				case Store.CacheTypes.CacheTypeNone: return "none";
				case Store.CacheTypes.CacheTypeRedis: return "redis";
			}
			return "";
		}
	}
}
