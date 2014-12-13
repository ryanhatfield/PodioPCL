// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="StreamObject.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class StreamObject.
	/// </summary>
    public class StreamObject
    {
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty("id")]
        public int? Id { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the last update on.
		/// </summary>
		/// <value>The last update on.</value>
        [JsonProperty("last_update_on")]
        public DateTime? LastUpdateOn { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights")]
        public string[] Rights { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty("data")]
        public JObject Data { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [comments allowed].
		/// </summary>
		/// <value><c>null</c> if [comments allowed] contains no value, <c>true</c> if [comments allowed]; otherwise, <c>false</c>.</value>
        [JsonProperty("comments_allowed")]
        public bool? CommentsAllowed { get; set; }

		/// <summary>
		/// Gets or sets the user ratings.
		/// </summary>
		/// <value>The user ratings.</value>
        [JsonProperty("user_ratings")]
        public JObject UserRatings { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the created via.
		/// </summary>
		/// <value>The created via.</value>
        [JsonProperty("created_via")]
        public Via CreatedVia { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public Space Space { get; set; }

		/// <summary>
		/// Gets or sets the organization.
		/// </summary>
		/// <value>The organization.</value>
        [JsonProperty("org")]
        public Organization Organization { get; set; }

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
        [JsonProperty("comments")]
        public List<Comment> Comments { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty("files")]
        public List<FileAttachment> Files { get; set; }

		/// <summary>
		/// Gets or sets the activity.
		/// </summary>
		/// <value>The activity.</value>
        [JsonProperty("activity")]
        public List<Activity> Activity { get; set; }
    }
}
