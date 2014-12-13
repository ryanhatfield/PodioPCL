// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Activity.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Activity.
	/// </summary>
    public class Activity
    {
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty("id")]
        public int? Id { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the type of the activity.
		/// </summary>
		/// <value>The type of the activity.</value>
        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty("data")]
        public JObject Data { get; set; }

		/// <summary>
		/// Gets or sets the data reference.
		/// </summary>
		/// <value>The data reference.</value>
        [JsonProperty("data_ref")]
        public Ref DataRef { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

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
    }
}
