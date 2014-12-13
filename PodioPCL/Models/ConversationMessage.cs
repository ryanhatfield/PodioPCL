// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ConversationMessage.cs" company="Onsharp">
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
	/// Class ConversationMessage.
	/// </summary>
    public class ConversationMessage
    {
		/// <summary>
		/// Gets or sets the message identifier.
		/// </summary>
		/// <value>The message identifier.</value>
        [JsonProperty(PropertyName = "message_id")]
        public int MessageId { get; set; }

		/// <summary>
		/// Gets or sets the embed identifier.
		/// </summary>
		/// <value>The embed identifier.</value>
        [JsonProperty(PropertyName = "embed_id")]
        public int? EmbedId { get; set; }

		/// <summary>
		/// Gets or sets the embed file identifier.
		/// </summary>
		/// <value>The embed file identifier.</value>
        [JsonProperty(PropertyName = "embed_file_id")]
        public int? EmbedFileId { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty(PropertyName = "created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the embed.
		/// </summary>
		/// <value>The embed.</value>
        [JsonProperty(PropertyName = "embed")]
        public Embed Embed { get; set; }

		/// <summary>
		/// Gets or sets the embed file.
		/// </summary>
		/// <value>The embed file.</value>
        [JsonProperty(PropertyName = "embed_file")]
        public FileAttachment EmbedFile { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty(PropertyName = "files")]
        public List<FileAttachment> Files { get; set; }
    }
}
