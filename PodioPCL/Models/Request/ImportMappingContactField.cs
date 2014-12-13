// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ImportMappingContactField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class ImportMappingContactField.
	/// </summary>
    public class ImportMappingContactField
    {
        /// <summary>
        /// The key for the field on the contact
        /// </summary>
        [JsonProperty("field_key")]
        public string FieldKey{get;set;}

        /// <summary>
        /// True of the value for the field is unique, false otherwise
        /// </summary>
        [JsonProperty("unique")]
        public bool Unique{get;set;}

        /// <summary>
        /// The id of the column to be used for the given field
        /// </summary>
        [JsonProperty("column_id")]
        public string ColumnId {get;set;}

    }
}
