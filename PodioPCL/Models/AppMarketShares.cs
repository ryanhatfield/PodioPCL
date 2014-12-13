// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="AppMarketShares.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class AppMarketShares.
	/// </summary>
   public class AppMarketShares
    {
		/// <summary>
		/// Gets or sets the total.
		/// </summary>
		/// <value>The total.</value>
       [JsonProperty("total")]
       public int? Total { get; set; }

	   /// <summary>
	   /// Gets or sets the shares.
	   /// </summary>
	   /// <value>The shares.</value>
       [JsonProperty("shares")]
       public List<AppMarketShare> Shares { get; set; }
    }
}
