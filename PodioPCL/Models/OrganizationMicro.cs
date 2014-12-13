// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="OrganizationMicro.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class OrganizationMicro.
	/// </summary>
    public class OrganizationMicro
    {
		/// <summary>
		/// Gets or sets the org identifier.
		/// </summary>
		/// <value>The org identifier.</value>
        [JsonProperty("org_id")]
        public int OrgId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
        [JsonProperty("url")]
        public string Url { get; set; }

		/// <summary>
		/// Gets or sets the URL label.
		/// </summary>
		/// <value>The URL label.</value>
        [JsonProperty("url_label")]
        public string UrlLabel { get; set; }
    }
}
