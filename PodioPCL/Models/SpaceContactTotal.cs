// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="SpaceContactTotal.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class SpaceContactTotal.
	/// </summary>
    public class SpaceContactTotal
    {
		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>The count.</value>
        [JsonProperty("count")]
        public int Count { get; set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public SpaceMicro Space { get; set; }
    }
}
