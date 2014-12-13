// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Grant.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Grant.
	/// </summary>
    public class Grant
    {
		/// <summary>
		/// Gets or sets the grant identifier.
		/// </summary>
		/// <value>The grant identifier.</value>
        [JsonProperty("grant_id")]
        public int grantId{get;set;}

		/// <summary>
		/// Gets or sets the type of the reference.
		/// </summary>
		/// <value>The type of the reference.</value>
        [JsonProperty("ref_type")]
        public string refType{get;set;}

		/// <summary>
		/// Gets or sets the reference identifier.
		/// </summary>
		/// <value>The reference identifier.</value>
        [JsonProperty("ref_id")]
        public int refId{get;set;}

		/// <summary>
		/// Gets or sets the action.
		/// </summary>
		/// <value>The action.</value>
        [JsonProperty("action")]
        public string Action {get;set;}

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		/// <value>The message.</value>
        [JsonProperty("message")]
        public string Message {get;set;}

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn{get;set;}

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy{get;set;}

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty("user")]
        public User User {get;set;}

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty("ref")]
        public Ref Reference {get;set;}
    }
}
