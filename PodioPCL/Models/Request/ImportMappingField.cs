// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ImportMappingField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class ImportMappingField.
	/// </summary>
    public class ImportMappingField
    {
        /// <summary>
        /// The id of the field in the app
        /// </summary>
        [JsonProperty("field_id")]
        public int FieldId { get; set; }

        /// <summary>
        /// True of the values for the field is unique, false otherwise
        /// </summary>
        [JsonProperty("unique")]
        public bool Unique { get; set; }

        /// <summary>
        /// Which value should be mapped for the field, depends on the type of field
        /// </summary>
        [JsonProperty("value")]
        public dynamic Value { get; set; }
    }
}
