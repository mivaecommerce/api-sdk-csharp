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

namespace MerchantAPI
{
	abstract public class ListQueryRequest : Request
	{
		/// <summary>
		///  Enumeration of available sorting directions
		/// </summary>
		public enum SortDirection
		{
			ASC,
			DESC
		}

		///  The sort field to sort results by.
		public String Sort { get; set; }

		/// The filter expression instance to filter results with.
		public FilterExpression Filter { get; set; }

		virtual public String[] AvailableSearchFields { get; } = { };

		/// The available sort fields. Override this if needed.
		virtual public String[] AvailableSortFields { get; } = { };
		virtual public String[] AvailableOnDemandColumns { get; } = { };

		/// The set on demand columns for request.
		public List<String> OnDemandColumns { get; set; } = new List<String>();

		/// The available custom filters. Override this if needed.
		virtual public String[] AvailableCustomFilters { get; } = { };

		/// The set custom filters for request.
		public Dictionary<String, IConvertible> CustomFilters { get; set; } = new Dictionary<String, IConvertible>();

		/// The result offset to request.
		public int Offset { get; set; }

		/// The number of results to return back.
		public int Count { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="client"></param>
		public ListQueryRequest(BaseClient client = null) :
			base(client)
		{
			Filter = FilterExpression();
		}

		/// <summary>
		/// Get the count
		/// </summary>
		/// <returns></returns>
		public int GetCount()
		{
			return Count;
		}

		/// <summary>
		/// Set the count
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		public ListQueryRequest SetCount(int count)
		{
			Count = count;
			return this;
		}

		/// <summary>
		/// Get the offset
		/// </summary>
		/// <returns></returns>
		public int GetOffset()
		{
			return Offset;
		}

		/// <summary>
		/// Set the offset
		/// </summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		public ListQueryRequest SetOffset(int offset)
		{
			Offset = offset;
			return this;
		}

		/// <summary>
		/// Get the available search fields
		/// </summary>
		/// <returns></returns>
		public String[] GetAvailableSearchFields()
		{
			return AvailableSearchFields;
		}

		/// <summary>
		/// Get the available sort fields
		/// </summary>
		/// <returns></returns>
		public String[] GetAvailableSortFields()
		{
			return AvailableSortFields;
		}

		/// <summary>
		/// Get the available on demand columnds
		/// </summary>
		/// <returns></returns>
		public String[] GetAvailableOnDemandColumns()
		{
			return AvailableOnDemandColumns;
		}

		/// <summary>
		/// Get the on demand columnds to request
		/// </summary>
		/// <returns></returns>
		public List<String> GetOnDemandColumns()
		{
			return OnDemandColumns;
		}

		/// <summary>
		/// Add an on demand column to the request
		/// </summary>
		/// <param name="column"></param>
		/// <returns></returns>
		public ListQueryRequest AddOnDemandColumn(String column)
		{
			if (AvailableOnDemandColumns.Length > 0 && !column.Contains(":"))
			{
				if (!Array.Exists(AvailableOnDemandColumns, c => c == column))
				{
					throw new MerchantAPIException(String.Format("On demand column {0} does not exist. Available columns are {1}", column, String.Join(", ", AvailableOnDemandColumns)));
				}
			}

			OnDemandColumns.Add(column);
			return this;
		}

		/// <summary>
		/// Remove an on demand column from the request
		/// </summary>
		/// <param name="column"></param>
		/// <returns></returns>
		public ListQueryRequest RemoveOnDemandColumn(String column)
		{
			OnDemandColumns.Remove(column);
			return this;
		}

		/// <summary>
		/// Set the on demand columnds from a list of strings
		/// </summary>
		/// <param name="columns"></param>
		/// <returns></returns>
		public ListQueryRequest SetOnDemandColumns(List<String> columns)
		{
			OnDemandColumns.Clear();

			foreach(String column in columns)
			{
				AddOnDemandColumn(column);
			}

			return this;
		}

		/// <summary>
		/// Set the on demand columnds from an array of strings
		/// </summary>
		/// <param name="columns"></param>
		/// <returns></returns>
		public ListQueryRequest SetOnDemandColumns(String[] columns)
		{
			OnDemandColumns.Clear();

			foreach (String column in columns)
			{
				AddOnDemandColumn(column);
			}

			return this;
		}

		/// <summary>
		/// Get the available custom fields
		/// </summary>
		/// <returns></returns>
		public String[] GetAvailableCustomFilters()
		{
			return AvailableCustomFilters;
		}

		/// <summary>
		/// Get the set custom fields
		/// </summary>
		/// <returns></returns>
		public Dictionary<String, IConvertible> GetCustomFilters()
		{
			return CustomFilters;
		}

		/// <summary>
		/// Set a custom filter field value
		/// </summary>
		/// <param name="field"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public ListQueryRequest SetCustomFilter(String field, IConvertible value)
		{
			if (AvailableCustomFilters.Length > 0)
			{
				if (!Array.Exists(AvailableCustomFilters, f => f == field))
				{
					throw new MerchantAPIException(String.Format("Custom filter {0} does not exist. Available filters are {1}", field, String.Join(", ", AvailableCustomFilters)));
				}
			}

			CustomFilters[field] = value;

			return this;
		}

		/// <summary>
		/// Remove a custom filter from the request
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ListQueryRequest RemoveCustomFilter(String name)
		{
			CustomFilters.Remove(name);
			return this;
		}

		/// <summary>
		/// Set the sorting of the response
		/// </summary>
		/// <param name="field"></param>
		/// <param name="direction"></param>
		/// <returns></returns>
		public ListQueryRequest SetSort(String field, SortDirection direction = SortDirection.ASC)
		{
			if (AvailableSortFields.Length > 0)
			{
				if (!Array.Exists(AvailableSortFields, f => f == field))
				{
					throw new MerchantAPIException(String.Format("Sort field {0} does not exist. Available fields are {1}", field, String.Join(", ", AvailableSortFields)));
				}
			}

			if (direction == SortDirection.DESC)
			{
				if (!field.StartsWith("-"))
				{
					field = "-" + field;
				}
			}

			Sort = field;

			return this;
		}

		/// <summary>
		/// Set the filter expression instance
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		public ListQueryRequest SetFilter(FilterExpression filter)
		{
			Filter = filter;
			return this;
		}

		/// <summary>
		/// Get the filter expression instance
		/// </summary>
		/// <returns></returns>
		public FilterExpression GetFilter()
		{
			return Filter;
		}

		/// <summary>
		/// Create a new filter expression instance
		/// </summary>
		/// <returns></returns>
		public FilterExpression FilterExpression()
		{
			return new FilterExpression(this);
		}

		/// <summary>
		/// Writes the request data to the JSON serialzier
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="options"></param>
		public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
		{
			bool hasFilters = OnDemandColumns.Count > 0 || CustomFilters.Count > 0 || (Filter != null && Filter.Entries.Count > 0);
			base.Write(writer, options);

			writer.WriteNumber("Offset", Offset);
			writer.WriteNumber("Count", Count);

			if (Sort != null && Sort.Length > 0)
			{
				writer.WriteString("Sort", Sort);
			}

			if (hasFilters)
			{
				writer.WriteStartArray("Filter");
			}

			if (OnDemandColumns.Count > 0)
			{
				writer.WriteStartObject();

				writer.WriteString("name", "ondemandcolumns");

				writer.WritePropertyName("value");

				JsonSerializer.Serialize(writer, OnDemandColumns, options);

				writer.WriteEndObject();
			}

			if (CustomFilters.Count > 0)
			{
				foreach(KeyValuePair<String, IConvertible> entry in CustomFilters)
				{
					writer.WriteStartObject();
					writer.WriteString("name", entry.Key);
					writer.WritePropertyName("value");

					if (Util.IsDecimal(entry.Value))
					{
						if (Util.IsFloat(entry.Value))
						{
							writer.WriteNumberValue((float)entry.Value);
						}
						else
						{
							writer.WriteNumberValue((double)entry.Value);
						}
					}
					else if (Util.IsNumeric(entry.Value))
					{
						writer.WriteNumberValue((int)entry.Value);
					}
					else if (Util.IsBoolean(entry.Value))
					{
						writer.WriteBooleanValue((bool)entry.Value);
					}
					else
					{
						writer.WriteStringValue(entry.Value.ToString());
					}

					writer.WriteEndObject();
				}
			}

			if (Filter != null && Filter.Entries.Count > 0)
			{
				JsonSerializer.Serialize(writer, Filter, options);
			}

			if (hasFilters)
			{
				writer.WriteEndArray();
			}
		}
	}
}