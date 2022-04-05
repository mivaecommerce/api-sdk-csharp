/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MerchantAPI
{
	/// <summary>
	/// Used for building search filter expressions.
	/// <see>ListQueryRequest</see>
	/// </summary>
	[JsonConverter(typeof(FilterExpressionConverter))]
	public class FilterExpression
	{
		public enum SearchType
		{
			search,
			search_AND,
			search_OR
		}

		public enum SearchOperator
		{
			EQ, 		/// Operator Equals
			GT, 		/// Operator Greater Than
			GE, 		/// Operator Greater Than or Equal
			LT,			/// Operator Less Than
			LE,			/// Operator Less Than or Equal
			CO,			/// Operator Contains
			NC,			/// Operator Does Not Contain
			LIKE,		/// Operator Like
			NOTLIKE,	/// Operator Not Like
			NE,			/// Operator Not Equal
			TRUE,		/// Operator True
			FALSE,		/// Operator False
			NULL,		/// Operator Is Null
			IN,			/// Operator In Set (comma separated list)
			NOT_IN,		/// Operator Not In Set (comma separated list)
			SUBWHERE	/// Operator SUBWHERE
		}

		/// The request instance to get rules and fields from, optional
		public ListQueryRequest Request;

		/// The parent expression
		public FilterExpression Parent = null;

		/// Holds the expression entries
		public List<FilterExpressionEntry> Entries = new List<FilterExpressionEntry>();

		/// <summary>
		/// Constructor. Do not include a request to exclude constraints.
		/// </summary>
		/// <param name="request"></param>
		public FilterExpression(ListQueryRequest request = null)
		{
			Request = request;
		}

		/// <summary>
		/// Get the parent expression
		/// </summary>
		/// <returns></returns>
		public FilterExpression getParent()
		{
			return Parent;
		}

		/// <summary>
		/// Check if this expression is a parented
		/// </summary>
		/// <returns></returns>
		public bool IsChild()
		{
			return Parent != null;
		}

		/// <summary>
		/// Get the child depth
		/// </summary>
		/// <returns></returns>
		public int ChildDepth()
		{
			int depth = 0;
			var parent = Parent;

			while (parent != null)
			{
				depth++;
				parent = parent.Parent;
			}

			return depth;
		}

		/// <summary>
		/// Create a new expression instance
		/// </summary>
		/// <returns></returns>
		public FilterExpression Expr()
		{
			return new FilterExpression(Request);
		}

		/// <summary>
		/// Add an expression
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="op"></param>
		/// <param name="value"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public FilterExpression Add<T>(String field, SearchOperator op, T value, SearchType type) where T : IConvertible
		{
			if (Request != null && Request.AvailableSearchFields.Length > 0)
			{
				if (!Array.Exists(Request.AvailableSearchFields, f => f == field))
				{
					throw new MerchantAPIException(String.Format("Search field {0} does not exist. Available fields are {1}", field, String.Join(", ", Request.AvailableSearchFields)));
				}
			}

			if (this.Entries.Count == 0)
			{
				type = SearchType.search;
			}
			else if (this.Entries.Count > 0 && type == SearchType.search)
			{
				type = SearchType.search_OR;
			}

			this.Entries.Add(new FilterExpressionEntry(
				this,
				SearchType.search_AND,
				new FilterExpressionOperation(field, value.ToString(), op, type)
			));

			return this;
		}

		/// <summary>
		/// Add a sub AND expression
		/// </summary>
		/// <param name="expression"></param>
		/// <returns></returns>
		public FilterExpression AndX(FilterExpression expression)
		{
			expression.Parent = this;
			Entries.Add(new FilterExpressionEntry(this, SearchType.search_AND, expression));
			return this;
		}

		/// <summary>
		/// Add a sub OR expression
		/// </summary>
		/// <param name="expression"></param>
		/// <returns></returns>
		public FilterExpression OrX(FilterExpression expression)
		{
			expression.Parent = this;
			Entries.Add(new FilterExpressionEntry(this, SearchType.search_OR, expression));
			return this;
		}

		/// <summary>
		/// Add a EQUAl expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression Equal<T>(String field, T value) where T : IConvertible
		{
			return Add(field, SearchOperator.EQ, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndEqual<T>(String field, T value) where T : IConvertible
		{
			return Add(field, SearchOperator.EQ, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.EQ, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a GREATER THAN expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression GreaterThan<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.GT, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND GREATER THAN expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndGreaterThan<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.GT, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR GREATER THAN expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrGreaterThan<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.GT, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a OR GREATER THAN EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression GreaterThanEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.GE, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND GREATER THAN EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndGreaterThanEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.GE, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR GREATER THAN EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrGreaterThanEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.GE, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a LESS THAN expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression LessThan<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.LT, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND LESS THAN expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndLessThan<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.LT, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR LESS THAN expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrLessThan<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.LT, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a LESS THAN EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression LessThanEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.LE, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND LESS THAN EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndLessThanEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.LE, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR LESS THAN EQUAL expression of IConvertible type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrLessThanEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.LE, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a CONTAINS expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression Contains(String field, String value)
		{
			return this.Add(field, SearchOperator.CO, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND CONTAINS expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndContains(String field, String value)
		{
			return this.Add(field, SearchOperator.CO, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR CONTAINS expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrContains(String field, String value)
		{
			return this.Add(field, SearchOperator.CO, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a DOES NOT CONTAINS expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression DoesNotContain(String field, String value)
		{
			return this.Add(field, SearchOperator.NC, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND DOES NOT CONTAINS expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndDoesNotContain(String field, String value)
		{
			return this.Add(field, SearchOperator.NC, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR DOES NOT CONTAINS expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrDoesNotContain(String field, String value)
		{
			return this.Add(field, SearchOperator.NC, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a LIKE expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression Like(String field, String value)
		{
			return this.Add(field, SearchOperator.LIKE, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND LIKE expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndLike(String field, String value)
		{
			return this.Add(field, SearchOperator.LIKE, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR LIKE expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrLike(String field, String value)
		{
			return this.Add(field, SearchOperator.LIKE, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a NOT LIKE expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression NotLike(String field, String value)
		{
			return this.Add(field, SearchOperator.NOTLIKE, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND LIKE expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndNotLike(String field, String value)
		{
			return this.Add(field, SearchOperator.NOTLIKE, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR NOT LIKE expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrNotLike(String field, String value)
		{
			return this.Add(field, SearchOperator.NOTLIKE, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a NOT EQ expression
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression NotEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.NE, value, SearchType.search);
		}

		/// <summary>
		/// Add a AND NOT EQ expression
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression AndNotEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.NE, value, SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR NOT EQ expression
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FilterExpression OrNotEqual<T>(String field, T value) where T : IConvertible
		{
			return this.Add(field, SearchOperator.NE, value, SearchType.search_OR);
		}

		/// <summary>
		/// Add a IS TRUE expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression IsTrue(String field)
		{
			return this.Add(field, SearchOperator.TRUE, "", SearchType.search);
		}

		/// <summary>
		/// Add a AND IS TRUE expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression AndIsTrue(String field)
		{
			return this.Add(field, SearchOperator.TRUE, "", SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR IS TRUE expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression OrIsTrue(String field)
		{
			return this.Add(field, SearchOperator.TRUE, "", SearchType.search_OR);
		}

		/// <summary>
		/// Add a OR IS FALSE expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression IsFalse(String field)
		{
			return this.Add(field, SearchOperator.FALSE, "", SearchType.search);
		}

		/// <summary>
		/// Add a AND IS FALSE expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression AndIsFalse(String field)
		{
			return this.Add(field, SearchOperator.FALSE, "", SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR IS FALSE expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression orIsFalse(String field)
		{
			return this.Add(field, SearchOperator.FALSE, "", SearchType.search_OR);
		}

		/// <summary>
		/// Add a IS NULL expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression IsNull(String field)
		{
			return this.Add(field, SearchOperator.NULL, "", SearchType.search);
		}

		/// <summary>
		/// Add a AND IS NULL expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression andIsNull(String field)
		{
			return this.Add(field, SearchOperator.NULL, "", SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR IS NULL expression
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		public FilterExpression OrIsNull(String field)
		{
			return this.Add(field, SearchOperator.NULL, "", SearchType.search_OR);
		}

		/// <summary>
		/// Add a IS IN expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public FilterExpression IsIn<T>(String field, T[] values) where T : IConvertible
		{
			return this.Add(field, SearchOperator.IN, ConvertibleToStringList(values), SearchType.search);
		}

		/// <summary>
		/// Add a AND IS IN expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public FilterExpression AndIsIn<T>(String field, T[] values) where T : IConvertible
		{
			return this.Add(field, SearchOperator.IN, ConvertibleToStringList(values), SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR IS IN expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public FilterExpression OrIsIn<T>(String field, T[] values) where T : IConvertible
		{
			return this.Add(field, SearchOperator.IN, ConvertibleToStringList(values), SearchType.search_OR);
		}

		/// <summary>
		/// Add a IS NOT IN expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public FilterExpression IsNotIn<T>(String field, T[] values) where T : IConvertible
		{
			return this.Add(field, SearchOperator.NOT_IN, ConvertibleToStringList(values), SearchType.search);
		}

		/// <summary>
		/// Add a AND IS NOT IN expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public FilterExpression AndIsNotIn<T>(String field, T[] values) where T : IConvertible
		{
			return this.Add(field, SearchOperator.NOT_IN, ConvertibleToStringList(values), SearchType.search_AND);
		}

		/// <summary>
		/// Add a OR IS NOT IN expression
		/// </summary>
		/// <param name="field"></param>
		/// <param name="values"></param>
		/// <returns></returns>
		public FilterExpression OrIsNotIn<T>(String field, T[] values) where T : IConvertible
		{
			return this.Add(field, SearchOperator.NOT_IN, ConvertibleToStringList(values), SearchType.search);
		}

		/// <summary>
		/// Converts a IConvertible array to a string list for array values
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="invalues"></param>
		/// <returns></returns>
		protected String ConvertibleToStringList<T>(T[] invalues)
		{
			String result = "";

			foreach (T val in invalues)
			{
				if (result.Length == 0)
				{
					result += val.ToString();
				}
				else
				{
					result += ",";
					result += val.ToString();
				}
			}

			return result;
		}
	}

	/// <summary>
	/// Handles serializing a FilterExpression
	/// </summary>
	public class FilterExpressionConverter : BaseJsonConverter<FilterExpression>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(FilterExpression);
		}

		public override FilterExpression Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException("FilterExpression only supports serialization");
		}

		public override void Write(Utf8JsonWriter writer, FilterExpression value, JsonSerializerOptions options)
		{
			foreach(FilterExpressionEntry entry in value.Entries)
			{
				JsonSerializer.Serialize(writer, entry, options);
			}
		}
	}
}