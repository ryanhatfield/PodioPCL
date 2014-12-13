// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="RowPreview.cs" company="Onsharp">
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
	/// Class RowPreview.
	/// </summary>
    public class RowPreview
    {
		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
        [JsonProperty("fields")]
        public List<PreviewField> Fields { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		/// <value>The tags.</value>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }

	/// <summary>
	/// Class PreviewField.
	/// </summary>
    public class PreviewField
    {
		/// <summary>
		/// Gets or sets the field identifier.
		/// </summary>
		/// <value>The field identifier.</value>
        [JsonProperty("field_id")]
        public int? FieldId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label")]
        public string Label { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty("config")]
        public FieldConfig Config { get; set; }

		/// <summary>
		/// Gets or sets the values.
		/// </summary>
		/// <value>The values.</value>
        [JsonProperty("values")]
        public JToken Values { get; set; }
    }
}
