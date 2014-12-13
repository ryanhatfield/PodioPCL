// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Profile.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Profile.
	/// </summary>
   public class Profile
    {
		/// <summary>
		/// Gets or sets the profile identifier.
		/// </summary>
		/// <value>The profile identifier.</value>
       [JsonProperty("profile_id")]
       public int ProfileId { get; set; }

	   /// <summary>
	   /// Gets or sets the avatar.
	   /// </summary>
	   /// <value>The avatar.</value>
       [JsonProperty("avatar")]
       public int? Avatar { get; set; }

	   /// <summary>
	   /// Gets or sets the image.
	   /// </summary>
	   /// <value>The image.</value>
       [JsonProperty("image")]
       public Image Image { get; set; }

	   /// <summary>
	   /// Gets or sets the last seen on.
	   /// </summary>
	   /// <value>The last seen on.</value>
       [JsonProperty("last_seen_on")]
       public DateTime? LastSeenOn { get; set; }

	   /// <summary>
	   /// Gets or sets the link.
	   /// </summary>
	   /// <value>The link.</value>
       [JsonProperty("link")]
       public string Link { get; set; }

	   /// <summary>
	   /// Gets or sets the name.
	   /// </summary>
	   /// <value>The name.</value>
       [JsonProperty("name")]
       public string Name { get; set; }

	   /// <summary>
	   /// Gets or sets the org identifier.
	   /// </summary>
	   /// <value>The org identifier.</value>
       [JsonProperty("org_id")]
       public int? OrgId { get; set; }

	   /// <summary>
	   /// Gets or sets the space identifier.
	   /// </summary>
	   /// <value>The space identifier.</value>
       [JsonProperty("space_id")]
       public int? SpaceId { get; set; }

	   /// <summary>
	   /// Gets or sets the type.
	   /// </summary>
	   /// <value>The type.</value>
       [JsonProperty("type")]
       public string Type { get; set; }

	   /// <summary>
	   /// Gets or sets the user identifier.
	   /// </summary>
	   /// <value>The user identifier.</value>
       [JsonProperty("user_id")]
       public int? UserId { get; set; }
    }
}
