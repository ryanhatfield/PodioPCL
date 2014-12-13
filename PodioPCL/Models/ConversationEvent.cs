// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ConversationEvent.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ConversationEvent.
	/// </summary>
    public class ConversationEvent
    {
		/// <summary>
		/// Gets or sets the event identifier.
		/// </summary>
		/// <value>The event identifier.</value>
        [JsonProperty("event_id")]
        public int EventId { get; set; }

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

		/// <summary>
		/// Gets or sets the action.
		/// </summary>
		/// <value>The action.</value>
        [JsonProperty("action")]
        public string Action { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty("data")] 
        public JObject Data { get; set; }
    }
}
