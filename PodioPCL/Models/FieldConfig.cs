// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FieldConfig.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FieldConfig.
	/// </summary>
    public class FieldConfig
    {
		/// <summary>
		/// Gets the default value.
		/// </summary>
		/// <value>The default value.</value>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; private set; }

		/// <summary>
		/// The description of the field, shown to the user when inserting and editing.
		/// </summary>
		/// <value>The description.</value>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

		/// <summary>
		/// Gets or sets the settings.
		/// </summary>
		/// <value>The settings.</value>
        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Settings { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FieldConfig"/> is required.
		/// </summary>
		/// <value><c>null</c> if [required] contains no value, <c>true</c> if [required]; otherwise, <c>false</c>.</value>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

		/// <summary>
		/// The mapping of the field, one of "meeting_time", "meeting_participants", "meeting_agenda" and "meeting_location".
		/// </summary>
		/// <value>The mapping.</value>
        [JsonProperty("mapping", NullValueHandling = NullValueHandling.Ignore)]
        public string Mapping { get; set; }

		/// <summary>
		/// Label of the field, This is required on Application create.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FieldConfig"/> is visible.
		/// </summary>
		/// <value><c>null</c> if [visible] contains no value, <c>true</c> if [visible]; otherwise, <c>false</c>.</value>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

		/// <summary>
		/// An integer indicating the order of the field compared to other fields
		/// </summary>
		/// <value>The delta.</value>
        [JsonProperty("delta", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delta { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FieldConfig"/> is hidden.
		/// </summary>
		/// <value><c>null</c> if [hidden] contains no value, <c>true</c> if [hidden]; otherwise, <c>false</c>.</value>
        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; }
    }
}
