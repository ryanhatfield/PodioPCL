// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="AppMarketShareInstall.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class AppMarketShareInstall.
	/// </summary>
    public class AppMarketShareInstall
    {
		/// <summary>
		/// Gets or sets the application identifier.
		/// </summary>
		/// <value>The application identifier.</value>
        [JsonProperty("app_id")]
        public int AppId { get; set; }

		/// <summary>
		/// Gets or sets the child application ids.
		/// </summary>
		/// <value>The child application ids.</value>
        [JsonProperty("child_app_ids")]
        public List<int> ChildAppIds { get; set; }
    }
}
