// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ExportFilter.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class ExportFilter.
	/// </summary>
    public class ExportFilter: FilterBase
    {
        /// <summary>
        /// The id of the view to use, 0 means last used view, blank means no view
        /// </summary>
        [JsonProperty("view_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ViewId { get; set; }
    }
}
