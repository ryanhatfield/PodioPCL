// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Tag.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Tag.
	/// </summary>
    public class Tag
    {
		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>The count.</value>
        [JsonProperty("count")]
        public int? Count { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
