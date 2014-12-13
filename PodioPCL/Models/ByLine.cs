// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ByLine.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ByLine.
	/// </summary>
    public class ByLine
    {
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

		/// <summary>
		/// Gets or sets the type of the avatar.
		/// </summary>
		/// <value>The type of the avatar.</value>
        [JsonProperty(PropertyName = "avatar_type")]
        public string AvatarType { get; set; }

		/// <summary>
		/// Gets or sets the avatar identifier.
		/// </summary>
		/// <value>The avatar identifier.</value>
        [JsonProperty(PropertyName = "avatar_id")]
        public int? AvatarId { get; set; }

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

		/// <summary>
		/// Gets or sets the avatar.
		/// </summary>
		/// <value>The avatar.</value>
        [JsonProperty(PropertyName = "avatar")]
        public int? Avatar { get; set; }

    }
}
