// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="StreamObjectV3.cs" company="Onsharp">
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
	/// Class StreamObjectV3.
	/// </summary>
    public class StreamObjectV3
    {
		/// <summary>
		/// Gets or sets the activity goups.
		/// </summary>
		/// <value>The activity goups.</value>
        [JsonProperty("activity_groups")]
        public List<ActivityGroup> ActivityGoups { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty("data")]
        public JObject Data { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty("files")]
        public List<FileAttachment> Files { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is liked.
		/// </summary>
		/// <value><c>true</c> if this instance is liked; otherwise, <c>false</c>.</value>
        [JsonProperty("is_liked")]
        public bool IsLiked { get; set; }

		/// <summary>
		/// Gets or sets the like count.
		/// </summary>
		/// <value>The like count.</value>
        [JsonProperty("like_count")]
        public int LikeCount { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string link { get; set; }

		/// <summary>
		/// Gets or sets the org.
		/// </summary>
		/// <value>The org.</value>
        [JsonProperty("org")]
        public Organization Org { get; set; }

		/// <summary>
		/// Gets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights")]
        public string[] Rights { get; private set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public SpaceMicro Space { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="StreamObjectV3"/> is subscribed.
		/// </summary>
		/// <value><c>true</c> if subscribed; otherwise, <c>false</c>.</value>
        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

		/// <summary>
		/// Gets or sets the subscribed count.
		/// </summary>
		/// <value>The subscribed count.</value>
        [JsonProperty("subscribed_count")]
        public int SubscribedCount { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string title { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
