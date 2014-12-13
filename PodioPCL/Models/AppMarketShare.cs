// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="AppMarketShare.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class AppMarketShare.
	/// </summary>
    public class AppMarketShare
    {
		/// <summary>
		/// Gets or sets the share identifier.
		/// </summary>
		/// <value>The share identifier.</value>
        [JsonProperty("share_id")]
        public int? ShareId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
        [JsonProperty("description")]
        public string Description { get; set; }

		/// <summary>
		/// Gets or sets the abstract.
		/// </summary>
		/// <value>The abstract.</value>
        [JsonProperty("abstract")]
        public string Abstract { get; set; }

		/// <summary>
		/// Gets or sets the language.
		/// </summary>
		/// <value>The language.</value>
        [JsonProperty("language")]
        public string Language { get; set; }

		/// <summary>
		/// Gets or sets the features.
		/// </summary>
		/// <value>The features.</value>
        [JsonProperty("features")]
        public String[] Features { get; set; }

		/// <summary>
		/// Gets or sets the integration.
		/// </summary>
		/// <value>The integration.</value>
        [JsonProperty("integration")]
        public string Integration { get; set; }

		/// <summary>
		/// Gets or sets the categories.
		/// </summary>
		/// <value>The categories.</value>
        [JsonProperty("categories")]
        public JObject Categories { get; set; }

		/// <summary>
		/// Gets or sets the org.
		/// </summary>
		/// <value>The org.</value>
        [JsonProperty("org")]
        public JObject Org { get; set; }

		/// <summary>
		/// Gets or sets the author apps.
		/// </summary>
		/// <value>The author apps.</value>
        [JsonProperty("author_apps")]
        public int? AuthorApps { get; set; }

		/// <summary>
		/// Gets or sets the author packs.
		/// </summary>
		/// <value>The author packs.</value>
        [JsonProperty("author_packs")]
        public int? AuthorPacks { get; set; }

		/// <summary>
		/// Gets or sets the icon.
		/// </summary>
		/// <value>The icon.</value>
        [JsonProperty("icon")]
        public string Icon { get; set; }

		/// <summary>
		/// Gets or sets the icon identifier.
		/// </summary>
		/// <value>The icon identifier.</value>
        [JsonProperty("icon_id")]
        public int? IconId { get; set; }

		/// <summary>
		/// Gets or sets the ratings.
		/// </summary>
		/// <value>The ratings.</value>
        [JsonProperty("ratings")]
        public JObject Ratings { get; set; }

		/// <summary>
		/// Gets or sets the user rating.
		/// </summary>
		/// <value>The user rating.</value>
        [JsonProperty("user_rating")]
        public String[] UserRating { get; set; }

		/// <summary>
		/// Gets or sets the video.
		/// </summary>
		/// <value>The video.</value>
        [JsonProperty("video")]
        public string Video { get; set; }

		/// <summary>
		/// Gets or sets the rating.
		/// </summary>
		/// <value>The rating.</value>
        [JsonProperty("rating")]
        public float? Rating { get; set; }

		/// <summary>
		/// Gets or sets the author.
		/// </summary>
		/// <value>The author.</value>
        [JsonProperty("author")]
        public ByLine Author { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application Application { get; set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public Space space { get; set; }

		/// <summary>
		/// Gets or sets the children.
		/// </summary>
		/// <value>The children.</value>
        [JsonProperty("children")]
        public List<AppMarketShare> Children { get; set; }

		/// <summary>
		/// Gets or sets the parents.
		/// </summary>
		/// <value>The parents.</value>
        [JsonProperty("parents")]
        public List<AppMarketShare> Parents { get; set; }

		/// <summary>
		/// Gets or sets the screenshots.
		/// </summary>
		/// <value>The screenshots.</value>
        [JsonProperty("screenshots")]
        public List<FileAttachment> Screenshots { get; set; }

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
        [JsonProperty("comments")]
        public List<Comment> Comments { get; set; }

    }
}
