// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Hook.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Hook.
	/// </summary>
    public class Hook
    {
		/// <summary>
		/// Gets or sets the hook identifier.
		/// </summary>
		/// <value>The hook identifier.</value>
        [JsonProperty("hook_id")]
        public int HookId { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
        [JsonProperty("url")]
        public string Url { get; set; }

		/// <summary>
		/// Gets or sets the createdon.
		/// </summary>
		/// <value>The createdon.</value>
        [JsonProperty("created_on")]
        public DateTime? Createdon { get; set; }

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
