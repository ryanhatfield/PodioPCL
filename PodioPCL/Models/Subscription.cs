// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Subscription.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Subscription.
	/// </summary>
    public class Subscription
    {
		/// <summary>
		/// Gets or sets the started on.
		/// </summary>
		/// <value>The started on.</value>
        [JsonProperty("started_on")]
        public DateTime StartedOn { get; set; }

		/// <summary>
		/// Gets or sets the notifications.
		/// </summary>
		/// <value>The notifications.</value>
        [JsonProperty("notifications")]
        public int Notifications { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty("ref")]
        public Ref Reference { get; set; }
    }
}
