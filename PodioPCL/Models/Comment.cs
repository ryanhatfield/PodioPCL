// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Comment.cs" company="Onsharp">
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
	/// Class Comment.
	/// </summary>
    public class Comment
    {
		/// <summary>
		/// Gets or sets the comment identifier.
		/// </summary>
		/// <value>The comment identifier.</value>
        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

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
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
        [JsonProperty("external_id")]
        public int? ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the space identifier.
		/// </summary>
		/// <value>The space identifier.</value>
        [JsonProperty("space_id")]
        public object SpaceId { get; set; }

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
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty("ref")]
        public Reference Ref { get; set; }

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
    }
}
