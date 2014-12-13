// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="PodioResponse.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class PodioResponse.
	/// </summary>
    public class PodioResponse
    {
		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		/// <value>The body.</value>
        public dynamic Body { get; set; }
		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        public int Status { get; set; }
		/// <summary>
		/// Gets or sets the headers.
		/// </summary>
		/// <value>The headers.</value>
        public Dictionary<string,string> Headers { get; set; }
		/// <summary>
		/// Gets or sets the request URI.
		/// </summary>
		/// <value>The request URI.</value>
        public string RequestUri { get; set; }
    }
}
