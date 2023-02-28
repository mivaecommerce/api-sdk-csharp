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
using System.Threading.Tasks;

namespace MerchantAPI
{
	/// <summary>
	/// Handles API Request PriceGroup_Insert.
	/// <see>https://docs.miva.com/json-api/functions/pricegroup_insert</see>
	/// </summary>
	[JsonConverter(typeof(RequestConverter))]
	public class PriceGroupInsertRequest : Request
	{
		/// Request field Name.
		[JsonPropertyName("Name")]
		public String Name { get; set; }

		/// Request field CustomerScope.
		[JsonPropertyName("CustomerScope")]
		public String CustomerScope { get; set; }

		/// Request field Rate.
		[JsonPropertyName("Rate")]
		public String Rate { get; set; }

		/// Request field Discount.
		[JsonPropertyName("Discount")]
		public float? Discount { get; set; }

		/// Request field Markup.
		[JsonPropertyName("Markup")]
		public float? Markup { get; set; }

		/// Request field Module_ID.
		[JsonPropertyName("Module_ID")]
		public int? ModuleId { get; set; }

		/// Request field Edit_Module.
		[JsonPropertyName("Edit_Module")]
		public String EditModule { get; set; }

		/// Request field Module_Code.
		[JsonPropertyName("Module_Code")]
		public String ModuleCode { get; set; }

		/// Request field Exclusion.
		[JsonPropertyName("Exclusion")]
		public bool? Exclusion { get; set; }

		/// Request field Description.
		[JsonPropertyName("Description")]
		public String Description { get; set; }

		/// Request field Display.
		[JsonPropertyName("Display")]
		public bool? Display { get; set; }

