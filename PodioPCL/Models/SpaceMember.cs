// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="SpaceMember.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class SpaceMember.
	/// </summary>
    public class SpaceMember
    {
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="SpaceMember"/> is employee.
		/// </summary>
		/// <value><c>null</c> if [employee] contains no value, <c>true</c> if [employee]; otherwise, <c>false</c>.</value>
        [JsonProperty("employee")]
        public bool? Employee {get;set;}

		/// <summary>
		/// Gets or sets the role.
		/// </summary>
		/// <value>The role.</value>
        [JsonProperty("role")]
        public string Role {get;set;}

		/// <summary>
		/// Gets or sets the invited on.
		/// </summary>
		/// <value>The invited on.</value>
        [JsonProperty("invited_on")]
        public DateTime? InvitedOn {get;set;}

		/// <summary>
		/// Gets or sets the started_on.
		/// </summary>
		/// <value>The started_on.</value>
        [JsonProperty("started_on")]
        public DateTime? started_on { get; set; }

		/// <summary>
		/// Gets or sets the ended_on.
		/// </summary>
		/// <value>The ended_on.</value>
        [JsonProperty("ended_on")]
        public DateTime? ended_on { get; set; }

		/// <summary>
		/// Gets or sets the grant.
		/// </summary>
		/// <value>The grant.</value>
        [JsonProperty("grants")]
        public int? Grant {get;set;}

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty("user")]
        public User User { get; set; }

		/// <summary>
		/// Gets or sets the contact.
		/// </summary>
		/// <value>The contact.</value>
        [JsonProperty("profile")]
        public Contact Contact { get; set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public Space Space { get; set; }
    }
}
