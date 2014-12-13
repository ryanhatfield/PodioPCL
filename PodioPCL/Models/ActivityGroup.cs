// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ActivityGroup.cs" company="Onsharp">
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
	/// Class ActivityGroup.
	/// </summary>
    public class ActivityGroup
    {
		/// <summary>
		/// Gets or sets the activities.
		/// </summary>
		/// <value>The activities.</value>
        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }

		/// <summary>
		/// Gets or sets the authors.
		/// </summary>
		/// <value>The authors.</value>
        [JsonProperty("authors")]
        public ByLine Authors { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the created via.
		/// </summary>
		/// <value>The created via.</value>
        [JsonProperty("created_via")]
        public Via CreatedVia { get; set; }

		/// <summary>
		/// Gets or sets the group identifier.
		/// </summary>
		/// <value>The group identifier.</value>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

		/// <summary>
		/// Gets or sets the kind.
		/// </summary>
		/// <value>The kind.</value>
        [JsonProperty("kind")]
        public string Kind { get; set; }
    }
}