		/// Request field DateTime_Start.
		[JsonPropertyName("DateTime_Start")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? DateTimeStart { get; set; }

		/// Request field DateTime_End.
		[JsonPropertyName("DateTime_End")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? DateTimeEnd { get; set; }

		/// Request field Qualifying_Min_Subtotal.
		[JsonPropertyName("Qualifying_Min_Subtotal")]
		public float? QualifyingMinSubtotal { get; set; }

		/// Request field Qualifying_Max_Subtotal.
		[JsonPropertyName("Qualifying_Max_Subtotal")]
		public float? QualifyingMaxSubtotal { get; set; }

		/// Request field Qualifying_Min_Quantity.
		[JsonPropertyName("Qualifying_Min_Quantity")]
		public int? QualifyingMinQuantity { get; set; }

		/// Request field Qualifying_Max_Quantity.
		[JsonPropertyName("Qualifying_Max_Quantity")]
		public int? QualifyingMaxQuantity { get; set; }

		/// Request field Qualifying_Min_Weight.
		[JsonPropertyName("Qualifying_Min_Weight")]
		public float? QualifyingMinWeight { get; set; }

		/// Request field Qualifying_Max_Weight.
		[JsonPropertyName("Qualifying_Max_Weight")]
		public float? QualifyingMaxWeight { get; set; }

		/// Request field Basket_Min_Subtotal.
		[JsonPropertyName("Basket_Min_Subtotal")]
		public float? BasketMinSubtotal { get; set; }

		/// Request field Basket_Max_Subtotal.
		[JsonPropertyName("Basket_Max_Subtotal")]
		public float? BasketMaxSubtotal { get; set; }

		/// Request field Basket_Min_Quantity.
		[JsonPropertyName("Basket_Min_Quantity")]
		public int? BasketMinQuantity { get; set; }

		/// Request field Basket_Max_Quantity.
		[JsonPropertyName("Basket_Max_Quantity")]
		public int? BasketMaxQuantity { get; set; }

		/// Request field Basket_Min_Weight.
		[JsonPropertyName("Basket_Min_Weight")]
		public float? BasketMinWeight { get; set; }

		/// Request field Basket_Max_Weight.
		[JsonPropertyName("Basket_Max_Weight")]
		public float? BasketMaxWeight { get; set; }

		/// Request field Priority.
		[JsonPropertyName("Priority")]
		public int? Priority { get; set; }

		/// Request field Exclusions.
		[JsonPropertyName("Exclusions")]
		public List<PriceGroupExclusion> Exclusions { get; set; } = new List<PriceGroupExclusion>();

		/// User set request fields
		public Dictionary<String, IConvertible> ModuleFields { get; set; } = new Dictionary<String, IConvertible>();

		/// <summary>
		/// Request constructor.
		/// <param name="client">BaseClient</param>
		/// </summary>
		public PriceGroupInsertRequest(BaseClient client = null) :
			base(client)
		{
			Function = "PriceGroup_Insert";
		}

		/// <summary>
		/// Getter for Name.
		/// <returns>String</returns>
		/// </summary>
		public String GetName()
		{
			return Name;
		}

		/// <summary>
		/// Getter for CustomerScope.
		/// <returns>String</returns>
		/// </summary>
		public String GetCustomerScope()
		{
			return CustomerScope;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>PriceGroup.Eligibility?</returns>
		/// </summary>
		public PriceGroup.Eligibility? GetCustomerScopeConst()
		{
			return PriceGroup.EligibilityFromString(CustomerScope);
		}

		/// <summary>
		/// Getter for Rate.
		/// <returns>String</returns>
		/// </summary>
		public String GetRate()
		{
			return Rate;
		}

		/// <summary>
		/// Enum Getter for .
		/// <returns>PriceGroup.DiscountType?</returns>
		/// </summary>
		public PriceGroup.DiscountType? GetRateConst()
		{
			return PriceGroup.DiscountTypeFromString(Rate);
		}

		/// <summary>
		/// Getter for Discount.
		/// <returns>float</returns>
		/// </summary>
		public float? GetDiscount()
		{
			return Discount;
		}

		/// <summary>
		/// Getter for Markup.
		/// <returns>float</returns>
		/// </summary>
		public float? GetMarkup()
		{
			return Markup;
		}

		/// <summary>
		/// Getter for Module_ID.
		/// <returns>int</returns>
		/// </summary>
		public int? GetModuleId()
		{
			return ModuleId;
		}

		/// <summary>
		/// Getter for Edit_Module.
		/// <returns>String</returns>
		/// </summary>
		public String GetEditModule()
		{
			return EditModule;
		}

		/// <summary>
		/// Getter for Module_Code.
		/// <returns>String</returns>
		/// </summary>
		public String GetModuleCode()
		{
			return ModuleCode;
		}

		/// <summary>
		/// Getter for Exclusion.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetExclusion()
		{
			return Exclusion;
		}

		/// <summary>
		/// Getter for Description.
		/// <returns>String</returns>
		/// </summary>
		public String GetDescription()
		{
			return Description;
		}

		/// <summary>
		/// Getter for Display.
		/// <returns>bool</returns>
		/// </summary>
		public bool? GetDisplay()
		{
			return Display;
		}

		/// <summary>
		/// Getter for DateTime_Start.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime? GetDateTimeStart()
		{
			return DateTimeStart;
		}

		/// <summary>
		/// Getter for DateTime_End.
		/// <returns>DateTime</returns>
		/// </summary>
		public DateTime? GetDateTimeEnd()
		{
			return DateTimeEnd;
		}

		/// <summary>
		/// Getter for Qualifying_Min_Subtotal.
		/// <returns>float</returns>
		/// </summary>
		public float? GetQualifyingMinSubtotal()
		{
			return QualifyingMinSubtotal;
		}

		/// <summary>
		/// Getter for Qualifying_Max_Subtotal.
		/// <returns>float</returns>
		/// </summary>
		public float? GetQualifyingMaxSubtotal()
		{
			return QualifyingMaxSubtotal;
		}

		/// <summary>
		/// Getter for Qualifying_Min_Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int? GetQualifyingMinQuantity()
		{
			return QualifyingMinQuantity;
		}

		/// <summary>
		/// Getter for Qualifying_Max_Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int? GetQualifyingMaxQuantity()
		{
			return QualifyingMaxQuantity;
		}

		/// <summary>
		/// Getter for Qualifying_Min_Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetQualifyingMinWeight()
		{
			return QualifyingMinWeight;
		}

		/// <summary>
		/// Getter for Qualifying_Max_Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetQualifyingMaxWeight()
		{
			return QualifyingMaxWeight;
		}

		/// <summary>
		/// Getter for Basket_Min_Subtotal.
		/// <returns>float</returns>
		/// </summary>
		public float? GetBasketMinSubtotal()
		{
			return BasketMinSubtotal;
		}

		/// <summary>
		/// Getter for Basket_Max_Subtotal.
		/// <returns>float</returns>
		/// </summary>
		public float? GetBasketMaxSubtotal()
		{
			return BasketMaxSubtotal;
		}

		/// <summary>
		/// Getter for Basket_Min_Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBasketMinQuantity()
		{
			return BasketMinQuantity;
		}

		/// <summary>
		/// Getter for Basket_Max_Quantity.
		/// <returns>int</returns>
		/// </summary>
		public int? GetBasketMaxQuantity()
		{
			return BasketMaxQuantity;
		}

		/// <summary>
		/// Getter for Basket_Min_Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetBasketMinWeight()
		{
			return BasketMinWeight;
		}

		/// <summary>
		/// Getter for Basket_Max_Weight.
		/// <returns>float</returns>
		/// </summary>
		public float? GetBasketMaxWeight()
		{
			return BasketMaxWeight;
		}

		/// <summary>
		/// Getter for Priority.
		/// <returns>int</returns>
		/// </summary>
		public int? GetPriority()
		{
			return Priority;
		}

		/// <summary>
		/// Getter for Exclusions.
		/// <returns>List<PriceGroupExclusion></returns>
		/// </summary>
		public List<PriceGroupExclusion> GetExclusions()
		{
			return Exclusions;
		}

		/// <summary>
		///  Get user set request fields.
		/// <returns>Dictionary<String, IConvertible></returns>
		/// </summary>
		public Dictionary<String, IConvertible> GetModuleFields()
		{
			return ModuleFields;
		}

		/// <summary>
		/// Setter for Name.
		/// <param name="value">String</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetName(String value)
		{
			Name = value;
			return this;
		}

		/// <summary>
		/// Setter for CustomerScope.
		/// <param name="value">String</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetCustomerScope(String value)
		{
			CustomerScope = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">PriceGroup.Eligibility</param>
		/// <returns></returns>
		/// </summary>
		public PriceGroupInsertRequest SetCustomerScope(PriceGroup.Eligibility value)
		{
			CustomerScope = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Rate.
		/// <param name="value">String</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetRate(String value)
		{
			Rate = value;
			return this;
		}

		/// <summary>
		/// Setter for .
		/// <param name="value">PriceGroup.DiscountType</param>
		/// <returns></returns>
		/// </summary>
		public PriceGroupInsertRequest SetRate(PriceGroup.DiscountType value)
		{
			Rate = value.ToConstString();
			return this;
		}

		/// <summary>
		/// Setter for Discount.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetDiscount(float? value)
	   {
			Discount = value;
			return this;
		}

		/// <summary>
		/// Setter for Discount.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetDiscount(double? value)
	   {
			Discount = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Markup.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetMarkup(float? value)
	   {
			Markup = value;
			return this;
		}

		/// <summary>
		/// Setter for Markup.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetMarkup(double? value)
	   {
			Markup = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Module_ID.
		/// <param name="value">int</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetModuleId(int? value)
		{
			ModuleId = value;
			return this;
		}

		/// <summary>
		/// Setter for Edit_Module.
		/// <param name="value">String</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetEditModule(String value)
		{
			EditModule = value;
			return this;
		}

		/// <summary>
		/// Setter for Module_Code.
		/// <param name="value">String</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetModuleCode(String value)
		{
			ModuleCode = value;
			return this;
		}

		/// <summary>
		/// Setter for Exclusion.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetExclusion(bool? value)
		{
			Exclusion = value;
			return this;
		}

		/// <summary>
		/// Setter for Description.
		/// <param name="value">String</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetDescription(String value)
		{
			Description = value;
			return this;
		}

		/// <summary>
		/// Setter for Display.
		/// <param name="value">bool</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetDisplay(bool? value)
		{
			Display = value;
			return this;
		}

		/// <summary>
		/// Setter for DateTime_Start.
		/// <param name="value">DateTime</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetDateTimeStart(DateTime? value)
		{
			DateTimeStart = value;
			return this;
		}

		/// <summary>
		/// Setter for DateTime_Start using a unix timestamp.
		/// <param name="value">long</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetDateTimeStart(long? value)
		{
			if (!value.HasValue)
			{
				DateTimeStart = null;
				return this;
			}

			DateTimeStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value.Value));
			return this;
		}

		/// <summary>
		/// Setter for DateTime_End.
		/// <param name="value">DateTime</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetDateTimeEnd(DateTime? value)
		{
			DateTimeEnd = value;
			return this;
		}

		/// <summary>
		/// Setter for DateTime_End using a unix timestamp.
		/// <param name="value">long</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetDateTimeEnd(long? value)
		{
			if (!value.HasValue)
			{
				DateTimeEnd = null;
				return this;
			}

			DateTimeEnd = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromSeconds(value.Value));
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Min_Subtotal.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMinSubtotal(float? value)
	   {
			QualifyingMinSubtotal = value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Min_Subtotal.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMinSubtotal(double? value)
	   {
			QualifyingMinSubtotal = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Max_Subtotal.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMaxSubtotal(float? value)
	   {
			QualifyingMaxSubtotal = value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Max_Subtotal.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMaxSubtotal(double? value)
	   {
			QualifyingMaxSubtotal = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Min_Quantity.
		/// <param name="value">int</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetQualifyingMinQuantity(int? value)
		{
			QualifyingMinQuantity = value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Max_Quantity.
		/// <param name="value">int</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetQualifyingMaxQuantity(int? value)
		{
			QualifyingMaxQuantity = value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Min_Weight.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMinWeight(float? value)
	   {
			QualifyingMinWeight = value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Min_Weight.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMinWeight(double? value)
	   {
			QualifyingMinWeight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Max_Weight.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMaxWeight(float? value)
	   {
			QualifyingMaxWeight = value;
			return this;
		}

		/// <summary>
		/// Setter for Qualifying_Max_Weight.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetQualifyingMaxWeight(double? value)
	   {
			QualifyingMaxWeight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Min_Subtotal.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMinSubtotal(float? value)
	   {
			BasketMinSubtotal = value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Min_Subtotal.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMinSubtotal(double? value)
	   {
			BasketMinSubtotal = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Max_Subtotal.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMaxSubtotal(float? value)
	   {
			BasketMaxSubtotal = value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Max_Subtotal.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMaxSubtotal(double? value)
	   {
			BasketMaxSubtotal = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Min_Quantity.
		/// <param name="value">int</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetBasketMinQuantity(int? value)
		{
			BasketMinQuantity = value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Max_Quantity.
		/// <param name="value">int</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetBasketMaxQuantity(int? value)
		{
			BasketMaxQuantity = value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Min_Weight.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMinWeight(float? value)
	   {
			BasketMinWeight = value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Min_Weight.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMinWeight(double? value)
	   {
			BasketMinWeight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Max_Weight.
		/// <param name="value">float</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMaxWeight(float? value)
	   {
			BasketMaxWeight = value;
			return this;
		}

		/// <summary>
		/// Setter for Basket_Max_Weight.
		/// <param name="value">double</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
	   public PriceGroupInsertRequest SetBasketMaxWeight(double? value)
	   {
			BasketMaxWeight = (float?) value;
			return this;
		}

		/// <summary>
		/// Setter for Priority.
		/// <param name="value">int</param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetPriority(int? value)
		{
			Priority = value;
			return this;
		}
		/// <summary>
		/// Set user request data.
		/// <param name="name">String<String></param>
		/// <param name="value">IConvertible<String></param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest SetModuleField(String name, IConvertible value)
		{
			ModuleFields[name] = value;
			return this;
		}

		/// <summary>
		/// Add a PriceGroupExclusion.
		/// - priceGroupExclusion: PriceGroupExclusion
		/// - Returns: Self
		/// </summary>
		public PriceGroupInsertRequest AddPriceGroupExclusion(PriceGroupExclusion priceGroupExclusion)
		{
			Exclusions.Add(priceGroupExclusion);
			return this;
		}

		/// <summary>
		/// Add an array of PriceGroupExclusion.
		/// <param name="exclusions">List<PriceGroupExclusion></param>
		/// <returns>PriceGroupInsertRequest</returns>
		/// </summary>
		public PriceGroupInsertRequest AddExclusions(List<PriceGroupExclusion> exclusions)
		{
			foreach(PriceGroupExclusion e in exclusions)
			{
				Exclusions.Add(e);
			}

			return this;
		}

		/// <summary>
		/// Write to the JSON writer. Used during serialization with a requests associated converter.
		/// <param name="writer">Utf8JsonWriter</param>
		/// <param name="options">JsonSerializerOptions</param>
		/// </summary>
		override public void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			base.Write(writer, options);

			if (ModuleId.HasValue)
			{
				writer.WriteNumber("Module_ID", ModuleId.Value);
			}
			else if (EditModule != null && EditModule.Length > 0)
			{
				writer.WriteString("Edit_Module", EditModule);
			}
			else if (ModuleCode != null && ModuleCode.Length > 0)
			{
				writer.WriteString("Module_Code", ModuleCode);
			}

			if (Name != null && Name.Length > 0)
			{
				writer.WriteString("Name", Name);
			}

			if (CustomerScope != null && CustomerScope.Length > 0)
			{
				writer.WriteString("CustomerScope", CustomerScope);
			}

			if (Rate != null && Rate.Length > 0)
			{
				writer.WriteString("Rate", Rate);
			}

			if (Discount.HasValue)
			{
				writer.WriteNumber("Discount", Discount.Value);
			}

			if (Markup.HasValue)
			{
				writer.WriteNumber("Markup", Markup.Value);
			}

			if (Exclusion.HasValue)
			{
				writer.WriteBoolean("Exclusion", Exclusion.Value);
			}

			if (Description != null && Description.Length > 0)
			{
				writer.WriteString("Description", Description);
			}

			if (Display.HasValue)
			{
				writer.WriteBoolean("Display", Display.Value);
			}

			if (DateTimeStart.HasValue)
			{
				writer.WriteNumber("DateTime_Start", new DateTimeOffset(DateTimeStart.Value).ToUnixTimeSeconds());
			}

			if (DateTimeEnd.HasValue)
			{
				writer.WriteNumber("DateTime_End", new DateTimeOffset(DateTimeEnd.Value).ToUnixTimeSeconds());
			}

			if (QualifyingMinSubtotal.HasValue)
			{
				writer.WriteNumber("Qualifying_Min_Subtotal", QualifyingMinSubtotal.Value);
			}

			if (QualifyingMaxSubtotal.HasValue)
			{
				writer.WriteNumber("Qualifying_Max_Subtotal", QualifyingMaxSubtotal.Value);
			}

			if (QualifyingMinQuantity.HasValue)
			{
				writer.WriteNumber("Qualifying_Min_Quantity", QualifyingMinQuantity.Value);
			}

			if (QualifyingMaxQuantity.HasValue)
			{
				writer.WriteNumber("Qualifying_Max_Quantity", QualifyingMaxQuantity.Value);
			}

			if (QualifyingMinWeight.HasValue)
			{
				writer.WriteNumber("Qualifying_Min_Weight", QualifyingMinWeight.Value);
			}

			if (QualifyingMaxWeight.HasValue)
			{
				writer.WriteNumber("Qualifying_Max_Weight", QualifyingMaxWeight.Value);
			}

			if (BasketMinSubtotal.HasValue)
			{
				writer.WriteNumber("Basket_Min_Subtotal", BasketMinSubtotal.Value);
			}

			if (BasketMaxSubtotal.HasValue)
			{
				writer.WriteNumber("Basket_Max_Subtotal", BasketMaxSubtotal.Value);
			}

			if (BasketMinQuantity.HasValue)
			{
				writer.WriteNumber("Basket_Min_Quantity", BasketMinQuantity.Value);
			}

			if (BasketMaxQuantity.HasValue)
			{
				writer.WriteNumber("Basket_Max_Quantity", BasketMaxQuantity.Value);
			}

			if (BasketMinWeight.HasValue)
			{
				writer.WriteNumber("Basket_Min_Weight", BasketMinWeight.Value);
			}

			if (BasketMaxWeight.HasValue)
			{
				writer.WriteNumber("Basket_Max_Weight", BasketMaxWeight.Value);
			}

			if (Priority.HasValue)
			{
				writer.WriteNumber("Priority", Priority.Value);
			}

			if (Exclusions.Count > 0)
			{
				writer.WritePropertyName("Exclusions");
				JsonSerializer.Serialize(writer, this.Exclusions, options);
			}

			if (ModuleFields.Count > 0)
			{
				foreach(KeyValuePair<String, IConvertible> entry in ModuleFields)
				{
					if (Util.IsDecimal(entry.Value))
					{
						if (Util.IsFloat(entry.Value))
						{
							writer.WriteNumber(entry.Key, (float)entry.Value);
						}
						else
						{
							writer.WriteNumber(entry.Key, (double)entry.Value);
						}
					}
					else if (Util.IsNumeric(entry.Value))
					{
						writer.WriteNumber(entry.Key, (int)entry.Value);
					}
					else if (Util.IsBoolean(entry.Value))
					{
						writer.WriteBoolean(entry.Key, (bool)entry.Value);
					}
					else
					{
						writer.WriteString(entry.Key, entry.Value.ToString());
					}
				}
			}
		}

		/// <summary>
		/// This is used for MultiCall response resolution
		/// <returns>Type</returns>
		/// </summary>
		override public Response ReadResponse(ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<PriceGroupInsertResponse>(ref reader, options);
		}

		/// <summary>
		/// Send the request for a response, blocking
		/// <returns>PriceGroupInsertResponse</returns>
		/// </summary>
		public new PriceGroupInsertResponse Send()
		{
			return Client.SendRequestAsync<PriceGroupInsertRequest, PriceGroupInsertResponse>(this).Result;
		}

		/// <summary>
		/// Send the request for a response, async
		/// <returns>Task<PriceGroupInsertResponse></returns>
		/// </summary>
		public new async Task<PriceGroupInsertResponse> SendAsync()
		{
			if (Client == null) throw new MerchantAPIException("Client not assigned to request");

			return await Client.SendRequestAsync<PriceGroupInsertRequest, PriceGroupInsertResponse>(this);
		}
	}
}
