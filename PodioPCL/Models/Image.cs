// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Image.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Image.
	/// </summary>
    public class Image
    {
		/// <summary>
		/// Gets or sets the hosted by.
		/// </summary>
		/// <value>The hosted by.</value>
        [JsonProperty("hosted_by")]
        public string HostedBy { get; set; }

		/// <summary>
		/// Gets or sets the name of the hosted by humanized.
		/// </summary>
		/// <value>The name of the hosted by humanized.</value>
        [JsonProperty("hosted_by_humanized_name")]
        public string HostedByHumanizedName { get; set; }

		/// <summary>
		/// Gets or sets the thumbnail link.
		/// </summary>
		/// <value>The thumbnail link.</value>
        [JsonProperty("thumbnail_link")]
        public string ThumbnailLink { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the file identifier.
		/// </summary>
		/// <value>The file identifier.</value>
        [JsonProperty("file_id")]
        public int FileId { get; set; }

		/// <summary>
		/// Gets or sets the link target.
		/// </summary>
		/// <value>The link target.</value>
        [JsonProperty("link_target")]
        public string LinkTarget { get; set; }
    }
}
