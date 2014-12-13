// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemCalculateRequest.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class Formula.
	/// </summary>
    public class Formula
    {
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

	/// <summary>
	/// Class Grouping.
	/// </summary>
    public class Grouping
    {
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

		/// <summary>
		/// Gets or sets the sub value.
		/// </summary>
		/// <value>The sub value.</value>
        [JsonProperty("sub_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SubValue { get; set; }
    }

	/// <summary>
	/// Class Filter.
	/// </summary>
    public class Filter
    {

		/// <summary>
		/// Gets or sets the key.
		/// </summary>
		/// <value>The key.</value>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

	/// <summary>
	/// Class ItemCalculateRequest.
	/// </summary>
    public class ItemCalculateRequest
    {
		/// <summary>
		/// Gets or sets the limit.
		/// </summary>
		/// <value>The limit.</value>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int Limit { get; set; }

		/// <summary>
		/// Gets or sets the aggregation.
		/// </summary>
		/// <value>The aggregation.</value>
        [JsonProperty("aggregation", NullValueHandling = NullValueHandling.Ignore)]
        public string Aggregation { get; set; }

		/// <summary>
		/// Gets or sets the formula.
		/// </summary>
		/// <value>The formula.</value>
        [JsonProperty("formula", NullValueHandling = NullValueHandling.Ignore)]
        public List<Formula> Formula { get; set; }

		/// <summary>
		/// Gets or sets the groupings.
		/// </summary>
		/// <value>The groupings.</value>
        [JsonProperty("groupings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Grouping> Groupings { get; set; }

		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		/// <value>The filters.</value>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Filter> Filters { get; set; }
    }
}
