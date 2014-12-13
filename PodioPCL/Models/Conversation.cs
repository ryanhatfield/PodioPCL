// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Conversation.cs" company="Onsharp">
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
	/// Class Conversation.
	/// </summary>
    public class Conversation
    {
		/// <summary>
		/// Gets or sets the unread count.
		/// </summary>
		/// <value>The unread count.</value>
        [JsonProperty(PropertyName = "unread_count")]
        public int? UnreadCount { get; set; }

		/// <summary>
		/// Gets or sets the presence.
		/// </summary>
		/// <value>The presence.</value>
        [JsonProperty(PropertyName = "presence")]
        public Presence Presence { get; set; }

		/// <summary>
		/// Gets or sets the participants.
		/// </summary>
		/// <value>The participants.</value>
        [JsonProperty(PropertyName = "participants", Required = Required.AllowNull)]
        public List<User> Participants { get; set; }

		/// <summary>
		/// Gets or sets the excerpt.
		/// </summary>
		/// <value>The excerpt.</value>
        [JsonProperty(PropertyName = "excerpt")]
        public string Excerpt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the push.
		/// </summary>
		/// <value>The push.</value>
        [JsonProperty(PropertyName = "push")]
        public Push Push { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty(PropertyName = "created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the last event on.
		/// </summary>
		/// <value>The last event on.</value>
        [JsonProperty(PropertyName = "last_event_on")]
        public DateTime LastEventOn { get; set; }

		/// <summary>
		/// Gets or sets the conversation identifier.
		/// </summary>
		/// <value>The conversation identifier.</value>
        [JsonProperty(PropertyName = "conversation_id")]
        public int? ConversationId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Conversation"/> is starred.
		/// </summary>
		/// <value><c>true</c> if starred; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "starred")]
        public bool Starred { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Conversation"/> is unread.
		/// </summary>
		/// <value><c>true</c> if unread; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "unread")]
        public bool Unread { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the subject.
		/// </summary>
		/// <value>The subject.</value>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty(PropertyName = "ref")]
        public Ref Ref { get; set; }

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
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty(PropertyName = "files")]
        public List<FileAttachment> Files { get; set; }

		/// <summary>
		/// Gets or sets the messages.
		/// </summary>
		/// <value>The messages.</value>
        [JsonProperty(PropertyName = "messages")]
        public List<ConversationMessage> Messages { get; set; }

        
    }
   
}
