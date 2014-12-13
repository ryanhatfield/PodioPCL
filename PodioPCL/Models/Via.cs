// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Via.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Via.
	/// </summary>
    public class Via
    {
		/// <summary>
		/// Gets or sets the authentication client identifier.
		/// </summary>
		/// <value>The authentication client identifier.</value>
        [JsonProperty(PropertyName = "auth_client_id")]
        public int? AuthClientId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Via"/> is display.
		/// </summary>
		/// <value><c>true</c> if display; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "display")]
        public bool Display { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }
}
