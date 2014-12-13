// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="View.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class View.
	/// </summary>
    public class View
    {
		/// <summary>
		/// Gets or sets the view identifier.
		/// </summary>
		/// <value>The view identifier.</value>
        [JsonProperty("view_id")]
        public int viewId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the sort by.
		/// </summary>
		/// <value>The sort by.</value>
        [JsonProperty("sort_by")]
        public string SortBy { get; set; }

		/// <summary>
		/// Gets or sets the sort desc.
		/// </summary>
		/// <value>The sort desc.</value>
        [JsonProperty("sort_desc")]
        public string SortDesc { get; set; }

		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		/// <value>The filters.</value>
        [JsonProperty("filters")]
        public JArray Filters { get; set; }

		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
        [JsonProperty("fields")]
        public JObject Fields { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the layout.
		/// </summary>
		/// <value>The layout.</value>
        [JsonProperty("layout")]
        public string Layout { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights")]
        public string[] Rights { get; set; }

		/// <summary>
		/// Gets or sets the filter identifier.
		/// </summary>
		/// <value>The filter identifier.</value>
        [JsonProperty("filter_id")]
        public int FilterId { get; set; }

		/// <summary>
		/// Gets or sets the items.
		/// </summary>
		/// <value>The items.</value>
        [JsonProperty("items")]
        public int Items { get; set; }
    }
}
