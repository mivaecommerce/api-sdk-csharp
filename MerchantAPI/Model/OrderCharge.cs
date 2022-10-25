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
using System.Text.Json;

namespace MerchantAPI
{
	[JsonConverter(typeof(OrderChargeConverter))]
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
		public float? Amount { get; set; }

		/// <value>Property FormattedAmount - String</value>
		[JsonPropertyName("formatted_amount")]
		public String FormattedAmount { get; set; }

		/// <value>Property DisplayAmount - float</value>
		[JsonPropertyName("disp_amt")]
		public float? DisplayAmount { get; set; }

		/// <value>Property FormattedDisplayAmount - String</value>
		[JsonPropertyName("formatted_disp_amt")]
		public String FormattedDisplayAmount { get; set; }

		/// <value>Property TaxExempt - bool</value>
		[JsonPropertyName("tax_exempt")]
		public bool? TaxExempt { get; set; }

		/// <value>Property Tax - float</value>
		[JsonPropertyName("tax")]
		public float Tax { get; set; }

		/// <value>Property FormattedTax - String</value>
		[JsonPropertyName("formatted_tax")]
		public String FormattedTax { get; set; }

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
		public float? GetAmount()
		{
			return Amount;
		}

		/// <summary>
		/// Getter for formatted_amount.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedAmount()
		{
			return FormattedAmount;
		}

		/// <summary>
		/// Getter for disp_amt.
		/// <returns>float</returns>
		/// </summary>
		public float? GetDisplayAmount()
		{
			return DisplayAmount;
		}

		/// <summary>
		/// Getter for formatted_disp_amt.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedDisplayAmount()
		{
			return FormattedDisplayAmount;
		}

		/// <summary>
		/// Getter for tax_exempt.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetTaxExempt()
		{
			return TaxExempt;
		}

		/// <summary>
		/// Getter for tax.
		/// <returns>float</returns>
		/// </summary>
		public float GetTax()
		{
			return Tax;
		}

		/// <summary>
		/// Getter for formatted_tax.
		/// <returns>String</returns>
		/// </summary>
		public String GetFormattedTax()
		{
			return FormattedTax;
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

	/// <summary>
	/// Converter for model OrderCharge
	/// </summary>
	public class OrderChargeConverter : BaseJsonConverter<OrderCharge>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(OrderCharge) || typeToConvert.IsSubclassOf(typeof(OrderCharge));
		}

		public override OrderCharge Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			OrderCharge value = new OrderCharge();

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new MerchantAPIException(String.Format("Expected start of object but got {0}", reader.TokenType));
			}

			while(reader.Read())
			{
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return value;
					}

					throw new MerchantAPIException(String.Format("Expected property name but got {0}", reader.TokenType));
				}

				String property = reader.GetString();

				if (String.Equals(property, "order_id", StringComparison.OrdinalIgnoreCase))
				{
					value.OrderId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "charge_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ChargeId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "module_id", StringComparison.OrdinalIgnoreCase))
				{
					value.ModuleId = ReadNextInteger(ref reader, options);
				}
				else if (String.Equals(property, "type", StringComparison.OrdinalIgnoreCase))
				{
					value.ChargeType = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "descrip", StringComparison.OrdinalIgnoreCase))
				{
					value.Description = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "amount", StringComparison.OrdinalIgnoreCase))
				{
					value.Amount = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_amount", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedAmount = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "disp_amt", StringComparison.OrdinalIgnoreCase))
				{
					value.DisplayAmount = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_disp_amt", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedDisplayAmount = ReadNextString(ref reader, options);
				}
				else if (String.Equals(property, "tax_exempt", StringComparison.OrdinalIgnoreCase))
				{
					value.TaxExempt = ReadNextBoolean(ref reader, options);
				}
				else if (String.Equals(property, "tax", StringComparison.OrdinalIgnoreCase))
				{
					value.Tax = ReadNextFloat(ref reader, options);
				}
				else if (String.Equals(property, "formatted_tax", StringComparison.OrdinalIgnoreCase))
				{
					value.FormattedTax = ReadNextString(ref reader, options);
				}
			}

			return value;
		}

		public override void Write(Utf8JsonWriter writer, OrderCharge value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value.ChargeType != null && value.ChargeType.Length > 0)
			{
				writer.WriteString("type", value.ChargeType);
			}

			if (value.Description != null && value.Description.Length > 0)
			{
				writer.WriteString("descrip", value.Description);
			}

			if (value.Amount.HasValue)
			{
				writer.WriteNumber("amount", value.Amount.Value);
			}

			if (value.DisplayAmount.HasValue)
			{
				writer.WriteNumber("disp_amt", value.DisplayAmount.Value);
			}

			if (value.TaxExempt.HasValue)
			{
				writer.WriteBoolean("tax_exempt", value.TaxExempt.Value);
			}

			writer.WriteEndObject();
		}
	}
}
