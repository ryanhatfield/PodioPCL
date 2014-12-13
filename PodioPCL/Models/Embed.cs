// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Embed.cs" company="Onsharp">
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
	/// Class Embed.
	/// </summary>
    public class Embed
    {
		/// <summary>
		/// Gets or sets the embed identifier.
		/// </summary>
		/// <value>The embed identifier.</value>
        [JsonProperty("embed_id")]
        public int EmbedId { get; set; }

		/// <summary>
		/// Gets or sets the original URL.
		/// </summary>
		/// <value>The original URL.</value>
        [JsonProperty("original_url")]
        public string OriginalUrl { get; set; }

		/// <summary>
		/// Gets or sets the resolved URL.
		/// </summary>
		/// <value>The resolved URL.</value>
        [JsonProperty("resolved_url")]
        public string ResolvedUrl { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
        [JsonProperty("description")]
        public string Description { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the name of the provider.
		/// </summary>
		/// <value>The name of the provider.</value>
        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }

		/// <summary>
		/// Gets or sets the embed HTML.
		/// </summary>
		/// <value>The embed HTML.</value>
        [JsonProperty("embed_html")]
        public string EmbedHtml { get; set; }

		/// <summary>
		/// Gets or sets the height of the embed.
		/// </summary>
		/// <value>The height of the embed.</value>
        [JsonProperty("embed_height")]
        public int? EmbedHeight { get; set; }

		/// <summary>
		/// Gets or sets the width of the embed.
		/// </summary>
		/// <value>The width of the embed.</value>
        [JsonProperty("embed_width")]
        public int? EmbedWidth { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
        [JsonProperty("files")]
        public List<FileAttachment> Files { get; set; }
    }
}
