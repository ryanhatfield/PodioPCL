// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FormFieldSettings.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FormFieldSettings.
	/// </summary>
    public class FormFieldSettings
    {
        /// <summary>
        /// See contact area for a list of all supported contact field types
        /// </summary>
        [JsonProperty("contact_field_types", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ContactFieldTypes { get; set; }
    }
}
