/*
 * This file is part of the MerchantAPI package.
 *
 * (c) Miva Inc <https://www.miva.com/>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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
	[JsonConverter(typeof(FilterExpressionEntryConverter))]
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
		public FilterExpressionEntry(FilterExpression parent, FilterExpression.SearchType type, FilterExpressionOperation operation )
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

	/// <summary>
	/// Handles serializing a FilterExpressionEntry
	/// </summary>
	public class FilterExpressionEntryConverter : BaseJsonConverter<FilterExpressionEntry>
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(FilterExpressionEntry);
		}

		public override FilterExpressionEntry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotImplementedException("FilterExpression only supports serialization");
		}

		public override void Write(Utf8JsonWriter writer, FilterExpressionEntry value, JsonSerializerOptions options)
		{
			if (value.Expression != null)
			{
				writer.WriteStartObject();

				writer.WriteString("name", value.Type.ToString());
				writer.WriteStartArray("value");

				foreach(FilterExpressionEntry e in value.Expression.Entries)
				{
					JsonSerializer.Serialize(writer, e);
				}

				writer.WriteEndArray();
				writer.WriteEndObject();
			}
			else if ( value.Operation != null)
			{
				if (value.Parent.IsChild())
				{
					writer.WriteStartObject();
					writer.WriteString("field", value.Type.ToString());
					writer.WriteString("operator", FilterExpression.SearchOperator.SUBWHERE.ToString());
					writer.WriteStartArray("value");
					writer.WriteStartObject();
					writer.WriteString("field", value.Operation.Left);
					writer.WriteString("operator", value.Operation.Operator.ToString());
					writer.WriteString("value", value.Operation.Right);
					writer.WriteEndObject();
					writer.WriteEndArray();
					writer.WriteEndObject();
				}
				else
				{
					writer.WriteStartObject();
					writer.WriteString("name", value.Operation.Type.ToString());
					writer.WriteStartArray("value");
					writer.WriteStartObject();
					writer.WriteString("field", value.Operation.Left);
					writer.WriteString("operator", value.Operation.Operator.ToString());
					writer.WriteString("value", value.Operation.Right);
					writer.WriteEndObject();
					writer.WriteEndArray();
					writer.WriteEndObject();
				}
			}
		}
	}
}