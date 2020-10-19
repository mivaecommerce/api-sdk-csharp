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

