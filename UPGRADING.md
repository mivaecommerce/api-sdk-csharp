
# Upgrade Guide to 2.5.0

## VariableValue

Issue **MMAPI-248** introduced changes to `VariableValue`, a model which was originally added to support deserialization of fields which are unknown type at runtime, specifically for use with the `VersionSettings` and `CustomFieldValues` models. It has been improved by working on a dynamic type internally and can now also be serialized as well as set with simple dynamic structures consisting of primitives, dictionaries, arrays, as well as nested values of those types for dictionaries and arrays.

Any code which uses `VariableValue`, `VersionSettings`, or `CustomFieldsValues` and calls now deprecated methods within VariableValue will need to be updated. 

Replace all calls to the following methods with `VariableValue.GetValue()` instead:

- VariableValue.GetValueDictionary
- VariableValue.GetValueArray
- VariableValue.GetValueConvertible

The new `GetValue()` method returns a dynamic type. You can utilize the following methods in `VariableValue` to determine the type of data the model is storing:

- VarableValue.IsConvertible() (Primitive value)
- VarableValue.IsDictionary()
- VarableValue.IsArray()

***Example usage from <= 2.4.x***

    var vv = VariableValue(); // value from somewhere
    if (vv.isDictionary()) {
    	var value = vv.getDictionaryValue();
    } else if (vv.isArray()) {
    	var value = vv.getArrayValue();
    } else {
    	var value - vv.GetConvertibleValue();
    }

***Example usage from 2.5.x***

    var vv = new VariableValue(); // value from somewhere
    var value = vv.GetValue();
    
    if (vv.IsDictionary())
    {
    	foreach (KeyValuePair<String, dynamic> kv in value)
    	{
    		// iterate it
    	}
    
    	// access it
    	var subProp = value["some_key"];
    }
    else if (vv.IsArray())
    {
    	foreach (var v in value)
    	{
    		// iterate it
    	}
    
    	// access it
    	var subProp = value[0];
    }
    else
    {
    	// value is primitive
    	var stringValue = vv.ToString();
    	var intValue = (int)value;
    }

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
