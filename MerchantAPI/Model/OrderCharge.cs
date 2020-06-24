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
	public class OrderCharge : Model
	{
		/// <value>Property OrderId - int</value>
		[JsonPropertyName("order_id")]
		public int OrderId { get; set; }

		/// <value>Property ChargeId - int</value>
		[JsonPropertyName("charge_id")]
		public int ChargeId { get; set; }

		/// <value>Property ModuleId - int</value>
		[JsonPropertyName("module_id")]
		public int ModuleId { get; set; }

		/// <value>Property ChargeType - String</value>
		[JsonPropertyName("type")]
		public String ChargeType { get; set; }

		/// <value>Property Description - String</value>
		[JsonPropertyName("descrip")]
		public String Description { get; set; }

		/// <value>Property Amount - float</value>
		[JsonPropertyName("amount")]
		public float Amount { get; set; }

		/// <value>Property DisplayAmount - float</value>
		[JsonPropertyName("disp_amt")]
		public float DisplayAmount { get; set; }

		/// <value>Property TaxExempt - bool</value>
		[JsonPropertyName("tax_exempt")]
		public bool TaxExempt { get; set; }

		/// <summary>
		/// Getter for order_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetOrderId()
		{
			return OrderId;
		}

		/// <summary>
		/// Getter for charge_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetChargeId()
		{
			return ChargeId;
		}

		/// <summary>
		/// Getter for module_id.
		/// <returns>int</returns>
		/// </summary>
		public int GetModuleId()
		{
			return ModuleId;
		}

		/// <summary>
		/// Getter for type.
		/// <returns>String</returns>
		/// </summary>
		public String GetChargeType()
		{
			return ChargeType;
		}

		/// <summary>
		/// Getter for descrip.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for amount.
		/// <returns>float</returns>
		/// </summary>
		public float GetAmount()
		{
			return Amount;
		}

		/// <summary>
		/// Getter for disp_amt.
		/// <returns>float</returns>
		/// </summary>
		public float GetDisplayAmount()
		{
			return DisplayAmount;
		}

		/// <summary>
		/// Getter for tax_exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool GetTaxExempt()
		{
			return TaxExempt;
		}

		/// <summary>
		/// Setter for type.
		/// <param name="value">String</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
		public OrderCharge SetChargeType(String value)
		{
			ChargeType = value;
			return this;
		}

		/// <summary>
		/// Setter for descrip.
		/// <param name="value">String</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
		public OrderCharge SetDescription(String value)
		{
			Description = value;
			return this;
		}

		/// <summary>
		/// Setter for amount.
		/// <param name="value">float</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
	   public OrderCharge SetAmount(float value)
	   {
			Amount = value;
			return this;
		}

		/// <summary>
		/// Setter for amount.
		/// <param name="value">double</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
	   public OrderCharge SetAmount(double value)
	   {
			Amount = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for disp_amt.
		/// <param name="value">float</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
	   public OrderCharge SetDisplayAmount(float value)
	   {
			DisplayAmount = value;
			return this;
		}

		/// <summary>
		/// Setter for disp_amt.
		/// <param name="value">double</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
	   public OrderCharge SetDisplayAmount(double value)
	   {
			DisplayAmount = (float) value;
			return this;
		}

		/// <summary>
		/// Setter for tax_exempt.
		/// <param name="value">bool</param>
		/// <returns>OrderCharge</returns>
		/// </summary>
		public OrderCharge SetTaxExempt(bool value)
		{
			TaxExempt = value;
			return this;
		}
	}
}
