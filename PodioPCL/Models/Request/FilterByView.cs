// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FilterByView.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class FilterByView.
	/// </summary>
    public class FilterByView
    {
        /// <summary>
        /// The maximum number of items to return, defaults to 30
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int Limit { get; set; }

        /// <summary>
        /// The offset into the returned items, defaults to 0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int Offset { get; set; }

        /// <summary>
        /// True if the view should be remembered, false otherwise
        /// </summary>
        [JsonProperty("remember", NullValueHandling = NullValueHandling.Ignore)]
        public bool Remember { get; set; }
    }
}
