// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ConversationCreateRequest.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class ConversationCreateRequest.
	/// </summary>
    public class ConversationCreateRequest
    {
		/// <summary>
		/// Gets or sets the subject.
		/// </summary>
		/// <value>The subject.</value>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

		/// <summary>
		/// Gets or sets the file ids.
		/// </summary>
		/// <value>The file ids.</value>
        [JsonProperty("file_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> FileIds { get; set; }

		/// <summary>
		/// Gets or sets the participants.
		/// </summary>
		/// <value>The participants.</value>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Participants { get; set; }

		/// <summary>
		/// Gets or sets the embed identifier.
		/// </summary>
		/// <value>The embed identifier.</value>
        [JsonProperty("embed_id", NullValueHandling = NullValueHandling.Ignore)]    
        public int? EmbedId { get; set; }

		/// <summary>
		/// Gets or sets the embed URL.
		/// </summary>
		/// <value>The embed URL.</value>
        [JsonProperty("embed_url", NullValueHandling = NullValueHandling.Ignore)]    
        public string EmbedUrl { get; set; }
    }
}
