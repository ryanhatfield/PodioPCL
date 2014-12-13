// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="CreatedGrant.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class CreatedGrant.
	/// </summary>
    public class CreatedGrant
    {
		/// <summary>
		/// Gets or sets the profiles.
		/// </summary>
		/// <value>The profiles.</value>
        [JsonProperty("invitable")]
        public List<User> Profiles { get; set; }
    }
}
