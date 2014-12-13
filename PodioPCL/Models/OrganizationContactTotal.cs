// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="OrganizationContactTotal.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class OrganizationContactTotal.
	/// </summary>
    public class OrganizationContactTotal
    {
		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>The count.</value>
        [JsonProperty("count")]
        public int Count { get; set; }

		/// <summary>
		/// Gets or sets the org.
		/// </summary>
		/// <value>The org.</value>
        [JsonProperty("org")]
        public OrganizationMicro Org { get; set; }

		/// <summary>
		/// Gets or sets the spaces.
		/// </summary>
		/// <value>The spaces.</value>
        [JsonProperty("spaces")]
        public List<SpaceContactTotal> Spaces { get; set; }
    }
}
