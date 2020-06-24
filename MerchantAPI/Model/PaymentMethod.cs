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
	public class PaymentMethod : Model
	{
		/// <value>Property ModuleId - int</value>
		[JsonPropertyName("module_id")]
		public int ModuleId { get; set; }

		/// <value>Property ModuleApi - float</value>
		[JsonPropertyName("module_api")]
		public float ModuleApi { get; set; }

		/// <value>Property MethodCode - String</value>
		[JsonPropertyName("method_code")]
		public String MethodCode { get; set; }

		/// <value>Property MethodName - String</value>
		[JsonPropertyName("method_name")]
		public String MethodName { get; set; }

		/// <value>Property Mivapay - bool</value>
		[JsonPropertyName("mivapay")]
		public bool Mivapay { get; set; }

		/// <value>Property PaymentCard - CustomerPaymentCard</value>
		[JsonPropertyName("paymentcard")]
		public CustomerPaymentCard PaymentCard { get; set; }

		/// <value>Property OrderPaymentCard - OrderPaymentCard</value>
		[JsonPropertyName("orderpaymentcard")]
		public OrderPaymentCard OrderPaymentCard { get; set; }

		/// <value>Property PaymentCardType - PaymentCardType</value>
		[JsonPropertyName("paymentcardtype")]
		public PaymentCardType PaymentCardType { get; set; }

		/// <summary>
		/// Getter for module_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetModuleId()
		{
			return ModuleId;
		}

		/// <summary>
		/// Getter for module_api.
		/// <returns>float</returns>
		/// </summary>
		public float GetModuleApi()
		{
			return ModuleApi;
		}

		/// <summary>
		/// Getter for method_code.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodCode()
		{
			return MethodCode;
		}

		/// <summary>
		/// Getter for method_name.
		/// <returns>String</returns>
		/// </summary>
		public String GetMethodName()
		{
			return MethodName;
		}

		/// <summary>
		/// Getter for mivapay.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetMivapay()
		{
			return Mivapay;
		}

		/// <summary>
		/// Getter for paymentcard.
		/// <returns>CustomerPaymentCard</returns>
		/// </summary>
		public CustomerPaymentCard GetPaymentCard()
		{
			return PaymentCard;
		}

		/// <summary>
		/// Getter for orderpaymentcard.
		/// <returns>OrderPaymentCard</returns>
		/// </summary>
		public OrderPaymentCard GetOrderPaymentCard()
		{
			return OrderPaymentCard;
		}

		/// <summary>
		/// Getter for paymentcardtype.
		/// <returns>PaymentCardType</returns>
		/// </summary>
		public PaymentCardType GetPaymentCardType()
		{
			return PaymentCardType;
		}
	}
}
