// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Organization.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Organization.
	/// </summary>
    public class Organization
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
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the logo.
		/// </summary>
		/// <value>The logo.</value>
        [JsonProperty("logo")]
        public int? Logo { get; set; }

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

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Organization"/> is premium.
		/// </summary>
		/// <value><c>true</c> if premium; otherwise, <c>false</c>.</value>
        [JsonProperty("premium")]
        public bool Premium { get; set; }

		/// <summary>
		/// Gets or sets the role.
		/// </summary>
		/// <value>The role.</value>
        [JsonProperty("role")]
        public string Role { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the sales agent identifier.
		/// </summary>
		/// <value>The sales agent identifier.</value>
        [JsonProperty("sales_agent_id")]
        public int SalesAgentId { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the domains.
		/// </summary>
		/// <value>The domains.</value>
        [JsonProperty("domains")]
        public string[] Domains { get; set; }

		/// <summary>
		/// Gets or sets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights")]
        public string[] Rights { get; set; }

		/// <summary>
		/// Gets or sets the rank.
		/// </summary>
		/// <value>The rank.</value>
        [JsonProperty("rank")]
        public int? Rank { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
        [JsonProperty("image")]
        public Image Image { get; set; }

		/// <summary>
		/// Gets or sets the spaces.
		/// </summary>
		/// <value>The spaces.</value>
        [JsonProperty("spaces")]
        public List<Space> Spaces { get; set; }

		/// <summary>
		/// Gets or sets the grants count.
		/// </summary>
		/// <value>The grants count.</value>
        [JsonProperty("grants_count")]
        public int? GrantsCount { get; set; }

		/// <summary>
		/// Gets or sets the segment.
		/// </summary>
		/// <value>The segment.</value>
        [JsonProperty("segment")]
        public string Segment { get; set; }

		/// <summary>
		/// Gets or sets the size of the segment.
		/// </summary>
		/// <value>The size of the segment.</value>
        [JsonProperty("segment_size")]
        public int? SegmentSize { get; set; }
    }
}
