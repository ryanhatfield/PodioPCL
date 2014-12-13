// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FormField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FormField.
	/// </summary>
    public class FormField
    {
        /// <summary>
        /// The id of the field
        /// </summary>
        [JsonProperty("field_id", NullValueHandling = NullValueHandling.Ignore)]
        public int FieldId { get; set; }

        /// <summary>
        /// Any settings of the field which depends on the type of the field. See area for more information
        /// </summary>
        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        public FormFieldSettings FormFieldSettings { get; set; }
    }
}
