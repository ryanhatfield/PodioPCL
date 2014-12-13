// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="AppMarketCategory.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class AppMarketCategory.
	/// </summary>
  public class AppMarketCategory
    {
		/// <summary>
		/// Gets or sets the functional.
		/// </summary>
		/// <value>The functional.</value>
      [JsonProperty("functional")]
      public JArray Functional { get; set; }

	  /// <summary>
	  /// Gets or sets the vertical.
	  /// </summary>
	  /// <value>The vertical.</value>
      [JsonProperty("vertical")]
      public JArray Vertical { get; set; }
    }
}
