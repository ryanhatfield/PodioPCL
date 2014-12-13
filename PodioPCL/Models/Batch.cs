// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Batch.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Batch.
	/// </summary>
    public class Batch
    {
		/// <summary>
		/// Gets or sets the batch identifier.
		/// </summary>
		/// <value>The batch identifier.</value>
        [JsonProperty("batch_id")]
        public int? BatchId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the plugin.
		/// </summary>
		/// <value>The plugin.</value>
        [JsonProperty("plugin")]
        public string Plugin { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the completed.
		/// </summary>
		/// <value>The completed.</value>
        [JsonProperty("completed")]
        public int? Completed { get; set; }

		/// <summary>
		/// Gets or sets the skipped.
		/// </summary>
		/// <value>The skipped.</value>
        [JsonProperty("skipped")]
        public int? Skipped { get; set; }

		/// <summary>
		/// Gets or sets the failed.
		/// </summary>
		/// <value>The failed.</value>
        [JsonProperty("failed")]
        public int? Failed { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the started on.
		/// </summary>
		/// <value>The started on.</value>
        [JsonProperty("started_on")]
        public DateTime? StartedOn { get; set; }

		/// <summary>
		/// Gets or sets the ended on.
		/// </summary>
		/// <value>The ended on.</value>
        [JsonProperty("ended_on")]
        public DateTime? EndedOn { get; set; }

		/// <summary>
		/// Gets or sets the file.
		/// </summary>
		/// <value>The file.</value>
        [JsonProperty("file")]
        public FileAttachment File { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }

		/// <summary>
		/// Gets or sets the space.
		/// </summary>
		/// <value>The space.</value>
        [JsonProperty("space")]
        public Space Space { get; set; }
    }
}
