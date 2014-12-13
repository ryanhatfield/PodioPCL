// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ContactTotal.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ContactTotal.
	/// </summary>
    public class ContactTotal
    {
		/// <summary>
		/// Gets or sets the total count.
		/// </summary>
		/// <value>The total count.</value>
        [JsonProperty("count")]
        public int TotalCount { get; set; }

		/// <summary>
		/// Gets or sets the orgs.
		/// </summary>
		/// <value>The orgs.</value>
        [JsonProperty("orgs")]
        public List<OrganizationContactTotal> Orgs { get; set; }
    }
}
