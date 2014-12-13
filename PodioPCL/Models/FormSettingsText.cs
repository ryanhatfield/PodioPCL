// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FormSettingsText.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FormSettingsText.
	/// </summary>
    public class FormSettingsText
    {
        /// <summary>
        /// A heading to display when the webform is not embedded (OPTIONAL)
        /// </summary>
        [JsonProperty("heading", NullValueHandling = NullValueHandling.Ignore)]
        public string Heading { get; set; }

        /// <summary>
        /// An explanatory text to display when the webform is not embedded (OPTIONAL)
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The text for the submit button
        /// </summary>
        [JsonProperty("submit", NullValueHandling = NullValueHandling.Ignore)]
        public string Submit { get; set; }

        /// <summary>
        /// The text when the form was successfully submitted
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }
    }
}
