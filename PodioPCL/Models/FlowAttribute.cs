// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FlowAttribute.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FlowAttribute.
	/// </summary>
    public class FlowAttribute
    {
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FlowAttribute"/> is required.
		/// </summary>
		/// <value><c>true</c> if required; otherwise, <c>false</c>.</value>
        [JsonProperty("required")]
        public bool Required { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        [JsonProperty("value")]
        public string Value { get; set; }

		/// <summary>
		/// Gets or sets the attribute identifier.
		/// </summary>
		/// <value>The attribute identifier.</value>
        [JsonProperty("attribute_id")]
        public string AttributeId { get; set; }

		/// <summary>
		/// Gets the label.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label")]
        public string Label { get; private set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets the substitutions.
		/// </summary>
		/// <value>The substitutions.</value>
        [JsonProperty("substitutions")]
        public Dictionary<string, string> Substitutions { get; private set; }
    }
}
