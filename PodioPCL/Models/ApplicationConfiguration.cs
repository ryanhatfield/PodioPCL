// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ApplicationConfiguration.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ApplicationConfiguration.
	/// </summary>
    public class ApplicationConfiguration
    {
		/// <summary>
		/// The type of the app, either "standard" or "meeting"
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// Name of the application. This is required on Application create.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// The name of each item in an app. This is required on Application create.
		/// </summary>
		/// <value>The name of the item.</value>
        [JsonProperty("item_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

		/// <summary>
		/// The usage information of the app.
		/// </summary>
		/// <value>The usage.</value>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public string Usage { get; set; }

		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public object ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the icon identifier.
		/// </summary>
		/// <value>The icon identifier.</value>
        [JsonProperty("icon_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IconId { get; set; }

		/// <summary>
		/// The icon for the app. This is required on Application create.
		/// </summary>
		/// <value>The icon.</value>
        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [allow edit].
		/// </summary>
		/// <value><c>null</c> if [allow edit] contains no value, <c>true</c> if [allow edit]; otherwise, <c>false</c>.</value>
        [JsonProperty("allow_edit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowEdit { get; set; }

		/// <summary>
		/// The default view of the app items on the app main page. Possible values: badge, table, stream, calendar or card
		/// </summary>
		/// <value>The default view.</value>
        [JsonProperty("default_view", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultView { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [allow attachments].
		/// </summary>
		/// <value><c>null</c> if [allow attachments] contains no value, <c>true</c> if [allow attachments]; otherwise, <c>false</c>.</value>
        [JsonProperty("allow_attachments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAttachments { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [allow comments].
		/// </summary>
		/// <value><c>null</c> if [allow comments] contains no value, <c>true</c> if [allow comments]; otherwise, <c>false</c>.</value>
        [JsonProperty("allow_comments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowComments { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [allow create].
		/// </summary>
		/// <value><c>null</c> if [allow create] contains no value, <c>true</c> if [allow create]; otherwise, <c>false</c>.</value>
        [JsonProperty("allow_create", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCreate { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [silent creates].
		/// </summary>
		/// <value><c>null</c> if [silent creates] contains no value, <c>true</c> if [silent creates]; otherwise, <c>false</c>.</value>
        [JsonProperty("silent_creates", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SilentCreates { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [silent edits].
		/// </summary>
		/// <value><c>null</c> if [silent edits] contains no value, <c>true</c> if [silent edits]; otherwise, <c>false</c>.</value>
        [JsonProperty("silent_edits", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SilentEdits { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [disable notifications].
		/// </summary>
		/// <value><c>null</c> if [disable notifications] contains no value, <c>true</c> if [disable notifications]; otherwise, <c>false</c>.</value>
        [JsonProperty("disable_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableNotifications { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ApplicationConfiguration"/> is fivestar.
		/// </summary>
		/// <value><c>null</c> if [fivestar] contains no value, <c>true</c> if [fivestar]; otherwise, <c>false</c>.</value>
        [JsonProperty("fivestar", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fivestar { get; set; }

		/// <summary>
		/// Gets or sets the fivestar label.
		/// </summary>
		/// <value>The fivestar label.</value>
        [JsonProperty("fivestar_label", NullValueHandling = NullValueHandling.Ignore)]
        public string FivestarLabel { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ApplicationConfiguration"/> is approved.
		/// </summary>
		/// <value><c>null</c> if [approved] contains no value, <c>true</c> if [approved]; otherwise, <c>false</c>.</value>
        [JsonProperty("approved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approved { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ApplicationConfiguration"/> is thumbs.
		/// </summary>
		/// <value><c>null</c> if [thumbs] contains no value, <c>true</c> if [thumbs]; otherwise, <c>false</c>.</value>
        [JsonProperty("thumbs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Thumbs { get; set; }

		/// <summary>
		/// Gets or sets the thumbs label.
		/// </summary>
		/// <value>The thumbs label.</value>
        [JsonProperty("thumbs_label", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbsLabel { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ApplicationConfiguration"/> is RSVP.
		/// </summary>
		/// <value><c>null</c> if [RSVP] contains no value, <c>true</c> if [RSVP]; otherwise, <c>false</c>.</value>
        [JsonProperty("rsvp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rsvp { get; set; }

		/// <summary>
		/// Gets or sets the RSVP label.
		/// </summary>
		/// <value>The RSVP label.</value>
        [JsonProperty("rsvp_label", NullValueHandling = NullValueHandling.Ignore)]
        public string RsvpLabel { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ApplicationConfiguration"/> is yesno.
		/// </summary>
		/// <value><c>null</c> if [yesno] contains no value, <c>true</c> if [yesno]; otherwise, <c>false</c>.</value>
        [JsonProperty("yesno", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Yesno { get; set; }

		/// <summary>
		/// Gets or sets the yesno label.
		/// </summary>
		/// <value>The yesno label.</value>
        [JsonProperty("yesno_label", NullValueHandling = NullValueHandling.Ignore)]
        public string YesnoLabel { get; set; }

		/// <summary>
		/// Gets or sets the tasks.
		/// </summary>
		/// <value>The tasks.</value>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AutoTask> Tasks { get; set; }
    }
}
