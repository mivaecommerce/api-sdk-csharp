/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;

namespace MerchantAPI
{
	public class FilterExpressionOperation
	{
		/// The left side of the expression
		public String Left { get; set; }

		/// The right side of the expression
		public String Right { get; set; }

		/// The expression search operator
		public FilterExpression.SearchOperator Operator { get; set; }

		/// The expression search type
		public FilterExpression.SearchType Type { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="op"></param>
		/// <param name="type"></param>
		public FilterExpressionOperation(String left, String right, FilterExpression.SearchOperator op, FilterExpression.SearchType type)
		{
			Left = left;
			Right = right;
			Operator = op;
			Type = type;
		}
	}

	/// <summary>
	/// Used internally in FilterExpression
	/// </summary>
	public class FilterExpressionEntry
	{
		/// The owner of the entry
		public FilterExpression Parent { get; set; }

		/// The type of search
		public FilterExpression.SearchType Type { get; set; }

		// The operation details, for operation entries
		public FilterExpressionOperation Operation { get; set; }

		// The nested expression for expression entries
		public FilterExpression Expression { get; set; }

		/// <summary>
		/// Construct as an operation entry.
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="type"></param>
		/// <param name="operation"></param>
		public FilterExpressionEntry(FilterExpression parent, FilterExpression.SearchType type, FilterExpressionOperation operation)
		{
			Parent = parent;
			Type = type;
			Operation = operation;
			Expression = null;
		}

		/// <summary>
		/// Construct as a nested expression entry.
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="type"></param>
		/// <param name="expression"></param>
		public FilterExpressionEntry(FilterExpression parent, FilterExpression.SearchType type, FilterExpression expression)
		{
			Parent = parent;
			Type = type;
			Operation = null;
			Expression = expression;
		}
	}
}