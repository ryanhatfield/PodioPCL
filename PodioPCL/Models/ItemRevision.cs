// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemRevision.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ItemRevision.
	/// </summary>
    public class ItemRevision
    {
		/// <summary>
		/// Gets or sets the revision.
		/// </summary>
		/// <value>The revision.</value>
        [JsonProperty("revision")]
        public int Revision { get; set; }

		/// <summary>
		/// Gets or sets the item revision identifier.
		/// </summary>
		/// <value>The item revision identifier.</value>
        [JsonProperty("item_revision_id")]
        public int? ItemRevisionId { get; set; }

		/// <summary>
		/// Gets or sets the application revision.
		/// </summary>
		/// <value>The application revision.</value>
        [JsonProperty("app_revision")]
        public int? AppRevision { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

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
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
