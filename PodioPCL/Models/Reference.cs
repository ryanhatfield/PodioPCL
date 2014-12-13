// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Reference.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Reference.
	/// </summary>
    public class Reference
    {
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

		/// <summary>
		/// Gets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

		/// <summary>
		/// Gets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; private set; }

		/// <summary>
		/// Gets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty(PropertyName = "created_on")]
        public DateTime? CreatedOn { get; private set; }

		/// <summary>
		/// Gets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; private set; }

		/// <summary>
		/// Gets the created via.
		/// </summary>
		/// <value>The created via.</value>
        [JsonProperty(PropertyName = "created_via")]
        public Via CreatedVia { get; private set; }

		/// <summary>
		/// Gets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty(PropertyName = "data")]
        public JObject Data { get; private set; }

		/// <summary>
		/// Gets or sets the accessor count.
		/// </summary>
		/// <value>The accessor count.</value>
        [JsonProperty("accessor_count")]
        public int AccessorCount { get; set; }
    }
}
