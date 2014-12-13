// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="UserStatus.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class UserStatus.
	/// </summary>
    public class UserStatus
    {
		/// <summary>
		/// Gets or sets the inbox new.
		/// </summary>
		/// <value>The inbox new.</value>
        [JsonProperty("inbox_new")]
        public int inboxNew{get;set;}

		/// <summary>
		/// Gets or sets the calender code.
		/// </summary>
		/// <value>The calender code.</value>
        [JsonProperty("calendar_code")]
        public string calenderCode {get;set;}

		/// <summary>
		/// Gets or sets the message unread count.
		/// </summary>
		/// <value>The message unread count.</value>
        [JsonProperty("message_unread_count")]
        public int MessageUnreadCount { get; set; }

		/// <summary>
		/// Gets or sets the mail box.
		/// </summary>
		/// <value>The mail box.</value>
        [JsonProperty("mailbox")]
        public string mailBox {get;set;}

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty("user")]
        public User User {get;set;}

		/// <summary>
		/// Gets or sets the profile.
		/// </summary>
		/// <value>The profile.</value>
        [JsonProperty("profile")]
        public Contact Profile {get;set;}

		/// <summary>
		/// Gets or sets the properties.
		/// </summary>
		/// <value>The properties.</value>
        [JsonProperty("properties")]
        public Dictionary<string,object> Properties {get;set;}
    }
}
