// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FilterBase.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class FilterBase.
	/// </summary>
    public class FilterBase
    {
        /// <summary>
        /// The sort order to use
        /// </summary>
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// True to sort descending, false otherwise
        /// </summary>
        [JsonProperty("sort_desc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SortDesc { get; set; }

        /// <summary>
        /// The filters to apply
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public Object Filters { get; set; }

        /// <summary>
        /// The maximum number of items to return
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// The offset into the returned items
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }
    }
}
