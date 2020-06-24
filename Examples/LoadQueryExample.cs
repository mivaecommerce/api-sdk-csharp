/*
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using MerchantAPI;

namespace MerchantAPILoadQueryExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client("https://www.mystore.com/mm5/json.mvc", "MY_API_TOKEN", "MY_SIGNING_KEY");
			client.DefaultStoreCode = "STORE_CODE";

			/// All Request objects which inherit from ListQueryRequest
			/// can utilize the FilterExpression class to fluently add
			/// search filters to the *List_Load_Query requests.
			/// @see ListQueryRequest
			/// @see FilterExpression

			var request = new ProductListLoadQueryRequest(client);

			/// Get the FilterExpression object for the request.
			/// This will enforce only adding search filters to
			/// defined fields in ProductListLoadQuery. Trying to
			/// filter against undefined fields throws an exception.
			/// @see ProductListLoadQueryRequest::availableSearchFields
			/// @see ProductListLoadQueryRequest::getAvailableSearchFields()
			/// @see FilterExpression

			var filters = request.GetFilter();

			/// Alternately, you can just create a FilterExpression object
			/// directly.
			///
			/// filters = new FilterExpression()
			///
			/// This will not enforce a requests available search fields.
			///
			/// var filters = FilterExpression(request: request)
			///
			/// This will enforce a requests available search fields.

			filters.Equal("code", "foo")
				.OrEqual("code", "bar");

			/// You can nest additional expressions to create
			/// more complex search queries:

			filters.OrX(
				filters.Expr()
					.Like("code", "BAZ%")
					.AndGreaterThan("price", 9.99)
			);

			/// This would result in a query along the lines of:
			///
			/// [...] WHERE code = "foo" OR code = "bar" OR ( code LIKE "BAZ%" AND price > 9.99 )

			/// You can get an array of available search fields for a ListQueryRequest
			var availableSearchFields = request.GetAvailableSearchFields();

			/// Some *List_Load_Query functions allow you to include additional data in the response
			/// by specifying additional on demand columns

			/// You can add a single column
			request.AddOnDemandColumn("column");

			/// You can set (and replace) an array columns
			request.SetOnDemandColumns(new string[] { "column", "column2", "column3"});

			/// You can get an array of supported columns from the Request
			var availableColumns = request.GetAvailableOnDemandColumns();

			/// You can set all supported on demand columns the request supports like this
			request.SetOnDemandColumns(request.GetAvailableOnDemandColumns());

			/// Lists which include Custom Fields (Product,Category,Order) you must explicitly specify
			/// the custom field module and code as an on demand column or using wildcards

			request.AddOnDemandColumn("CustomField_Values:*");							// Includes ALL custom fields
			request.AddOnDemandColumn("CustomField_Values:customfields:*");				// Includes all fields provided by the customfields module
			request.AddOnDemandColumn("CustomField_Values:customfields:MyFieldCode");	// includes only the MyFieldCode provided by the customfields module

			/* You can sort the result list by using  the setSort method on the Request */
			request.SetSort("field", ProductListLoadQueryRequest.SortDirection.ASC);

			/// Get an array of available sort fields
			var availableSortFields = request.GetAvailableSortFields();

			/// Some *List_Load_Query functions support custom filters specific to the request.
			/// You can add custom filters using the setCustomFilter method. The value type will
			/// vary for each custom field.

			// Send the request

			ProductListLoadQueryResponse response = request.Send();

			if (!response.IsSuccess())
			{
				Console.WriteLine("Error: {0}: {1}", response.GetErrorCode(), response.GetErrorMessage());
			}
			else
			{
				foreach (Product product in response.GetProducts())
				{
					Console.WriteLine("Product ID: {0} Code: {1} Name: {2}", product.GetId(), product.GetCode(), product.GetName());

					/// Custom Field Values can be accessed via the CustomFieldValues model object
					/// @see CustomFieldValues

					var myCustomField = product.GetCustomFieldValues().GetValue("MyFieldCode");

					var myModuleCustomField = product.GetCustomFieldValues().GetValue("MyModuleFieldCode", "MyModule");
				}
			}
		}
	}
}