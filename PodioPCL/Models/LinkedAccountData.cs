// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="LinkedAccountData.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class LinkedAccountData.
	/// </summary>
    public class LinkedAccountData
    {
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the information.
		/// </summary>
		/// <value>The information.</value>
        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
