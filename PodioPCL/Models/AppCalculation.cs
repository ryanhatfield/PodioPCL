// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="AppCalculation.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class AppCalculation.
	/// </summary>
    public class AppCalculation
    {
		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the reference field.
		/// </summary>
		/// <value>The reference field.</value>
        [JsonProperty("reference_field")]
        public ReferenceField ReferenceField { get; set; }

		/// <summary>
		/// Gets or sets the value fields.
		/// </summary>
		/// <value>The value fields.</value>
        [JsonProperty("value_fields")]
        public List<ValueFields> ValueFields { get; set; }
    }

	/// <summary>
	/// Class ReferenceField.
	/// </summary>
    public class ReferenceField : CommenFieldsValues
    {
		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty("config")]
        public ReferenceFieldConfig Config { get; set; }
    }

	/// <summary>
	/// Class ReferenceFieldConfig.
	/// </summary>
    public class ReferenceFieldConfig
    {
		/// <summary>
		/// Gets or sets the setting.
		/// </summary>
		/// <value>The setting.</value>
        [JsonProperty("settings")]
        public ReferenceFieldSetting Setting { get; set; }

		/// <summary>
		/// Gets or sets the mapping.
		/// </summary>
		/// <value>The mapping.</value>
        [JsonProperty("mapping")]
        public string Mapping { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
	/// <summary>
	/// Class ReferenceFieldSetting.
	/// </summary>
    public class ReferenceFieldSetting
    {
		/// <summary>
		/// Gets or sets the referenceable types.
		/// </summary>
		/// <value>The referenceable types.</value>
        [JsonProperty("referenceable_types")]
        public int[] ReferenceableTypes { get; set; }
    }

	/// <summary>
	/// Class ValueFields.
	/// </summary>
    public class ValueFields : CommenFieldsValues
    {
		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty("config")]
        public ValueFieldConfig Config { get; set; }
    }
	/// <summary>
	/// Class ValueFieldConfig.
	/// </summary>
    public class ValueFieldConfig
    {
		/// <summary>
		/// Gets or sets the mapping.
		/// </summary>
		/// <value>The mapping.</value>
        [JsonProperty("mapping")]
        public string Mapping { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label")]
        public string Label { get; set; }

		/// <summary>
		/// Gets or sets the setting.
		/// </summary>
		/// <value>The setting.</value>
        [JsonProperty("settings")]
        public object Setting { get; set; }
    }

	/// <summary>
	/// Class CommenFieldsValues.
	/// </summary>
    public class CommenFieldsValues
    {
		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
        [JsonProperty("external_id")]
        string ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        string Type { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label")]
        public string Label { get; set; }

		/// <summary>
		/// Gets or sets the field identifier.
		/// </summary>
		/// <value>The field identifier.</value>
        [JsonProperty("field_id")]
        public int FieldId { get; set; }
    }
}
