// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="TaggedObject.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class TaggedObject.
	/// </summary>
    public class TaggedObject
    {
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id {get;set;}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type{get;set;}

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string Title{get;set;}

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link {get;set;}

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn {get;set;}
    }
}
