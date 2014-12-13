// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="CalendarEvent.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class CalendarEvent.
	/// </summary>
    public class CalendarEvent
    {
		/// <summary>
		/// Gets or sets the type of the reference.
		/// </summary>
		/// <value>The type of the reference.</value>
        [JsonProperty("ref_type")]
        public string RefType { get; set; }

		/// <summary>
		/// Gets or sets the reference identifier.
		/// </summary>
		/// <value>The reference identifier.</value>
        [JsonProperty("ref_id")]
        public string RefId { get; set; }

		/// <summary>
		/// Gets or sets the group.
		/// </summary>
		/// <value>The group.</value>
        [JsonProperty("group")]
        public string Group { get; set; }

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
		/// Gets or sets the location.
		/// </summary>
		/// <value>The location.</value>
        [JsonProperty("location")]
        public string Location { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the start.
		/// </summary>
		/// <value>The start.</value>
        [JsonProperty("start")]
        public DateTime? Start { get; set; }

		/// <summary>
		/// Gets or sets the end.
		/// </summary>
		/// <value>The end.</value>
        [JsonProperty("end")]
        public DateTime? End { get; set; }

		/// <summary>
		/// Gets or sets the start UTC.
		/// </summary>
		/// <value>The start UTC.</value>
        [JsonProperty("start_utc")]
        public DateTime? StartUtc { get; set; }

		/// <summary>
		/// Gets or sets the end UTC.
		/// </summary>
		/// <value>The end UTC.</value>
        [JsonProperty("end_utc")]
        public DateTime? EndUtc { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }
    }
}