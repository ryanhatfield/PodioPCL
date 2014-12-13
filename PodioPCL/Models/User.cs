// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="User.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class User.
	/// </summary>
    public class User
    {
		/// <summary>
		/// Gets or sets the user identifier.
		/// </summary>
		/// <value>The user identifier.</value>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

		/// <summary>
		/// Gets or sets the profile identifier.
		/// </summary>
		/// <value>The profile identifier.</value>
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProfileId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the avatar.
		/// </summary>
		/// <value>The avatar.</value>
        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public int? Avatar { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the locale.
		/// </summary>
		/// <value>The locale.</value>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

		/// <summary>
		/// Gets or sets the timezone.
		/// </summary>
		/// <value>The timezone.</value>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

		/// <summary>
		/// Gets or sets the flags.
		/// </summary>
		/// <value>The flags.</value>
        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Flags { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the profile.
		/// </summary>
		/// <value>The profile.</value>
        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Contact Profile { get; set; }

		/// <summary>
		/// Gets or sets the mails.
		/// </summary>
		/// <value>The mails.</value>
        [JsonProperty("mails", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserMail> Mails { get; set; }

		/// <summary>
		/// Gets or sets the activated on.
		/// </summary>
		/// <value>The activated on.</value>
        [JsonProperty ("activated_on",NullValueHandling=NullValueHandling.Ignore)]
        public DateTime? ActivatedON { get; set; }

		/// <summary>
		/// Gets or sets the mail.
		/// </summary>
		/// <value>The mail.</value>
        [JsonProperty("mail", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail { get; set; }
    }
}
