// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FormSettings.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FormSettings.
	/// </summary>
    public class FormSettings
    {
		/// <summary>
		/// True if captcha is enabled, false otherwise
		/// </summary>
		/// <value><c>true</c> if captcha; otherwise, <c>false</c>.</value>
        [JsonProperty("captcha", NullValueHandling = NullValueHandling.Ignore)]
        public bool Captcha { get; set; }

		/// <summary>
		/// The texts used for the form
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public FormSettingsText Text { get; set; }

		/// <summary>
		/// The colors for the form in the form "#xxxxxx"
		/// </summary>
		/// <value>The color.</value>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

		/// <summary>
		/// The theme to use, for a list of valid themes see the area
		/// </summary>
		/// <value>The theme.</value>
        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public string Theme { get; set; }

		/// <summary>
		/// Optional inline css to include in the form
		/// </summary>
		/// <value>The CSS.</value>
        [JsonProperty("css", NullValueHandling = NullValueHandling.Ignore)]
        public string Css { get; set; }
    }
}
