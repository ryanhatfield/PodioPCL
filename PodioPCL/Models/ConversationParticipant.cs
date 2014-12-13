// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ConversationParticipant.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ConversationParticipant.
	/// </summary>
    public class ConversationParticipant
    {
		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty(PropertyName = "created_on")]
        public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

		/// <summary>
		/// Gets or sets the created via.
		/// </summary>
		/// <value>The created via.</value>
        [JsonProperty("created_via")]
        public Via CreatedVia { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; set; }
    }
}
