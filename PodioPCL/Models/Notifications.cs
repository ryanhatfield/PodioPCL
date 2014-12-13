// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Notifications.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PodioPCL.Models
{

	/// <summary>
	/// Class Notifications.
	/// </summary>
    public class Notifications
    {
		/// <summary>
		/// Gets or sets the notification.
		/// </summary>
		/// <value>The notification.</value>
        [JsonProperty("notifications")]
        public List<Notification> Notification { get; set; }
    }

	/// <summary>
	/// Class Notification.
	/// </summary>
    public class Notification
    {
		/// <summary>
		/// Gets or sets the notification identifier.
		/// </summary>
		/// <value>The notification identifier.</value>
        [JsonProperty("notification_id")]
        public int? NotificationId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty("data")]
        public JToken Data { get; set; }

		/// <summary>
		/// Gets or sets the icon.
		/// </summary>
		/// <value>The icon.</value>
        [JsonProperty("icon")]
        public string Icon { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty("text")]
        public string Text { get; set; }

		/// <summary>
		/// Gets or sets the viewed on.
		/// </summary>
		/// <value>The viewed on.</value>
        [JsonProperty("viewed_on")]
        public DateTime ViewedOn { get; set; }

		/// <summary>
		/// Gets or sets the subscription identifier.
		/// </summary>
		/// <value>The subscription identifier.</value>
        [JsonProperty("subscription_id")]
        public int? SubscriptionId { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Notification"/> is starred.
		/// </summary>
		/// <value><c>null</c> if [starred] contains no value, <c>true</c> if [starred]; otherwise, <c>false</c>.</value>
        [JsonProperty("starred")]
        public bool? Starred { get; set; }

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
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
