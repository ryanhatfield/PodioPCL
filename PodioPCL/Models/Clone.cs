// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Clone.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Clone.
	/// </summary>
    public class Clone
    {
		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty("files")]
        public List<FileAttachment> Files { get; set; }
		/// <summary>
		/// Gets or sets the values.
		/// </summary>
		/// <value>The values.</value>
        [JsonProperty("values")]
        public Dictionary<string, object> Values { get; set; }
		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		/// <value>The tags.</value>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}
