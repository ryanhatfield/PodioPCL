// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Integration.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Integration.
	/// </summary>
    public class Integration
    {
		/// <summary>
		/// Gets or sets the integration identifier.
		/// </summary>
		/// <value>The integration identifier.</value>
        [JsonProperty(PropertyName = "integration_id")]
        public int? IntegrationId { get; set; }

		/// <summary>
		/// Gets or sets the application identifier.
		/// </summary>
		/// <value>The application identifier.</value>
        [JsonProperty(PropertyName = "app_id")]
        public int? AppId { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Integration"/> is silent.
		/// </summary>
		/// <value><c>null</c> if [silent] contains no value, <c>true</c> if [silent]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "silent")]
        public bool? Silent { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty(PropertyName = "config")]
        public JToken Config { get; set; }

		/// <summary>
		/// Gets or sets the mapping.
		/// </summary>
		/// <value>The mapping.</value>
        [JsonProperty(PropertyName = "mapping")]
        public JToken Mapping { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Integration"/> is updating.
		/// </summary>
		/// <value><c>null</c> if [updating] contains no value, <c>true</c> if [updating]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "updating")]
        public bool? Updating { get; set; }

		/// <summary>
		/// Gets or sets the last updated on.
		/// </summary>
		/// <value>The last updated on.</value>
        [JsonProperty(PropertyName = "last_updated_on")]
        public DateTime? LastUpdatedOn { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty(PropertyName = "created_on")]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; set; }
    }
}
