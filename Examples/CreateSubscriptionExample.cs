/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using MerchantAPI;

namespace MerchantAPICreateSubscriptionExample
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomerAddress address;
			CustomerPaymentCard paymentCard;
			SubscriptionShippingMethod method;
			Subscription subscription;

			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			var productCode = "MySubscriptionProduct";
			var productSubscriptionTerm = "MySubscriptionTermDescription";
			var customerLogin = "CustomerLogin";

			//
			// Load our subscribing customers addresses
			//

			var addressRequest = new CustomerAddressListLoadQueryRequest(client);

			addressRequest.SetCustomerLogin(customerLogin);

			var addressResponse = addressRequest.Send();

			if (!addressResponse.IsSuccess())
			{
				Console.WriteLine(String.Format("Error Loading Customer Addresses: {0}", addressResponse.GetErrorMessage()));
				return 0;
			}
			else if (addressResponse.GetTotalCount() == 0)
			{
				Console.WriteLine("Customer Addresses Not Found");
				return 0;
			}

			address = addressResponse.GetCustomerAddresses()[0];

			//
			// Register a payment card with CustmerPaymentCardRegisterRequest
			// Or load an existing card with CustomerPaymentCardListLoadQueryRequest
			// In this example we are going to register a payment card
			//

			var paymentCardRequest = new CustomerPaymentCardRegisterRequest(client);

			paymentCardRequest.SetCustomerLogin(customerLogin);
			paymentCardRequest.SetFirstName(address.GetFirstName());
			paymentCardRequest.SetLastName(address.GetLastName());
			paymentCardRequest.SetCardType("Visa");
			paymentCardRequest.SetCardNumber("4111111111111111");
			paymentCardRequest.SetExpirationMonth(08);
			paymentCardRequest.SetExpirationYear(2025);
			paymentCardRequest.SetAddress1(address.GetAddress1());
			paymentCardRequest.SetAddress2(address.GetAddress2());
			paymentCardRequest.SetCity(address.GetCity());
			paymentCardRequest.SetState(address.GetState());
			paymentCardRequest.SetZip(address.GetZip());
			paymentCardRequest.SetCountry(address.GetCountry());

			var paymentCardResponse = paymentCardRequest.Send();

			if (!paymentCardResponse.IsSuccess())
			{
				Console.WriteLine(String.Format("Error Registering Customer Payment Card: {0}", paymentCardResponse.GetErrorMessage()));
				return 0;
			}

			paymentCard = paymentCardResponse.GetCustomerPaymentCard();

			//
			// Find a valid shipping method
			//

			var methodRequest = new SubscriptionShippingMethodListLoadQueryRequest(client);

			methodRequest.SetProductCode(productCode);
			methodRequest.SetCustomerLogin(customerLogin);
			methodRequest.SetAddressId(address.GetId());
			methodRequest.SetPaymentCardId(paymentCard.GetId());
			methodRequest.SetQuantity(1);
			methodRequest.SetProductSubscriptionTermDescription(productSubscriptionTerm);

			var methodResponse = methodRequest.Send();

			if (!methodResponse.IsSuccess())
			{
				Console.WriteLine(String.Format("Error Loading Shipping Methods: {0}", methodResponse.GetErrorMessage()));
				return 0;
			}
			else if (methodResponse.GetTotalCount() == 0)
			{
				Console.WriteLine("Method Not Found");
				return 0;
			}

			method = methodResponse.GetSubscriptionShippingMethods()[0];

			//
			// Create the subscription
			//

			var request = new SubscriptionInsertRequest(client);

			request.SetProductCode(productCode);
			request.SetProductSubscriptionTermDescription(productSubscriptionTerm);
			request.SetCustomerLogin(customerLogin);
			request.SetCustomerAddressId(address.GetId());
			request.SetPaymentCardId(paymentCard.GetId());
			request.SetQuantity(1);
			request.SetShipId(method.GetModule().GetId());          // Supply the shipping module id
			request.SetShipData("MyShippingMethodData");            // Supply any required shipping data for this method
			request.SetNextDate(DateTime.Now);                      // Set the next charge date, in this case we are using today

			// If you have attributes, you can specify them here

			var attr1 = new SubscriptionAttribute();
			var attr2 = new SubscriptionAttribute();

			attr1.SetCode("attr1");
			attr1.SetValue("attr1val");

			attr2.SetCode("attr2");
			attr2.SetValue("attr2val");

			request.AddAttribute(attr1);
			request.AddAttribute(attr2);

			var response = request.Send();

			if (!response.IsSuccess())
			{
				Console.WriteLine(String.Format("Error Creating Subscription: {0}", response.GetErrorMessage()));
				return 0;
			}

			subscription = response.GetSubscription();

			Console.WriteLine(String.Format("Create Subscription ID: {0} For Customer {1} With Product {2} Term {3}",
				subscription.GetId(),
				customerLogin,
				productCode,
				productSubscriptionTerm));
		}
	}
}