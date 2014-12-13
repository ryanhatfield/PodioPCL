// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="AppValues.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class AppValues.
	/// </summary>
    public class AppValues
    {
		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
        [JsonProperty(PropertyName = "fields")]
        public List<ItemField> Fields { get; set; }

		/// <summary>
		/// Gets or sets the created bys.
		/// </summary>
		/// <value>The created bys.</value>
        [JsonProperty(PropertyName = "created_bys")]
        public List<ByLine> CreatedBys { get; set; }

		/// <summary>
		/// Gets or sets the created vias.
		/// </summary>
		/// <value>The created vias.</value>
        [JsonProperty(PropertyName = "created_vias")]
        public List<Via> CreatedVias { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		/// <value>The tags.</value>
        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }
    }
}
