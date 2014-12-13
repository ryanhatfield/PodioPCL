// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="SearchResult.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class SearchResult.
	/// </summary>
    public class SearchResult
    {
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the rank.
		/// </summary>
		/// <value>The rank.</value>
        [JsonProperty("rank")]
        public int Rank { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }

		/// <summary>
		/// Gets or sets the org.
		/// </summary>
		/// <value>The org.</value>
        [JsonProperty("org")]
        public OrganizationMicro Org { get; set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public SpaceMicro Space { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

    }
}
