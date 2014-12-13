// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="BulkDeleteRequest.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class BulkDeleteRequest.
	/// </summary>
    public class BulkDeleteRequest
    {
        /// <summary>
        /// An explicit list of item ids to be deleted
        /// </summary>
        [JsonProperty(PropertyName = "item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ItemIds { get; set; }

        /// <summary>
        /// The id of the saved view whose items are to be deleted. Ignored if "item_ids" is given.
        /// </summary>
        [JsonProperty(PropertyName = "view_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ViewId { get; set; }

        /// <summary>
        /// The filters to apply. Ignored if "item_ids" is given
        /// </summary>
        [JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore)]
        public Object Filters { get; set; }
    }
}
