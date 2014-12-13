// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Status.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Status.
	/// </summary>
    public class Status
    {
		/// <summary>
		/// Gets or sets the status identifier.
		/// </summary>
		/// <value>The status identifier.</value>
        [JsonProperty("status_id")]
        public int StatusId { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        [JsonProperty("value")]
        public string Value { get; set; }

		/// <summary>
		/// Gets or sets the rich value.
		/// </summary>
		/// <value>The rich value.</value>
        [JsonProperty("rich_value")]
        public string RichValue { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the ratings.
		/// </summary>
		/// <value>The ratings.</value>
        [JsonProperty("ratings")]
        public Dictionary<string, object> Ratings { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Status"/> is subscribed.
		/// </summary>
		/// <value><c>null</c> if [subscribed] contains no value, <c>true</c> if [subscribed]; otherwise, <c>false</c>.</value>
        [JsonProperty("subscribed")]
        public bool? Subscribed { get; set; }

		/// <summary>
		/// Gets or sets the user ratings.
		/// </summary>
		/// <value>The user ratings.</value>
        [JsonProperty("user_ratings")]
        public Dictionary<string, object> UserRatings { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

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
		/// Gets or sets the embed.
		/// </summary>
		/// <value>The embed.</value>
        [JsonProperty("embed")]
        public Embed Embed { get; set; }

		/// <summary>
		/// Gets or sets the embed file.
		/// </summary>
		/// <value>The embed file.</value>
        [JsonProperty("embed_file")]
        public FileAttachment EmbedFile { get; set; }

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
        [JsonProperty("comments")]
        public List<Comment> Comments { get; set; }

		/// <summary>
		/// Gets or sets the conversations.
		/// </summary>
		/// <value>The conversations.</value>
        [JsonProperty("conversations")]
        public List<Conversation> Conversations { get; set; }

		/// <summary>
		/// Gets or sets the tasks.
		/// </summary>
		/// <value>The tasks.</value>
        [JsonProperty("tasks")]
        public List<PodioTask> Tasks { get; set; }

		/// <summary>
		/// Gets or sets the shares.
		/// </summary>
		/// <value>The shares.</value>
        [JsonProperty("shares")]
        public List<AppMarketShare> Shares { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty("files")]
        public List<FileAttachment> Files { get; set; }

		/// <summary>
		/// Gets or sets the questions.
		/// </summary>
		/// <value>The questions.</value>
        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }
    }
}
