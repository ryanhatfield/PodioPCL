// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FilterOptions.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class FilterOptions.
	/// </summary>
    public class FilterOptions: FilterBase
    {
        /// <summary>
        /// True if the view should be remembered, false otherwise
        /// </summary>
        [JsonProperty("remember", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Remember { get; set; }
    }
}
