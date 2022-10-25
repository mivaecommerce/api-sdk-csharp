# Upgrade Guide from 2.1.0 to 2.2.0

Issue **MMAPI-62** added the inserted object into the response. ProductVariantInsertResponse has had its original response data moved and all calling code should be updated to reflect this change.

***Example usage from 2.1.x***

	ProductVariantInsertResponse response;
	response.GetProductId();
	response.GetVariantId();

***Should be updated to for 2.2.x***
	
	ProductVariantInsertResponse response;
	response.GetProductVariant().GetProductId();
	response.GetProductVariant().GetVariantId();

Issue **MMAPI-67** renamed some model fields and all calling code should be updated. Use the following list to rename all usage in your applications:

	CustomerSubscription.AddressDescrip 		-> CustomerSubscription.AddressDescription
	CustomerSubscription.AddressAdress 			-> CustomerSubscription.AddressAddress
	CustomerSubscription.AddressAddress_1		-> CustomerSubscription.AddressAddress1
	CustomerSubscription.AddressAddress_2		-> CustomerSubscription.AddressAddress2
	ProductAndSubscriptionTerm.TermDescrip		-> ProductAndSubscriptionTerm.TermDescription

# Upgrade Guide from 2.0.X to 2.1.0+

The class `TemplateVersionSettings` has been renamed to `VersionSettings`.

If you are utilizing this class within your code then you will need to be renamed in their type declarations. Usage has stayed the same.

# Upgrade Guide from 1.x to 2.x

## Usage of OrderItemOption

Usage of OrderItemOption will need to be updated to support the change to the member `Attribute` to `AttributeCode`.

Replace all usage of `OrderItemOption` models that call either `GetAttribute()` or `SetAttribute(String)` with `GetAttributeCode()` and `SetAttributeCode(String)`.

**Example usage from 1.x:**

    var itemOption = new OrderItemOption();
    itemOption.SetAttribute("code");

**Should be update for 2.x:**

    itemOption = new OrderItemOption();
    itemOption.SetAttributeCode("code");

**Example usage from 1.x:**

	var itemOption; // A OrderItemOption model loaded from an OrderListLoadQuery, for example
	itemOption.GetAttribute();

**Should be updated for 2.x:**

	var itemOption; // A OrderItemOption model loaded from an OrderListLoadQuery, for example
	itemOption.GetAttributeCode();
