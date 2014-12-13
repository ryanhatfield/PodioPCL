// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="OrganizationMember.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class OrganizationMember.
	/// </summary>
    public class OrganizationMember
    {
		/// <summary>
		/// Gets or sets the profile.
		/// </summary>
		/// <value>The profile.</value>
        [JsonProperty(PropertyName = "profile")]
        public Contact Profile { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="OrganizationMember"/> is admin.
		/// </summary>
		/// <value><c>null</c> if [admin] contains no value, <c>true</c> if [admin]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "admin")]
        public bool? Admin { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="OrganizationMember"/> is employee.
		/// </summary>
		/// <value><c>null</c> if [employee] contains no value, <c>true</c> if [employee]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "employee")]
        public bool? Employee { get; set; }

		/// <summary>
		/// Gets or sets the space memberships.
		/// </summary>
		/// <value>The space memberships.</value>
        [JsonProperty(PropertyName = "space_memberships")]
        public int? SpaceMemberships { get; set; }

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

		/// <summary>
		/// Gets or sets the contact.
		/// </summary>
		/// <value>The contact.</value>
        [JsonProperty(PropertyName = "spaces")]
        public List<Space> Contact { get; set; }
    }
}
